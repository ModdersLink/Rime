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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(112), ContainerClass]
	public class DeathAreaTriggerEntityData : 
		GameEntityData
	{
		protected float m_Damage = new float();
		[ContainerField(96), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2589892334)]
		public float Damage { get { return m_Damage; } set { if (OnPropertyChanging("DeathAreaTriggerEntityData." + nameof(Damage), this, m_Damage, value)) m_Damage = value; } } // 0x60 (96)
		
		protected float m_TimeToReturn = new float();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2769825281)]
		public float TimeToReturn { get { return m_TimeToReturn; } set { if (OnPropertyChanging("DeathAreaTriggerEntityData." + nameof(TimeToReturn), this, m_TimeToReturn, value)) m_TimeToReturn = value; } } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2589892334:
					Damage = (float) p_Value;
					break;

				case 2769825281:
					TimeToReturn = (float) p_Value;
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
				case 2589892334:
					return Damage;

				case 2769825281:
					return TimeToReturn;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2589892334:
					return typeof(DeathAreaTriggerEntityData).GetProperty(nameof(Damage));

				case 2769825281:
					return typeof(DeathAreaTriggerEntityData).GetProperty(nameof(TimeToReturn));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
