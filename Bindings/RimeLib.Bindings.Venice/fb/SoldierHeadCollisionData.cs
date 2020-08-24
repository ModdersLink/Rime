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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class SoldierHeadCollisionData : 
		DataContainer
	{
		protected float m_HeadRadius = new float();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2199912853)]
		public float HeadRadius { get { return m_HeadRadius; } set { if (OnPropertyChanging("SoldierHeadCollisionData." + nameof(HeadRadius), this, m_HeadRadius, value)) m_HeadRadius = value; } } // 0x8 (8)
		
		protected List<SoldierHeadCollisionPoseData> m_PoseStates = new List<SoldierHeadCollisionPoseData>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(294615368), ContainerArray]
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
