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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class RandomEvaluatorData : 
		EvaluatorData
	{
		protected float m_Max = new float();
		[ContainerField(Name: "Max", Offset: 12, NameHash: 193446865, Flags: 49469), LayoutImmutable, Blittable]
		public float Max { get { return m_Max; } set { if (OnPropertyChanging("RandomEvaluatorData." + nameof(Max), this, m_Max, value)) m_Max = value; } } // 0xC (12)
		
		protected float m_Min = new float();
		[ContainerField(Name: "Min", Offset: 16, NameHash: 193446607, Flags: 49469), LayoutImmutable, Blittable]
		public float Min { get { return m_Min; } set { if (OnPropertyChanging("RandomEvaluatorData." + nameof(Min), this, m_Min, value)) m_Min = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193446865:
					Max = (float) p_Value;
					break;

				case 193446607:
					Min = (float) p_Value;
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
				case 193446865:
					return Max;

				case 193446607:
					return Min;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193446865:
					return typeof(RandomEvaluatorData).GetProperty(nameof(Max));

				case 193446607:
					return typeof(RandomEvaluatorData).GetProperty(nameof(Min));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
