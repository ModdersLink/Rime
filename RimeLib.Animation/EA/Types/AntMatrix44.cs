using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Animation.EA.Types
{
    public class AntMatrix44
        : IFbSerializable
    {
        public AntVector4 this[int p_Index]
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
        public AntVector4 X { get; private set; } = new();

        /// <summary>
        /// Y vector component
        /// </summary>
        public AntVector4 Y { get; private set; } = new();

        /// <summary>
        /// Z vector component
        /// </summary>
        public AntVector4 Z { get; private set; } = new();

        /// <summary>
        /// W vector component
        /// </summary>
        public AntVector4 W { get; private set; } = new();

        /// <summary>
        /// Returns the matrix 4x4 array as an array of Vec4's
        /// </summary>
        public AntVector4[] Array
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



        public override string ToString() => $"M44{X} {Y} {Z} {W}";

        /// <summary>
        /// Default constructor
        /// </summary>
        public AntMatrix44()
        {
        }

        /// <summary>
        /// Constructor taking each vector component as arguments
        /// </summary>
        /// <param name="p_V1">X vector component</param>
        /// <param name="p_V2">Y vector component</param>
        /// <param name="p_V3">Z vector component</param>
        /// <param name="p_V4">W vector component</param>
        public AntMatrix44(AntVector4 p_V1, AntVector4 p_V2, AntVector4 p_V3, AntVector4 p_V4)
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
        public AntMatrix44(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            X.Serialize(p_Writer);
            Y.Serialize(p_Writer);
            Z.Serialize(p_Writer);
            W.Serialize(p_Writer);

            return true;
        }

        public void Deserialize(RimeReader p_Reader)
        {
            X = new AntVector4(p_Reader);
            Y = new AntVector4(p_Reader);
            Z = new AntVector4(p_Reader);
            W = new AntVector4(p_Reader);
        }
        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            var s_Stream = new MemoryStream();
            using var s_Writer = new RimeWriter(s_Stream);

            if (Serialize(s_Writer))
            {
                p_Data = s_Stream.ToArray();
                return true;
            }

            p_Data = null;
            return false;
        }

        public void Deserialize(byte[] p_Data)
        {
            using var s_Reader = new RimeReader(new MemoryStream(p_Data));
            Deserialize(s_Reader);
        }
    }
}
