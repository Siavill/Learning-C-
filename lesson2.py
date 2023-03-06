""" Задача про монетки
print("Input quantity coins")
n = int(input())
x = 0
for i in range(n):
   y = int(input())
   if y == 1:
       x += 1
print(x if y<n/2 else n-x)
"""


"""
###Задача 12: Петя и Катя – брат и сестра. Петя – студент, а Катя – школьница. Петя помогает Кате по
###математике. Он задумывает два натуральных числа X и Y (X,Y≤1000), а Катя должна их отгадать. Для этого
###Петя делает две подсказки. Он называет сумму этих чисел S и их произведение P. Помогите Кате отгадать задуманные Петей числа.

print("Please input your numbers X and Y")
print("Please input X")
x = int(input())
while x > 1000:
    print("Your number's > 1000, please try again")
    x = int(input())

print("Please input Y")
y = int(input())
while y > 1000:
    print("Your number's > 1000, please try again")
    y = int(input())

for i in range(x):
    for j in range(y):
        if x == i+j and y  == i*j:
            print("Your number's is", i, j)
"""


"""###Задача 14: Требуется вывести все целые степени двойки (т.е. числа вида 2k), не превосходящие числа N.

print("Input numbers N")
n = int(input())
i = 0
while 2 ** i <= n:
    print(2**i)
    i += 1
"""