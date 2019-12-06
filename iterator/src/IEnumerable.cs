namespace iterator
{
    interface IEnumerable<T>
    {
        IEnumerator<T> GetEnumerator();
    }
}