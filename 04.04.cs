using System;

class Program
{
    static void Main()
    {
        int[] szamok = { 10, 15, 17, 20, 30, 40, 50, 60, 70 };
        int[] lk = new int[szamok.Length];

        int ujindex = 0;
        for (int i = 0; i < szamok.Length; i++)
        {
            if (szamok[i]%2==0)
            {
                lk[ujindex] = szamok[i];
                ujindex++;
            }
        }


        Console.ReadKey();
    }
}

