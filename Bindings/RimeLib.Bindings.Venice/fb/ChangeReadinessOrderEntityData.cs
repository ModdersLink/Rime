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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(52), ContainerClass]
	public class ChangeReadinessOrderEntityData : 
		BFOrderEntityData
	{
		protected ReadinessLevel m_Pulse = new ReadinessLevel();
		[ContainerField(40), MemberInfoFlag(137), ContainerFieldNameHash(231633466)]
		public ReadinessLevel Pulse { get { return m_Pulse; } set { if (OnPropertyChanging("ChangeReadinessOrderEntityData." + nameof(Pulse), this, m_Pulse, value)) m_Pulse = value; } } // 0x28 (40)
		
		protected ReadinessLevel m_Minimum = new ReadinessLevel();
		[ContainerField(44), MemberInfoFlag(137), ContainerFieldNameHash(1011407507)]
		public ReadinessLevel Minimum { get { return m_Minimum; } set { if (OnPropertyChanging("ChangeReadinessOrderEntityData." + nameof(Minimum), this, m_Minimum, value)) m_Minimum = value; } } // 0x2C (44)
		
		protected bool m_AllowDecrease = new bool();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3792051486)]
		public bool AllowDecrease { get { return m_AllowDecrease; } set { if (OnPropertyChanging("ChangeReadinessOrderEntityData." + nameof(AllowDecrease), this, m_AllowDecrease, value)) m_AllowDecrease = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 231633466:
					Pulse = (ReadinessLevel) Enum.ToObject(typeof(ReadinessLevel), p_Value);
					break;

				case 1011407507:
					Minimum = (ReadinessLevel) Enum.ToObject(typeof(ReadinessLevel), p_Value);
					break;

				case 3792051486:
					AllowDecrease = (bool) p_Value;
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
				case 231633466:
					return Pulse;

				case 1011407507:
					return Minimum;

				case 3792051486:
					return AllowDecrease;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 231633466:
					return typeof(ChangeReadinessOrderEntityData).GetProperty(nameof(Pulse));

				case 1011407507:
					return typeof(ChangeReadinessOrderEntityData).GetProperty(nameof(Minimum));

				case 3792051486:
					return typeof(ChangeReadinessOrderEntityData).GetProperty(nameof(AllowDecrease));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
