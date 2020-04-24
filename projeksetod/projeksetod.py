import class3
New = class3.New_Fitur()
New.option_baru()
lagi = input('Apakah anda ingin kembali ke menu?(y/n) : ')
while (lagi == 'y'):
    New.option_baru()
while (lagi == 'n'):
    print('Terimakasih sudah menggunakan Aplikasi kami,Jika berkenan anda boleh membantu kami dengan berdonasi seikhlasnya ke rekening : 12345678 a/n Dimas Seto ')
    break
while (lagi != 'y' and lagi != 'n'):
    print ('Input salah, Aplikasi berhenti!!')
    break