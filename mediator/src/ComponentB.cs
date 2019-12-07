namespace mediator
{
    class ComponentB : Component
    {
        public ComponentB(IMediator aMediator) : base(aMediator) {}
        public void OnB()
        {
            mMediator.Notify(this,"B");
        }
    }
}