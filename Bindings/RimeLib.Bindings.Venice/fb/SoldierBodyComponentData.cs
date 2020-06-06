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
	public class SoldierBodyComponentData : 
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float SprintMultiplier { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float OverrideGravityValue { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float OverrideVelocityY { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public bool OverrideVelocity { get; set; } // 0x6C (108)
		
		[ContainerField(109), LayoutImmutable, Blittable]
		public bool OverrideGravity { get; set; } // 0x6D (109)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4088490892:
					SprintMultiplier = (float) p_Value;
					break;

				case 1923054204:
					OverrideGravityValue = (float) p_Value;
					break;

				case 3664501567:
					OverrideVelocityY = (float) p_Value;
					break;

				case 3104507558:
					OverrideVelocity = (bool) p_Value;
					break;

				case 2610853335:
					OverrideGravity = (bool) p_Value;
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
				case 4088490892:
					return SprintMultiplier;

				case 1923054204:
					return OverrideGravityValue;

				case 3664501567:
					return OverrideVelocityY;

				case 3104507558:
					return OverrideVelocity;

				case 2610853335:
					return OverrideGravity;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4088490892:
					return typeof(SoldierBodyComponentData).GetProperty(nameof(SprintMultiplier));

				case 1923054204:
					return typeof(SoldierBodyComponentData).GetProperty(nameof(OverrideGravityValue));

				case 3664501567:
					return typeof(SoldierBodyComponentData).GetProperty(nameof(OverrideVelocityY));

				case 3104507558:
					return typeof(SoldierBodyComponentData).GetProperty(nameof(OverrideVelocity));

				case 2610853335:
					return typeof(SoldierBodyComponentData).GetProperty(nameof(OverrideGravity));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
