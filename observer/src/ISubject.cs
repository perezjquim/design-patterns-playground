namespace observer
{
    interface ISubject
    {
        void Notify(object aObject);
        void Notify();
        void RegisterObserver(IObserver aObserver);
        void UnregisterObserver(IObserver aObserver);
    }
}