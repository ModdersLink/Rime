///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class MovieTextureAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public GUID ChunkGuid { get; set; } // 0xC (12)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public uint ChunkSize { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public GUID SubtitleChunkGuid { get; set; } // 0x20 (32)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public uint SubtitleChunkSize { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public bool HasLocalizedAudioTracks { get; set; } // 0x34 (52)
		
		[ContainerField(53), LayoutImmutable, Blittable]
		public bool OverrideBackgroundMusic { get; set; } // 0x35 (53)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3693055745:
					ChunkGuid = (GUID) p_Value;
					break;

				case 3692630139:
					ChunkSize = (uint) p_Value;
					break;

				case 3946824677:
					SubtitleChunkGuid = (GUID) p_Value;
					break;

				case 3946120031:
					SubtitleChunkSize = (uint) p_Value;
					break;

				case 300816458:
					HasLocalizedAudioTracks = (bool) p_Value;
					break;

				case 2360371614:
					OverrideBackgroundMusic = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3693055745:
					return ChunkGuid;

				case 3692630139:
					return ChunkSize;

				case 3946824677:
					return SubtitleChunkGuid;

				case 3946120031:
					return SubtitleChunkSize;

				case 300816458:
					return HasLocalizedAudioTracks;

				case 2360371614:
					return OverrideBackgroundMusic;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3693055745:
					return typeof(MovieTextureAsset).GetProperty(nameof(ChunkGuid));

				case 3692630139:
					return typeof(MovieTextureAsset).GetProperty(nameof(ChunkSize));

				case 3946824677:
					return typeof(MovieTextureAsset).GetProperty(nameof(SubtitleChunkGuid));

				case 3946120031:
					return typeof(MovieTextureAsset).GetProperty(nameof(SubtitleChunkSize));

				case 300816458:
					return typeof(MovieTextureAsset).GetProperty(nameof(HasLocalizedAudioTracks));

				case 2360371614:
					return typeof(MovieTextureAsset).GetProperty(nameof(OverrideBackgroundMusic));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
