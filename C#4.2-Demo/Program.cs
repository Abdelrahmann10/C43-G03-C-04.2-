namespace C_4._2_Demo
{
    internal class Program
    {
        #region Params
        //static int SumArray(params int[] arr)
        //{
        //    int Sum = 0;
        //    if (arr is not null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //            Sum += arr[i];
        //    }
        //    return Sum;
        //}
        #endregion

        #region Passing By Out
        //static void SumMul(int x, int y, out int sum, out int Mul) //Output Param => Initialize 
        //{
        //    sum = x + y;
        //    Mul = x * y;
        //}
        #endregion

        #region Paramters Value Type
        #region Passing By Value
        //public static void Swap(int x, int y)
        //{
        //    int Temp = x;
        //    x = y;
        //    y = Temp;
        //}
        #endregion
        #region Passing By Reference
        //public static void Swap(ref int x, ref int y)
        //{
        //    int Temp = x;
        //    x = y;
        //    y = Temp;
        //}
        #endregion
        #endregion

        #region Paramters Reference Type
        #region Passing By Value
        //public static int SumArr(int[] Arr)
        //{
        //    int Sum = 0;
        //    if (Arr != null)
        //    {
        //        Arr[0] = 100;

        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            Sum += Arr[i];
        //        }
        //    }
        //    return Sum;
        //}
        #endregion
        #region Passing By Reference
        //public static int SumArr(ref int[] Arr)
        //{
        //    int Sum = 0;
        //    if (Arr != null)
        //    {
        //        Arr[0] = 100;

        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            Sum += Arr[i];
        //        }
        //    }
        //    return Sum;
        //}
        #endregion
        #endregion

        #region Print & PrintPattern
        //public static void Print(string pattern, int count)
        //{
        //    for (int i = 0; i <= count; i++)
        //        Console.WriteLine(pattern);
        //}
        // The function "PrintPattern" is same as function "Print" but with default value
        //public static void PrintPattern(string pattern = "#", int count = 10)
        //{
        //    for (int i = 0; i <= count; i++)
        //        Console.WriteLine(pattern);
        //}
        #endregion

        static void Main(string[] args) //Entry Point
        {
            #region Array Methods
            //int[] Nums = { 5, 1, 5, 4, 3, 10, 7 };
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = new int[5];
            #region Class Member Methods [Static Methods]
            //Array.Sort(Nums);
            //Array.Copy(Arr01,Arr02,2); // 1-2-0-0-0
            //foreach(int num in Arr02 )
            //  Console.WriteLine(num);
            //Array.Clear(Nums); // return all values in array to default value {0}
            //Array.ConstrainedCopy(Arr01, 1, Arr02, 1, 2);
            //int[] Arr03 = (int[]) Array.CreateInstance(typeof(int), 10); //Like i'm saying -> new int[10]
            //int[,,] Arr04 = (int[,,]) Array.CreateInstance(typeof(int), 2, 4, 3);
            #endregion
            #region Object Member Methods
            //Arr01.CopyTo(Arr02, 1);
            //foreach (int num in Arr02) // 0-1-2-3-0
            //  Console.WriteLine(num);
            //Arr01.SetValue(100,1);
            //Console.WriteLine(Arr01[1]);
            #endregion
            #endregion
            #region Functions
            //Functions has 2 components
            // 1- Prototype
            // 1.1- Signature
            //  -Return Type
            //  -Name
            //  -Parameters
            // 1.2- Body

            // 2- Calling of function
            #endregion
            //Program.Print("$$$",5);
            //Program.PrintPattern("*");  // Passing By Order
            //Program.PrintPattern(10, "*"); // Invalid
            //Program.PrintPattern(count: 10, pattern: "*"); // Passing By Name
            #region Paremters Value Type
            #region Passing By Value
            //int A = 3, B = 5;
            //Console.WriteLine("Before Swaping");
            //Console.WriteLine(A); //3
            //Console.WriteLine(B); //5
            //Console.WriteLine("After Swaping");
            //Swap(A, B);
            //Console.WriteLine(A); //3
            //Console.WriteLine(B); //5
            #endregion
            #region Passing By Reference
            //int A = 3, B = 5;
            //Console.WriteLine("Before Swaping");
            //Console.WriteLine(A); //3
            //Console.WriteLine(B); //5
            //Console.WriteLine("After Swaping");
            //Swap(ref A, ref B);
            //Console.WriteLine(A); //5
            //Console.WriteLine(B); //3
            #endregion
            #endregion
            #region Paremters Reference Type
            #region Passing By Value
            //int[] Numbers = { 1, 2, 3 };
            //int Result = SumArr(Numbers);
            //Console.WriteLine(Result);
            //Console.WriteLine(Numbers[0]);
            #endregion
            #region Passing By Reference
            //int[] Numbers = { 1, 2, 3 };
            //int Result = SumArr(ref Numbers);
            //Console.WriteLine(Result);
            //Console.WriteLine(Numbers[0]);
            #endregion
            #endregion

            #region Passing By Out
            //int A = 10, B = 5, SumResult, MulResult;
            //SumMul(A, B, out SumResult, out MulResult);
            //Console.WriteLine($"Sum = {SumResult}");
            //Console.WriteLine($"Mul = {MulResult}");
            //int Age;
            //int.TryParse( Console.ReadLine(), out Age);
            #endregion

            #region Params
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int Total = SumArray(Numbers);
            //Console.WriteLine($"Sum Of Array = {Total}"); //Rest  //Spread
            #endregion

            #region Boxing VS UnBoxing (Casting)
            // Boxing: Casting From DataType [ValueType] to DataTyoe [Reference Type]
            // UnBoxing:Casting From DataType [Reference Type] to DataType [Value Type]
            #region Example 1
            object obj;
            ////Declare for reference of tyoe "Object", Reference To Null
            ////This reference obj can refere to an instance from type object or any another DataType
            //obj = new object();
            //obj = new string("Abdelrahman");
            //obj = 'A';
            //obj = 3;
            //obj = true;
            //bool flag = (bool)obj;
            //Console.WriteLine(flag); // UnBoxing / Explicit casting //Unsafe casting
            #endregion
            #region Example 2
            //int X = 5;
            //object O1 = X;
            ////Casting from int [ValueType] to object [ReferenceType]
            ////5 -------------------> new object (5) // Boxing
            ////Parent = Child
            ////Animal = Dog
            ////Boxing [Safe casting] // Implicit casting
            //Console.WriteLine(O1);
            ////UnBoxing
            //object o2 = 10;
            //o2 = "Ahmed";
            //int Y = (int)o2;
            ////Casting from object [ReferenceType] to int [ValueType] //Explicitly
            ////UnBoxing UnSafe Casting : Maybe Threw Exception[InvalidCastingException]
            ////UnBoxing
            ////new object(10) --------------> 10
            ////Child = Parent
            #endregion
            #endregion

            #region Nullable Value Type
            ////Null => Is valid value for DataTypes ReferenceType only
            ////--------------------------------
            //int? Age;
            //Age = 10;
            //Age = null;
            ////------------------

            ////Nullable Double : ( double values + Null ) 
            ////Nullable<double> Salary;
            //double? Salary; // is syntax sugar for Nullable<double> Salary
            //Salary = 22.5;
            //Salary = null;
            #endregion



        }
    }
}
