using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.Solutions
{
    public class ShaderSolution : IFbSerializable
    {
        public ulong m_StateHash = 0;
        public ShaderSolutionState? m_State = null;

        public byte m_Flags = 0; // 1 = DoubleSided, 2 = GammaCorrection

        public byte m_SurfaceType = 0; //fb::SurfaceShaderType
        public byte m_BlendMode = 0;  //fb::ShaderBlendMode

        public long m_VertexShaderIndex = -1;
        public long m_PixelShaderIndex = -1;
        public long m_GeometryShaderIndex = -1;

        public long m_VertexConstantsIndex = -1;
        public long m_PixelConstantsIndex = -1;

        public ShaderSolution()
        {
        }

        public ShaderSolution(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new System.NotImplementedException();
        }
      
        public void Deserialize(RimeReader p_Reader)
        {
            m_StateHash = p_Reader.ReadUInt64( );

            m_Flags = p_Reader.ReadUByte(); // 1 = DoubleSided, 2 = GammaCorrection

            m_SurfaceType = p_Reader.ReadUByte(); //fb::SurfaceShaderType
            m_BlendMode = p_Reader.ReadUByte();  //fb::ShaderBlendMode

            p_Reader.Seek(0xD, System.IO.SeekOrigin.Current);

            m_VertexShaderIndex = p_Reader.ReadInt64();
            m_PixelShaderIndex = p_Reader.ReadInt64();
            m_GeometryShaderIndex = p_Reader.ReadInt64();

            m_VertexConstantsIndex = p_Reader.ReadInt64();
            m_PixelConstantsIndex = p_Reader.ReadInt64();
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
