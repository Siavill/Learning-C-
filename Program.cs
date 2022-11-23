// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. (без пеобразования типов)

/*int number()
{
     Console.WriteLine("Input your number is ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num<100 | num>1000){
        while (num<100 | num>1000){

        Console.WriteLine("Your number <100 or >1000, please try again  ");
        num = Convert.ToInt32(Console.ReadLine());}
        int sec_num = num % 100;
        sec_num = sec_num / 10;
        return sec_num;
       
    }
    else{
        int sec_num = num % 100;
        sec_num = sec_num / 10;
        return sec_num;
    }
     
    
}

Console.WriteLine($"Your new number is {number()}"); */



// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (без пеобразования типов)

/*int number()
{
     Console.WriteLine("Input your number is ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < 100){

        Console.WriteLine("Третьей цифры нет ");
        int sec_num = 0;      
        return sec_num;
       
    }
    else{
        while (num>1000)    //поиск третьего числа
        {
            num = num/10;
        }
        int sec_num = num % 10;
        
        return sec_num;
    }    
}

Console.WriteLine($"Your new number is {number()}"); */


//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


/*int dayofweek()
{
     Console.WriteLine("Input your day is ");
    int num =  Convert.ToInt32(Console.ReadLine());

    if (num <=5 ){
        Console.WriteLine("Сегодня рабочий день, идём и плачем");
        return num;
    }

    if (num == 6 | num == 7)
    {
        Console.WriteLine("Сегодня выходной, а это значит лежим под одеялком и смотрим сериальчики");
        return num;
    }
    
    if (num < 1 | num > 7){
        while (num < 1 | num > 7 )
        {
            Console.WriteLine("Вы ввели неправильный день недели ");
            num = Convert.ToInt32(Console.ReadLine());
        }
         if (num <=5 ){
        Console.WriteLine("Сегодня рабочий день, идём и плачем");
        return num;
    }

    if (num == 6 | num == 7)
    {
        Console.WriteLine("Сегодня выходной, а это значит лежим под одеялком и смотрим сериальчики");
        return num;
    }
    }
    
    return num;
    
}
Console.WriteLine($"{dayofweek()}"); */

