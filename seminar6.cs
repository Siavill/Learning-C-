//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*int [] CreateArray(int size){
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int [] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int poisk(int [] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
           count++; 
        }
    }

    return count;
}

Console.WriteLine("Input amounts of elements ");
int size_of_elements = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your numbers");
int [] newArray =  CreateArray(size_of_elements);

ShowArray(newArray);

Console.WriteLine(" ");
Console.WriteLine($"Amounts of elements > 0 = {poisk(newArray)}" );*/




//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


/*double method(double k1, double b1, double k2, double b2){
    double x = (b2-b1)/ (k1-k2);
    double y = k1*x + b1;
    return x;
}

double method2(double k1, double b1, double k2, double b2){
    double x = (b2-b1)/ (k1-k2);
    double y = k1*x + b1;
    return y;
}


    Console.WriteLine("Input number k1 ");
    int K1 =  Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number b1 ");
    int B1 =  Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number k2 ");
    int K2 =  Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number b2 ");
    int B2 =  Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Your coordinate is ({method(K1, B1, K2, B2)} , {method2(K1, B1, K2, B2)})");*/
