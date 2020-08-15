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
	[ContainerType(8)]
	public class ScoreAggregate : 
		MetricAggregate
	{
		protected float m_TotalScore = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(4045234607)]
		public float TotalScore { get { return m_TotalScore; } set { if (OnPropertyChanging("ScoreAggregate." + nameof(TotalScore), this, m_TotalScore, value)) m_TotalScore = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4045234607:
					TotalScore = (float) p_Value;
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
				case 4045234607:
					return TotalScore;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4045234607:
					return typeof(ScoreAggregate).GetProperty(nameof(TotalScore));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
