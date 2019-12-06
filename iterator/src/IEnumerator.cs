namespace iterator
{
    interface IEnumerator<T>
    {
        bool HasNext();

        T GetNext();
    }
}