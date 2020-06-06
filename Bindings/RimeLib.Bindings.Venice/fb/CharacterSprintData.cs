///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class CharacterSprintData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float SprintPowerDecreasePerSecond { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float SprintPowerIncreasePerSecond { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float SprintMinimumPower { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool AllowContinousSprinting { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4236817773:
					SprintPowerDecreasePerSecond = (float) p_Value;
					break;

				case 3679952971:
					SprintPowerIncreasePerSecond = (float) p_Value;
					break;

				case 2057558894:
					SprintMinimumPower = (float) p_Value;
					break;

				case 3446677350:
					AllowContinousSprinting = (bool) p_Value;
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
				case 4236817773:
					return SprintPowerDecreasePerSecond;

				case 3679952971:
					return SprintPowerIncreasePerSecond;

				case 2057558894:
					return SprintMinimumPower;

				case 3446677350:
					return AllowContinousSprinting;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4236817773:
					return typeof(CharacterSprintData).GetProperty(nameof(SprintPowerDecreasePerSecond));

				case 3679952971:
					return typeof(CharacterSprintData).GetProperty(nameof(SprintPowerIncreasePerSecond));

				case 2057558894:
					return typeof(CharacterSprintData).GetProperty(nameof(SprintMinimumPower));

				case 3446677350:
					return typeof(CharacterSprintData).GetProperty(nameof(AllowContinousSprinting));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
