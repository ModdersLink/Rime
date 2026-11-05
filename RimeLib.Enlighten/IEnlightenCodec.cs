using RimeLib.Content.Frostbite;
using RimeLib.Frostbite;

namespace RimeLib.Enlighten
{
    /// <summary>An Enlighten resource's fields, ready for a JSON dump, and whether writing it back gives the shipped bytes.</summary>
    public sealed record EnlightenResourceDump(object Fields, bool ReEncodesExactly);

    /// <summary>Reads the Enlighten resources that hold structure rather than pixels or radiosity data.</summary>
    public interface IEnlightenCodec : IEngineInterface
    {
        /// <summary>The resource's fields, or null when the type is not one this engine reads.</summary>
        EnlightenResourceDump? Dump(ResourceType p_Type, byte[] p_Data);
    }
}
