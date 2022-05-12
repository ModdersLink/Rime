using RimeLib.Frostbite;
using RimeLib.IO;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using SharpDX.Direct3D11;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.ShaderConstants;

public class SamplerState : IFbSerializable
{
    public uint Index { get; set; }
    public SamplerStateDescription Desc { get; set; } = SamplerStateDescription.Default();


    public SamplerState()
    {

    }

    public SamplerState(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        throw new System.NotImplementedException();
    }

        

    public void Deserialize(RimeReader p_Reader)
    {
        Index = p_Reader.ReadUInt32();

        var s_Desc = SamplerStateDescription.Default();
        s_Desc.Filter = (Filter)p_Reader.ReadInt32();
        s_Desc.AddressU = (TextureAddressMode)p_Reader.ReadInt32();
        s_Desc.AddressV = (TextureAddressMode)p_Reader.ReadInt32();
        s_Desc.AddressW = (TextureAddressMode)p_Reader.ReadInt32();
        s_Desc.MipLodBias = p_Reader.ReadSingle();
        s_Desc.MaximumAnisotropy = p_Reader.ReadInt32();
        s_Desc.ComparisonFunction = (Comparison)p_Reader.ReadInt32();
        s_Desc.BorderColor.R = p_Reader.ReadSingle();
        s_Desc.BorderColor.G = p_Reader.ReadSingle();
        s_Desc.BorderColor.B = p_Reader.ReadSingle();
        s_Desc.BorderColor.A = p_Reader.ReadSingle();
        s_Desc.MinimumLod = p_Reader.ReadSingle();
        s_Desc.MaximumLod = p_Reader.ReadSingle();

        Desc = s_Desc;
            
        //Padding
        p_Reader.Seek(0x8, SeekOrigin.Current); 
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