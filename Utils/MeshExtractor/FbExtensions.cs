using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

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
    }
}
