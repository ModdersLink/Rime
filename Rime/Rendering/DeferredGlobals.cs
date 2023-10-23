using System.Runtime.InteropServices;
using Vector3 = SharpDX.Vector3;

namespace Rime.Rendering
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct DeferredGlobals
    {
        public Vector3 LightDirection;
        private readonly float _pad;
    }
}
