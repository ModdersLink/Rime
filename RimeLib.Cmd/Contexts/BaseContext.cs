namespace RimeLib.Cmd.Contexts
{
    public class BaseContext : ExecutionContext
    {
        public BaseContext()
        {

        }

        public override string GetShortDescription()
        {
            return "0 games mounted";
        }

        public override string GetLongDescription()
        {
            return "0 games mounted";
        }
    }
}
