/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tugas_kelompok23;

import java.util.Scanner;

/**
 *
 * @author aar
 */
public class Class1 {

    public void main() {
        String name, Dname;
        int semester, nim, Dnim, Dsmt;
        float ip1, ip2, ip3, ip4, ip5, ip6, ip7, ip8, Dttlip, Dipk;

        try {
            Scanner input = new Scanner(System.in);
            Mahasiswa data = new Mahasiswa();
            System.out.print("Nama Mahasiswa\t : ");
            name = input.nextLine();
            data.setname(name);
            System.out.print("NIM Mahasiswa\t : ");
            nim = input.nextInt();
            System.out.print("Semester Saat ini : ");
            semester = input.nextInt();
            switch (semester) {
                case 2:
                    System.out.print("IP Semester 1: ");
                    ip1 = input.nextFloat();
                    data.setip2(ip1);
                    break;
                case 3:
                    System.out.print("IP Semester 1: ");
                    ip1 = input.nextFloat();
                    System.out.print("IP Semester 2: ");
                    ip2 = input.nextFloat();
                    data.setip2(ip2);
                    data.setip1(ip1);
                    break;
                case 4:
                    System.out.print("IP Semester 1: ");
                    ip1 = input.nextFloat();
                    System.out.print("IP Semester 2: ");
                    ip2 = input.nextFloat();
                    System.out.print("IP Semester 3: ");
                    ip3 = input.nextFloat();
                    data.setip1(ip1);
                    data.setip2(ip2);
                    data.setip3(ip3);
                    break;
                case 5:
                    System.out.print("IP Semester 1: ");
                    ip1 = input.nextFloat();
                    System.out.print("IP Semester 2: ");
                    ip2 = input.nextFloat();
                    System.out.print("IP Semester 3: ");
                    ip3 = input.nextFloat();
                    System.out.print("IP Semester 4: ");
                    ip4 = input.nextFloat();
                    data.setip1(ip1);
                    data.setip2(ip2);
                    data.setip3(ip3);
                    data.setip4(ip4);
                    break;
                case 6:
                    System.out.print("IP Semester 1: ");
                    ip1 = input.nextFloat();
                    System.out.print("IP Semester 2: ");
                    ip2 = input.nextFloat();
                    System.out.print("IP Semester 3: ");
                    ip3 = input.nextFloat();
                    System.out.print("IP Semester 4: ");
                    ip4 = input.nextFloat();
                    System.out.print("IP Semester 5: ");
                    ip5 = input.nextFloat();
                    data.setip1(ip1);
                    data.setip2(ip2);
                    data.setip3(ip3);
                    data.setip4(ip4);
                    data.setip5(ip5);
                    break;
                case 7:
                    System.out.print("IP Semester 1: ");
                    ip1 = input.nextFloat();
                    System.out.print("IP Semester 2: ");
                    ip2 = input.nextFloat();
                    System.out.print("IP Semester 3: ");
                    ip3 = input.nextFloat();
                    System.out.print("IP Semester 4: ");
                    ip4 = input.nextFloat();
                    System.out.print("IP Semester 5: ");
                    ip5 = input.nextFloat();
                    System.out.print("IP Semester 6: ");
                    ip6 = input.nextFloat();
                    data.setip1(ip1);
                    data.setip2(ip2);
                    data.setip3(ip3);
                    data.setip4(ip4);
                    data.setip5(ip5);
                    data.setip6(ip6);
                    break;
                case 8:
                    System.out.print("IP Semester 1: ");
                    ip1 = input.nextFloat();
                    System.out.print("IP Semester 2: ");
                    ip2 = input.nextFloat();
                    System.out.print("IP Semester 3: ");
                    ip3 = input.nextFloat();
                    System.out.print("IP Semester 4: ");
                    ip4 = input.nextFloat();
                    System.out.print("IP Semester 5: ");
                    ip5 = input.nextFloat();
                    System.out.print("IP Semester 6: ");
                    ip6 = input.nextFloat();
                    System.out.print("IP Semester 7: ");
                    ip7 = input.nextFloat();
                    data.setip1(ip1);
                    data.setip2(ip2);
                    data.setip3(ip3);
                    data.setip4(ip4);
                    data.setip5(ip5);
                    data.setip6(ip6);
                    data.setip7(ip7);
                    break;
                case 9:
                    System.out.print("IP Semester 1: ");
                    ip1 = input.nextFloat();
                    System.out.print("IP Semester 2: ");
                    ip2 = input.nextFloat();
                    System.out.print("IP Semester 3: ");
                    ip3 = input.nextFloat();
                    System.out.print("IP Semester 4: ");
                    ip4 = input.nextFloat();
                    System.out.print("IP Semester 5: ");
                    ip5 = input.nextFloat();
                    System.out.print("IP Semester 6: ");
                    ip6 = input.nextFloat();
                    System.out.print("IP Semester 7: ");
                    ip7 = input.nextFloat();
                    System.out.print("IP Semester 8: ");
                    ip8 = input.nextFloat();
                    data.setip1(ip1);
                    data.setip2(ip2);
                    data.setip3(ip3);
                    data.setip4(ip4);
                    data.setip5(ip5);
                    data.setip6(ip6);
                    data.setip7(ip7);
                    data.setip8(ip8);
                default:
                    System.err.println("Data yang anda masukan tidak terdeteksi oleh sistem !!!");
                    System.err.println("Aplikasi masih dalam tahap uji coba");
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

            System.out.println("\n==============DATA MAHASISWA==============");
            System.out.println("Nama\t\t: " + Dname);
            System.out.println("NIM\t\t: " + Dnim);
            System.out.println("Semester\t: " + Dsmt);
            System.out.println("IP Total\t: " + Dttlip);
            System.out.println("IPK\t\t: " + Dipk);
        } catch (Exception e) {
            System.err.println("Data yang anda masukan salah !!!");
        }
    }
}
