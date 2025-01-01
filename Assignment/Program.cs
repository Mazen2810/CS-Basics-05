using System.Security.Cryptography.X509Certificates;

namespace Assignment
{
    internal class Program
    {
        // Q1
        public static void ModifyValue(int x)
        {
            x = 20;
        }
        public static void ModifyValue(ref int x)
        {
            x = 20;
        }

        // Q2
        public static void ModifyArrayByValue(int[] arr)
        {
            arr[0] = 99;  // Modifies the original array
            arr = new int[] { 7, 8, 9 };  // Reassignment (no effect outside this method)
        }
        public static void ModifyArrayByRef(ref int[] arr)
        {
            arr[0] = 55;  // Modifies the original array
            arr = new int[] { 10, 11, 12 };  // Reassignment (affects the original reference)
        }

        // Q3
        public static void SumSub(int X, int Y, out int sum, out int sub)
        {
            sum = X + Y;
            sub = X - Y;
        }

        //Q4
        public static int SumOfDigits(int Num)
        {
            int NumOfdigits = 1;
            int Numm = Num;

            for (int i = 0; i < 10; i++)
            {
                Numm /= 10;
                if (Numm != 0)
                {
                    NumOfdigits++;
                }
                else
                {
                    break;
                }

            }
            int[] digits = new int[NumOfdigits];
            for(int i = 0; i<NumOfdigits;i++)
            { 
             
                digits[i] = Num%10 ;
                Num /= 10;
            }
            int Sum = 0;
            for(int i = 0;i<digits.Length;i++)
            {
                Sum += digits[i];
            }
            return Sum;
        }

        // Q5
        public static bool Isprime(int Num)
        {
            if (Num <= 0)
                return false;
            if(Num ==2)
                return true;
            if (Num % 2 == 0)
                return false;

            for(int i =3; i < Math.Sqrt(Num);i += 2)
            {
                if (Num % i == 0)
                    return false;
            }
            return true;
        }

        // Q6
        public static void MinMaxArray(int[] arr, ref int Max, ref int Min)
        {
            int n = arr.Length;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n - i -1;j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int Temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = Temp;
                    }
                }
            }
            Min = arr[0];
            Max = arr[n - 1];
        }

        // Q7
        public static long Factorial(int Num)
        {
            long Factorial = 1;
            for(int i = 1; i <= Num; i++)
            {
                Factorial *= i;
            }
            return Factorial;
        }
        static void Main(string[] args)
        {
            #region Q1:Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            /* Passing Value Type Parameter by Value: it passing the value not the variable itself, and when changes occur
                                                      the clr clear the stack frame and the changes doesn't apply on the passing variables


               Passing Value Type Parameters by Reference: it passing the reference itself so any changes occur affect on the variables

             */

            // Ex for Passing by Value
            //int num = 10;
            //ModifyValue(num);
            //Console.WriteLine(num);  // Output: 10 (num remains unchanged)



            // Ex for passing by Reference
            //int num = 10;
            //ModifyValue(ref num);
            //Console.WriteLine(num); // Output: 20 (num is modified)
            #endregion

            #region Q2: Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example

            /*
             Reference Type passing by value: It doesn't pass the object itself, instead passing the address that pointed to 
                                              the value in the heap.

            Reference Type passing by ref: It passes the object itself so any change will affect the original object.
              
              */

            //Ex for Reference Type passing by value
            //int[] Numbers = { 1, 2, 3, 4, 5 };
            //ModifyArrayByValue(Numbers);           
            //Console.WriteLine(Numbers[0]);

            // Ex for Reference Type passing by ref
            //int[] Numbers = { 1, 2, 3, 4, 5 };
            //ModifyArrayByValue(ref Numbers);           
            //Console.WriteLine(Numbers[0]);
            #endregion

            #region Q3: Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //bool flag1;
            //bool flag2;
            //int FNum;
            //int SNum;
            //do
            //{
            //    Console.WriteLine("Enter the First Number");
            //    flag1 = int.TryParse(Console.ReadLine(), out  FNum);

            //} while (!flag1);
            //do
            //{

            //    Console.WriteLine("Enter the Second Number");
            //    flag2 = int.TryParse(Console.ReadLine(), out  SNum);
            //} while (!flag2);


            //int Sum = default, Sub = default;
            //SumSub(FNum, SNum, out Sum, out Sub);

            //Console.WriteLine($"The Summation of the two numbers = {Sum}\nThe Substraction of the two numbers = {Sub}");
            #endregion

            #region Q4: Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //Console.WriteLine(SumOfDigits(21551));
            #endregion

            #region Q5: Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //Console.WriteLine(Isprime(4));
            #endregion

            #region Q6: Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int[] Numbers = { 12, 3, 453, 1, 233, 43, 24 };
            //int Max = 0, Min = 0;
            //MinMaxArray(Numbers, ref Max, ref Min);
            //Console.WriteLine(Max);
            //Console.WriteLine(Min);
            #endregion

            #region Q7: Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //Console.WriteLine(Factorial(13));
            #endregion


        }
    }
}
