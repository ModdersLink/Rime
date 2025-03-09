using System.Runtime.InteropServices;
using Vector2 = SharpDX.Vector2;
using Vector4 = SharpDX.Vector4;

namespace Rime.Rendering
{
    [StructLayout(LayoutKind.Sequential, Size = kSizeOf)]
    public struct ScreenToTextureVertex
    {
        public const int kSizeOf = 16 + 8;

        public Vector4 Postion;
        public Vector2 Texcoord;

        public ScreenToTextureVertex(Vector4 position, Vector2 texcoord)
        {
            this.Postion = position;
            this.Texcoord = texcoord;
        }
    }
}
