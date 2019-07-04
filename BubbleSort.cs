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
                if (items[i] > items[j])
                {
                    temp = items[i];

                    items[i] = items[j];

                    items[j] = temp;
                }
            }
        }

        return items;
    }
}