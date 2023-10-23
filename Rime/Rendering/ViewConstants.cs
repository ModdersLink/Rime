using System.Runtime.InteropServices;
using Vector3 = SharpDX.Vector3;
using Vector4 = SharpDX.Vector4;
using Matrix = SharpDX.Matrix;

namespace Rime.Rendering
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct ViewConstants
    {
        public float Time;
        private readonly uint _pad0;
        private readonly ulong _pad1;
        public Vector4 ScreenSize;
        public Vector3 DebugNonFiniteColor;
        private readonly uint _pad2;
        public Matrix ViewMatrix;
        public Matrix ProjMatrix;
        public Matrix ViewProjMatrix;
        public Matrix CrViewProjMatrix;
        public Vector4 ViewportZMinMaxKzKw;
        public Vector3 CameraPos;
        private readonly uint _pad3;
        public Vector3 TransparentStartAndEndAndClamp;
        private readonly uint _pad4;
    }
}
