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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class SoldierHeadCollisionData : 
		DataContainer
	{
		protected float m_HeadRadius = new float();
		[ContainerField(Name: "HeadRadius", Offset: 8, NameHash: 2199912853, Flags: 49469), LayoutImmutable, Blittable]
		public float HeadRadius { get { return m_HeadRadius; } set { if (OnPropertyChanging("SoldierHeadCollisionData." + nameof(HeadRadius), this, m_HeadRadius, value)) m_HeadRadius = value; } } // 0x8 (8)
		
		protected List<SoldierHeadCollisionPoseData> m_PoseStates = new List<SoldierHeadCollisionPoseData>();
		[ContainerField(Name: "PoseStates", Offset: 12, NameHash: 294615368, Flags: 65)]
		public List<SoldierHeadCollisionPoseData> PoseStates { get { return m_PoseStates; } set { if (OnPropertyChanging("SoldierHeadCollisionData." + nameof(PoseStates), this, m_PoseStates, value)) m_PoseStates = value; } } // 0xC (12)
		
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
