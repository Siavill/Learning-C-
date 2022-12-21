//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*double [,] NewArray( int row, int colum, int minval, int maxval){
    double [,] newarray = new double [row, colum];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < colum; j++)
            newarray [i,j] = new Random().Next(minval,maxval) ;
            return newarray;
     
    
}

void showarray(double [,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(0); j++)
        {
            Console.Write(array [i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.WriteLine("Input count of row");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of colum");
int colums = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Input min possible value ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possible value");
int max = Convert.ToInt32(Console.ReadLine());

double [,] array = NewArray(rows, colums, min, max);
showarray(array);*/



//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


/*int [,] NewArray( int row, int colum){
    int [,] newarray = new int [row, colum];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < colum; j++)
            newarray [i,j] = new Random().Next(-100, 100);
            return newarray;
     
    
}

void showarray(int [,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array [i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int poisk(int [,] array){
    Console.WriteLine("Input pisstions elements first ");
    int first = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input pisstions elements second ");
    int second = Convert.ToInt32(Console.ReadLine());

     for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (i == first-1 && j == second-1)
            {
                Console.WriteLine($"{array[first-1, second-1]}" );
            }
            if(first > array.GetLength(0) | second >array.GetLength(1))
            {
                Console.WriteLine("your number is not correct");
            }
    
        
            return first;
            
    
}


Console.WriteLine("Input count of row");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of colum");
int colums = Convert.ToInt32(Console.ReadLine());



int [,] array = NewArray(rows, colums);
showarray(array);
poisk(array);*/


// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. 


int [,] NewArray( int row, int colum){
    int [,] newarray = new int [row, colum];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < colum; j++)
            newarray [i,j] = new Random().Next(-10, 10);
            return newarray;
     
    
}

void showarray(int [,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array [i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int poisksumstolb(int [,] array){
    int sum = 0;
     for (int i = 0; i < array.GetLength(0); i++){
        sum = 0;
        int sr = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
               sum += array[j,i]; 

        }
        sr = sum/array.GetLength(0);
        Console.WriteLine("Srednee znachenine = " + sr);
        }
        return sum;  
}


Console.WriteLine("Input count of row");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of colum");
int colums = Convert.ToInt32(Console.ReadLine());



int [,] array = NewArray(rows, colums);
showarray(array);
poisksumstolb(array);



