using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace RimeLib.Shader.Frostbite2_0.Frostbite
{
    public class SurfaceShaderInfo : IFbSerializable
    {

        public class StreamableTextureBase
        {
            public uint m_CoordType = 0; //fb::ShaderTextureCoordType
            public uint m_VertexUsage = 0; //fb::VertexElementUsage
            public float m_Factor = 0.0f;
        }
        public class StreamableTexture : StreamableTextureBase, IFbSerializable
        {
            //fb::ShaderStreamableTexture
            public string m_Name = string.Empty;
           //public short m_TextureHandle = -1;

            public StreamableTexture()
            {
            }

            public StreamableTexture(RimeReader p_Reader)
            {
                Deserialize(p_Reader);
            }

            public bool Serialize(RimeWriter p_Writer)
            {
                throw new System.NotImplementedException();
            }
            public void Deserialize(RimeReader p_Reader)
            {
                m_Name = p_Reader.ReadNullTerminatedString();

                m_CoordType = p_Reader.ReadUInt32(); //fb::ShaderTextureCoordType
                m_VertexUsage = p_Reader.ReadUInt32(); //fb::VertexElementUsage
                m_Factor = p_Reader.ReadSingle();
            }

            public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
            {
                p_Data = null;
                throw new System.NotImplementedException();
            }
            
            public void Deserialize(byte[] p_Data)
            {
                throw new System.NotImplementedException();
            }
        }

        public class StreamableExternalTexture : StreamableTextureBase, IFbSerializable
        {
            //fb::ShaderStreamableExternalTexture
            public string m_ParameterName = string.Empty;
            public uint m_ParameterId = 0;

            public StreamableExternalTexture()
            {
            }

            public StreamableExternalTexture(RimeReader p_Reader)
            {
                Deserialize(p_Reader);
            }

            public bool Serialize(RimeWriter p_Writer)
            {
                throw new System.NotImplementedException();
            }
            public void Deserialize(RimeReader p_Reader)
            {
                m_ParameterName = p_Reader.ReadNullTerminatedString();
                m_ParameterId = p_Reader.ReadUInt32();


                m_CoordType = p_Reader.ReadUInt32(); //fb::ShaderTextureCoordType
                m_VertexUsage = p_Reader.ReadUInt32(); //fb::VertexElementUsage
                m_Factor = p_Reader.ReadSingle();
            }

            public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
            {
                p_Data = null;
                throw new System.NotImplementedException();
            }
            
            public void Deserialize(byte[] p_Data)
            {
                throw new System.NotImplementedException();
            }
        }


        public uint m_SurfaceShaderType = 0;

        public byte m_Flags = 0; //fb::ShaderRenderMode
        public byte m_BoolParameterCount = 0; //fb::ShaderGeometrySpace
        public byte m_BoolParameterDefaultMask = 0; //fb::ShaderSkinningMethod
        public byte m_BoolParameterRequiredMask = 0; //fb::ShaderInstancingMehod

        public uint[] m_BoolParameterIds = new uint[8]; //fb::ShaderObjectLighting

        public StreamableTexture[] m_StreamableTextures = new StreamableTexture[0];

        public StreamableExternalTexture[] m_StreamableExternalTextures = new StreamableExternalTexture[0];


        public ushort[] m_SolutionIndicies = new ushort[0];


        public SurfaceShaderInfo()
        {
        }

        public SurfaceShaderInfo(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new System.NotImplementedException();
        }
        public void Deserialize(RimeReader p_Reader)
        {
            m_SurfaceShaderType = p_Reader.ReadUInt32();

            m_Flags = p_Reader.ReadUByte();
            m_BoolParameterCount = p_Reader.ReadUByte();
            m_BoolParameterDefaultMask = p_Reader.ReadUByte();
            m_BoolParameterRequiredMask = p_Reader.ReadUByte();


            for (var i = 0; i < 8; i++)
                m_BoolParameterIds[i] = p_Reader.ReadUInt32();


            var s_StreamableTexturesCount = p_Reader.ReadUInt32();
            m_StreamableTextures = new StreamableTexture[s_StreamableTexturesCount];
            for (var i = 0; i < s_StreamableTexturesCount; i++)
                m_StreamableTextures[i] = new StreamableTexture(p_Reader);


            var s_StreamableExternalTexturesCount = p_Reader.ReadUInt32();
            m_StreamableExternalTextures = new StreamableExternalTexture[s_StreamableExternalTexturesCount];
            for (var i = 0; i < s_StreamableExternalTexturesCount; i++)
                m_StreamableExternalTextures[i] = new StreamableExternalTexture(p_Reader);


            var s_SolutionCount = p_Reader.ReadUInt32();
            m_SolutionIndicies = new ushort[s_SolutionCount];
            for (var i = 0; i < s_SolutionCount; i++)
                m_SolutionIndicies[i] = p_Reader.ReadUInt16();
        }

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            p_Data = null;
            throw new System.NotImplementedException();
        }
        
        public void Deserialize(byte[] p_Data)
        {
            throw new System.NotImplementedException();
        }
    }
}
