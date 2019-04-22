using System;
using RimeLib.IO;

namespace RimeLib.Frostbite.Core
{
    /// <summary>
    /// Implementation of fb::Matrix44
    /// 4x4 Matrix
    /// </summary>
    public class Matrix44 : IFbSerializable
    {
        public Vec4 this[int p_Index]
        {
            get
            {
                switch (p_Index)
                {
                    case 0:
                        return X;
                    case 1:
                        return Y;
                    case 2:
                        return Z;
                    case 3:
                        return W;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }

            set
            {
                switch (p_Index)
                {
                    case 0:
                        X = value;
                        break;
                    case 1:
                        Y = value;
                        break;
                    case 2:
                        Z = value;
                        break;
                    case 3:
                        W = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }

        /// <summary>
        /// X vector component
        /// </summary>
        public Vec4 X { get; private set; } = new Vec4();

        /// <summary>
        /// Y vector component
        /// </summary>
        public Vec4 Y { get; private set; } = new Vec4();

        /// <summary>
        /// Z vector component
        /// </summary>
        public Vec4 Z { get; private set; } = new Vec4();

        /// <summary>
        /// W vector component
        /// </summary>
        public Vec4 W { get; private set; } = new Vec4();

        /// <summary>
        /// Returns the matrix 4x4 array as an array of Vec4's
        /// </summary>
        public Vec4[] Array
        {
            get => new[] { X, Y, Z, W };
            set
            {
                if (value.Length != 4)
                    throw new ArgumentException("Input array is not type Vec4[].");

                X = value[0];
                Y = value[1];
                Z = value[2];
                W = value[3];
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Matrix44()
        {
        }

        /// <summary>
        /// Constructor taking each vector component as arguments
        /// </summary>
        /// <param name="p_V1">X vector component</param>
        /// <param name="p_V2">Y vector component</param>
        /// <param name="p_V3">Z vector component</param>
        /// <param name="p_V4">W vector component</param>
        public Matrix44(Vec4 p_V1, Vec4 p_V2, Vec4 p_V3, Vec4 p_V4)
        {
            X = p_V1;
            Y = p_V2;
            Z = p_V3;
            W = p_V4;
        }

        /// <summary>
        /// Constructor that reads a Matrix44 from an opened reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of a matrix44</param>
        public Matrix44(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new NotImplementedException();
        }

        public bool Serialize(out byte[] p_Data)
        {
            throw new NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            X = new Vec4(p_Reader);
            Y = new Vec4(p_Reader);
            Z = new Vec4(p_Reader);
            W = new Vec4(p_Reader);
        }

        public void Deserialize(byte[] p_Data)
        {
            throw new NotImplementedException();
        }
    }
}
