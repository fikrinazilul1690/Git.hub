using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_Kelompok23
{
    class Mahasiswa
    {
        private string name;
        private int semester, nim;
        private double ip1, ip2, ip3, ip4, ip5, ip6, ip7, ip8, ipk, totalip;

        public Mahasiswa()
        {
            this.name = "";
            this.nim = 0;
            this.semester = 0;
            this.totalip = 0;
            this.ipk = 0;
        }
        public void setname(String name)
        {
            this.name = name;
        }
        public void setnim(int nim)
        {
            this.nim = nim;
        }
        public void setsemester(int semester)
        {
            this.semester = semester;
        }
        public void setip1(double ip1)
        {
            this.ip1 = ip1;
        }
        public void setip2(double ip2)
        {
            this.ip2 = ip2;
        }
        public void setip3(double ip3)
        {
            this.ip3 = ip3;
        }
        public void setip4(double ip4)
        {
            this.ip4 = ip4;
        }
        public void setip5(double ip5)
        {
            this.ip5 = ip5;
        }
        public void setip6(double ip6)
        {
            this.ip6 = ip6;
        }
        public void setip7(double ip7)
        {
            this.ip7 = ip7;
        }
        public void setip8(double ip8)
        {
            this.ip8 = ip8;
        }
        public void setttlip()
        {
            this.totalip = this.ip1 + this.ip2 + this.ip3 + this.ip4 + this.ip5 + this.ip6 + this.ip7 + this.ip8;
        }
        public void setipk()
        {
            this.ipk = this.totalip / (this.semester - 1);
        }
        public string getname()
        {
            return name;
        }
        public int getnim()
        {
            return nim;
        }
        public int getsemester()
        {
            return semester;
        }
        public double gettotalip()
        {
            return totalip;
        }
        public double getipk()
        {
            return ipk;
        }
    }
}
