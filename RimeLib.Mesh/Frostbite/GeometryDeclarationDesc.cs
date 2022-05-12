using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Extensions;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Mesh.Frostbite;

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
        public VertexElementClassification Classification { get; set; } = VertexElementClassification.VertexElementClassification_PerVertex;

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
            p_Writer.Write(Stride);
            p_Writer.Write((byte)Classification);
            
            return true;
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
        public VertexElementUsage Usage { get; set; } = VertexElementUsage.VertexElementUsage_Unknown;

        public VertexElementFormat Format { get; set; } = VertexElementFormat.VertexElementFormat_None;

        public byte Offset { get; set; } = 255;

        public byte StreamIndex { get; set; }

        public Element()
        {
                
        }

        public Element(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write((byte) Usage);
            p_Writer.Write((byte) Format);
            p_Writer.Write(Offset);
            p_Writer.Write(StreamIndex);
            return true;
        }
            
        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            using var s_Writer = new RimeWriter(new MemoryStream());
            
            if (Serialize(s_Writer))
            {
                s_Writer.Flush();
                s_Writer.Seek(0, SeekOrigin.Begin);
                
                p_Data = s_Writer.ToArray();
                return true;
            }

            p_Data = null;
            return false;
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

    public List<Element> Elements { get; set; } = new();
    public List<Stream> Streams { get; set; } = new();
    
    public uint Hash
    {
        get
        {
            using var s_Writer = new RimeWriter(new MemoryStream());
            Serialize(s_Writer);
            s_Writer.Seek(0, SeekOrigin.Begin);
            return RimeLib.Frostbite.Utils.Fletcher32(s_Writer.ToArray());
        }
    }

    public GeometryDeclarationDesc()
    {

    }

    public GeometryDeclarationDesc(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        if (Elements.Count > 16)
            throw new Exception("Cannot declare more than 16 elements.");

        if (Streams.Count > 4)
            throw new Exception("Cannot declare more than 4 streams.");
            
        foreach (var s_Element in Elements)
            if (!s_Element.Serialize(p_Writer))
                return false;

        for (var i = Elements.Count; i < 16; ++i)
            new Element().Serialize(p_Writer);

        foreach (var s_Stream in Streams)
            p_Writer.Write(s_Stream.Serialize());

        for (var i = Streams.Count; i < 4; ++i)
            new Stream().Serialize(p_Writer);

        p_Writer.Write((byte) Elements.Count);
        p_Writer.Write((byte) Streams.Count);
        p_Writer.Write((ushort)0); // Padding

        return true;
    }

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        p_Data = null;
        throw new System.NotImplementedException();
    }

    public void Deserialize(RimeReader p_Reader)
    {
        Elements.Clear();
        Streams.Clear();
            
        for (var i = 0; i < 16; ++i)
            Elements.Add(new Element(p_Reader));

        for (var i = 0; i < 4; ++i)
            Streams.Add(new Stream(p_Reader));

        var s_ElementCount = p_Reader.ReadUByte();
        var s_StreamCount = p_Reader.ReadUByte();
        p_Reader.ReadBytes(2); // padding
            
        Elements.RemoveRange(s_ElementCount, 16 - s_ElementCount);
        Streams.RemoveRange(s_StreamCount, 4 - s_StreamCount);
    }

    public void Deserialize(byte[] p_Data)
    {
        throw new System.NotImplementedException();
    }
}