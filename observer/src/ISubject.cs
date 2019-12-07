namespace observer
{
    interface ISubject
    {
        void Notify(object aObject = null);
        void RegisterObserver(IObserver aObserver);
        void UnregisterObserver(IObserver aObserver);
    }
}