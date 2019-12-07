namespace mediator
{
    interface IMediator
    {
        void Notify(object aSender, string aEvent);
    }
}