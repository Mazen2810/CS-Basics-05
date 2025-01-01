namespace Assignment
{
    internal class Program
    {
        public static void ModifyValue(int x)
        {
            x = 20;
        }
        public static void ModifyValue(ref int x)
        {
            x = 20;
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
        }
    }
}
