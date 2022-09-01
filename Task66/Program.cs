int SumNM(int N, int M)
{ int sum=0;
  for (int i = N; i <=M; i++)
    sum+=i;
  return sum;  
}  

System.Console.Write(" N ( N > 0) = ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.Write(" M ( M > N ) = ");
int M = Convert.ToInt32(Console.ReadLine());
if ( N <=0 || M<=0 || M < N )
  System.Console.WriteLine("Некорректный ввод!");
else
  System.Console.WriteLine($"сумма равна {SumNM(N,M)}");