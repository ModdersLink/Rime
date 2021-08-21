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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 12)]
	public class SuppressionReactionData : FrostbiteContainer
	{
		[ContainerField(Name: "SuppressionHighThreshold", Offset: 0, NameHash: 3801721413, Flags: 49469), LayoutImmutable, Blittable]
		public float SuppressionHighThreshold { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "SuppressionLowThreshold", Offset: 4, NameHash: 1312712383, Flags: 49469), LayoutImmutable, Blittable]
		public float SuppressionLowThreshold { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "SuppressionUIThreshold", Offset: 8, NameHash: 1390635895, Flags: 49469), LayoutImmutable, Blittable]
		public float SuppressionUIThreshold { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3801721413:
					SuppressionHighThreshold = (float) p_Value;
					break;

				case 1312712383:
					SuppressionLowThreshold = (float) p_Value;
					break;

				case 1390635895:
					SuppressionUIThreshold = (float) p_Value;
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
				case 3801721413:
					return SuppressionHighThreshold;

				case 1312712383:
					return SuppressionLowThreshold;

				case 1390635895:
					return SuppressionUIThreshold;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3801721413:
					return typeof(SuppressionReactionData).GetProperty(nameof(SuppressionHighThreshold));

				case 1312712383:
					return typeof(SuppressionReactionData).GetProperty(nameof(SuppressionLowThreshold));

				case 1390635895:
					return typeof(SuppressionReactionData).GetProperty(nameof(SuppressionUIThreshold));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
