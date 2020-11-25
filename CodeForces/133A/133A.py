a = input()

flag = False

for i in a:
    if i in ('H', 'Q', '+', '9'):
        flag = True
        break

if(flag):
    print('YES')
else:
    print('NO')