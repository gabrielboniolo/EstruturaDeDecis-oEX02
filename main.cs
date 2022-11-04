using System;

class Program {
  public static void Main (string[] args) {
   int n1, n2, n3;
     n1 = 10;
     n2 = 10;
      n3 = 0;
     if (n1>n2 && n1>n3) {
       Console.WriteLine(n1);
     }
    else if (n2>n1 && n2>n3) {
      Console.WriteLine(n2);
    }
    else {
      if (n3>n1 && n3>n2) {
        Console.WriteLine(n3);
      }
      else if (n1 == 0 && n2 == 0 && n3 == 0) {
        Console.WriteLine("Todos os números são iguais a zero.");
      }
        else {
          if (n1==n2 && n2==n3 && n3==n1) {
            Console.WriteLine ("Todos os números são iguais.");
          }
          else if (n1==n2 && n1>n3) {
            Console.WriteLine("N1 e n2 são maiores que n3.");
          }
          else {
            if(n2==n3 && n2>n1) {
              Console.WriteLine("N2 e n3 são maiores que n1.");
            }
            else {
              Console.WriteLine("N3 e n1 são maiores que n2.");
            }
          }
        }
      }
    }
  }
