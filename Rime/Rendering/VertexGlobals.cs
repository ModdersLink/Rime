using System.Runtime.InteropServices;
using Matrix = SharpDX.Matrix;

namespace Rime.Rendering
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct VertexGlobals
    {
        public Matrix WorldMatrix;
    }
}
