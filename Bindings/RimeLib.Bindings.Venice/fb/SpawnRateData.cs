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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(64), ContainerClass]
	public class SpawnRateData : 
		ProcessorData
	{
		protected float m_SpawnRate = new float();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2317161148)]
		public float SpawnRate { get { return m_SpawnRate; } set { if (OnPropertyChanging("SpawnRateData." + nameof(SpawnRate), this, m_SpawnRate, value)) m_SpawnRate = value; } } // 0x30 (48)
		
		protected float m_TrailSegmentLength = new float();
		[ContainerField(52), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3461940440)]
		public float TrailSegmentLength { get { return m_TrailSegmentLength; } set { if (OnPropertyChanging("SpawnRateData." + nameof(TrailSegmentLength), this, m_TrailSegmentLength, value)) m_TrailSegmentLength = value; } } // 0x34 (52)
		
		protected bool m_DistributeOverTime = new bool();
		[ContainerField(56), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2990510569)]
		public bool DistributeOverTime { get { return m_DistributeOverTime; } set { if (OnPropertyChanging("SpawnRateData." + nameof(DistributeOverTime), this, m_DistributeOverTime, value)) m_DistributeOverTime = value; } } // 0x38 (56)
		
		protected bool m_DistributeOverDistance = new bool();
		[ContainerField(57), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2314066943)]
		public bool DistributeOverDistance { get { return m_DistributeOverDistance; } set { if (OnPropertyChanging("SpawnRateData." + nameof(DistributeOverDistance), this, m_DistributeOverDistance, value)) m_DistributeOverDistance = value; } } // 0x39 (57)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2317161148:
					SpawnRate = (float) p_Value;
					break;

				case 3461940440:
					TrailSegmentLength = (float) p_Value;
					break;

				case 2990510569:
					DistributeOverTime = (bool) p_Value;
					break;

				case 2314066943:
					DistributeOverDistance = (bool) p_Value;
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
				case 2317161148:
					return SpawnRate;

				case 3461940440:
					return TrailSegmentLength;

				case 2990510569:
					return DistributeOverTime;

				case 2314066943:
					return DistributeOverDistance;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2317161148:
					return typeof(SpawnRateData).GetProperty(nameof(SpawnRate));

				case 3461940440:
					return typeof(SpawnRateData).GetProperty(nameof(TrailSegmentLength));

				case 2990510569:
					return typeof(SpawnRateData).GetProperty(nameof(DistributeOverTime));

				case 2314066943:
					return typeof(SpawnRateData).GetProperty(nameof(DistributeOverDistance));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
