using RimeLib.IO;
using BaseInfo = RimeLib.Shader.Frostbite2_0.Frostbite.SurfaceShaderInfo;

namespace RimeLib.Shader.Frostbite2013_2.Frostbite;

/// <summary>A version 194 shader table entry: BF3's, with its streamed textures named by hash.</summary>
public class SurfaceShaderInfo : BaseInfo
{
    /// <summary>A texture the shader streams, by the lowercase hash of its name.</summary>
    public class HashedStreamableTexture : StreamableTexture
    {
        public uint NameHash { get; set; }

        public override void Deserialize(RimeReader p_Reader)
        {
            NameHash = p_Reader.ReadUInt32();
            ReadMapping(p_Reader);
        }

        public override bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(NameHash);
            WriteMapping(p_Writer);
            return true;
        }
    }

    /// <summary>A texture the shader streams through a parameter, by the hash of the parameter's name and its id.</summary>
    public class HashedStreamableExternalTexture : StreamableExternalTexture
    {
        public uint ParameterNameHash { get; set; }

        public override void Deserialize(RimeReader p_Reader)
        {
            ParameterNameHash = p_Reader.ReadUInt32();
            ParameterId = p_Reader.ReadUInt32();
            ReadMapping(p_Reader);
        }

        public override bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(ParameterNameHash);
            p_Writer.Write(ParameterId);
            WriteMapping(p_Writer);
            return true;
        }
    }

    protected override StreamableTexture CreateStreamableTexture() => new HashedStreamableTexture();
    protected override StreamableExternalTexture CreateStreamableExternalTexture() => new HashedStreamableExternalTexture();
}
