//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*int polindrom(){


    Console.WriteLine("Input your number of 5 signs");
    int pretendent = Convert.ToInt32(Console.ReadLine());
    int x1 = pretendent / 10000;          //поиск первого элемента
    int x2 = pretendent / 1000 % 10;      //поиск второго элемента
    int x3 = pretendent % 100 / 10;       //поиск третьего элемента  
    int x4 = pretendent % 10;             //поиск четвертого элемента

    if (x1 == x4 & x2 == x3){                                  //проверка на полиндром
        Console.WriteLine("Your number is polindrom ");
    }
    else
    {
        Console.WriteLine("Your number is not polindrom ");
    }

    if (pretendent>100000 | pretendent < 10000)   //на всякий случай
    {
        while (pretendent>100000 | pretendent < 10000)
        {
            Console.WriteLine("Your input uncorrectly numbers, please try again");
            pretendent = Convert.ToInt32(Console.ReadLine());
            if (x1 == x4 & x2 == x3){
            Console.WriteLine("Your number is polindrom ");
            }
            else
            {
            Console.WriteLine("Your number is not polindrom ");
            }
            

        }
        
    }


    
    return pretendent;

    


}

Console.WriteLine($" {polindrom()} ");*/







//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*double distance(int x1,int y1, int z1,int x2,int y2, int z2  ){

    double dist = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
    Console.WriteLine("Distance A and B "+ dist);
    return dist;
}

    Console.WriteLine("Input X coordinate  of A ");
    int xA = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Input Y coordinate  of A ");
    int yA = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Input Z coordinate  of A ");
    int zA = Convert.ToInt32(Console.ReadLine());

     Console.WriteLine("Input X coordinate  of B ");
    int xB = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Input Y coordinate  of B ");
    int yB = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Input Z coordinate  of B ");
    int zB = Convert.ToInt32(Console.ReadLine());

    distance(xA, yA, zA, xB, yB, zB ); */








//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


/*int kubik(){
    Console.WriteLine("Input N > 1 " );
    int N = Convert.ToInt32(Console.ReadLine());
    int cub;

    for (int i = 1; i <= N; i++)
    {
        cub = i*i*i;
        Console.Write(cub + " , " );
        
    }
    
    if (N == 0)
    {
        cub = 0;
         Console.WriteLine(cub );

    }
return N;
}

Console.WriteLine($"Значение кубов от N  {kubik()}");*/
