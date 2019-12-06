namespace template_method
{
    abstract class Builder
    {
        public abstract void lint();

        public abstract void minify();

        public abstract void build();

        public abstract void install();

        public void run()
        {
            this.lint();
            this.minify();
            this.build();
            this.install();
        }
    }
}