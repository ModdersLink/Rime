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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 20)]
	public class EmitterTextureInfo : FrostbiteContainer
	{
		[ContainerField(Name: "TextureName", Offset: 0, NameHash: 3058697309, Flags: 16509), LayoutImmutable]
		public string TextureName { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "NormalmapName", Offset: 4, NameHash: 3269467725, Flags: 16509), LayoutImmutable]
		public string NormalmapName { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "AnimationFrameCount", Offset: 8, NameHash: 1220614861, Flags: 49469), LayoutImmutable, Blittable]
		public float AnimationFrameCount { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "AnimationFrameColumnCount", Offset: 12, NameHash: 3878152251, Flags: 49469), LayoutImmutable, Blittable]
		public float AnimationFrameColumnCount { get; set; } // 0xC (12)
		
		[ContainerField(Name: "EnableAnimation", Offset: 16, NameHash: 3666133042, Flags: 49325), LayoutImmutable, Blittable]
		public bool EnableAnimation { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3058697309:
					TextureName = (string) p_Value;
					break;

				case 3269467725:
					NormalmapName = (string) p_Value;
					break;

				case 1220614861:
					AnimationFrameCount = (float) p_Value;
					break;

				case 3878152251:
					AnimationFrameColumnCount = (float) p_Value;
					break;

				case 3666133042:
					EnableAnimation = (bool) p_Value;
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
				case 3058697309:
					return TextureName;

				case 3269467725:
					return NormalmapName;

				case 1220614861:
					return AnimationFrameCount;

				case 3878152251:
					return AnimationFrameColumnCount;

				case 3666133042:
					return EnableAnimation;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3058697309:
					return typeof(EmitterTextureInfo).GetProperty(nameof(TextureName));

				case 3269467725:
					return typeof(EmitterTextureInfo).GetProperty(nameof(NormalmapName));

				case 1220614861:
					return typeof(EmitterTextureInfo).GetProperty(nameof(AnimationFrameCount));

				case 3878152251:
					return typeof(EmitterTextureInfo).GetProperty(nameof(AnimationFrameColumnCount));

				case 3666133042:
					return typeof(EmitterTextureInfo).GetProperty(nameof(EnableAnimation));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
