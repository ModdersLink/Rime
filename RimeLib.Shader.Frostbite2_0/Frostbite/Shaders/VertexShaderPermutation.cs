using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.Shaders
{
    public class VertexShaderPermutation : ShaderBase, IFbSerializable
    {
        public class Element : IFbSerializable
        {
            public uint m_SemanticIndex = 0;
            public uint m_DxgiFormat = 0; //DXGI_FORMAT
            public uint m_InputSlot = 0;
            public uint m_AlignedByteOffset = 0;
            public uint m_InputSlotClass = 0; //D3D11_INPUT_CLASSIFICATION
            public uint m_InstanceDataStepRate = 0;


            public Element()
            {

            }

            public Element(RimeReader p_Reader)
            {
                Deserialize(p_Reader);
            }

            public bool Serialize(RimeWriter p_Writer)
            {
                throw new NotImplementedException();
            }

            public void Deserialize(RimeReader p_Reader)
            {
                m_SemanticIndex = p_Reader.ReadUInt32();
                m_DxgiFormat = p_Reader.ReadUInt32(); //DXGI_FORMAT
                m_InputSlot = p_Reader.ReadUInt32();
                m_AlignedByteOffset = p_Reader.ReadUInt32();
                m_InputSlotClass = p_Reader.ReadUInt32(); //D3D11_INPUT_CLASSIFICATION
                m_InstanceDataStepRate = p_Reader.ReadUInt32();

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

        public uint m_ConstantsIndex = 0;
        public uint m_ConstantFunctionIndex = 0;
        public uint m_TextureFunctionIndex = 0;
        public List<Element> m_Elements = new List<Element>();
        public Element[] m_NamedElements = new Element[0];
        public string[] m_SemanticNames = new string[0];

        public VertexShaderPermutation()
        {
        }

        public VertexShaderPermutation(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new System.NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            m_Guid = new GUID(p_Reader);

            var s_DataSize = p_Reader.ReadUInt32();
            m_ShaderData = p_Reader.ReadBytes((int)s_DataSize);

            m_ConstantsIndex = p_Reader.ReadUInt32();
            m_ConstantFunctionIndex = p_Reader.ReadUInt32();
            m_TextureFunctionIndex = p_Reader.ReadUInt32();


            //THIS IS SUPPOSED TO BE ELEMENTs, BUT HAS GARBAGE DATA
            var s_ElementsSize = p_Reader.ReadUInt32();

            var s_ElementStartPosition = p_Reader.Position;
            using (var s_ElementsReader = new LimitedRimeReader(p_Reader, s_ElementsSize))
            {
                while (s_ElementsReader.Position < s_ElementsReader.Length)
                    m_Elements.Add(new Element(s_ElementsReader));
            }
            //Not sure how limitedrimereader works in this case
            p_Reader.Seek(s_ElementStartPosition + s_ElementsSize, System.IO.SeekOrigin.Begin);



            var s_NamedElementsCount = p_Reader.ReadUInt32();

            m_NamedElements = new Element[s_NamedElementsCount];
            for ( var i=0; i < s_NamedElementsCount; i++)
                m_NamedElements[i] = new Element(p_Reader);

            var s_StringVectorCount = p_Reader.ReadUInt32();
            
            m_SemanticNames = new string[s_StringVectorCount];
            for (var i = 0; i < s_StringVectorCount; i++)
                m_SemanticNames[i] = p_Reader.ReadNullTerminatedString();

            m_Metrics = p_Reader.ReadUInt32();
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
