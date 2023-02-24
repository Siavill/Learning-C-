"""# найти сумму элементов трёхзначного числа
print("Введите трёхзначное число ")
n = int(input())
while n < 99:
    print("incorrect number, please try again ")
    n = int(input())

a = n % 10
b = n % 100 // 10
c = n // 100
print("Сумма цифр равна: ", a + b + c)
"""

"""# Задача 2, найти сколько сделал журавликов каждый ребёнок
print("Input numbers of cranes ")
n = int(input())
print((n/6), ((n/6)*4), (n/6))
"""

"""# Задача 6, узнать является ли билет счастливым
print("Input number of your ticket")
n = input()

a = int(n[0])
b = int(n[1])
c = int(n[2])
d = int(n[3])
e = int(n[4])
f = int(n[5])
s1 = a + b + c
s2 = d + e + f
if s1 == s2:
    print("Your ticket is lucky")
else:
    print("Your ticket is not lucky")
"""

"""# Задача 8, определить можно ли разломить шоколадку
print("Input size of chokolate ")
n = int(input())
m = int(input())
print("Input size of slices ")
k = int(input())
if k < n * m and ((k % n == 0) or (k % m == 0)):
    print("Yes")
else:
    print("No")
"""


