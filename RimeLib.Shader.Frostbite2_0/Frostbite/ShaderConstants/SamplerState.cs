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
        p_Writer.Write(Index);
        p_Writer.Write((int)Desc.Filter);
        p_Writer.Write((int)Desc.AddressU);
        p_Writer.Write((int)Desc.AddressV);
        p_Writer.Write((int)Desc.AddressW);
        p_Writer.Write(Desc.MipLodBias);
        p_Writer.Write(Desc.MaximumAnisotropy);
        p_Writer.Write((int)Desc.ComparisonFunction);
        p_Writer.Write(Desc.BorderColor.R);
        p_Writer.Write(Desc.BorderColor.G);
        p_Writer.Write(Desc.BorderColor.B);
        p_Writer.Write(Desc.BorderColor.A);
        p_Writer.Write(Desc.MinimumLod);
        p_Writer.Write(Desc.MaximumLod);
        p_Writer.Write(new byte[8]);
        return true;
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
        var s_Stream = new MemoryStream();
        using (var s_Writer = new RimeWriter(s_Stream))
            Serialize(s_Writer);

        p_Data = s_Stream.ToArray();
        return true;
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
        Deserialize(s_Reader);
    }
}
