a = int(input())

b = input()

A = 0
D = 0

for i in range(0, len(b)):
    if b[i] == 'A':
        A += 1
    else:
        D += 1

if A > D:
    print("Anton")
elif D > A:
    print("Danik")
else:
    print("Friendship")