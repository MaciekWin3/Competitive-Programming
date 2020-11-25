a = input()

a = a.lower()

for i in a:
    if i in ("a", "o", "y", "e", "u", "i"):
        b = ''
        a = a.replace(i, b)
    else:
        b = '.' + i
        a = a.replace(i, b)

print(a)
