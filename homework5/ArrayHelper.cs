using System.Linq;

namespace homework5
{
    public static class ArrayHelper
    {
        public static string Pop(ref string[] args)
        {
            var lastElement = args[^1];
            args = args.Take(args.Length - 1).ToArray();
            return lastElement;
        }

        public static int Pop(ref int[] args)
        {
            var lastElement = args[^1];
            args = args.Take(args.Length - 1).ToArray();
            return lastElement;
        }

        public static double Pop(ref double[] args)
        {
            var lastElement = args[^1];
            args = args.Take(args.Length - 1).ToArray();
            return lastElement;
        }

        public static decimal Pop(ref decimal[] args)
        {
            var lastElement = args[^1];
            args = args.Take(args.Length - 1).ToArray();
            return lastElement;
        }

        public static float Pop(ref float[] args)
        {
            var lastElement = args[^1];
            args = args.Take(args.Length - 1).ToArray();
            return lastElement;
        }

        public static int Push(ref string[] args, string element)
        {
            var elements = args.Append(element);
            args = new string[args.Length];
            args = elements.ToArray();
            return args.Length;
        }

        public static int Push(ref int[] args, int element)
        {
            var elements = args.Append(element);
            args = new int[args.Length];
            args = elements.ToArray();
            return args.Length;
        }

        public static int Push(ref double[] args, double element)
        {
            var elements = args.Append(element);
            args = new double[args.Length];
            args = elements.ToArray();
            return args.Length;
        }

        public static int Push(ref decimal[] args, decimal element)
        {
            var elements = args.Append(element);
            args = new decimal[args.Length];
            args = elements.ToArray();
            return args.Length;
        }

        public static int Push(ref float[] args, float element)
        {
            var elements = args.Append(element);
            args = new float[args.Length];
            args = elements.ToArray();
            return args.Length;
        }

        public static string Shift(ref string[] args)
        {
            var firstElement = args[0];
            args = args.Skip(1).ToArray();
            return firstElement;
        }

        public static int Shift(ref int[] args)
        {
            var firstElement = args[0];
            args = args.Skip(1).ToArray();
            return firstElement;
        }

        public static double Shift(ref double[] args)
        {
            var firstElement = args[0];
            args = args.Skip(1).ToArray();
            return firstElement;
        }

        public static decimal Shift(ref decimal[] args)
        {
            var firstElement = args[0];
            args = args.Skip(1).ToArray();
            return firstElement;
        }

        public static float Shift(ref float[] args)
        {
            var firstElement = args[0];
            args = args.Skip(1).ToArray();
            return firstElement;
        }

        public static int UnShift(ref string[] args, string element)
        {
            args = new[] {element}.Concat(args).ToArray();
            return args.Length;
        }

        public static int UnShift(ref int[] args, int element)
        {
            args = new[] {element}.Concat(args).ToArray();
            return args.Length;
        }

        public static int UnShift(ref double[] args, double element)
        {
            args = new[] {element}.Concat(args).ToArray();
            return args.Length;
        }

        public static int UnShift(ref decimal[] args, decimal element)
        {
            args = new[] {element}.Concat(args).ToArray();
            return args.Length;
        }

        public static int UnShift(ref float[] args, float element)
        {
            args = new[] {element}.Concat(args).ToArray();
            return args.Length;
        }
    }
}