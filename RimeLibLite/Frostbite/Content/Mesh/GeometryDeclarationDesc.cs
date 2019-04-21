using System.Collections.Generic;
using System.IO;
using RimeLib.IO;

namespace RimeLib.Frostbite.Content.Mesh
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

            public void Serialize(RimeWriter p_Writer)
            {
                throw new System.NotImplementedException();
            }

            /// <summary>
            /// Writes out the stream
            /// </summary>
            /// <returns>byte[] containing the serialized data</returns>
            public byte[] Serialize()
            {
                byte[] s_Data;

                using (var s_Writer = new RimeWriter(new MemoryStream()))
                {
                    s_Writer.Write(Stride);
                    s_Writer.Write((byte)Classification);

                    s_Data = (s_Writer.BaseStream as MemoryStream)?.ToArray();
                }

                return s_Data;
            }

            public void Deserialize(RimeReader p_Reader)
            {
                Stride = p_Reader.ReadByte();
                Classification = (VertexElementClassification)p_Reader.ReadByte();
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

            public void Serialize(RimeWriter p_Writer)
            {
                throw new System.NotImplementedException();
            }

            /// <summary>
            /// Serializes a element
            /// </summary>
            /// <returns>byte[] containing the data of an element</returns>
            public byte[] Serialize()
            {
                byte[] s_Data;

                using (var s_Writer = new RimeWriter(new MemoryStream()))
                {
                    s_Writer.Write((byte)Usage);
                    s_Writer.Write((byte)Format);
                    s_Writer.Write(Offset);
                    s_Writer.Write(StreamIndex);

                    s_Data = (s_Writer.BaseStream as MemoryStream)?.ToArray();
                }

                return s_Data;
            }

            public void Deserialize(RimeReader p_Reader)
            {
                Usage = (VertexElementUsage) p_Reader.ReadByte();
                Format = (VertexElementFormat) p_Reader.ReadByte();
                Offset = p_Reader.ReadByte();
                StreamIndex = p_Reader.ReadByte();
            }

            public void Deserialize(byte[] p_Data)
            {
                throw new System.NotImplementedException();
            }
        }

        private List<Element> m_Elements = new List<Element>(); // [16]
        private List<Stream> m_Streams = new List<Stream>(); // [4]
        private byte m_ElementCount;
        private byte m_StreamCount;
        private byte[] m_Padding; // Len2

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
        public void Serialize(RimeWriter p_Writer)
        {
            foreach (var s_Element in m_Elements)
                p_Writer.Write(s_Element.Serialize());

            foreach (var s_Stream in m_Streams)
                p_Writer.Write(s_Stream.Serialize());

            p_Writer.Write(m_ElementCount);
            p_Writer.Write(m_StreamCount);
            p_Writer.Write(m_Padding);
        }

        public byte[] Serialize()
        {
            throw new System.NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            for (var i = 0; i < 16; ++i)
                m_Elements.Add(new Element(p_Reader));

            for (var i = 0; i < 4; ++i)
                m_Streams.Add(new Stream(p_Reader));

            m_ElementCount = p_Reader.ReadByte();
            m_StreamCount = p_Reader.ReadByte();
            m_Padding = p_Reader.ReadBytes(2);
        }

        public void Deserialize(byte[] p_Data)
        {
            throw new System.NotImplementedException();
        }
    }
}
