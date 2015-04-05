namespace Strategy
{
    public sealed class QuickBubbleSorter<T>
    {
        private int operations = 0;
        private int length = 0;
        private SortHandler<T> itsSortHandler = null;

        public QuickBubbleSorter(SortHandler<T> handler)
        {
            itsSortHandler = handler;
        }

        public int Sort(T[] arrayToSort)
        {
            itsSortHandler.SetArray(arrayToSort);
            length = itsSortHandler.Length();

            if (length <= 1)
                return operations;

            bool thisPassInOrder = false;

            for (int nextToLast = length - 1;
                nextToLast >= 0 && !thisPassInOrder;
                nextToLast--)
            {
                thisPassInOrder = true; // Potentially.

                for (int index = 0; index <= nextToLast; index++)
                {
                    if (itsSortHandler.OutOfOrder(index))
                    {
                        itsSortHandler.Swap(index);
                        thisPassInOrder = false;
                    }

                    operations++;
                }
            }

            return operations;
        }
    }
}
