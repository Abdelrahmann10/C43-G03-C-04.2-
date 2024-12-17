using System.ComponentModel;

namespace functionAssignment
{

    internal class Program
    {

        #region Q 1

        // By Value
        //static void Swap(int x, int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}

        // By Reference

        //static void Swap( ref int x,ref int y )
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;

        //}
        #endregion


        #region Q 2


        //  By Value

        //static int SumArray(int[] arr)
        //{
        //    int sum = 0;

        //    if (arr is not null)
        //    {
        //        arr =new int[] { 7,8,9 } ;
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            sum += arr[i];
        //        }
        //    }
        //    return sum;
        //}



        // By Reference

        //static int SumArray(ref int[] arr)
        //{
        //    int sum = 0;

        //    if (arr is not null)
        //    {
        //        arr = new int[] { 7, 8, 9 };
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            sum += arr[i];
        //        }
        //    }
        //    return sum;
        //}



        #endregion


        #region Q 3

        //static double GetNumber()
        //{
        //    double number;

        //    if (!double.TryParse(Console.ReadLine(), out number))
        //    {
        //        Console.WriteLine("Please enter valid number: ");
        //    }
        //    return number;
        //}

        //static double sum(double num1, double num2)
        //{
        //    return num1 + num2;
        //}

        //static double sub(double num1, double num2)
        //{
        //    return num1 - num2;
        //}

        #endregion


        #region Q 4

        //static int CalcSum(int num)
        //{

        //int sum = 0 , number ;

        //while (num > 0)
        //{
        //    number = num % 10 ;
        //    sum = sum + number ;
        //    num = num / 10 ;
        //}

        //return sum;

        //-------- Another Solution-------

        //string n1 = Convert.ToString(n);
        //int sum = 0;

        //for (int i = 0; i < n1.Length; i++)
        //    sum += Convert.ToInt32(n1.Substring(i, 1));
        //return sum;

        //}


        //static int UserNumber()
        //{
        //    int number;

        //    if (!int.TryParse(Console.ReadLine(), out number))
        //    {
        //        Console.WriteLine(" Enter a valid number: ");
        //    }
        //    return number;
        //}

        #endregion


        #region Q 5

        //static int GetNumber()
        //{
        //    int number;
        //    if (!int.TryParse(Console.ReadLine(), out number) || number < 2)
        //    {
        //        Console.WriteLine(" Please enter a valid number bigger than 1 : ");
        //    }
        //    return number;
        //}

        //static bool IsPrime(int num)
        //{
        //    if ( num < 2 )
        //    {
        //        return false;
        //    }

        //    for (int i = 2; i <= Math.Sqrt(num); i++)
        //    {
        //        if (num % i == 0)
        //        {
        //            return false;
        //        }
        //    }

        //    return true;

        //}
        #endregion


        #region Q 6

        //static void MaxAndMiniArray(int[] array, out int max, out int min)
        //{
        //    max = min = array[0];


        //    foreach (int num in array)
        //    {
        //        if (num > max)
        //        {
        //            max = num;
        //        }
        //        if (num < min)
        //        {
        //            min = num;
        //        }
        //    }
        //}

        #endregion


        #region Q 7

        //static int NonNegativeInteger()
        //{
        //    int number;

        //    if (!int.TryParse(Console.ReadLine(), out number) || number < 0)
        //    {
        //        Console.WriteLine(" Enter a non-negative integer : ");
        //    }
        //    return number;
        //}

        //static long CalFactorial(int n)
        //{
        //    if (n == 0 || n == 1)
        //    {
        //        return 1;
        //    }

        //    long result = 1;
        //    for (int i = 2; i <= n; i++)
        //    {
        //        result *= i;
        //    }

        //    return result;
        //}

        #endregion


        #region Q 8 

        //static char SingleChar()
        //{
        //    char character;

        //    if (!char.TryParse(Console.ReadLine(), out character) || char.IsWhiteSpace(character))
        //    {
        //        Console.WriteLine(" Enter a single character : ");
        //    }
        //    return character;
        //}

        //static int NonNegativeInteger()
        //{
        //    int number;
        //    if (!int.TryParse(Console.ReadLine(), out number) || number < 0)
        //    {
        //        Console.WriteLine("Enter a non-negative integer:");
        //    }
        //    return number;
        //}

        //static string ChangeChar(string input, int position, char NewChar)
        //{
        //    if (position < 0 || position >= input.Length)
        //    {
        //        Console.WriteLine(" position isn't correct so there is no changes happened");

        //        return input;

        //    }


        //    char[] charArray = input.ToCharArray();
        //    charArray[position] = NewChar;


        //    return new string(charArray);
        //}

        #endregion



        static void Main(string[] args)
        {


            #region Q 1
            // Passing By value 

            //int A = 10; int B = 5;
            //Console.WriteLine($"A = {A}"); // 10 
            //Console.WriteLine($"B = {B}"); // 5

            //Console.WriteLine("==================================");

            //Swap(A, B); 
            //Console.WriteLine($"A = {A}"); // 10
            //Console.WriteLine($"B = {B}"); // 5

            //any changes we will made to the parameter inside method (no changes) will happen when we call it . 



            //  Passing By reference 

            //int A = 10; int B = 5;
            //Console.WriteLine($"A = {A}"); // 10
            //Console.WriteLine($"B = {B}"); // 5

            //Console.WriteLine("==================================");

            //Swap(ref A , ref B); 
            //Console.WriteLine($"A = {A}"); // 5
            //Console.WriteLine($"B = {B}"); // 10 


            // any changes we will made to the object inside the method will effect on real object outside the method
            #endregion


            #region Q 2
            ////  By Value

            //int[] mainArray = { 1, 2, 3 };
            //int total = SumArray(mainArray); 
            //Console.WriteLine($" Total = {total} "); //24

            //Console.WriteLine("=====================");

            //Console.WriteLine($" mainArray[0] = {mainArray[0]} "); //1

            /*
            // total is 24 because we made new object so old one become unreachable
            // if we made any changes on the object no changes will happen on the real object ,
            // but if we make changes on Element in object the changes will happen.
            */




            //  By Reference

            //int[] mainArray = { 1, 2, 3 };
            //int total = SumArray(ref mainArray);

            //Console.WriteLine($" Total = {total} ");

            //Console.WriteLine("=====================");

            //Console.WriteLine($" mainArray[0] = {mainArray[0]} ");

            /*
           // total is 24 because we made new object so old one become unreachable
           // if we made changes on (object and elment insde the object) any changes will happen on the real object
           // ( 1 Ref , 1 Obj )
           */
            #endregion


            #region Q 3
            //Console.Write(" Enter 1st number for sum : ");
            //double num1 = GetNumber();

            //Console.Write(" Enter 2nd number for sum : ");
            //double num2 = GetNumber();

            //Console.Write(" Enter 1st number for sub : ");
            //double Subnum1 = GetNumber();

            //Console.Write(" Enter 2nd number for sub : ");
            //double Subnum2 = GetNumber();


            //double sumResult = sum( num1, num2 );
            //double subResult = sub( Subnum1, Subnum2 );

            //Console.WriteLine("================================");


            //Console.WriteLine($" Sum Result = { sumResult } ");
            //Console.WriteLine($" Sub Result = { subResult } ");
            #endregion


            #region Q 4
            //Console.Write(" Enter a number : ");
            //int number = UserNumber();

            //int Sum = CalcSum(number);
            //Console.WriteLine($" The sum of the digits of the number {number} is : {Sum}");
            #endregion


            #region Q 5
            //Console.Write("Enter a number: ");
            //int number = GetNumber();


            //bool isPrime = IsPrime(number);
            //Console.WriteLine($"{number} is {(isPrime ? "prime" : "not prime")}");
            #endregion


            #region Q 6
            //int[] numbers = { 25, 36, 45, 28, 20, 7, 88, 66, 77 };

            //MaxAndMiniArray(numbers, out int max, out int min);

            //Console.WriteLine($"Maximum value is : {max}");
            //Console.WriteLine($"Minimum value is : {min}");
            #endregion


            #region Q 7
            //Console.Write(" Enter a non-negative integer: ");
            //int number = NonNegativeInteger();

            //long factResult = CalFactorial(number);

            //Console.WriteLine($" the factorial of {number} is : {factResult}");
            #endregion


            #region Q 8
            //Console.Write(" Enter a string : ");
            //string userInput = Console.ReadLine();

            //Console.Write(" Enter position (0-based) to change: ");
            //int position = NonNegativeInteger();

            //Console.Write(" Enter a new character : ");
            //char NewChar = SingleChar();

            //string modifyString = ChangeChar(userInput, position, NewChar);

            //Console.WriteLine($" modifyString = {modifyString}");
            #endregion


        }

    }

}
