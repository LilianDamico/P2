//Inicio
int c = 1;
int i = 1;
while (c <= 10)
{
    Console.WriteLine("( "+c + "  ,");
    while (i <= 10)
    {
        Console.Write(i + " ");
        i++;
    }
    Console.WriteLine("" + ")");
    i = 1;
    c++;
}




Console.ReadKey();
//Fim