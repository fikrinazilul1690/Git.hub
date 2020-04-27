using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_Kelompok23
{
    class Class1
    {
        public void main()
        {
            string name, Dname,input;
            int semester, nim, Dnim, Dsmt;
            double ip1, ip2, ip3, ip4, ip5, ip6, ip7, ip8, Dttlip, Dipk;

            try
            {
                Mahasiswa data = new Mahasiswa();
                Console.Write("Nama Mahasiswa\t : ");
                name = Console.ReadLine();
                data.setname(name);
                Console.Write("NIM Mahasiswa\t : ");
                input = Console.ReadLine();
                int.TryParse(input, out nim);
                Console.Write("Semester Saat ini : ");
                input = Console.ReadLine();
                int.TryParse(input, out semester);
                switch (semester)
                {
                    case 2:
                        Console.Write("IP Semester 1: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip1);
                        data.setip1(ip1);
                        break;
                    case 3:
                        Console.Write("IP Semester 1: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip1);
                        Console.Write("IP Semester 2: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip2);
                        data.setip1(ip1);
                        data.setip2(ip2);
                        break;
                    case 4:
                        Console.Write("IP Semester 1: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip1);
                        Console.Write("IP Semester 2: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip2);
                        Console.Write("IP Semester 3: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip3);
                        data.setip1(ip1);
                        data.setip2(ip2);
                        data.setip3(ip3);
                        break;
                    case 5:
                        Console.Write("IP Semester 1: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip1);
                        Console.Write("IP Semester 2: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip2);
                        Console.Write("IP Semester 3: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip3);
                        Console.Write("IP Semester 4: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip4);
                        data.setip1(ip1);
                        data.setip2(ip2);
                        data.setip3(ip3);
                        data.setip4(ip4);
                        break;
                    case 6:
                        Console.Write("IP Semester 1: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip1);
                        Console.Write("IP Semester 2: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip2);
                        Console.Write("IP Semester 3: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip3);
                        Console.Write("IP Semester 4: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip4);
                        Console.Write("IP Semester 5: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip5);
                        data.setip1(ip1);
                        data.setip2(ip2);
                        data.setip3(ip3);
                        data.setip4(ip4);
                        data.setip5(ip5);
                        break;
                    case 7:
                        Console.Write("IP Semester 1: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip1);
                        Console.Write("IP Semester 2: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip2);
                        Console.Write("IP Semester 3: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip3);
                        Console.Write("IP Semester 4: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip4);
                        Console.Write("IP Semester 5: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip5);
                        Console.Write("IP Semester 6: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip6);
                        data.setip1(ip1);
                        data.setip2(ip2);
                        data.setip3(ip3);
                        data.setip4(ip4);
                        data.setip5(ip5);
                        data.setip6(ip6);
                        break;
                    case 8:
                        Console.Write("IP Semester 1: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip1);
                        Console.Write("IP Semester 2: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip2);
                        Console.Write("IP Semester 3: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip3);
                        Console.Write("IP Semester 4: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip4);
                        Console.Write("IP Semester 5: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip5);
                        Console.Write("IP Semester 6: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip6);
                        Console.Write("IP Semester 7: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip7);
                        data.setip1(ip1);
                        data.setip2(ip2);
                        data.setip3(ip3);
                        data.setip4(ip4);
                        data.setip5(ip5);
                        data.setip6(ip6);
                        data.setip7(ip7);
                        break;
                    case 9:
                        Console.Write("IP Semester 1: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip1);
                        Console.Write("IP Semester 2: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip2);
                        Console.Write("IP Semester 3: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip3);
                        Console.Write("IP Semester 4: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip4);
                        Console.Write("IP Semester 5: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip5);
                        Console.Write("IP Semester 6: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip6);
                        Console.Write("IP Semester 7: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip7);
                        Console.Write("IP Semester 8: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out ip8);
                        data.setip1(ip1);
                        data.setip2(ip2);
                        data.setip3(ip3);
                        data.setip4(ip4);
                        data.setip5(ip5);
                        data.setip6(ip6);
                        data.setip7(ip7);
                        data.setip8(ip8);
                        break;
                    default:
                        Console.WriteLine("Data yang anda masukan tidak terdeteksi oleh sistem !!!");
                        Console.WriteLine("Aplikasi masih dalam tahap uji coba");
                        return;
                }
                data.setnim(nim);
                data.setsemester(semester);
                data.setttlip();
                data.setipk();

                Dname = data.getname();
                Dnim = data.getnim();
                Dsmt = data.getsemester();
                Dttlip = data.gettotalip();
                Dipk = data.getipk();

                Console.WriteLine("\n==============DATA MAHASISWA==============");
                Console.WriteLine("Nama\t\t: " + Dname);
                Console.WriteLine("NIM\t\t: " + Dnim);
                Console.WriteLine("Semester\t: " + Dsmt);
                Console.WriteLine("IP Total\t: " + Dttlip);
                Console.WriteLine("IPK\t\t: " + Dipk);
            }
            catch (Exception)
            {
                Console.WriteLine("Data yang anda masukan salah !!!");
            }
        }
    }
}
