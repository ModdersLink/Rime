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
	public class EnlightenState : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SkyBoxGroundColor { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SkyBoxSunLightColor { get; set; } = new Vec3(); // 0x20 (32)
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SkyBoxBackLightColor { get; set; } = new Vec3(); // 0x30 (48)
		
		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SkyBoxSkyColor { get; set; } = new Vec3(); // 0x40 (64)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public float SunScale { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float OutputScale { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public float BounceScale { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public float SkyBoxSunLightColorSize { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public float SkyBoxBackLightRotationY { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float SkyBoxBackLightColorSize { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float SkyBoxBackLightRotationX { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public bool SkyBoxEnable { get; set; } // 0x6C (108)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2438224137:
					SkyBoxGroundColor = (Vec3) p_Value;
					break;

				case 2622963034:
					SkyBoxSunLightColor = (Vec3) p_Value;
					break;

				case 554253337:
					SkyBoxBackLightColor = (Vec3) p_Value;
					break;

				case 573165997:
					SkyBoxSkyColor = (Vec3) p_Value;
					break;

				case 2209231701:
					SunScale = (float) p_Value;
					break;

				case 734776130:
					OutputScale = (float) p_Value;
					break;

				case 1158285805:
					BounceScale = (float) p_Value;
					break;

				case 1176662367:
					SkyBoxSunLightColorSize = (float) p_Value;
					break;

				case 533859401:
					SkyBoxBackLightRotationY = (float) p_Value;
					break;

				case 3173445660:
					SkyBoxBackLightColorSize = (float) p_Value;
					break;

				case 533859400:
					SkyBoxBackLightRotationX = (float) p_Value;
					break;

				case 2201282448:
					SkyBoxEnable = (bool) p_Value;
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
				case 2438224137:
					return SkyBoxGroundColor;

				case 2622963034:
					return SkyBoxSunLightColor;

				case 554253337:
					return SkyBoxBackLightColor;

				case 573165997:
					return SkyBoxSkyColor;

				case 2209231701:
					return SunScale;

				case 734776130:
					return OutputScale;

				case 1158285805:
					return BounceScale;

				case 1176662367:
					return SkyBoxSunLightColorSize;

				case 533859401:
					return SkyBoxBackLightRotationY;

				case 3173445660:
					return SkyBoxBackLightColorSize;

				case 533859400:
					return SkyBoxBackLightRotationX;

				case 2201282448:
					return SkyBoxEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2438224137:
					return typeof(EnlightenState).GetProperty(nameof(SkyBoxGroundColor));

				case 2622963034:
					return typeof(EnlightenState).GetProperty(nameof(SkyBoxSunLightColor));

				case 554253337:
					return typeof(EnlightenState).GetProperty(nameof(SkyBoxBackLightColor));

				case 573165997:
					return typeof(EnlightenState).GetProperty(nameof(SkyBoxSkyColor));

				case 2209231701:
					return typeof(EnlightenState).GetProperty(nameof(SunScale));

				case 734776130:
					return typeof(EnlightenState).GetProperty(nameof(OutputScale));

				case 1158285805:
					return typeof(EnlightenState).GetProperty(nameof(BounceScale));

				case 1176662367:
					return typeof(EnlightenState).GetProperty(nameof(SkyBoxSunLightColorSize));

				case 533859401:
					return typeof(EnlightenState).GetProperty(nameof(SkyBoxBackLightRotationY));

				case 3173445660:
					return typeof(EnlightenState).GetProperty(nameof(SkyBoxBackLightColorSize));

				case 533859400:
					return typeof(EnlightenState).GetProperty(nameof(SkyBoxBackLightRotationX));

				case 2201282448:
					return typeof(EnlightenState).GetProperty(nameof(SkyBoxEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
