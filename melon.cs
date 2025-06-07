using System;
class Prgram{
   static void Main(){
       int n = int.Parse(Console.ReadLine());
       if(n==2)
       {
           Console.WriteLine("NO");
       }
       else if(n%2==0)
       {
           Console.WriteLine("YES");
       }
       else
       {
           Console.WriteLine("NO");
       }
   }
}
