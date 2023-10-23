using System.Runtime.InteropServices;
using Vector4 = SharpDX.Vector4;

namespace Rime.Rendering
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct ExternalConstants
    {
        public Vector4 Color;
    }
}
