///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(56), ContainerClass]
	public class MovieTextureAsset : 
		Asset
	{
		protected GUID m_ChunkGuid = new GUID();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49501), ContainerFieldNameHash(3693055745)]
		public GUID ChunkGuid { get { return m_ChunkGuid; } set { if (OnPropertyChanging("MovieTextureAsset." + nameof(ChunkGuid), this, m_ChunkGuid, value)) m_ChunkGuid = value; } } // 0xC (12)
		
		protected uint m_ChunkSize = new uint();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3692630139)]
		public uint ChunkSize { get { return m_ChunkSize; } set { if (OnPropertyChanging("MovieTextureAsset." + nameof(ChunkSize), this, m_ChunkSize, value)) m_ChunkSize = value; } } // 0x1C (28)
		
		protected GUID m_SubtitleChunkGuid = new GUID();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49501), ContainerFieldNameHash(3946824677)]
		public GUID SubtitleChunkGuid { get { return m_SubtitleChunkGuid; } set { if (OnPropertyChanging("MovieTextureAsset." + nameof(SubtitleChunkGuid), this, m_SubtitleChunkGuid, value)) m_SubtitleChunkGuid = value; } } // 0x20 (32)
		
		protected uint m_SubtitleChunkSize = new uint();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3946120031)]
		public uint SubtitleChunkSize { get { return m_SubtitleChunkSize; } set { if (OnPropertyChanging("MovieTextureAsset." + nameof(SubtitleChunkSize), this, m_SubtitleChunkSize, value)) m_SubtitleChunkSize = value; } } // 0x30 (48)
		
		protected bool m_HasLocalizedAudioTracks = new bool();
		[ContainerField(52), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(300816458)]
		public bool HasLocalizedAudioTracks { get { return m_HasLocalizedAudioTracks; } set { if (OnPropertyChanging("MovieTextureAsset." + nameof(HasLocalizedAudioTracks), this, m_HasLocalizedAudioTracks, value)) m_HasLocalizedAudioTracks = value; } } // 0x34 (52)
		
		protected bool m_OverrideBackgroundMusic = new bool();
		[ContainerField(53), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2360371614)]
		public bool OverrideBackgroundMusic { get { return m_OverrideBackgroundMusic; } set { if (OnPropertyChanging("MovieTextureAsset." + nameof(OverrideBackgroundMusic), this, m_OverrideBackgroundMusic, value)) m_OverrideBackgroundMusic = value; } } // 0x35 (53)
		
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
