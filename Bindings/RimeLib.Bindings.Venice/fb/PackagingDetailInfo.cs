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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 12)]
	public class PackagingDetailInfo : FrostbiteContainer
	{
		[ContainerField(Name: "MipsToSkip", Offset: 0, NameHash: 3915133016, Flags: 49405), LayoutImmutable, Blittable]
		public int MipsToSkip { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "LodsToSkip", Offset: 4, NameHash: 1143487915, Flags: 49405), LayoutImmutable, Blittable]
		public int LodsToSkip { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "IncludeAnimation", Offset: 8, NameHash: 2443212815, Flags: 49325), LayoutImmutable, Blittable]
		public bool IncludeAnimation { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "IncludeMeshes", Offset: 9, NameHash: 879627068, Flags: 49325), LayoutImmutable, Blittable]
		public bool IncludeMeshes { get; set; } // 0x9 (9)
		
		[ContainerField(Name: "IncludeSounds", Offset: 10, NameHash: 330444105, Flags: 49325), LayoutImmutable, Blittable]
		public bool IncludeSounds { get; set; } // 0xA (10)
		
		[ContainerField(Name: "IncludeTextures", Offset: 11, NameHash: 3274933973, Flags: 49325), LayoutImmutable, Blittable]
		public bool IncludeTextures { get; set; } // 0xB (11)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3915133016:
					MipsToSkip = (int) p_Value;
					break;

				case 1143487915:
					LodsToSkip = (int) p_Value;
					break;

				case 2443212815:
					IncludeAnimation = (bool) p_Value;
					break;

				case 879627068:
					IncludeMeshes = (bool) p_Value;
					break;

				case 330444105:
					IncludeSounds = (bool) p_Value;
					break;

				case 3274933973:
					IncludeTextures = (bool) p_Value;
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
				case 3915133016:
					return MipsToSkip;

				case 1143487915:
					return LodsToSkip;

				case 2443212815:
					return IncludeAnimation;

				case 879627068:
					return IncludeMeshes;

				case 330444105:
					return IncludeSounds;

				case 3274933973:
					return IncludeTextures;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3915133016:
					return typeof(PackagingDetailInfo).GetProperty(nameof(MipsToSkip));

				case 1143487915:
					return typeof(PackagingDetailInfo).GetProperty(nameof(LodsToSkip));

				case 2443212815:
					return typeof(PackagingDetailInfo).GetProperty(nameof(IncludeAnimation));

				case 879627068:
					return typeof(PackagingDetailInfo).GetProperty(nameof(IncludeMeshes));

				case 330444105:
					return typeof(PackagingDetailInfo).GetProperty(nameof(IncludeSounds));

				case 3274933973:
					return typeof(PackagingDetailInfo).GetProperty(nameof(IncludeTextures));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
