namespace mediator
{
    class ComponentA : Component
    {
        public ComponentA(IMediator aMediator) : base(aMediator) {}        
        public void OnA()
        {
            mMediator.Notify(this,"A");
        }
    }
}