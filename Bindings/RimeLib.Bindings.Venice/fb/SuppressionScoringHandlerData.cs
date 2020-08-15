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
	public class SuppressionScoringHandlerData : 
		ScoringHandlerData
	{
		protected float m_SuppressionAmountLimit = new float();
		[ContainerField(8), LayoutImmutable, Blittable, ContainerFieldNameHash(3089705413)]
		public float SuppressionAmountLimit { get { return m_SuppressionAmountLimit; } set { if (OnPropertyChanging("SuppressionScoringHandlerData." + nameof(SuppressionAmountLimit), this, m_SuppressionAmountLimit, value)) m_SuppressionAmountLimit = value; } } // 0x8 (8)
		
		protected float m_TimeSinceSuppressionLimit = new float();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(804971118)]
		public float TimeSinceSuppressionLimit { get { return m_TimeSinceSuppressionLimit; } set { if (OnPropertyChanging("SuppressionScoringHandlerData." + nameof(TimeSinceSuppressionLimit), this, m_TimeSinceSuppressionLimit, value)) m_TimeSinceSuppressionLimit = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3089705413:
					SuppressionAmountLimit = (float) p_Value;
					break;

				case 804971118:
					TimeSinceSuppressionLimit = (float) p_Value;
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
				case 3089705413:
					return SuppressionAmountLimit;

				case 804971118:
					return TimeSinceSuppressionLimit;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3089705413:
					return typeof(SuppressionScoringHandlerData).GetProperty(nameof(SuppressionAmountLimit));

				case 804971118:
					return typeof(SuppressionScoringHandlerData).GetProperty(nameof(TimeSinceSuppressionLimit));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
