'''### Задача 26:  Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
def funct(alf, bet):
    if (bet == 1):
        return (alf)
    if (bet == 0):
        return (1)
    if (bet != 1):
        return (alf * funct(alf, bet - 1))
alf = int(input("Please input number: "))
bet = int(input("Please input degree: "))
print("Your solutions: ", funct(alf, bet))
'''


'''###Задача 28: Напишите рекурсивную функцию sum(a, b), возвращающую сумму двух целых неотрицательных чисел. Из всех арифметических операций
###допускаются только +1 и -1. Также нельзя использовать циклы.
def sum(a, b):
    if (b == 0):
        return (a)

    if (b > 0):
        return sum(a + 1, b - 1)
a = int(input("Please input a :"))
b = int(input("Please input b :"))
if (a < 0 or b < 0):
    print("Not correctly, please try again")
else:
    print("Your solutions : ", sum(a , b))
'''