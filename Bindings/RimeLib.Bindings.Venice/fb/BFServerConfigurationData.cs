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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 8)]
	public class BFServerConfigurationData : FrostbiteContainer
	{
		[ContainerField(Name: "ScoreMultiplier", Offset: 0, NameHash: 81894022, Flags: 49421), LayoutImmutable, Blittable]
		public uint ScoreMultiplier { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "Licenses", Offset: 4, NameHash: 2259172461, Flags: 16509), LayoutImmutable]
		public string Licenses { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 81894022:
					ScoreMultiplier = (uint) p_Value;
					break;

				case 2259172461:
					Licenses = (string) p_Value;
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
				case 81894022:
					return ScoreMultiplier;

				case 2259172461:
					return Licenses;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 81894022:
					return typeof(BFServerConfigurationData).GetProperty(nameof(ScoreMultiplier));

				case 2259172461:
					return typeof(BFServerConfigurationData).GetProperty(nameof(Licenses));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
