///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class CharacterHealthComponentData : 
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float MaxHealth { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float RegenerateHealthPerSecond { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public bool RegenerateHealth { get; set; } // 0x68 (104)
		
		[ContainerField(105), LayoutImmutable, Blittable]
		public bool IsImmortal { get; set; } // 0x69 (105)
		
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
