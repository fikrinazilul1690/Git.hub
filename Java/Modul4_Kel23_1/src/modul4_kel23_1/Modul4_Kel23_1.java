package modul4_kel23_1;

public class Modul4_Kel23_1 {
    
/*    static void cetak(String kelompok) {
        System.out.println(kelompok);
    }

    // non-return type tanpa parameter
    static void cetak1() {
        System.out.println("Hello Praktikan DKP 2020 ^^ ");
    }

    // return type dengan parameter
    static String cetak2(String text) {
        return text;
    }

    // return type tanpa parameter
    static String cetak3() {
        return "Kali ini kita akan belajar mengenai Function";
    }*/
    
    public static void main(String[] args) {
   /*      //penggunaan function non-return type dengan megisikan argument untuk parameter kelompok
        cetak("Kelompok 23");
        //penggunaan function non-return type tanpa parameter
        cetak1();
        //penggunaan function return type dengan mengisikan nilai pada parameter text
        System.out.println(cetak2("Function dengan Return"));
        //penggunaan function return type tanpa parameter
        System.out.println(cetak3());*/

        pendefinisi objek = new pendefinisi();

        objek.greeting();
        objek.kelompok("Kelompok 23");
        objek.kelompok("Shift 1");
        String print = objek.kenalan("Fikri", "Rebahan");
        String print2 = objek.kenalan("Seto","nge-DOTA");
        System.out.println(print);
        System.out.println(print2);
    }
    
}
