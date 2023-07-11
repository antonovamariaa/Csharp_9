int Input(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(System.Console.ReadLine());
}

int Function(int m, int n)
{
    if (m == 0) { return n + 1; }
    if (n == 0) { return Function(m - 1, 1); }
    return Function(m - 1, Function(m, n - 1));
}

//---------------------------------------------------------
int m = Input("input first number: ");
int n = Input("input second number: ");
System.Console.WriteLine(Function(m, n));





