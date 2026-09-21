using System;
class Program
{
    static void Main(string[] args)
    {
        string[] mass = Console.ReadLine().Split(' ');
        int G = int.Parse(mass[0]);
        int L = int.Parse(mass[1]);
        int max = (G + L) - 1;
        int _G = max - G;
        int _L = max - L;
        Console.WriteLine($"{_G} {_L}");
        //первый тест для новой ветки
        //
    }
}