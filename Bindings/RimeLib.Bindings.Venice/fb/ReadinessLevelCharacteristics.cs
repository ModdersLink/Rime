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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(12), ContainerStruct]
	public class ReadinessLevelCharacteristics : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MinReactionTime { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MaxReactionTime { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
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
