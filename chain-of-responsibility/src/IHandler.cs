namespace chain_of_responsibility
{
    interface IHandler
    {
        object Handle(object aArgs);

        IHandler SetNext(IHandler aNextHandler);
    }
}