n = int(input())


figures = []

for i in range(0, n): 
    a = input() 
  
    figures.append(a)
    

output = 0

i = 0

while(i < n):
    if(figures[i] == "Tetrahedron"):
        output = output + 4
    elif(figures[i] == "Cube"):
        output = output + 6
    elif(figures[i] == "Octahedron"):
        output = output + 8
    elif(figures[i] == "Dodecahedron"):
        output = output + 12
    elif(figures[i] == "Icosahedron"):
        output = output + 20
    else:
        print("Error!")
    i = i + 1

print (output)
