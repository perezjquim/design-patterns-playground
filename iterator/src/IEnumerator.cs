namespace iterator
{
    interface IEnumerator
    {
        bool HasNext();

        object GetNext();
    }
}