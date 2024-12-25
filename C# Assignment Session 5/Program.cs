using System.Security.Cryptography.X509Certificates;

namespace C__Assignment_Session_5
{
    internal class Program
    {
        public static void Swap(ref int X, ref int Y)
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }

        public static int SummArray(int X, params int[] Arr)
        {
            int Sum = 0;
            Arr[0] = 100;
            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i];
            }
            return Sum;
        }

        public static void SumSub(ref int X, ref int Y, out int Sum, out int Sub)
        {
            int sum = X + Y;
            int Subb = X - Y;
        }

        public static int SumDigits(int X)
        {
            int Sum = 0;
            while (X > 0)
            {
                Sum += X % 10;
                X /= 10;
            }
            return Sum;
        }   

        static bool IsPrime(int X)
        {
            if (X < 2)
            {
                return false;
            }
            for (int i = 2; i < X; i++)
            {
                if (X % i == 0)
                {
                    return false;
                }
               
            }
            return true;
        }

        public static void MinMax(int[] Arr, out int Min, out int Max)
        {
            Min = Arr[0];
            Max = Arr[0];
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] < Min)
                {
                    Min = Arr[i];
                }
                if (Arr[i] > Max)
                {
                    Max = Arr[i];
                }
            }

            public static String ChangeChar(string S, char OldChar, char NewChar)
        {
            string NewString = "";
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == OldChar)
                {
                    NewString += NewChar;
                }
                else
                {
                    NewString += S[i];
                }
            }
            return NewString;
        }



        static void Main(string[] args)
        {
            #region Q 1
            // By value

            //int A = 5;
            //int B = 10;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Swap(A, B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);


            // By reference

            //int A = 5;
            //int B = 10;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Swap(ref A, ref B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            #endregion
            #region Q 2

            // By value
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SummArray(Numbers));
            //Console.WriteLine(Numbers[0]);


            // By Reference

            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SummArray(Numbers));
            //Console.WriteLine(Numbers[0]);
            #endregion
            #region Q 3
            //int A = 20;
            //int B = 8;
            //int Sum, Sub;
            //SumSub(ref A,ref B, out Sum, out Sub);

            //Console.WriteLine(Sum);
            //Console.WriteLine(Sub);
            #endregion
            #region Q 4
            //int X = 6666;
            //int result = SumDigits(X);
            //Console.WriteLine($"The Sum of the didgits of the number {X} is {result}");           
            #endregion
            #region Q 5
            //int X = 7;
            //bool result = IsPrime(X);
            //Console.WriteLine(result);
            #endregion
            #region Q 6
            //int[] Arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int Min, Max;
            //MinMax(Arr, out Min, out Max);
            //Console.WriteLine(Min);
            //Console.WriteLine(Max);
            #endregion
            #region Q 8
            //string S = "My Name Is Mostafa";
            //char OldChar = 'N';
            //char NewChar = 'H';
            //string NewString = ChangeChar(S, OldChar, NewChar);
            //Console.WriteLine(NewString);

            #endregion
        }
        }
}
