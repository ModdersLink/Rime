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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 36)]
	public class ProfileOptionDataInt : 
		ProfileOptionData
	{
		protected int m_Min = new int();
		[ContainerField(Name: "Min", Offset: 20, NameHash: 193446607, Flags: 49405), LayoutImmutable, Blittable]
		public int Min { get { return m_Min; } set { if (OnPropertyChanging("ProfileOptionDataInt." + nameof(Min), this, m_Min, value)) m_Min = value; } } // 0x14 (20)
		
		protected int m_Max = new int();
		[ContainerField(Name: "Max", Offset: 24, NameHash: 193446865, Flags: 49405), LayoutImmutable, Blittable]
		public int Max { get { return m_Max; } set { if (OnPropertyChanging("ProfileOptionDataInt." + nameof(Max), this, m_Max, value)) m_Max = value; } } // 0x18 (24)
		
		protected int m_Value = new int();
		[ContainerField(Name: "Value", Offset: 28, NameHash: 225375086, Flags: 49405), LayoutImmutable, Blittable]
		public int Value { get { return m_Value; } set { if (OnPropertyChanging("ProfileOptionDataInt." + nameof(Value), this, m_Value, value)) m_Value = value; } } // 0x1C (28)
		
		protected int m_Step = new int();
		[ContainerField(Name: "Step", Offset: 32, NameHash: 2089400887, Flags: 49405), LayoutImmutable, Blittable]
		public int Step { get { return m_Step; } set { if (OnPropertyChanging("ProfileOptionDataInt." + nameof(Step), this, m_Step, value)) m_Step = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193446607:
					Min = (int) p_Value;
					break;

				case 193446865:
					Max = (int) p_Value;
					break;

				case 225375086:
					Value = (int) p_Value;
					break;

				case 2089400887:
					Step = (int) p_Value;
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
				case 193446607:
					return Min;

				case 193446865:
					return Max;

				case 225375086:
					return Value;

				case 2089400887:
					return Step;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193446607:
					return typeof(ProfileOptionDataInt).GetProperty(nameof(Min));

				case 193446865:
					return typeof(ProfileOptionDataInt).GetProperty(nameof(Max));

				case 225375086:
					return typeof(ProfileOptionDataInt).GetProperty(nameof(Value));

				case 2089400887:
					return typeof(ProfileOptionDataInt).GetProperty(nameof(Step));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
