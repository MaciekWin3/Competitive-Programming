cases = int(input())
i = 0

while i < cases:
    params = input().split()
    params = list(map(int, params))

    a = input().split()
    a = list(map(int, a))
    b = input().split()
    b = list(map(int, b))
    answers = []

    check = True

    for j in range (len(a)):
        if(max(a) + min(b) > params[1]):
            check = False
            break
        else:
            a.remove(max(a))
            b.remove(min(b))
    
    if(check):
        answers.append("Yes")
    else:
        answers.append("No")

    blank = input()
    i = i + 1

print(*answers,sep='\n')