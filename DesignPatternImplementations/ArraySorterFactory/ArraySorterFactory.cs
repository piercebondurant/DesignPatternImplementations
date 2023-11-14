using DesignPatternImplementations.ArraySorters;
using DesignPatternImplementations.ArraySorters.Interfaces;
using DesignPatternImplementations.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternImplementations.ArraySorterFactory
{
    public class ArraySorterFactory
    {
        public ArraySorterFactory() { }

        public static IArraySorter CreateArraySorter(ArraySorterTypes type)
        {
            switch (type)
            {
                case ArraySorterTypes.Bubble:
                    return new BubbleSorter();
                    break;
                case ArraySorterTypes.Selection:
                    return new SelectionSorter();
                    break;
                case ArraySorterTypes.Merge:
                    return new MergeSorter();
                    break;
            }
            throw new Exception("No ArraySorter of specified type available.");
        }
    }
}
