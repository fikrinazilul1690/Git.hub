import class2
import os
show = class2.panggil2()
def return_func(welcome):
    return print(welcome)
def fitur_baru():
    print('Fitur baru telah hadir\nRekomendasi merk RAM terbaik 2020')
def Nama_aplikasi():
    print('\t\t\tRAMpage')

class New_Fitur:
    """description of class"""
    def option_baru(self):
        Nama_aplikasi()
        print("""Pilihan Menu :
        1. RAMpage
        2. Rekomendasi RAM 2020 (New Fitur !!!)
        0. Keluar""")
        pilihan = int (input('Masukan Pilihan Anda : '))
        if pilihan == 1:
            return_func('Selamat Datang di Aplikasi RAMpage \nAplikasi untuk mengenal lebih dalam tentang RAM')
            show.menu()
            lagi = input('Apakah anda ingin memakai Keyword lain?(y/n) : ')
            while (lagi == 'y'):
                show.menu()
                lagi = input('Apakah anda ingin memakai Keyword lain?(y/n) : ')
                break
            while (lagi == 'n'):
                print('Terimakasih sudah menggunakan Aplikasi kami')
                os._exit(0)
                break
            while (lagi != 'y' and lagi != 'n'):
                print ('Input salah !!!')
                break
        elif pilihan == 2:
            self.rekomend_merk_ram()
        elif pilihan == 0:
            os._exit(0)
        else:
            print('Inputan Salah!!')

    def rekomend_merk_ram(self):
        print("""10 Rekomendasi merk RAM terbaik 2020 :
    1.\tCorsair
    2.\tG.Skill
    3.\tTranscend
    4.\tKongston
    5.\tHynix
    6.\tPatriot
    7.\tAdata
    8.\tVenom RX
    9.\tTeam Ellite
    10.\tCrucial""")
       
      