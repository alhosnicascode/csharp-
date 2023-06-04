


Console.WriteLine("enter Student Numbers : ");
int cnt = int.Parse(Console.ReadLine());
int[] scorarr = new int[cnt];
char[] arr = new char[cnt];
for (int i = 0; i < cnt; i++)
{
    scorarr[i] = int.Parse(Console.ReadLine());
    if (scorarr[i] >= 90)
    {
        arr[i] = 'A';
    }
    else if (scorarr[i] >= 80)
    {
        arr[i] = 'B';
    }
    else if (scorarr[i] >= 70)
    {
        arr[i] = 'C';
    }
    else if (scorarr[i] >= 60)
    {
        arr[i] = 'D';
    }
    else
    {
        arr[i] = 'F';
    }
}
for (int i = 0; i < cnt; i++)
{
    Console.WriteLine($"Student {i} grade is : {arr[i]}");
}
