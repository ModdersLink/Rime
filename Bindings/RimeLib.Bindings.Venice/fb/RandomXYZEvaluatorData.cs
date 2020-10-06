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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(36), ContainerClass]
	public class RandomXYZEvaluatorData : 
		EvaluatorData
	{
		protected float m_MaxX = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2088779177)]
		public float MaxX { get { return m_MaxX; } set { if (OnPropertyChanging("RandomXYZEvaluatorData." + nameof(MaxX), this, m_MaxX, value)) m_MaxX = value; } } // 0xC (12)
		
		protected float m_MinX = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2088770807)]
		public float MinX { get { return m_MinX; } set { if (OnPropertyChanging("RandomXYZEvaluatorData." + nameof(MinX), this, m_MinX, value)) m_MinX = value; } } // 0x10 (16)
		
		protected float m_MaxY = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2088779176)]
		public float MaxY { get { return m_MaxY; } set { if (OnPropertyChanging("RandomXYZEvaluatorData." + nameof(MaxY), this, m_MaxY, value)) m_MaxY = value; } } // 0x14 (20)
		
		protected float m_MinY = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2088770806)]
		public float MinY { get { return m_MinY; } set { if (OnPropertyChanging("RandomXYZEvaluatorData." + nameof(MinY), this, m_MinY, value)) m_MinY = value; } } // 0x18 (24)
		
		protected float m_MaxZ = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2088779179)]
		public float MaxZ { get { return m_MaxZ; } set { if (OnPropertyChanging("RandomXYZEvaluatorData." + nameof(MaxZ), this, m_MaxZ, value)) m_MaxZ = value; } } // 0x1C (28)
		
		protected float m_MinZ = new float();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2088770805)]
		public float MinZ { get { return m_MinZ; } set { if (OnPropertyChanging("RandomXYZEvaluatorData." + nameof(MinZ), this, m_MinZ, value)) m_MinZ = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088779177:
					MaxX = (float) p_Value;
					break;

				case 2088770807:
					MinX = (float) p_Value;
					break;

				case 2088779176:
					MaxY = (float) p_Value;
					break;

				case 2088770806:
					MinY = (float) p_Value;
					break;

				case 2088779179:
					MaxZ = (float) p_Value;
					break;

				case 2088770805:
					MinZ = (float) p_Value;
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
				case 2088779177:
					return MaxX;

				case 2088770807:
					return MinX;

				case 2088779176:
					return MaxY;

				case 2088770806:
					return MinY;

				case 2088779179:
					return MaxZ;

				case 2088770805:
					return MinZ;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088779177:
					return typeof(RandomXYZEvaluatorData).GetProperty(nameof(MaxX));

				case 2088770807:
					return typeof(RandomXYZEvaluatorData).GetProperty(nameof(MinX));

				case 2088779176:
					return typeof(RandomXYZEvaluatorData).GetProperty(nameof(MaxY));

				case 2088770806:
					return typeof(RandomXYZEvaluatorData).GetProperty(nameof(MinY));

				case 2088779179:
					return typeof(RandomXYZEvaluatorData).GetProperty(nameof(MaxZ));

				case 2088770805:
					return typeof(RandomXYZEvaluatorData).GetProperty(nameof(MinZ));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
