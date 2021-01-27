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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class SearchAndDestroyConstantData : 
		Asset
	{
		protected float m_TimeToWaitMin = new float();
		[ContainerField(Name: "TimeToWaitMin", Offset: 12, NameHash: 3374725610, Flags: 49469), LayoutImmutable, Blittable]
		public float TimeToWaitMin { get { return m_TimeToWaitMin; } set { if (OnPropertyChanging("SearchAndDestroyConstantData." + nameof(TimeToWaitMin), this, m_TimeToWaitMin, value)) m_TimeToWaitMin = value; } } // 0xC (12)
		
		protected float m_TimeToWaitMax = new float();
		[ContainerField(Name: "TimeToWaitMax", Offset: 16, NameHash: 3374725876, Flags: 49469), LayoutImmutable, Blittable]
		public float TimeToWaitMax { get { return m_TimeToWaitMax; } set { if (OnPropertyChanging("SearchAndDestroyConstantData." + nameof(TimeToWaitMax), this, m_TimeToWaitMax, value)) m_TimeToWaitMax = value; } } // 0x10 (16)
		
		protected float m_DefaultSearchAndDestroyRadius = new float();
		[ContainerField(Name: "DefaultSearchAndDestroyRadius", Offset: 20, NameHash: 222001681, Flags: 49469), LayoutImmutable, Blittable]
		public float DefaultSearchAndDestroyRadius { get { return m_DefaultSearchAndDestroyRadius; } set { if (OnPropertyChanging("SearchAndDestroyConstantData." + nameof(DefaultSearchAndDestroyRadius), this, m_DefaultSearchAndDestroyRadius, value)) m_DefaultSearchAndDestroyRadius = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3374725610:
					TimeToWaitMin = (float) p_Value;
					break;

				case 3374725876:
					TimeToWaitMax = (float) p_Value;
					break;

				case 222001681:
					DefaultSearchAndDestroyRadius = (float) p_Value;
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
				case 3374725610:
					return TimeToWaitMin;

				case 3374725876:
					return TimeToWaitMax;

				case 222001681:
					return DefaultSearchAndDestroyRadius;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3374725610:
					return typeof(SearchAndDestroyConstantData).GetProperty(nameof(TimeToWaitMin));

				case 3374725876:
					return typeof(SearchAndDestroyConstantData).GetProperty(nameof(TimeToWaitMax));

				case 222001681:
					return typeof(SearchAndDestroyConstantData).GetProperty(nameof(DefaultSearchAndDestroyRadius));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
