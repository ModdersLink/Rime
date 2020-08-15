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
	[ContainerType(4)]
	public class SuppressionReactionData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float SuppressionHighThreshold { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float SuppressionLowThreshold { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable]
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
