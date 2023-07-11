int Input(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(System.Console.ReadLine());
}

int SumNums(int m, int n)
{
    if (m == n) { return m; }
    //return n + SumNums(m, n - 1); //еще вариант
    return m + SumNums(m + 1, n);
}

//---------------------------------------------

int m = Input("input first number: ");
int n = Input("input second number: ");
System.Console.WriteLine(SumNums(m, n));