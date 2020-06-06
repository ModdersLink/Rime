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
	public class HovercraftFloatPhysicsData : 
		HullFloatPhysicsData
	{
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 LandResistanceAxisMod { get; set; } = new Vec3(); // 0x80 (128)
		
		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 LandFrictionAxisMod { get; set; } = new Vec3(); // 0x90 (144)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public float FrontLength { get; set; } // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public float SideLength { get; set; } // 0xA4 (164)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3707997700:
					LandResistanceAxisMod = (Vec3) p_Value;
					break;

				case 3677552229:
					LandFrictionAxisMod = (Vec3) p_Value;
					break;

				case 2116152088:
					FrontLength = (float) p_Value;
					break;

				case 45904162:
					SideLength = (float) p_Value;
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
				case 3707997700:
					return LandResistanceAxisMod;

				case 3677552229:
					return LandFrictionAxisMod;

				case 2116152088:
					return FrontLength;

				case 45904162:
					return SideLength;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3707997700:
					return typeof(HovercraftFloatPhysicsData).GetProperty(nameof(LandResistanceAxisMod));

				case 3677552229:
					return typeof(HovercraftFloatPhysicsData).GetProperty(nameof(LandFrictionAxisMod));

				case 2116152088:
					return typeof(HovercraftFloatPhysicsData).GetProperty(nameof(FrontLength));

				case 45904162:
					return typeof(HovercraftFloatPhysicsData).GetProperty(nameof(SideLength));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
