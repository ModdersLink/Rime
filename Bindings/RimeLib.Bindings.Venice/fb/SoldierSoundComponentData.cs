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
	public class SoldierSoundComponentData : 
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float WalkVelocityThreshold { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float RunVelocityThreshold { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float WalkPeriod { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float RunPeriod { get; set; } // 0x6C (108)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2022862740:
					WalkVelocityThreshold = (float) p_Value;
					break;

				case 37427148:
					RunVelocityThreshold = (float) p_Value;
					break;

				case 2834426449:
					WalkPeriod = (float) p_Value;
					break;

				case 877844489:
					RunPeriod = (float) p_Value;
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
				case 2022862740:
					return WalkVelocityThreshold;

				case 37427148:
					return RunVelocityThreshold;

				case 2834426449:
					return WalkPeriod;

				case 877844489:
					return RunPeriod;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2022862740:
					return typeof(SoldierSoundComponentData).GetProperty(nameof(WalkVelocityThreshold));

				case 37427148:
					return typeof(SoldierSoundComponentData).GetProperty(nameof(RunVelocityThreshold));

				case 2834426449:
					return typeof(SoldierSoundComponentData).GetProperty(nameof(WalkPeriod));

				case 877844489:
					return typeof(SoldierSoundComponentData).GetProperty(nameof(RunPeriod));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
