///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class EnlightenComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SkyBoxSkyColor { get; set; } = new Vec3(); // 0x60 (96)
		
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SkyBoxBackLightColor { get; set; } = new Vec3(); // 0x70 (112)
		
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SkyBoxGroundColor { get; set; } = new Vec3(); // 0x80 (128)
		
		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 TerrainColor { get; set; } = new Vec3(); // 0x90 (144)
		
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SkyBoxSunLightColor { get; set; } = new Vec3(); // 0xA0 (160)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public float BounceScale { get; set; } // 0xB0 (176)
		
		[ContainerField(180), LayoutImmutable, Blittable]
		public float CullDistance { get; set; } // 0xB4 (180)
		
		[ContainerField(184), LayoutImmutable, Blittable]
		public float SunScale { get; set; } // 0xB8 (184)
		
		[ContainerField(188)]
		public Realm Realm { get; set; } = new Realm(); // 0xBC (188)
		
		[ContainerField(192), LayoutImmutable, Blittable]
		public float SkyBoxBackLightRotationY { get; set; } // 0xC0 (192)
		
		[ContainerField(196), LayoutImmutable, Blittable]
		public float SkyBoxSunLightColorSize { get; set; } // 0xC4 (196)
		
		[ContainerField(200), LayoutImmutable, Blittable]
		public float SkyBoxBackLightColorSize { get; set; } // 0xC8 (200)
		
		[ContainerField(204), LayoutImmutable, Blittable]
		public float SkyBoxBackLightRotationX { get; set; } // 0xCC (204)
		
		[ContainerField(208), LayoutImmutable, Blittable]
		public bool SkyBoxEnable { get; set; } // 0xD0 (208)
		
		[ContainerField(209), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0xD1 (209)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 573165997:
					SkyBoxSkyColor = (Vec3) p_Value;
					break;

				case 554253337:
					SkyBoxBackLightColor = (Vec3) p_Value;
					break;

				case 2438224137:
					SkyBoxGroundColor = (Vec3) p_Value;
					break;

				case 87781231:
					TerrainColor = (Vec3) p_Value;
					break;

				case 2622963034:
					SkyBoxSunLightColor = (Vec3) p_Value;
					break;

				case 1158285805:
					BounceScale = (float) p_Value;
					break;

				case 1000432400:
					CullDistance = (float) p_Value;
					break;

				case 2209231701:
					SunScale = (float) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 533859401:
					SkyBoxBackLightRotationY = (float) p_Value;
					break;

				case 1176662367:
					SkyBoxSunLightColorSize = (float) p_Value;
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

				case 2342790116:
					Enable = (bool) p_Value;
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
				case 573165997:
					return SkyBoxSkyColor;

				case 554253337:
					return SkyBoxBackLightColor;

				case 2438224137:
					return SkyBoxGroundColor;

				case 87781231:
					return TerrainColor;

				case 2622963034:
					return SkyBoxSunLightColor;

				case 1158285805:
					return BounceScale;

				case 1000432400:
					return CullDistance;

				case 2209231701:
					return SunScale;

				case 229961746:
					return Realm;

				case 533859401:
					return SkyBoxBackLightRotationY;

				case 1176662367:
					return SkyBoxSunLightColorSize;

				case 3173445660:
					return SkyBoxBackLightColorSize;

				case 533859400:
					return SkyBoxBackLightRotationX;

				case 2201282448:
					return SkyBoxEnable;

				case 2342790116:
					return Enable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 573165997:
					return typeof(EnlightenComponentData).GetProperty(nameof(SkyBoxSkyColor));

				case 554253337:
					return typeof(EnlightenComponentData).GetProperty(nameof(SkyBoxBackLightColor));

				case 2438224137:
					return typeof(EnlightenComponentData).GetProperty(nameof(SkyBoxGroundColor));

				case 87781231:
					return typeof(EnlightenComponentData).GetProperty(nameof(TerrainColor));

				case 2622963034:
					return typeof(EnlightenComponentData).GetProperty(nameof(SkyBoxSunLightColor));

				case 1158285805:
					return typeof(EnlightenComponentData).GetProperty(nameof(BounceScale));

				case 1000432400:
					return typeof(EnlightenComponentData).GetProperty(nameof(CullDistance));

				case 2209231701:
					return typeof(EnlightenComponentData).GetProperty(nameof(SunScale));

				case 229961746:
					return typeof(EnlightenComponentData).GetProperty(nameof(Realm));

				case 533859401:
					return typeof(EnlightenComponentData).GetProperty(nameof(SkyBoxBackLightRotationY));

				case 1176662367:
					return typeof(EnlightenComponentData).GetProperty(nameof(SkyBoxSunLightColorSize));

				case 3173445660:
					return typeof(EnlightenComponentData).GetProperty(nameof(SkyBoxBackLightColorSize));

				case 533859400:
					return typeof(EnlightenComponentData).GetProperty(nameof(SkyBoxBackLightRotationX));

				case 2201282448:
					return typeof(EnlightenComponentData).GetProperty(nameof(SkyBoxEnable));

				case 2342790116:
					return typeof(EnlightenComponentData).GetProperty(nameof(Enable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
