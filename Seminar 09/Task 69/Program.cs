// Задача №69: Напишите программу, которая будет принимать два числа А и В.
// Возведите число А в степень В с помощью рекурсии.

long RecPow(int a, int b)
{
  
  if (b>0) return a*RecPow(a,b-1);
  else return 1;
}
long AdvancedRecPow(int a, int b)
{
  if (b==2)
  {
  return 4;
  }
  else
  {
  return AdvancedRecPow(a,b/2)*AdvancedRecPow(a,b/2);
  }
}



Console.WriteLine(AdvancedRecPow(2,5));




