Console.WriteLine("Eded daxil edin : ");

int eded = Convert.ToInt32(Console.ReadLine());
int bolunenSayi = 0;

for (int i = 1; i < eded; i++)
{
    if (eded % i == 0)
        bolunenSayi += i;
}

if (eded == 0 || eded == 1)

    Console.WriteLine("Eded ne sade ne de murekkebdir");

else
{

    if (bolunenSayi <= 2)

        Console.WriteLine("Verilen eded sadedir");

    else
        Console.WriteLine("Verilen eded murekkebdir");
}