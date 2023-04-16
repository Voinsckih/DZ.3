﻿int x = ReadInt("Введите число - ");

if (IsPalindrome(M(x)))
{
    System.Console.WriteLine("Палиндром");
}
else
{
    System.Console.WriteLine("Не Палиндром");
}

int ReadInt(string argument)
{
	Console.Write(argument);

	int i;

	while (!int.TryParse(Console.ReadLine(), out i))
	{
        Console.WriteLine("Это не число!");
        Console.Write(argument);
        
	}

	return i;
}

int [] M(int x)
{
    string str = x.ToString();
    int [] S = new int [str.Length];
    for (int i = 0; i < str.Length; i++)
    {
       S[i] = int.Parse(str[i].ToString()); 
    }
    return S;
}

bool IsPalindrome(int [] S)
{  
    int i = 0;
    int k = S.Length - 1;
    while (i < k)
    {
        if (S[i] == S[k])
        {
            i++;
            k--;
        }
        else
        {
            return false;
        }
    }
return true;
}
