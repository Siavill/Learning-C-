//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*int [,] NewArray( int row, int colum){
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

void difarray(int [,] array){
     for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++){
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i,k] < array[i,k + 1])
                {
                  int temp = array[i, k+1];
                  array[i, k+1] = array[i,k];
                  array[i,k] = temp;  
                }
            }

        }          
}


Console.WriteLine("Input count of row");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of colum");
int colums = Convert.ToInt32(Console.ReadLine());



int [,] array = NewArray(rows, colums);
Console.WriteLine("Yor massive ");
showarray(array);
difarray(array); 
Console.WriteLine("new massive ");
showarray(array);*/



//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*int [,] NewArray( int row, int colum){
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

int poisk(int [,] array){
    int sum = 0;
    int index = 0;
    int temp = 0;
     for (int i = 0; i < array.GetLength(0); i++){
        sum = 0;
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
               sum += array[i,j]; 
        }
        Console.WriteLine("sum = " + sum);
         if (temp > sum)
        {
            temp = sum;
            index = i+1;
        }
        }
        Console.WriteLine("Min value in "+ index + " stroka");
        return sum;  
}


Console.WriteLine("Input count of row");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of colum");
int colums = Convert.ToInt32(Console.ReadLine());



int [,] array = NewArray(rows, colums);
showarray(array);
poisk(array);*/


//Напишите программу, которая заполнит спирально массив 4 на 4.


    int n = 4;
    int [,] spiralarray = new int [n, n];
    int i = 0;
    int j = 0;
    int temp = 0;
     while (temp <= spiralarray.GetLength(0)*spiralarray.GetLength(1))
     {
        spiralarray[i,j] = temp;
        temp ++;
        if (i<= j+1 && i+j < spiralarray.GetLength(1)-1)
        j++;
        else if (i<j && i + j >= spiralarray.GetLength(0)-1)
        i++;
        else if(i >= j && i + j > spiralarray.GetLength(1)-1)
        j--;
        else i--;
     }
     
    


void showarray(int [,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] / 10 <= 0)
            Console.Write($" {array [i, j]} ");
            else Console.Write($" {array [i, j]} ");
        }
        Console.WriteLine();
    }

}

showarray(spiralarray);



