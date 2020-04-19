package com.tutorial;

public class main {
    public static void main(String[] args) {
        // TODO code application logic here
        //membuat objek mobil
        SetterGetter mobil_baru = new SetterGetter();

        //mengatur nilai atribut
        mobil_baru.setMerk("Mitsubishi");
        mobil_baru.setTipe("Mirage");
        mobil_baru.setWarna("merah");
        mobil_baru.setJenisBBM("Pertamax");

        //mencetak nilai
        System.out.println("Saya punya mobil dengan merk " + mobil_baru.getMerk());
        System.out.print(mobil_baru.getMerk() + " " + mobil_baru.getTipe());
        System.out.println(" berwarna " + mobil_baru.getWarna());
        System.out.println("Mobil saya menggunakan bensin berjenis " + mobil_baru.getJenisBBM() + ".");
    }
}