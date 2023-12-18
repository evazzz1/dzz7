// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"
int num;
Console.WriteLine("Введите первое число: ");
int m = Convert.ToInt32(IsNatural(Console.ReadLine()));
Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(IsNatural(Console.ReadLine()));
Console.Write("M = " + m + "; N = "+ n +" -> \""); //решила что нужно выводить точно также как указано в задании
GetNaturalNumbers(m,n); Console.Write("\"");     


void GetNaturalNumbers(int m, int n)
{
    if(m <= n)
    {
        if(m == n)
        {
           Console.Write(m); 
        }
        else
        {
            Console.Write(m + ", "); //поэтому добавила дополнительные проверки, где нужно ставить запятые
        }        
        GetNaturalNumbers(m + 1, n);
    }
}

string IsNatural (string str) //проверка на ввод с консоли
{
     bool isNum = Int32.TryParse(str, out num);
     if(isNum)
     {
        int num = Convert.ToInt32(str);
        if(num > 0) return str;
        else 
        {
            Console.WriteLine("Не является натуральным числом, попробуйте снова");
            return IsNatural(Console.ReadLine());
        }
     }
     else
     {
        Console.WriteLine("Не является числом, попробуйте снова");
        return IsNatural(Console.ReadLine());
     }
}