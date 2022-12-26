 //Ввод n . вывод все натуральные от n до 1. n=5 5 4 3 2 1

void NatChisla (int n)
{
    if(n ==1) Console.Write(n);
    else
    {
        Console.Write($"{n} ");
        NatChisla(n-1);
    }
} 
  NatChisla(Convert.ToInt32(Console.ReadLine()));