using DesignPatternImplementations.ArraySorterFactory;
using DesignPatternImplementations.Enums;
using System;
namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            var type = ArraySorterTypes.Merge;

            var input = new int[]{ 3, 4, 61, 5, 1, 49, 89 };

            Run(input, type);
        }

        public static void Run(int[] input, ArraySorterTypes type)
        {
            var sorter = ArraySorterFactory.CreateArraySorter(type);

            sorter.Sort(input);
        }
    }
}
