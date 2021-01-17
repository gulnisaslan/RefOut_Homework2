using System;

namespace RefOut_Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1= 20;
            int num2 = 30;
            Console.WriteLine(Add1(num1, num2));
            Console.WriteLine(Add2(ref num1, num2));
            Console.WriteLine(Add3(out num1 , num2));





            static int Add1(int num1 , int num2)
          {
                return num1 + num2;
          }
          static int Add2(ref int num1, int num2)
          {
                num1 = 30;
                return num1 + num2;
          }
          static int Add3(out int num1,  int num2)
          {
                num1 = 20;
                return num1 + num2;
          }
        }
    }
}


