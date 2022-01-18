using RimeLib.Frostbite.Core;
using System.Numerics;
using fb;

namespace MeshExtractor
{
    public static class FbExtensions
    {
        public static Matrix4x4 ToMatrix4x4 (this Matrix44 p_Matrix)
        {
            return new Matrix4x4(
                p_Matrix.X.X, p_Matrix.X.Y, p_Matrix.X.Z, p_Matrix.X.W,
                p_Matrix.Y.X, p_Matrix.Y.Y, p_Matrix.Y.Z, p_Matrix.Y.W,
                p_Matrix.Z.X, p_Matrix.Z.Y, p_Matrix.Z.Z, p_Matrix.Z.W,
                p_Matrix.W.X, p_Matrix.W.Y, p_Matrix.W.Z, p_Matrix.W.W);
        }

        public static Matrix4x4 ToMatrix4x4 (this LinearTransform p_Transform)
        {
            return new Matrix4x4(
                p_Transform.right.x, p_Transform.right.y, p_Transform.right.z, 0,
                p_Transform.up.x, p_Transform.up.y, p_Transform.up.z, 0,
                p_Transform.forward.x, p_Transform.forward.y, p_Transform.forward.z, 0,
                p_Transform.trans.x, p_Transform.trans.y, p_Transform.trans.z, 0);
        }
    }
}
