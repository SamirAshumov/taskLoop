Console.WriteLine("Eded daxil edin : ");

int eded = Convert.ToInt32(Console.ReadLine());

int ededCopy = eded;
int ededinTersi = 0;

while (eded > 0)
{
    int reqem = eded % 10;
    ededinTersi = (ededinTersi * 10) + reqem;
    eded /= 10;
}

if (ededCopy == ededinTersi)

    Console.WriteLine("Verilen eded polindromdur");
else

    Console.WriteLine("Verilen eded polindrom deyil");