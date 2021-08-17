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
                // Determine if the item at the current index the array is greater than
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
