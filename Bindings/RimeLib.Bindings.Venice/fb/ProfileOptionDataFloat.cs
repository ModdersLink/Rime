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
	public class ProfileOptionDataFloat : 
		ProfileOptionData
	{
		protected float m_Min = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(193446607)]
		public float Min { get { return m_Min; } set { if (OnPropertyChanging("ProfileOptionDataFloat." + nameof(Min), this, m_Min, value)) m_Min = value; } } // 0x14 (20)
		
		protected float m_Max = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(193446865)]
		public float Max { get { return m_Max; } set { if (OnPropertyChanging("ProfileOptionDataFloat." + nameof(Max), this, m_Max, value)) m_Max = value; } } // 0x18 (24)
		
		protected float m_Value = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(225375086)]
		public float Value { get { return m_Value; } set { if (OnPropertyChanging("ProfileOptionDataFloat." + nameof(Value), this, m_Value, value)) m_Value = value; } } // 0x1C (28)
		
		protected float m_Step = new float();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2089400887)]
		public float Step { get { return m_Step; } set { if (OnPropertyChanging("ProfileOptionDataFloat." + nameof(Step), this, m_Step, value)) m_Step = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193446607:
					Min = (float) p_Value;
					break;

				case 193446865:
					Max = (float) p_Value;
					break;

				case 225375086:
					Value = (float) p_Value;
					break;

				case 2089400887:
					Step = (float) p_Value;
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
					return typeof(ProfileOptionDataFloat).GetProperty(nameof(Min));

				case 193446865:
					return typeof(ProfileOptionDataFloat).GetProperty(nameof(Max));

				case 225375086:
					return typeof(ProfileOptionDataFloat).GetProperty(nameof(Value));

				case 2089400887:
					return typeof(ProfileOptionDataFloat).GetProperty(nameof(Step));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
