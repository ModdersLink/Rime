using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Diagnostics.CodeAnalysis;
using fb;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.Functions;

public class ShaderConstantFunctionData : IFbSerializable
{
    public class Constant : IFbSerializable
    {
        public ShaderConstantFunction Function { get; set; } = ShaderConstantFunction.ShaderConstantFunction_ViewMatrix;
        public byte Index { get; set; }
        public byte Parameter { get; set; }
        public byte ArraySize { get; set; }
        public byte VectorCount { get; set; }

        public Constant()
        {
        }

        public Constant(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write((uint) Function);
            p_Writer.Write(Index);
            p_Writer.Write(Parameter);
            p_Writer.Write(ArraySize);
            p_Writer.Write(VectorCount);

            return true;
        }

        public void Deserialize(RimeReader p_Reader)
        {
            Function = (ShaderConstantFunction)p_Reader.ReadUInt32();
            Index = p_Reader.ReadUByte();
            Parameter = p_Reader.ReadUByte();
            ArraySize = p_Reader.ReadUByte();
            VectorCount = p_Reader.ReadUByte();

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

    public uint RegisterCount { get; set; } // Not used
    public Constant[] Constants { get; set; } = Array.Empty<Constant>();

    /// <summary>
    /// Default constructor
    /// </summary>
    public ShaderConstantFunctionData()
    {

    }

    public ShaderConstantFunctionData(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write((short) Constants.Length);
        p_Writer.Write((short) RegisterCount);

        for (var i = 0; i < (short) Constants.Length; i++)
            Constants[i].Serialize(p_Writer);

        return true;
    }
                             
    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        p_Data = null;
        throw new System.NotImplementedException();
    }

    public void Deserialize(RimeReader p_Reader)
    {
        var s_ContantsCount = p_Reader.ReadUInt16();

        RegisterCount = p_Reader.ReadUInt16();

        Constants = new Constant[s_ContantsCount];

        for (var i = 0; i < s_ContantsCount; i++)
            Constants[i] = new Constant(p_Reader);
    }

    public void Deserialize(byte[] p_Data)
    {
        throw new System.NotImplementedException();
    }

}