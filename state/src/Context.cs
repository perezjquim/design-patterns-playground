namespace state
{
    public class Context
    {
        public State mState { get; set; }

        public Context(State aState)
        {
            TransitionTo(aState);
        }

        public void TransitionTo(State aState)
        {
            mState = aState;
            mState.mContext = this;
        }

        public void onReceive(object aObject)
        {
            mState.onReceive(aObject);
        }

        public void onSend(object aObject)
        {
            mState.onSend(aObject);
        }        
    }
}