import class1
show = class1.panggil()
class panggil2:
    """description of class"""
    
    def menu(self):
        keyword = ['RAM','Spesifikasi','Timing','Impact','System','Bandwidth','Bandwidth Counter','Channel']
        Keyword1 = input('Silahkan Ketik "Keyword" untuk menampilkan keyword dalam aplikasi ini : ')
        while (Keyword1 != 'Keyword'):
            show.warning_wrongKeyword()
            Keyword1 = input('Silahkan Ketik "Keyword" untuk menampilkan keyword dalam aplikasi ini : ')
        while (Keyword1 == 'Keyword'):
           show.Keyword()
           i=1
           if i == 1:
               break
        Keyword2 = input('Silahkan masukkan Keyword untuk memakai aplikasi : ')
        if (Keyword2 == keyword[0]):
           show.RAM()
        elif (Keyword2 == keyword[1]):
            show.spesifikasi()
            show.Rumus_ram()
            lagi = input('Apakah anda ingin menghitung lagi?(y/n)')
            while (lagi == 'y'):
                show.Rumus_ram()
                lagi = input('Apakah anda ingin menghitung lagi?(y/n) : ')
            while (lagi == 'n'):
                print('Terimakasih telah menggunakan aplikasi kami!!')
                break
            while (lagi != 'y' and lagi != 'n'):
                print ('Input salah !!')
                break
        elif (Keyword2 == keyword[2]):
           show.Timing()
        elif (Keyword2 == keyword[3]):
            show.Impact()
            show.Rumus_Impact()
            lagi = input('Apakah anda ingin menghitung lagi?(y/n)')
            while (lagi == 'y'):
                show.Rumus_Impact()
                lagi = input('Apakah anda ingin menghitung lagi?(y/n) : ')
            while (lagi == 'n'):
                print('Terimakasih telah menggunakan aplikasi kami!!')
                break
            while (lagi != 'y' and lagi != 'n'):
                print ('Input salah !!')
                break
        elif (Keyword2 == keyword[4]):
            show.System()
        elif (Keyword2 == keyword[5]):
            show.Bandwidth()
        elif (Keyword2 == keyword[6]):
            show.Bandwidth_counter()
        elif (Keyword2 == keyword[7]):
            show.Channel()
        else:
            print('Keyword Salah\nUlang kembali!!')
        