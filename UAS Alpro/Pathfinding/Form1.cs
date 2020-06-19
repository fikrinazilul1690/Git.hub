using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pathfinding
{
    public partial class Form1 : Form
    {
        private class Cell
        {
            public int baris, kolom;
            public double g, h, f;
            public int level;
            public Cell prev;
            public Cell(int baris, int kolom)
            {
                this.baris = baris;
                this.kolom = kolom;
            }
        }
        const int Infinity = Int32.MaxValue;
        const int kosong = 0;
        const int blok = 1;
        const int start = 2;
        const int finish = 3;
        const int batas = 4;
        const int closed = 5;
        const int rute = 6;

        int brs, kol, size;

        List<Cell> openSet = new List<Cell>();
        List<Cell> closedSet = new List<Cell>();

        Cell startPoin;
        Cell finishPoin;

        int[,] grid;
        bool realTime, found, search, searchEnd, animasi;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_down = true;
            int baris = (e.Y - 10) / size;
            int kolom = (e.X - 10) / size;

            if (baris >= 0 && baris < brs && kolom >= 0 && kolom < kol)
            {
                if (realTime ? true : !found && !search)
                {
                    if (realTime)
                        FillGrid();
                    cur_row = baris;
                    cur_col = kolom;
                    cur_val = grid[baris, kolom];
                    if (cur_val == kosong)
                        grid[baris, kolom] = blok;
                    if(cur_val == blok)
                        grid[baris, kolom] = kosong;
                }
                if (realTime)
                    RealTime_action();
                else
                    Invalidate();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_down = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouse_down)
                return;
            int baris = (e.Y - 10) / size;
            int kolom = (e.X - 10) / size;
            if(baris>=0 && baris<brs&&kolom>=0&&kolom<kol)
            {
                if(realTime ? true : !found && !search)
                {
                    if (realTime)
                        FillGrid();
                    if (!(baris == cur_row && kolom == cur_col) && (cur_val == start || cur_val == finish))
                    {
                        int new_val = grid[baris, kolom];
                        if (new_val == kosong)
                        {
                            grid[baris, kolom] = cur_val;
                            if (cur_val == start)
                            {
                                startPoin.baris = baris;
                                startPoin.kolom = kolom;
                            }
                            else
                            {
                                finishPoin.baris = baris;
                                finishPoin.kolom = kolom;
                            }
                            grid[cur_row, cur_col] = new_val;
                            cur_row = baris;
                            cur_col = kolom;
                            cur_val = grid[baris, kolom];
                        }
                        else if (grid[baris, kolom] != start && grid[baris, kolom] != finish)
                            grid[baris, kolom] = blok;
                    }
                    if (realTime)
                        RealTime_action();
                    else
                        Invalidate();
                }
            }
        }

        private void RealTime_action()
        {
            do
            {
                CheckTermination();
            } while (!searchEnd);
        }

        private void FillGrid()
        {
            if (search || searchEnd || realTime)
            {
                for (int r = 0; r < brs; r++)
                    for(int c = 0; c < kol; c++)
                    {
                        if (grid[r, c] == batas || grid[r, c] == closed || grid[r, c] == rute)
                            grid[r, c] = kosong;
                        if (grid[r, c] == start)
                            startPoin = new Cell(r, c);
                        if (grid[r, c] == finish)
                            finishPoin = new Cell(r, c);
                    }
            }
            else
            {
                for (int r = 0; r < brs; r++)
                    for (int c = 0; c < kol; c++)
                        grid[r, c] = kosong;
                startPoin = new Cell(brs - 1, 0);
                finishPoin = new Cell(0, kol - 1);
            }
            startPoin.g = 0;
            startPoin.h = 0;
            startPoin.f = 0;

            expand = 0;
            found = false;
            search = (realTime ? true : false);
            searchEnd = false;

            openSet.Clear();
            openSet.Add(startPoin);
            closedSet.Clear();

            if (!realTime)
            {
                grid[finishPoin.baris, finishPoin.kolom] = finish;
                grid[startPoin.baris, startPoin.kolom] = start;
            }
        }

        int delay, expand, level;

        bool mouse_down = false;
        int cur_row, cur_col, cur_val;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Animation_action();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            animasi = false;
            realTime = false;
            button2.Enabled = true;
            InitializeGrid(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            animasi = true;
            search = true;
            trackBar1.Enabled = true;
            delay = trackBar1.Value;
            timer1.Stop();
            timer1.Interval = delay;
            timer1.Start();
            Animation_action();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            animasi = false;
            realTime = false;
            button2.Enabled = true;
            FillGrid();
            Invalidate();
        }

        private void Animation_action()
        {
            if (animasi)
            {
                CheckTermination();
                Invalidate();
                if (searchEnd)
                {
                    animasi = false;
                    timer1.Stop();
                }
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush brush;
            Rectangle rect;
            brush = new SolidBrush(Color.DarkGray);
            rect = new Rectangle(10, 10, kol * size + 1, brs * size + 1);
            g.FillRectangle(brush, rect);
            for (int r = 0; r < brs; r++)
                for(int c = 0; c < kol; c++)
                {
                    if (grid[r, c] == kosong)
                        brush = new SolidBrush(Color.White);
                    else if (grid[r, c] == start)
                        brush = new SolidBrush(Color.Red);
                    else if (grid[r, c] == finish)
                        brush = new SolidBrush(Color.Green);
                    else if (grid[r, c] == blok)
                        brush = new SolidBrush(Color.Black);
                    else if (grid[r, c] == batas)
                        brush = new SolidBrush(Color.OrangeRed);
                    else if (grid[r, c] == closed)
                        brush = new SolidBrush(Color.Orange);
                    else if(grid[r,c]==rute)
                        brush = new SolidBrush(Color.Blue);
                    rect = new Rectangle(11 + c * size, 11 + r * size, size - 1, size - 1);
                    g.FillRectangle(brush, rect);
                    brush.Dispose();
                }
        }

        public Form1()
        {
            InitializeComponent();
            InitializeGrid(false);
            trackBar1.Enabled = true;
        }
        private Cell BarisKolom(int posX, int posY)
        {
            int baris = 0, kolom = 0;
            baris = (posY - 10) / size;
            kolom = (posX - 10) / size;
            return new Cell(baris, kolom);
        }
        private void CheckTermination()
        {
            ExpandNode();
            if (found)
            {
                searchEnd = true;
                PlotRoute();
                button2.Enabled = false;
                trackBar1.Enabled = false;
                Invalidate();
            }
        }

        private void ExpandNode()
        {
            Cell current;
            openSet.Sort((x, y) =>
            {
                int hasil = x.f.CompareTo(y.f);
                if (hasil == 0)
                    hasil = x.level.CompareTo(y.level);
                return hasil;
            });

            current = (Cell)openSet[0];
            openSet.RemoveAt(0);
            closedSet.Insert(0, current);
            grid[current.baris, current.kolom] = closed;

            if(current.baris == finishPoin.baris && current.kolom == finishPoin.kolom)
            {
                Cell final = finishPoin;
                final.prev = current.prev;
                closedSet.Add(final);
                found = true;
                return;
            }

            expand++;
            List<Cell> succesors = CreateSuccesors(current, false);

            foreach(Cell cell in succesors)
            {
                int dxg = current.kolom - cell.kolom;
                int dyg = current.baris - cell.baris;
                int dxh = finishPoin.kolom - cell.kolom;
                int dyh = finishPoin.baris - cell.baris;
                cell.g = current.g + Math.Abs(dxg) + Math.Abs(dyg);
                cell.h = Math.Abs(dxh) + Math.Abs(dyh);
                cell.f = cell.g + cell.h;
                int openIndex = InList(openSet, cell);
                int closeIndex = InList(closedSet, cell);

                if(openIndex == -1 && closeIndex == -1)
                {
                    openSet.Add(cell);
                    grid[cell.baris, cell.kolom] = batas;
                }
                else
                {
                    if(openIndex > -1)
                    {
                        Cell openSetCell = (Cell)openSet[openIndex];
                        if (openSetCell.f <= cell.f)
                        {

                        }
                        else
                        {
                            openSet.RemoveAt(openIndex);
                            openSet.Add(cell);
                            grid[cell.baris, cell.kolom] = batas;
                        }
                    }
                    else
                    {
                        Cell closedSetCell = (Cell)closedSet[closeIndex];
                        if (closedSetCell.f <= cell.f)
                        {

                        }
                        else
                        {
                            closedSet.RemoveAt(closeIndex);
                            openSet.Add(cell);
                            grid[cell.baris, cell.kolom] = batas;
                        }
                    }
                }
            }
            
        }

        private int InList(List<Cell> list, Cell current)
        {
            int index = -1;
            for(int i = 0; i < list.Count; i++)
            {
                Cell listItem = (Cell)list[i];
                if(current.baris == listItem.baris&&current.kolom == listItem.kolom)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        private List<Cell> CreateSuccesors(Cell current, bool terhubung)
        {
            int r = current.baris;
            int c = current.kolom;

            List<Cell> temp = new List<Cell>();
            if(r>0&& grid[r-1,c]!=blok&&(InList(openSet, new Cell(r-1,c))==-1&&InList(closedSet, new Cell(r - 1, c)) == -1))
            {
                Cell cell = new Cell(r - 1, c);
                cell.prev = current;
                cell.level = ++level;
                temp.Add(cell);
            }
            if (c < kol - 1 && grid[r, c + 1] != blok && (InList(openSet, new Cell(r, c + 1)) == -1 && InList(closedSet, new Cell(r, c + 1)) == -1))
            {
                Cell cell = new Cell(r, c + 1);
                cell.prev = current;
                cell.level = ++level;
                temp.Add(cell);
            }
            if (r < brs - 1 && grid[r + 1, c] != blok && (InList(openSet, new Cell(r + 1, c)) == -1 && InList(closedSet, new Cell(r + 1, c)) == -1))
            {
                Cell cell = new Cell(r + 1, c);
                cell.prev = current;
                cell.level = ++level;
                temp.Add(cell);
            }
            if (c > 0 && grid[r, c - 1] != blok && (InList(openSet, new Cell(r, c - 1)) == -1 && InList(closedSet, new Cell(r, c - 1)) == -1))
            {
                Cell cell = new Cell(r, c - 1);
                cell.prev = current;
                cell.level = ++level;
                temp.Add(cell);
            }
            return temp;
        }
        private double JarakAntara(Cell u, Cell v)
        {
            double jarak;
            double dx = u.kolom - v.kolom;
            double dy = u.baris - v.baris;
            jarak = Math.Abs(dx) + Math.Abs(dy);
            return jarak;
        }
        private void PlotRoute()
        {
            int langkah = 0;
            double jrk = 0;
            int index = InList(closedSet, finishPoin);
            Cell cur = (Cell)closedSet[index];
            grid[cur.baris, cur.kolom] = finish;
            do
            {
                langkah++;
                jrk++;
                cur = cur.prev;
                grid[cur.baris, cur.kolom] = rute;
            }
            while (!(cur.baris == startPoin.baris && cur.kolom == startPoin.kolom));
            grid[startPoin.baris, startPoin.kolom] = start;
        }
        private void InitializeGrid(bool makeMaze)
        {
            level = 0;
            brs = (int)this.numericUpDown1.Value;
            kol = (int)this.numericUpDown2.Value;
            if (makeMaze && brs % 2 == 0)
                brs -= 1;
            if (makeMaze && kol % 2 == 0)
                kol -= 1;
            startPoin = new Cell(brs - 2, 1);
            finishPoin = new Cell(1, kol - 2);
            size = (int)(500 / (brs > kol ? brs : kol));
            grid = new int[brs, kol];
            FillGrid();
            /*if (makeMaze)
            {
                var maze = new Maze(brs / 4, kol / 4);
                int brs2 = brs / 2 + 1;
                int kol2 = kol / 2 + 1;
                for (int r1 = 0; r1 < brs2; r1++)
                    for(int c1 = 0; c1 < kol2; c1++)
                    {
                       
                    }

            }*/
            Invalidate();
        }
    }
}
