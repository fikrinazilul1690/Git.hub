data = [1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30]
i = 0
stack = []

while(i == 0):
    print('MENU :')
    print('1.Stack Ganjil')
    print('2.Stack Genap')
    print('0.Keluar')
    try:
        a = int(input('Pilihan : '))
        if(a == 1):
            for a in range(30):
                if (data[a] % 2 != 0):
                    stack.append(data[a])
            print(stack,'\n')
            stack.clear()
            continue
        if(a == 2):
            for a in range(30):
                if (data[a] % 2 == 0):
                    stack.append(data[a])
            print(stack,'\n')
            stack.clear()
            continue
        if(a == 0):
            i = 1
        else:
            print('Input salah !!!\n')
    except:
        print('Input salah !!!\n')
