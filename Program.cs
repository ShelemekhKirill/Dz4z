/* Напишите цикл, который принимает на вход два числа (A и B) 
 и возводит число A в натуральную степень B. 
 (Задачи, решенные через Math.Pow, будут отправлены на переделку, 
 так как задача стоит в том, чтобы написать цикл)
3, 5 -> 243 (3⁵)
2, 4 -> 16 */


/* Console.Write("Видите число A:  ");         
int a = int.Parse(Console.ReadLine()!);     
Console.Write("Видите число B:  ");            
int b = int.Parse(Console.ReadLine()!);
int count = a;
for (int i = 1; i < b; i++)
{
    count = count * a;
}
Console.WriteLine("Ответ 'А' в степени 'В' ровна: " +count);
 */

/*  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
 452 -> 11
82 -> 10
9012 -> 12  */

/* Console.Write("Ввидите число:  ");
int num = int.Parse(Console.ReadLine()!);
int GetSize(int number)
{
    int i = 10;
    int size = 1;
    while(true)
    {
        if(number / i != 0)
        {
            size += 1;
        }
        else
        {
            break;
        }
         i *= 10;    
    }
    return(size);
} 
Console.WriteLine(GetSize(num)); */


// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

/* int[] array = GetArray(8);
Console.WriteLine($"[{String.Join(", ", array) }]");
//----------------Метод--------------------------
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] =new Random().Next();
        
    }
    return result;
}
 */

