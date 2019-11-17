using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.Solutions
{
    public class ShaderSolutionState : IFbSerializable
    {
        public uint m_ShaderNameHash = 0;
        public uint m_VertexShaderHash = 0;
        public uint m_GeometryDeclarationHash = 0;

        public byte m_Mode = 0; //fb::ShaderRenderMode
        public byte m_GeometrySpace = 0; //fb::ShaderGeometrySpace
        public byte m_SkinningMethod = 0; //fb::ShaderSkinningMethod
        public byte m_InstancingMethod = 0; //fb::ShaderInstancingMehod
        public byte m_ObjectLighting = 0; //fb::ShaderObjectLighting

        public byte m_ColorScale = 0;
        public byte m_Technique = 0;
        public byte m_BoolPermutation = 0;

        public byte m_Ps3ClipPlaneCount = 0;
        public byte m_HeightfieldTessalation = 0;

        //Theese members are part of fb::OutdoorLightSolutionState
        public bool m_Enable = false;
        public byte m_ShadowmapMethod = 0; //fb::ShaderShadowmapMethod
        public byte m_ShadowmapQuality = 0; //fb::ShaderShadowmapQuality
        public bool m_TransparencyShadowmapEnable = false;



        public ShaderSolutionState()
        {
        }

        public ShaderSolutionState(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new System.NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            m_ShaderNameHash = p_Reader.ReadUInt32();
            m_VertexShaderHash = p_Reader.ReadUInt32();
            m_GeometryDeclarationHash = p_Reader.ReadUInt32();

            m_Mode = p_Reader.ReadUByte(); //fb::ShaderRenderMode
            m_GeometrySpace = p_Reader.ReadUByte(); //fb::ShaderGeometrySpace
            m_SkinningMethod = p_Reader.ReadUByte(); //fb::ShaderSkinningMethod
            m_InstancingMethod = p_Reader.ReadUByte(); //fb::ShaderInstancingMehod
            m_ObjectLighting = p_Reader.ReadUByte(); //fb::ShaderObjectLighting

            m_ColorScale = p_Reader.ReadUByte();
            m_Technique = p_Reader.ReadUByte();
            m_BoolPermutation = p_Reader.ReadUByte();

            m_Ps3ClipPlaneCount = p_Reader.ReadUByte();
            m_HeightfieldTessalation = p_Reader.ReadUByte();

            //Theese members are part of fb::OutdoorLightSolutionState
            m_Enable = p_Reader.ReadBool();
            m_ShadowmapMethod = p_Reader.ReadUByte(); //fb::ShaderShadowmapMethod
            m_ShadowmapQuality = p_Reader.ReadUByte(); //fb::ShaderShadowmapQuality
            m_TransparencyShadowmapEnable = p_Reader.ReadBool();

            p_Reader.Seek(0x6, System.IO.SeekOrigin.Current);
        }

        public bool Serialize(out byte[] p_Data)
        {
            throw new System.NotImplementedException();
        }
        public void Deserialize(byte[] p_Data)
        {
            throw new System.NotImplementedException();
        }

    }
}
