
namespace Strategy
{
    public interface SortHandler<T>
    {
        void Swap(int index);

        bool OutOfOrder(int index);

        int Length();

        void SetArray(T[] array);
    }
}
