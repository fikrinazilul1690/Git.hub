class panggil:
    """description of class"""

    def warning_wrongKeyword(self):
            print("""Inputan anda salah
    Ketikkan "Keyword" untuk menampilkan keyword dalam aplikasi ini.
    Perhatikan huruf kapital """)
    
    def Keyword(self):
        print("""Berikut adalah keyword yang ada dalam aplikasi ini :
    "RAM"               =   untuk mengetahui perbedaan DDR,SDRAM, dan SODIMM
    "Spesifikasi"       =   untuk mengetahui cara membaca spesifikasi RAM anda
    "Timing"            =   untuk mengetahui tentang timing dari RAM anda
    "Impact"            =   untuk mengetahui dampak timing terhadap performa RAM anda
    "System"            =   untuk mengetahui cara kerja RAM terkoneksi dengan sistem
    "Bandwidth"         =   untuk mengetahui tentang bandwidth dari RAM 
    "Bandwidth Counter" =   untuk menghitung bandwidth dari RAM anda
    "Channel"           =   untuk mengetahui perbedaan dari single,dual,triple maupun quadruple channel 
    NB : 
    1.Tulis Keyword Tanpa Tanda Petik
    2.Perhatikan Huruf Kapital""""")

    def RAM(self):
        print("""Perbedaan DDR,SDRAM,SODIMM
    
    DDR
    DDR adalah kependekan dari Double Data Rate.
    DDR adalah sebuah tipe RAM dengan data transfer sebesar 64 bit dan menggunaan DIMM 184 PIN.
    Biasanya RAM tipe DDR memiliki clockspeed sebesar setengah dari yang tertera di label.
    RAM bertipe DDDR ini seiring berjalannya waktu mengalami beberapa perkembangan.
    DDR2 menggunakan PIN 240 dan DDR3 mulai merendahkan konsumsi daya dan memilik transfer rate lebih cepat
    
    SDRAM
    SDRAM adalah kependekan dari Synchronous Dynamic Random Access Memory.
    Slot memory untuk SDRAM adalah 168 PIN.Bentuk dari SDRAM adalah Dual Inline Memory Modul(DIMM).
    Komputer yang memakai RAM jenis ini adalah Komputer Pentium 2 dan Pentium 3 gen yang pertama.
    
    SODIMM
    SODIMM adalah kependekan dari Small Outline Dual Inline Memory Module.
    Fungsi dari SODIMM ini sama saja seperti RAM pada komputer.
    Namum yang menjadi perbedaan adalah RAM ini untuk laptop.
    Dari segi bentuk,RAM ini lebih ramping dan lebih compact dari RAM komputer.""")

    def spesifikasi(self):
         print("""
    Cara Membaca Spesifikasi RAM
    Biasanya pada Label di RAM yang anda beli terdapat tulisan DDRxxx/PCyyyy.
    Hal tersebut menunjukan spesifikasi dari RAM yang anda beli.
    DDRxxx,angka xxx ini menunjukkan maximum clockspeed pada RAM anda.
    Sedangkan,PCyyyy,angka yyyy ini menunjukkan Maximum Transfer Rate pada RAM anda.
    Berikut kami sediakan alat untuk menmbaca spesifikasi RAM anda : """)

    def Timing(self):
         print("""Penjelasan Timing RAM
    Dalam Label RAM biasanya terdapat angka berupa w-x-y-zz.
    Angka tersebut adalah representasi dari Timing RAM yang anda miliki.
    w merepresentasikan CL(CAS Latency), x merepresentasikan tRCD(RAS to CAS Delay)
    y merepresentasikan tRP(RAS Precharges, dan zz merepresentasikan tRAS(Active to Precharge Delay).
    CAS Latency(CL) adalah waktu yang dibutuhkan saat processor meminta data dan mengembalikan ke memori lagi.
    tRCD (RAS tp CAS Delay) adalah waktu yang dibutuhkan untuk mengaktifkan Baris(RAS) dan Kolom(CAS) dimana data itu disimpan dalam matrix.
    tRP(RAS Precharges) adalah waktu yang dibutuhkan untuk menonaktifkan akses suatu Baris (RAS) dan mengaktifkan Baris(RAS) yang lain.
    tRAS(Active to Precharge Delay) adalah waktu yang dibutuhkan untuk menunggu sampai akses memori selanjutnya dapat di inisiasi.""")

    def Impact(self):
        print("""Dampak Timing Terhadap Performa RAM
    Bukan hanya clockspeed saja yang bisa mempengaruhi performa pada RAM,namun Timing juga salah satu faktor penting yang mempengaruhi RAM.
    Salah satu Timing yang paling mempengaruhi performa RAM adalah CAS Latency(CL),berikut akan kami jelaskan bagaimana CL bisa mempengaruhi performa RAM.
    CAS Latency adalah waktu yang dibutuhkan saat processor meminta data dari RAM dan mengambilkan data itu lagi ke RAM.
    Singkatnya,CAS Latency adalah waktu yang dibutuhkan saat perpindahan data dari processor ke RAM.
    Berikut adalah alat untuk menghitung waktu yang dibutuhkan saat perpindahan data dari processor ke RAM""")
        print("""Semakin kecil waktu yang dibutuhkan untuk melakukan perpindahan data maka akan semaki bagus performa dari RAM tersebut.
        Sehingga semakin kecil nilai dari CL(Cas Latency) maka semakin baik performa dari RAM.
        Begitu juga dengan nilai dari tRCD,tRP,dan tRAS semakin kecil maka akan semakin baik""")

    def System(self):
        print("""Cara Kerja RAM Sehingga Dapat Terkoneksi ke Sistem
    Cara Kerja RAM anda sehingga dapat terbaca melalui sistem yaitu : 
    RAM terhubung dengan memory controller.Di masa sekarang Memory controller biasanya terdapat pada processor.
    FYI,Pada Jaman Dulu Memory controller terdapat pada motherboard yang terletak pada North Bridge.
    RAM bisa terhubung dengan memory controller karena adanya kabel-kabel yang menghubungkan yang dinamakan memory bus.
    Memory bus terbagi menjadi  bagian yaitu : data,address, dan control.
    Kabel dari data bus akan membawa data yang sedang dibaca atau ditulis.
    Kabel address berfungsi memberitahu modul memori dimana harus data harus diambil ataupun disimpan
    Kabel Kontrol memberitahu modul memori dan memberi instruksi operasi apa yang sudah selesai.
    Melalui memory bus tersebut RAM bisa terkoneksi dengan processor dan bisa terbaca ke sistem""")

    def Bandwidth(self):
        print("""Bandwidth adalah maximum theoritical data rata
    Bandwidth sendiri dapat melalui sebuah rumus.
    Perhitungan dari Rumus tersebut menentukan nilai maksimum transfer rate.
    Hasil dari perhitungan tersebut tidak akan tercapai karena memory tidak akan memberi performa 100% dalam satu waktu
    FYI : Jika ingin menghitung Bandwidth maka ketik Bandwidth Counter pada keyword""")

    def Channel(self):
        print("""Dikarenakan kecepatan processor lebih cepat daripada kecepatan RAM,maka ditemukanlah teknologi RAM Dual Channel,Triple Channel,Maupun Quadruple Channel
    Lalu apakah anda masih bingung tentang channel tersebut?
    Mari simak dibawah ini
    Teknologi Dual,Triple,maupun Quad Channel adalah sebuah tenik dengan menambah kabel data dalam memory bus sehingga transfer rate akan naik 2x,3x,maupun 4x
    Apakah Performa sebuah PC akan naik sama dengan nilai kelipatan dari transfer data rate?
    Jawabnnya tidak,karena transfer data rate tidak mempengaruhi seratus persen performa Komputer anda,ada banyak variabel yang mempengaruh performa dari PC anda.
    Apakah Memasang Memory pada 4 slot membuat RAM menjadi Quad Channel?
    Tidak karena disina yang mempengaruhi adalah kabel data dari memory bus yang terletak pada motherbord,bukan tentang slot dari memory tersebut.""")

    def Rumus_ram(self):
        x = input('Masukkanlah Spesifikasi RAM anda dengan angka yang ada setelah DDR DDRxxx : ')
        y = input('Masukkanlah Spesifikasi RAM anda dengan angka yang ada setelah PC PCyyyy : ')
        clockspeed = x + "Mhz"
        transfer = y + "Mbps"
        print("Berikut adalah Maximum Clockspeed dari RAM anda : " + clockspeed)
        print("Berikut adalah Maximum Transfer Rate dari RAM anda : " + transfer)

    def Rumus_Impact(self):
        print('Real Clockspeed dari RAM DDR adalah Clockspeed dari label dibagi 2')
        f = input('Masukkan Real Clockspeed dari RAM Anda : ')
        int(f)
        T = 1/int(f)
        str(T)
        print("Periode Clock Cycle anda adalah : " )
        print(T)
        CL = input("Masukkan nilai CAS Latency dari RAM anda : ")
        int(CL)
        Delay = int(CL)*float(T)
        print("Waktu yang dibutuhkan untuk perpindahan data adalah : ")
        print(Delay)

    def warning(self):
        print('Keyword salah!!\nMasukan Keyword yang benar!!')

    def Bandwidth_counter(self):
        print('Berikut adalah alat untuk menghitung Bandwidth RAM : ')
        clock = int(input('Masukkan DDR Clock Rate,bukan Real Clock Rate : '))
        Bandwidth = clock * 8
        print("Bandwidth dari RAM anda adalah : ")
        print(Bandwidth)