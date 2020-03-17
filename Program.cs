using System;
using System.Linq;

namespace bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {

            // An array of values to be sorted
            int[] values = { 742, 16, 152, 654, 582, 77, 15, 364, 5, 22 };

            // Instantiate a new bubble sort object
            BubbleSort bubbleSort = new BubbleSort();

            // Sort the bubble sort values into a new array
            int[] sortedValues = bubbleSort.sort(values);

            // Print the sorted values
            sortedValues.ToList().ForEach(Console.WriteLine);

        }
    }
}
