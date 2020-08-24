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
	[ContainerType(4), MemberInfoFlag(41), ContainerStruct]
	public class PackagingDetailInfo : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int MipsToSkip { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int LodsToSkip { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool IncludeAnimation { get; set; } // 0x8 (8)
		
		[ContainerField(9), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool IncludeMeshes { get; set; } // 0x9 (9)
		
		[ContainerField(10), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool IncludeSounds { get; set; } // 0xA (10)
		
		[ContainerField(11), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
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
