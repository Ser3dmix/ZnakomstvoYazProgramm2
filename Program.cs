// Знакомство с яз.программирования. Семинар-2.




// ЗАДАЧА 1. Написать программу,кот. выводит случайное трехзн.число и удаляет вторую цифру этого числа
/*
int CutNumber(int num)
{
    int sot = num / 100;
    int ed = num % 10;

    int result = sot * 10 + ed;
    return result;
}

int RandNum = new Random().Next(100, 1000);
int NewNum = CutNumber(RandNum);

Console.WriteLine($"New version of a number {RandNum} is {NewNum}");
*/




// ЗАДАЧА 2. Программа, кот. выводит случайное число от 10 до 99 вкючительно и показывает наибольшую цифру числа

/*
int MaxNumber(int num)
{
    int des = num / 10;
    int ed = num % 10;
    int result;

    if(des > ed)
    {
        result = des;
    }
    else
    {
        result = ed;
    }
    return result;
}

int RandNum = new Random().Next(10, 100);
int NewNum = MaxNumber(RandNum);

Console.WriteLine($"Random number {RandNum} , max number {NewNum}");
*/

/*
int MaxNumber(int num)
{
    int des = num / 10;
    int ed = num % 10;
    int result = des;

    if(des < ed)result = ed;

    return result;
}

int RandNum = new Random().Next(10, 100);
int NewNum = MaxNumber(RandNum);

Console.WriteLine($"Random number {RandNum} , max number {NewNum}");
*/





// ЗАДАЧА 3. Программа,кот принимает на вход два числа и выводит,является ли второе число кратным первому
/*
bool KratnN( int n1 , int n2 )
{
    if(n2 % n1 == 0)
     {
        return true;
     }
     else
     {
        return false;
     }
     
}

Console.Write("enter number 1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("enter number 2: ");
int n2 = Convert.ToInt32(Console.ReadLine());

bool otvet = KratnN( n1, n2 );

Console.WriteLine($"kratno {otvet}");
*/





// ЗАДАЧА 4. Программа, кот. принимает на вход число и проверяет, кратно ли оно одновременно a и b
/*
// Зад 4 Вар 1
bool KratnNN( int nOsn, int del1, int del2 )
{
    if(nOsn % del1 == 0 && nOsn % del2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
    
}

Console.Write("введите проверяемое на четность число: ");
int nOsn = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число 1: ");
int del1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число 2: ");
int del2 = Convert.ToInt32(Console.ReadLine());

bool otvet = KratnNN( nOsn, del1, del2 );

Console.WriteLine($"кратно ли число {nOsn} числам {del1} и {del2} ? {otvet}");
*/
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





//Homework
//Homework
//Homework
//Homework

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//ЗАДАЧА 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Зад 1- Вар 1
/*
int ShowTwoNum(int twoN)
{
    int result = twoN / 10 % 10;
    return result;
}

Console.Write("введите трехзначное число : ");
int n = Convert.ToInt32(Console.ReadLine());

int res = ShowTwoNum(n);

Console.WriteLine(res); //решено
*/

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Зад 1 Вар 2
/*
int ShowTwoNum2(int toN2)
{

while (toN2 > 100)
{
    toN2 = toN2 / 10;
}
    toN2 = toN2 % 10;

    return toN2;
}

Console.Write("введите любое число от трехзначного и больше : ");
int n = Convert.ToInt32(Console.ReadLine());

int nSec = ShowTwoNum2(n);

Console.WriteLine(nSec); // решено(можно проверить любое число от трехзн. и выше в рамках ToInt32)
*/

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Зад 1 Вар 3
/*
long ShowTwoNum2(long toN2)
{

while (toN2 > 100)
{
    toN2 = toN2 / 10;
}
    toN2 = toN2 % 10;

    return toN2;
}

Console.Write("введите любое число от трехзначного и больше : ");
long n = Convert.ToInt64(Console.ReadLine());

long nSec = ShowTwoNum2(n);

Console.WriteLine(nSec); // решено(можно вводить больше разрядов в рамках ToInt64)
*/


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//ЗАДАЧА 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
/*
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
int ShowThreeNum(int toN3)
{
    if(toN3 > 1000)
    {
        while(toN3 > 1000)
        {
            toN3 = toN3 / 10;
        }
        toN3 = toN3 % 10;
    }    
    else
    {
        if(toN3 > 99)
        {
            toN3 = toN3 % 10;
        }
        else
        {
            toN3 = -1;
        }
    }

    return toN3;
}    
    
Console.Write("введите любое число от трехзначного и больше : ");
int n = Convert.ToInt32(Console.ReadLine());

int nSec = ShowThreeNum(n);

if(nSec == -1)
{
    Console.WriteLine("третьей циферки в этом числе нет ;)");
}
else
{
    Console.WriteLine(nSec);
}                                   // решено
*/

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//ЗАДАЧА 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*
//Зад 15 Вар 1
bool DayOff( int day )
{
    if(day == 6 || day == 7)
     {
        return true;
     }
     else
     {
        return false;
     }
     
}

Console.Write("enter number day: ");
int nDay = Convert.ToInt32(Console.ReadLine());

bool otvet = DayOff( nDay );

Console.WriteLine(otvet);
*/


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*
//Зад 15 Вар 2
bool DayOff( int day )
{
    if(day == 6 || day == 7)
     {
        return true;
     }
     else
     {
        return false;
     }
     
}

Console.Write("enter number day: ");
int nDay = Convert.ToInt32(Console.ReadLine());

bool otvet = DayOff( nDay );

if(otvet == false)Console.WriteLine("работай, рано еще отдыхать...");
if(otvet == true)Console.WriteLine("можно отдохнуть!");  // решено
*/