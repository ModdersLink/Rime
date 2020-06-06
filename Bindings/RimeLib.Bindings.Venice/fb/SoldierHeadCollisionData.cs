///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class SoldierHeadCollisionData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float HeadRadius { get; set; } // 0x8 (8)
		
		[ContainerField(12)]
		public List<SoldierHeadCollisionPoseData> PoseStates { get; set; } = new List<SoldierHeadCollisionPoseData>(); // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2199912853:
					HeadRadius = (float) p_Value;
					break;

				case 294615368:
					PoseStates = (List<SoldierHeadCollisionPoseData>) p_Value;
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
				case 2199912853:
					return HeadRadius;

				case 294615368:
					return PoseStates;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2199912853:
					return typeof(SoldierHeadCollisionData).GetProperty(nameof(HeadRadius));

				case 294615368:
					return typeof(SoldierHeadCollisionData).GetProperty(nameof(PoseStates));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
