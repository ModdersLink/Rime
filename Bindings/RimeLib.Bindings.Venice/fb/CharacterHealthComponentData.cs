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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class CharacterHealthComponentData : 
		ComponentData
	{
		protected float m_MaxHealth = new float();
		[ContainerField(Name: "MaxHealth", Offset: 96, NameHash: 1153188365, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxHealth { get { return m_MaxHealth; } set { if (OnPropertyChanging("CharacterHealthComponentData." + nameof(MaxHealth), this, m_MaxHealth, value)) m_MaxHealth = value; } } // 0x60 (96)
		
		protected float m_RegenerateHealthPerSecond = new float();
		[ContainerField(Name: "RegenerateHealthPerSecond", Offset: 100, NameHash: 3985253426, Flags: 49469), LayoutImmutable, Blittable]
		public float RegenerateHealthPerSecond { get { return m_RegenerateHealthPerSecond; } set { if (OnPropertyChanging("CharacterHealthComponentData." + nameof(RegenerateHealthPerSecond), this, m_RegenerateHealthPerSecond, value)) m_RegenerateHealthPerSecond = value; } } // 0x64 (100)
		
		protected bool m_RegenerateHealth = new bool();
		[ContainerField(Name: "RegenerateHealth", Offset: 104, NameHash: 736723333, Flags: 49325), LayoutImmutable, Blittable]
		public bool RegenerateHealth { get { return m_RegenerateHealth; } set { if (OnPropertyChanging("CharacterHealthComponentData." + nameof(RegenerateHealth), this, m_RegenerateHealth, value)) m_RegenerateHealth = value; } } // 0x68 (104)
		
		protected bool m_IsImmortal = new bool();
		[ContainerField(Name: "IsImmortal", Offset: 105, NameHash: 2713171602, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsImmortal { get { return m_IsImmortal; } set { if (OnPropertyChanging("CharacterHealthComponentData." + nameof(IsImmortal), this, m_IsImmortal, value)) m_IsImmortal = value; } } // 0x69 (105)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1153188365:
					MaxHealth = (float) p_Value;
					break;

				case 3985253426:
					RegenerateHealthPerSecond = (float) p_Value;
					break;

				case 736723333:
					RegenerateHealth = (bool) p_Value;
					break;

				case 2713171602:
					IsImmortal = (bool) p_Value;
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
				case 1153188365:
					return MaxHealth;

				case 3985253426:
					return RegenerateHealthPerSecond;

				case 736723333:
					return RegenerateHealth;

				case 2713171602:
					return IsImmortal;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1153188365:
					return typeof(CharacterHealthComponentData).GetProperty(nameof(MaxHealth));

				case 3985253426:
					return typeof(CharacterHealthComponentData).GetProperty(nameof(RegenerateHealthPerSecond));

				case 736723333:
					return typeof(CharacterHealthComponentData).GetProperty(nameof(RegenerateHealth));

				case 2713171602:
					return typeof(CharacterHealthComponentData).GetProperty(nameof(IsImmortal));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
