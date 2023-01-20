class Program {
    static void Main(string[] args)
    {
        Console.Write("Num1:");
        var num1 = Double.Parse(Console.ReadLine());
        Console.Write("Num2:");
        var num2 = Double.Parse(Console.ReadLine());

        Console.Write("1.Toplama,2.Cixma,3.Vurma,4.Bolme");
        var secim = int.Parse(Console.ReadLine());

        switch (secim)
        {
            case 1:
                Console.WriteLine(Toplama(num1, num2));
                break;
            case 2:
                Console.WriteLine(Cixma(num1, num2));
                break;
            case 3:
                Console.WriteLine(Vurma(num1,num2));
                break;
            case 4:
                Console.WriteLine(Bolme(num1,num2));
                break;
            default:
                throw new ArgumentException();
        }
    }    
    static double Toplama(double num1,double num2)
    {
        return num1 + num2;
    }
    static double Cixma(double num1,double num2)
    {
        return num1 - num2;
    }
    static double Bolme(double num1,double num2)
    {
        if (num2 == 0)
            throw new DivideByZeroException();
        return num1 / num2;
    }
    static double Vurma(double num1,double num2)
    {
        return num1 * num2;
    }
}