using RimeLib.IO;

namespace RimeLib.Shader.Frostbite2013_2.Frostbite;

/// <summary>A version 194 shader table entry: BF3's, with its textures named by hash.</summary>
public class SurfaceShaderInfo : Frostbite2_0.Frostbite.SurfaceShaderInfo
{
    protected override void DeserializeTextures(RimeReader p_Reader)
    {
        StreamableTextures = new StreamableTexture[p_Reader.ReadUInt32()];
        for (var i = 0; i < StreamableTextures.Length; i++)
            StreamableTextures[i] = StreamableTexture.ReadHashed(p_Reader);

        StreamableExternalTextures = new StreamableExternalTexture[p_Reader.ReadUInt32()];
        for (var i = 0; i < StreamableExternalTextures.Length; i++)
            StreamableExternalTextures[i] = StreamableExternalTexture.ReadHashed(p_Reader);
    }

    protected override void SerializeTextures(RimeWriter p_Writer)
    {
        p_Writer.Write((uint)StreamableTextures.Length);
        foreach (var s_Texture in StreamableTextures)
            s_Texture.WriteHashed(p_Writer);

        p_Writer.Write((uint)StreamableExternalTextures.Length);
        foreach (var s_Texture in StreamableExternalTextures)
            s_Texture.WriteHashed(p_Writer);
    }
}
