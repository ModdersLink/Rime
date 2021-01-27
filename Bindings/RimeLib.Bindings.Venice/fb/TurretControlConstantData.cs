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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 28)]
	public class TurretControlConstantData : 
		Asset
	{
		protected float m_SearchLookSpeed = new float();
		[ContainerField(Name: "SearchLookSpeed", Offset: 12, NameHash: 1142077483, Flags: 49469), LayoutImmutable, Blittable]
		public float SearchLookSpeed { get { return m_SearchLookSpeed; } set { if (OnPropertyChanging("TurretControlConstantData." + nameof(SearchLookSpeed), this, m_SearchLookSpeed, value)) m_SearchLookSpeed = value; } } // 0xC (12)
		
		protected float m_SlowLookSpeed = new float();
		[ContainerField(Name: "SlowLookSpeed", Offset: 16, NameHash: 3507040034, Flags: 49469), LayoutImmutable, Blittable]
		public float SlowLookSpeed { get { return m_SlowLookSpeed; } set { if (OnPropertyChanging("TurretControlConstantData." + nameof(SlowLookSpeed), this, m_SlowLookSpeed, value)) m_SlowLookSpeed = value; } } // 0x10 (16)
		
		protected float m_NormalLookSpeed = new float();
		[ContainerField(Name: "NormalLookSpeed", Offset: 20, NameHash: 3237374486, Flags: 49469), LayoutImmutable, Blittable]
		public float NormalLookSpeed { get { return m_NormalLookSpeed; } set { if (OnPropertyChanging("TurretControlConstantData." + nameof(NormalLookSpeed), this, m_NormalLookSpeed, value)) m_NormalLookSpeed = value; } } // 0x14 (20)
		
		protected float m_FastLookSpeed = new float();
		[ContainerField(Name: "FastLookSpeed", Offset: 24, NameHash: 599104037, Flags: 49469), LayoutImmutable, Blittable]
		public float FastLookSpeed { get { return m_FastLookSpeed; } set { if (OnPropertyChanging("TurretControlConstantData." + nameof(FastLookSpeed), this, m_FastLookSpeed, value)) m_FastLookSpeed = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1142077483:
					SearchLookSpeed = (float) p_Value;
					break;

				case 3507040034:
					SlowLookSpeed = (float) p_Value;
					break;

				case 3237374486:
					NormalLookSpeed = (float) p_Value;
					break;

				case 599104037:
					FastLookSpeed = (float) p_Value;
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
				case 1142077483:
					return SearchLookSpeed;

				case 3507040034:
					return SlowLookSpeed;

				case 3237374486:
					return NormalLookSpeed;

				case 599104037:
					return FastLookSpeed;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1142077483:
					return typeof(TurretControlConstantData).GetProperty(nameof(SearchLookSpeed));

				case 3507040034:
					return typeof(TurretControlConstantData).GetProperty(nameof(SlowLookSpeed));

				case 3237374486:
					return typeof(TurretControlConstantData).GetProperty(nameof(NormalLookSpeed));

				case 599104037:
					return typeof(TurretControlConstantData).GetProperty(nameof(FastLookSpeed));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
