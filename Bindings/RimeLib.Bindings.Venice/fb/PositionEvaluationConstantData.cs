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
	public class PositionEvaluationConstantData : 
		Asset
	{
		protected float m_OwnRandomPositionsRadius = new float();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(40735674)]
		public float OwnRandomPositionsRadius { get { return m_OwnRandomPositionsRadius; } set { if (OnPropertyChanging("PositionEvaluationConstantData." + nameof(OwnRandomPositionsRadius), this, m_OwnRandomPositionsRadius, value)) m_OwnRandomPositionsRadius = value; } } // 0xC (12)
		
		protected float m_LeaderRandomPositionsRadius = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(1408843063)]
		public float LeaderRandomPositionsRadius { get { return m_LeaderRandomPositionsRadius; } set { if (OnPropertyChanging("PositionEvaluationConstantData." + nameof(LeaderRandomPositionsRadius), this, m_LeaderRandomPositionsRadius, value)) m_LeaderRandomPositionsRadius = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 40735674:
					OwnRandomPositionsRadius = (float) p_Value;
					break;

				case 1408843063:
					LeaderRandomPositionsRadius = (float) p_Value;
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
				case 40735674:
					return OwnRandomPositionsRadius;

				case 1408843063:
					return LeaderRandomPositionsRadius;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 40735674:
					return typeof(PositionEvaluationConstantData).GetProperty(nameof(OwnRandomPositionsRadius));

				case 1408843063:
					return typeof(PositionEvaluationConstantData).GetProperty(nameof(LeaderRandomPositionsRadius));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
