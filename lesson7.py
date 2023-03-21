'''###Задача 34 про винни пуха

def song(slog):
    str = slog.lower().split()
    f = lambda x: sum(1 for i in x if i in 'аоуэеёиюяы')
    tmp = f(str[0])
    if all([f(i) == tmp for i in str]):
        return print("Парам пам-пам")
    return print("Пам парам")

print("Input your song :")
slog = input()
print(song(slog))
'''

'''
###Задача 36, Возведение в степень
def print_operation_table(operation, num_row = 6, num_colum = 6):
    for row in range(1, num_row+1):
        for col in range(1, num_colum+1):
            print(operation(row, col), end = ' ')
        print()
print_operation_table(lambda x, y: x ** y)
'''
