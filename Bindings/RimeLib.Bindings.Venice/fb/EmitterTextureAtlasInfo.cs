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
	public class EmitterTextureAtlasInfo : FrostbiteContainer
	{
		[ContainerField(Name: "MinUv", Offset: 0, NameHash: 209960012, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 MinUv { get; set; } = new Vec2(); // 0x0 (0)
		
		[ContainerField(Name: "MaxUv", Offset: 8, NameHash: 210235986, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 MaxUv { get; set; } = new Vec2(); // 0x8 (8)
		
		[ContainerField(Name: "TextureName", Offset: 16, NameHash: 3058697309, Flags: 16509), LayoutImmutable]
		public string TextureName { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 209960012:
					MinUv = (Vec2) p_Value;
					break;

				case 210235986:
					MaxUv = (Vec2) p_Value;
					break;

				case 3058697309:
					TextureName = (string) p_Value;
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
				case 209960012:
					return MinUv;

				case 210235986:
					return MaxUv;

				case 3058697309:
					return TextureName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 209960012:
					return typeof(EmitterTextureAtlasInfo).GetProperty(nameof(MinUv));

				case 210235986:
					return typeof(EmitterTextureAtlasInfo).GetProperty(nameof(MaxUv));

				case 3058697309:
					return typeof(EmitterTextureAtlasInfo).GetProperty(nameof(TextureName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
