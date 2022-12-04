//положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*int [] creatarray (int size){
    int [] array = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;

 }

 void showarray(int [] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
 }

 int Poisk_ch(int [] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] %2 == 0)
        {
            count++;
        }
    }
    return count;
 }



 Console.WriteLine("Input count of elements ");
 int count_of_elem = Convert.ToInt32(Console.ReadLine());
 int [] array1 = creatarray(count_of_elem);
 showarray(array1);
 Console.WriteLine("");
 Console.WriteLine($"Amount of elements  {Poisk_ch(array1)}");*/


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
 /*int [] creatarray (int size, int min,int max){
    int [] array = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;

 }

 void showarray(int [] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
 }

 int Sum_pol(int [] array){
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 != 0)
        {
            sum =sum + array[i];
           
        }
    }
    return sum;
 }

Console.WriteLine("Please input min value ");
int minvalue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input max value ");
int maxvalue = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Input count of elements ");
 int count_of_elem = Convert.ToInt32(Console.ReadLine());
 int [] array1 = creatarray(count_of_elem, minvalue, maxvalue);
 showarray(array1);
 Console.WriteLine("");
 Console.WriteLine($"Amount of elements  {Sum_pol(array1)}");*/




 //Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*double [] creatarray (int size, int min,int max){
    double [] array = new double[size];
    
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;

 }

 void showarray(double [] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
 }

 double raznica(double [] array){   // в данном методе поиск разницы одновременно с поисками максимального и минимального значения
    double sum = 0;
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max )
        {
            max = array[i];
        }
    }

    for (int i = 0; i < array.Length; i++)
    {   
        
        if (array[i] < min)
        {
            min = array[i];
        }
    }

    sum = max - min;
    return sum;
 }

Console.WriteLine("Please input min value ");
int minvalue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input max value ");
int maxvalue = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Input count of elements ");
 int count_of_elem = Convert.ToInt32(Console.ReadLine());
 double [] array1 = creatarray(count_of_elem, minvalue, maxvalue);
 showarray(array1);
 Console.WriteLine("");
 Console.WriteLine($"{raznica(array1)}");*/


 


 




