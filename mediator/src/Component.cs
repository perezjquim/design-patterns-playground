namespace mediator
{
    abstract class Component
    {
        public IMediator mMediator { get; set; }

        public Component(IMediator aMediator = null)
        {
            mMediator = aMediator;
        }
    }
}