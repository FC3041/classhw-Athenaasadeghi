int i =10;
char c = 'A';
double d = 0.5;
long l = 1;
ulong ll=2;
char[] chars = new char[5];
// malloc
//
while(i>0)
{
    if (i%2==1)
    {
    Console.WriteLine("great!" +i);
    }
    else
    {
        Console.WriteLine("Skip");
    }
    i--;
}
for(int j =0;j<3;j++)
{
Console.Write("name?");
string name = Console.ReadLine();
Console.WriteLine("Hello,"+ name + "!");
}
