namespace observer
{
    interface IObserver
    {
        void OnNotified(object aObject = null);
    }
}