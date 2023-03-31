Console.Clear();
Console.WriteLine("Введите пятизначное число N:");
int N = int.Parse (Console.ReadLine());

if ((N/10000) == N%10 && ((N/1000)%10 == ((N%100)/10)))
{Console.Write ($" Число N является палиндромом ");}
else
{Console.Write ($" Число N не является палиндромом ");}
