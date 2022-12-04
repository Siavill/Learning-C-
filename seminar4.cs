// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


/*double method(){
    Console.WriteLine("Input number A and number B");
    int A = Convert.ToInt32(Console.ReadLine());
    int B = Convert.ToInt32(Console.ReadLine());
    //double result = Math.Pow(A, B);  решение без цикла
    double result = 0;
    for (int i = 1; i <= B; i++)
    {
        result = Math.Pow(A, i);
    }
    return result;
}

Console.WriteLine($"Your solutions  {method()} ");*/
 

 // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

 /*int functions(){
    Console.WriteLine("Input your numbers ");
    int N = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    while (N> 0)
    {
        sum =sum + N%10; 
        N = N/10;

    }
    return sum;

 }

 Console.WriteLine($"{functions()}"); */


 //Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

 /*int [] creatarray (int size, int min, int max){
    int [] array = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max +1);
    }
    return array;

 }

 void showarray(int [] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
 }

Console.WriteLine("Please input min value ");
int minvalue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input max value ");
int maxvalue = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Input count of elements ");
 int count_of_elem = Convert.ToInt32(Console.ReadLine());
 int [] array1 = creatarray(count_of_elem, minvalue, maxvalue);
 showarray(array1);*/
 


 




