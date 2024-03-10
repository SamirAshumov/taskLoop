Console.WriteLine("Eded daxil edin : ");

int eded = Convert.ToInt32(Console.ReadLine());
int reqem = 1;
int hasil = 1;

while (eded > 0)
{
    reqem = eded % 10;
    hasil *= reqem;
    eded /= 10;

}

Console.WriteLine("Ededin reqemlerinin hasili : " + hasil);