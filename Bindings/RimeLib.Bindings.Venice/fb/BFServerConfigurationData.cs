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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(8), ContainerStruct]
	public class BFServerConfigurationData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint ScoreMultiplier { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, MemberInfoFlag(16509)]
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
