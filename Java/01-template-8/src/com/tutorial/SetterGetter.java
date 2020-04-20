package com.tutorial;

public class SetterGetter {
      //membuat class
    //deklarasi atribut
    private String merk;
    private String tipe;
    private String warna;
    private String jenisBBM;

    //membuat setter
    public void setMerk(String merk) {
        this.merk = merk;
    }

    public void setTipe(String tipe) {
        this.tipe = tipe;
    }

    public void setWarna(String warna) {
        this.warna = warna;
    }

    public void setJenisBBM(String jenisBBM) {
        this.jenisBBM = jenisBBM;
    }

    //membuat getter
    public String getMerk() {
        return merk;
    }

    public String getTipe() {
        return tipe;
    }

    public String getWarna() {
        return warna;
    }

    public String getJenisBBM() {
        return jenisBBM;
    }
}