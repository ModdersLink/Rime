using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Mesh.Frostbite
{
    /// <summary>
    /// Implementation of fb::GeometryDeclarationDesc
    /// </summary>
    public class GeometryDeclarationDesc : IFbSerializable
    {
        /// <summary>
        /// Geometry declaration stream
        /// </summary>
        public class Stream : IFbSerializable
        {
            /// <summary>
            /// Stride of the model data
            /// </summary>
            public byte Stride { get; set; }

            /// <summary>
            /// Classification of stream
            /// </summary>
            public VertexElementClassification Classification { get; set; }

            /// <summary>
            /// Default constructor
            /// </summary>
            public Stream()
            {

            }

            /// <summary>
            /// Reads a stream from an opened reader
            /// </summary>
            /// <param name="p_Reader">Reader opened to the position of a geometry declaration descriptor stream</param>
            public Stream(RimeReader p_Reader)
            {
                Deserialize(p_Reader);
            }

            public bool Serialize(RimeWriter p_Writer)
            {
                throw new NotImplementedException();
            }

            public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
            {
                p_Data = null;
                throw new NotImplementedException();
            }

            /// <summary>
            /// Writes out the stream
            /// </summary>
            /// <returns>byte[] containing the serialized data</returns>
            public byte[] Serialize()
            {
                byte[] s_Data;

                var s_Stream = new MemoryStream();
                using (var s_Writer = new RimeWriter(s_Stream))
                {
                    s_Writer.Write(Stride);
                    s_Writer.Write((byte)Classification);

                    s_Data = s_Stream.ToArray();
                }

                return s_Data;
            }

            public void Deserialize(RimeReader p_Reader)
            {
                Stride = p_Reader.ReadUByte();
                Classification = (VertexElementClassification) p_Reader.ReadUByte();
            }

            public void Deserialize(byte[] p_Data)
            {
                throw new System.NotImplementedException();
            }
        }

        /// <summary>
        /// Geometry declaration description element
        /// </summary>
        public class Element : IFbSerializable
        {
            /// <summary>
            /// Usage of this element
            /// </summary>
            public VertexElementUsage Usage { get; set; }
            
            /// <summary>
            /// Format of this element
            /// </summary>
            public VertexElementFormat Format { get; set; }

            /// <summary>
            /// Offset of this element
            /// </summary>
            public byte Offset { get; set; }

            /// <summary>
            /// Stream index
            /// </summary>
            public byte StreamIndex { get; set; }

            /// <summary>
            /// Constructor to read an element from an open reader
            /// </summary>
            /// <param name="p_Reader">Reader opened to the position of an element</param>
            public Element(RimeReader p_Reader)
            {
                Deserialize(p_Reader);
            }

            public bool Serialize(RimeWriter p_Writer)
            {
                throw new System.NotImplementedException();
            }
            
            /// <summary>
            /// Serializes a element
            /// </summary>
            /// <returns>byte[] containing the data of an element</returns>
            public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
            {
                p_Data = null;
                var s_Stream = new MemoryStream();
                using (var s_Writer = new RimeWriter(new MemoryStream()))
                {
                    s_Writer.Write((byte) Usage);
                    s_Writer.Write((byte) Format);
                    s_Writer.Write(Offset);
                    s_Writer.Write(StreamIndex);

                    p_Data = s_Stream.ToArray();
                }

                return true;
            }

            public void Deserialize(RimeReader p_Reader)
            {
                Usage = (VertexElementUsage) p_Reader.ReadUByte();
                Format = (VertexElementFormat) p_Reader.ReadUByte();
                Offset = p_Reader.ReadUByte();
                StreamIndex = p_Reader.ReadUByte();
            }

            public void Deserialize(byte[] p_Data)
            {
                throw new System.NotImplementedException();
            }
        }

        public List<Element> Elements { get; set; } = new List<Element>(); // [16]
        public List<Stream> Streams { get; set; } = new List<Stream>(); // [4]
        public byte ElementCount { get; set; }
        public byte StreamCount { get; set; }
        public byte[] Padding { get; set; } = new byte[2]; // Len2

        /// <summary>
        /// Default constructor
        /// </summary>
        public GeometryDeclarationDesc()
        {

        }

        /// <summary>
        /// Constructor that reads a geometry declaration desc from an open reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of the geometry declaration descriptor</param>
        public GeometryDeclarationDesc(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        /// <summary>
        /// Serializes this geometry declaration descriptor
        /// </summary>
        /// <param name="p_Writer">Writer opened to the position where this descriptor should be written</param>
        public bool Serialize(RimeWriter p_Writer)
        {
            foreach (var s_Element in Elements)
                if (!s_Element.Serialize(p_Writer))
                    return false;

            foreach (var s_Stream in Streams)
                p_Writer.Write(s_Stream.Serialize());

            p_Writer.Write(ElementCount);
            p_Writer.Write(StreamCount);
            p_Writer.Write(Padding);

            return true;
        }

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            p_Data = null;
            throw new System.NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            for (var i = 0; i < 16; ++i)
                Elements.Add(new Element(p_Reader));

            for (var i = 0; i < 4; ++i)
                Streams.Add(new Stream(p_Reader));

            ElementCount = p_Reader.ReadUByte();
            StreamCount = p_Reader.ReadUByte();
            Padding = p_Reader.ReadBytes(2);
        }

        public void Deserialize(byte[] p_Data)
        {
            throw new System.NotImplementedException();
        }
    }
}
