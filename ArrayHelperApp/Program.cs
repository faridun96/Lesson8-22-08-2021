using System;

namespace ArrayHelperApp
{
    public static class ArrayHelper
    {
        public static string Pop(ref string[] sourceArray)
        {
            string lastElement = sourceArray[sourceArray.Length - 1];
            string[] newArr = new string[sourceArray.Length - 1];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = sourceArray[i];
            }
            sourceArray = newArr;
            return lastElement;
        }
        public static int Push(ref string[] sourceArray, string value)
        {
            string[] newArray = new string[sourceArray.Length + 1];
            for (int i = 0; i < sourceArray.Length; i++)
            {
                newArray[i] = sourceArray[i];
            }
            newArray[newArray.Length - 1] = value;
            sourceArray = newArray;
            return sourceArray.Length;
        }
        public static string Shift(ref string[] sourceArray)
        {
            string firstElement = sourceArray[0];
            string[] newArray = new string[sourceArray.Length - 1];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = sourceArray[i + 1];
            }
            sourceArray = newArray;
            return firstElement;
        }
        public static int UnShift(ref string[] sourceArray, string value)
        {
            string[] newArray = new string[sourceArray.Length + 1];
            newArray[0] = value;
            for (int i = 0; i < sourceArray.Length; i++)
            {
                newArray[i + 1] = sourceArray[i];
            }
            sourceArray = newArray;
            return sourceArray.Length;
        }
        public static int Pop(ref int[] sourceArray)
        {
            int lastElement = sourceArray[sourceArray.Length - 1];
            int[] newArr = new int[sourceArray.Length - 1];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = sourceArray[i];
            }
            sourceArray = newArr;
            return lastElement;
        }
        public static double Push(ref int[] sourceArray, int value)
        {
            int[] newArray = new int[sourceArray.Length + 1];
            for (int i = 0; i < sourceArray.Length; i++)
            {
                newArray[i] = sourceArray[i];
            }
            newArray[newArray.Length - 1] = value;
            sourceArray = newArray;
            return sourceArray.Length;
        }
        public static int Shift(ref int[] sourceArray)
        {
            int firstElement = sourceArray[0];
            int[] newArray = new int[sourceArray.Length - 1];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = sourceArray[i + 1];
            }
            sourceArray = newArray;
            return firstElement;
        }
        public static double UnShift(ref int[] sourceArray, int value)
        {
            int[] newArray = new int[sourceArray.Length + 1];
            newArray[0] = value;
            for (int i = 0; i < sourceArray.Length; i++)
            {
                newArray[i + 1] = sourceArray[i];
            }
            sourceArray = newArray;
            return sourceArray.Length;
        }
         public static double Pop(ref double[] sourceArray)
        {
            double lastElement = sourceArray[sourceArray.Length - 1];
            double[] newArr = new double[sourceArray.Length - 1];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = sourceArray[i];
            }
            sourceArray = newArr;
            return lastElement;
        }
        public static int Push(ref double[] sourceArray, double value)
        {
            double[] newArray = new double[sourceArray.Length + 1];
            for (int i = 0; i < sourceArray.Length; i++)
            {
                newArray[i] = sourceArray[i];
            }
            newArray[newArray.Length - 1] = value;
            sourceArray = newArray;
            return sourceArray.Length;
        }
        public static double Shift(ref double[] sourceArray)
        {
            double firstElement = sourceArray[0];
            double[] newArray = new double[sourceArray.Length - 1];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = sourceArray[i + 1];
            }
            sourceArray = newArray;
            return firstElement;
        }
        public static int UnShift(ref double[] sourceArray, double value)
        {
            double[] newArray = new double[sourceArray.Length + 1];
            newArray[0] = value;
            for (int i = 0; i < sourceArray.Length; i++)
            {
                newArray[i + 1] = sourceArray[i];
            }
            sourceArray = newArray;
            return sourceArray.Length;
        }
         public static decimal Pop(ref decimal[] sourceArray)
        {
            decimal lastElement = sourceArray[sourceArray.Length - 1];
            decimal[] newArr = new decimal[sourceArray.Length - 1];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = sourceArray[i];
            }
            sourceArray = newArr;
            return lastElement;
        }
        public static int Push(ref decimal[] sourceArray, decimal value)
        {
            decimal[] newArray = new decimal[sourceArray.Length + 1];
            for (int i = 0; i < sourceArray.Length; i++)
            {
                newArray[i] = sourceArray[i];
            }
            newArray[newArray.Length - 1] = value;
            sourceArray = newArray;
            return sourceArray.Length;
        }
        public static decimal Shift(ref decimal[] sourceArray)
        {
            decimal firstElement = sourceArray[0];
            decimal[] newArray = new decimal[sourceArray.Length - 1];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = sourceArray[i + 1];
            }
            sourceArray = newArray;
            return firstElement;
        }
        public static int UnShift(ref decimal[] sourceArray, decimal value)
        {
            decimal[] newArray = new decimal[sourceArray.Length + 1];
            newArray[0] = value;
            for (int i = 0; i < sourceArray.Length; i++)
            {
                newArray[i + 1] = sourceArray[i];
            }
            sourceArray = newArray;
            return sourceArray.Length;
        }
        public static float Pop(ref float[] sourceArray)
        {
            float lastElement = sourceArray[sourceArray.Length - 1];
            float[] newArr = new float[sourceArray.Length - 1];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = sourceArray[i];
            }
            sourceArray = newArr;
            return lastElement;
        }
        public static int Push(ref float[] sourceArray, float value)
        {
            float[] newArray = new float[sourceArray.Length + 1];
            for (int i = 0; i < sourceArray.Length; i++)
            {
                newArray[i] = sourceArray[i];
            }
            newArray[newArray.Length - 1] = value;
            sourceArray = newArray;
            return sourceArray.Length;
        }
        public static float Shift(ref float[] sourceArray)
        {
            float firstElement = sourceArray[0];
            float[] newArray = new float[sourceArray.Length - 1];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = sourceArray[i + 1];
            }
            sourceArray = newArray;
            return firstElement;
        }
        public static int UnShift(ref float[] sourceArray, float value)
        {
            float[] newArray = new float[sourceArray.Length + 1];
            newArray[0] = value;
            for (int i = 0; i < sourceArray.Length; i++)
            {
                newArray[i + 1] = sourceArray[i];
            }
            sourceArray = newArray;
            return sourceArray.Length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { "a", "b", "c", "d", "e", "f" };
            Console.WriteLine( "Исходный массив типа string:" );
            foreach (string s in arr) { Console.Write( s + " " ); }
            Console.WriteLine( "\nПоследний элемент типа string: {0}", ArrayHelper.Pop(ref arr));
            Console.WriteLine( "Новый массив типа string:" );
            foreach ( string s in arr ) { Console.Write( s + " " ); }
            int[] array = new int[] {1,2,3,4,5,6};
            Console.WriteLine( "\nИсходный массив типа int:" );
            foreach (int s in array) { Console.Write( s + " " ); }
            Console.Write( "\nДобавить элемент типа int: " );
            int ne = int.Parse(Console.ReadLine());
            Console.WriteLine( "Новая длина массива типа int: {0}", ArrayHelper.Push( ref array, ne));
            Console.WriteLine( "Новый массив типа int:" );
            foreach ( int s in array ) { Console.Write( s + " " );}
            double[] arra = new double[] {1.2,2.3,3.4,4.5,5.6,6.7};
            Console.WriteLine( "\nИсходный массив типа double:" );
            foreach (double s in arra) { Console.Write( s + " " ); }
            Console.WriteLine("\nПервый элемент типа double: {0}", ArrayHelper.Shift(ref arra));
            Console.WriteLine( "Новый массив типа double:" );
            foreach ( double s in arra ) { Console.Write( s + " " ); }
            decimal[] ar = new decimal[] {1.111m,2.222m,3.333m,4.444m,5.555m,6.666m};
            Console.WriteLine( "\nИсходный массив типа decimal:" );
            foreach (decimal s in ar) { Console.Write( s + " " ); }
            Console.Write( "\nДобавить элемент типа decimal: " );
            decimal nw = decimal.Parse(Console.ReadLine());
            Console.WriteLine( "Новая длина массива типа decimal: {0}", ArrayHelper.UnShift( ref ar, nw));
            Console.WriteLine( "Новый массив типа decimal:" );
            foreach ( decimal s in ar ) { Console.Write( s + " " );}
            Console.WriteLine();
        }
    }
}