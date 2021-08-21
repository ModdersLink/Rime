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
	public class ReadinessLevelCharacteristics : FrostbiteContainer
	{
		[ContainerField(Name: "MinReactionTime", Offset: 0, NameHash: 3956001331, Flags: 49469), LayoutImmutable, Blittable]
		public float MinReactionTime { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "MaxReactionTime", Offset: 4, NameHash: 352354861, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxReactionTime { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "ReductionTime", Offset: 8, NameHash: 2486342921, Flags: 49469), LayoutImmutable, Blittable]
		public float ReductionTime { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3956001331:
					MinReactionTime = (float) p_Value;
					break;

				case 352354861:
					MaxReactionTime = (float) p_Value;
					break;

				case 2486342921:
					ReductionTime = (float) p_Value;
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
				case 3956001331:
					return MinReactionTime;

				case 352354861:
					return MaxReactionTime;

				case 2486342921:
					return ReductionTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3956001331:
					return typeof(ReadinessLevelCharacteristics).GetProperty(nameof(MinReactionTime));

				case 352354861:
					return typeof(ReadinessLevelCharacteristics).GetProperty(nameof(MaxReactionTime));

				case 2486342921:
					return typeof(ReadinessLevelCharacteristics).GetProperty(nameof(ReductionTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
