using System;
using System.Linq.Expressions;

namespace ExceptionHanding
{
    class ExceptionHanding
    {
        public static void Main()
        {
            try
            {
                int []array = new int[5];
                int num = 0;
                array[4] = 30/num;
                int a = array[5];
                int b = int.Parse(Console.ReadLine());
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            
            
            CustomExpection.AgeVerifier(32);


        }
        class CustomExpection
        {
            public static void AgeVerifier(int age)
            {
                try
                {
                    if(age > 22)
                    {
                        throw new Exception("Your Age limit Was Exceeded... Sry");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}