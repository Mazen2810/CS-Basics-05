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

        public static void ModifyArrayByValue(int[] arr)
        {
            arr[0] = 99;  // Modifies the original array
            arr = new int[] { 7, 8, 9 };  // Reassignment (no effect outside this method)
        }

        // Pass Array by Reference (Using ref)
       public static void ModifyArrayByRef(ref int[] arr)
        {
            arr[0] = 55;  // Modifies the original array
            arr = new int[] { 10, 11, 12 };  // Reassignment (affects the original reference)
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








        }
    }
}
