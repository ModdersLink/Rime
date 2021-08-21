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
	public class MissileLockableInfoData : FrostbiteContainer
	{
		[ContainerField(Name: "HeatSignature", Offset: 0, NameHash: 2221510681, Flags: 49469), LayoutImmutable, Blittable]
		public float HeatSignature { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "RadarSignature", Offset: 4, NameHash: 1808737829, Flags: 49469), LayoutImmutable, Blittable]
		public float RadarSignature { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2221510681:
					HeatSignature = (float) p_Value;
					break;

				case 1808737829:
					RadarSignature = (float) p_Value;
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
				case 2221510681:
					return HeatSignature;

				case 1808737829:
					return RadarSignature;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2221510681:
					return typeof(MissileLockableInfoData).GetProperty(nameof(HeatSignature));

				case 1808737829:
					return typeof(MissileLockableInfoData).GetProperty(nameof(RadarSignature));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
