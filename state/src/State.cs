namespace state
{
    public abstract class State
    {
        public Context mContext { get; set; }

        public abstract void onReceive(object aObject);

        public abstract void onSend(object aObject);
    }
}