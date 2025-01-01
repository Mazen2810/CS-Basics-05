namespace CS_Basics_05
{
    internal class Program

    {

        public static void Printshape(int Count = 10, string Pattern = "*_*")
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(Pattern);
            }

        }
        public static void Swap(ref int X, ref int Y)
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }

        public static int SumArray(int[] arr)
        {
            int Sum = 0;
            //arr[0] = 100;
            arr = new[] { 4, 5, 6 };
            for (int i = 0; i < arr.Length; i++)
            {

                Sum += arr[i];
            }

            return Sum;

        }
        public static int SumArray(ref int[] arr)
        {
            int Sum = 0;
            //arr[0] = 100;
            arr = new[] { 4, 5, 6 };
            for (int i = 0; i < arr.Length; i++)
            {

                Sum += arr[i];
            }

            return Sum;

        }
        public static void SumMul(int X, int Y, ref int Sum, ref int Mul)
        {
            Sum = X + Y;
            Mul = Y * X;
        }
        static void Main(string[] args)
        {
            #region Casting [Boxing - Unboxing]
            // Reference type casting => Convert from ref to ref type
            // Boxing casting => convert from value type to ref type
            // Unboxing casting => convert from ref type to value type


            //object obj = new object();
            //obj = "Mostafa"; // ref type casting
            //obj = 2; // Boxing type casting
            #region Boxing [Safe]
            //int X = 10;
            //object obj1 = new object();
            //obj1 = X;
            //Console.WriteLine(obj1);
            // Parent = child
            // dog is animal
            #endregion

            #region UnBoxing [Un safe]
            //object obj2 = new object();
            //obj2 = 10;
            //int X = (int)obj2;
            //Console.WriteLine(X);
            // child = Parent
            // animals are dogs
            #endregion




            #endregion

            #region Nullable Datatype
            #region Value Type
            /* int X = null;*/ // int Number only
                               //int? X = null; // int Number and Null
                               // Nullable <int> Number;
                               //Console.WriteLine(X);

            //int X = 10;
            //int? Y = X;

            //int? X = null;
            //int Y;
            //if (X != null)
            //{
            //    Y = (int)X;
            //}
            //else
            //{
            //    Y = 0;
            //}

            //if (X.HasValue)
            //{
            //    Y = X.Value;
            //}
            //else
            //{
            //    Y = 0;
            //}
            //Y = X.HasValue ? X.Value : 0;
            //Console.WriteLine(Y);
            #endregion

            #region Reference Type
            //string? Name = null;
            //Console.WriteLine(Name);
            #endregion
            #endregion
            #region Null Propagation Operator
            //int[] Numbers = null;
            //if (Numbers != null)
            //{
            //    for (int i = 0; i < Numbers.Length; i++)
            //    {
            //        Console.WriteLine(Numbers[i]);
            //    }
            //}


            // i < Numbers?.Length
            // Numbers = Obj [Length]
            // Numbers = null [Null]

            //int Length = Numbers?.Length ?? 0;
            //Console.WriteLine(Length);


            //Employee Emp = new Employee();
            //if (Emp != null)
            //{
            //    if (Emp.Department != null)
            //    {
            //        Console.WriteLine(Emp.Department.Name);
            //    }
            //}

            //Console.WriteLine(Emp?.Department?.Name??"Not Found");
            #endregion

            #region Function
            //Printshape(10, "*_*");
            //Printshape(Pattern: "*_*", Count: 10);

            //Printshape();
            //Console.WriteLine("Hello Mazen\nWelcom to \tRoute");
            //Printshape(10 , @"/*\");

            #endregion

            #region Value Type Parameters

            #region Passing by Value
            //int A = 5;
            //int B = 10;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Swap(A, B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            #endregion

            #region Passing by Reference
            //int A = 5;
            //int B = 10;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Swap(ref A,ref B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            #endregion
            #endregion

            #region Reference Type Parameters Ex01

            #region By Value
            //int[] Numbers = { 1, 2, 3 };

            //Console.WriteLine(SumArray(Numbers));
            //Console.WriteLine(Numbers[0]);
            #endregion
            #region By Reference
            //int[] Numbers = { 1, 2, 3 };

            //Console.WriteLine(SumArray(ref Numbers));
            //Console.WriteLine(Numbers[0]);
            #endregion
            #endregion
            #region Reference Type Ex02

            #region passing Value
            //int[] Numbers = { 1, 2, 3 };

            //Console.WriteLine(SumArray(Numbers));
            //Console.WriteLine(Numbers[0]);
            #endregion
            #region Passing Ref
            //int[] Numbers = { 1, 2, 3 };

            //Console.WriteLine(SumArray(ref Numbers));
            //Console.WriteLine(Numbers[0]);
            #endregion
            #endregion

            #region Passing By out
            //int X = 5, Y = 10;
            //int Sum, Mul;
            //SumMul(X, Y,out Sum,out Mul);
            //Console.WriteLine(Sum);
            //Console.WriteLine(Mul);

            //int X = 5, Y = 10;
            //int Sum = default, Mul = default;
            //SumMul(X, Y, ref Sum, ref Mul);
            //Console.WriteLine(Sum);
            //Console.WriteLine(Mul);
            #endregion

        }
    }
}
