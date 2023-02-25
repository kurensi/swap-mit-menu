double a = 0, b = 0, wahl = 1; while (wahl != 0)
{
    try
    {
        Menu(ref wahl); switch (wahl)
        {
            case 1:
                Eingabe(ref a, ref b);
                break;
            case 2:
                Swap(ref a, ref b);
                break;
            case 0:
                break;
            default:
                Console.WriteLine("Falsche Eingabe");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
static void Menu(ref double wahl)
{
    try
    {
        Console.WriteLine("Wählen Sie eine Methode :");
        Console.WriteLine("Eingabe()                       (1) :");
        Console.WriteLine("Swap()                          (2) :");
        Console.WriteLine("Beenden                         (0) :\n");
        wahl = Convert.ToDouble(Console.ReadLine());
        Console.Clear();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
static void Eingabe(ref double a, ref double b)
{
    try
    {
        Console.Write("Gebene Sie x ein :");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Gebene Sie y ein :");
        b = Convert.ToDouble(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine($"x muss kleiner sein als y");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
static void Swap(ref double a, ref double b)
{
    try
    {
        if (a > b)
        {
            Console.WriteLine(" x muss kleiner als y sein");
        }
        else if (a < b)
        {
            Console.WriteLine($" x = {a} y = {b}");
            (a, b) = (b, a);
            Console.WriteLine("Nach dem Swap");
            Console.WriteLine($" x = {a} y = {b}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}