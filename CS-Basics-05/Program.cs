﻿namespace CS_Basics_05
{
    internal class Program
    {
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
        }
    }
}
