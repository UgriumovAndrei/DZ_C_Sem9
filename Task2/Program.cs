// Вводим m и n . Вывод сумма от m до n; 1 15 => 120; 4 8 => 30
int Summ(int m, int n)
{
    if(n==m) return(n);
    return n + Summ(m, n-1);
}
Console.WriteLine("Введите 1 число");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int n2 = Convert.ToInt32(Console.ReadLine());
int summa = Summ(n1, n2);
Console.Write(summa);