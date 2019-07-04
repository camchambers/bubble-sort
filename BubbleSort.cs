// Bubble sort works by repeatedly stepping through a list of values,
// compares adjacent pairs, and swaps them if they are in the wrong order.
// The algorithm stops when the list is sorted.
// It is named based on the way that small elements 'bubble' up to the top
// of the list. 
// It is a simple, but slow algorithm and is impractical for most problems
// compared to other sorting algorithms such as "insertion sort".
// Bubble sort can be practical if the elements being sorted are already mostly
// in sorted order with some elements nearly in position. 
// Bubble sort has a worst case and average case time complexity of O(n²) and a
// best case complexity of O(n) when the list of values is already sorted.

class BubbleSort
{
    public int[] sort(int[] items)
    {
        int length = items.Length;

        int temp = items[0];

        for (int i = 0; i < length; i++)
        {
            for (int j = i + 1; j < length; j++)
            {
                // Determine if the current item in the array is greater than
                // the next item in the array
                if (items[i] > items[j])
                {
                    // Swap the current and next item
                    temp = items[i];
                    items[i] = items[j];
                    items[j] = temp;
                }
            }
        }
        return items;
    }
}