namespace Strategy
{
    public sealed class BubbleSorter<T>
    {
        private int operations = 0;
        private int length = 0;
        private SortHandler<T> itsSortHandler = null;

        public BubbleSorter(SortHandler<T> handler)
        {
            itsSortHandler = handler;
        }

        public int Sort(T[] arrayToSort)
        {
            itsSortHandler.SetArray(arrayToSort);

            length = itsSortHandler.Length();

            if (length <= 1)
                return operations;

            for (int nextToLast = length - 2;
                nextToLast >= 0;
                nextToLast--)
                for (int index = 0; index <= nextToLast; index++)
                {
                    if (itsSortHandler.OutOfOrder(index))
                        itsSortHandler.Swap(index);
                    operations++;
                }

            return operations;
        }
    }
}
