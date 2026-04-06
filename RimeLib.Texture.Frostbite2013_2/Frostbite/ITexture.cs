using RimeLib.Frostbite.Core;

namespace RimeLib.Texture.Frostbite2013_2.Frostbite;

public interface ITexture
{
	public TextureType Type { get;  }
	public TextureFormat Format { get; }
	public TextureFlags Flags { get;  }
	public short Width { get;  }
	public short Height { get; }
	public short Depth { get; }
	public short SliceCount { get; }
	public byte MipmapCount { get; }
	public byte MipmapBaseIndex { get; }
	public GUID StreamingChunkId { get; }
	public uint[] MipmapSizes { get; }
	public uint MipmapChainSize { get; }
	public uint ResourceNameHash { get; }
	public string TextureGroup { get; }
}