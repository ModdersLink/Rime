using RimeLib.Frostbite.Core;

namespace RimeLib.Serialization;

public abstract record DataContainerId
{
    public sealed record Guid(GUID Id) : DataContainerId()
    {
        public override string ToString() => Id.ToString();
    }

    public sealed record Index(long Id) : DataContainerId()
    {
        public override string ToString() => Id.ToString();
    }
}

