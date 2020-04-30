t = int(input())

i = 0

tab = []

while(i < t):
    a = input()
    tab.append(a)
    i = i + 1
    
i = 0

while(i < t):
    if(tab[i][-1] == 'o'):
        print('FILIPINO')
    elif(tab[i][-1] == 'u'):
        print('JAPANESE')
    elif(tab[i][-1] == 'a'):
        print('KOREAN')
    i = i + 1

