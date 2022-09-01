
int Akkerman(int M, int N)
{
  if ( M == 0)
     return N+1;
  if (  N ==0  )
     return Akkerman( M-1,1) ;
  return Akkerman ( M-1, Akkerman (M, N-1 )) ;     

}
System.Console.Write(" M ( M > N ) = ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write(" N ( N > 0) = ");
int N = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Akkerman(M, N));
