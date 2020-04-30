

n, m, k = input().split()

n = int(n)
m = int(m)
k = int(k)

if(m >= k):
    min = k
else:
    min = m

if(n > min):
    print('NO')
else:
    print('YES')
