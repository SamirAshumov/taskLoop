Console.WriteLine("Faktoriali tapilmali olan ededi daxil edin : ");

int eded = Convert.ToInt32(Console.ReadLine());

long factorial = 1;


if (eded >= 0)
{

    for (int i = 1; i <= eded; i++)
    {
        factorial = factorial * i;
    }

    Console.WriteLine("Daxil edilen ededin faktoriali : " + factorial);
}

else
    Console.WriteLine("Faktorial teyin olunmayib...");




