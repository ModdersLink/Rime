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
	public class SunFlareComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element5AlphaScreenPosCurve { get; set; } = new Vec4(); // 0x60 (96)
		
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element5AlphaOccluderCurve { get; set; } = new Vec4(); // 0x70 (112)
		
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element5SizeScreenPosCurve { get; set; } = new Vec4(); // 0x80 (128)
		
		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element2SizeOccluderCurve { get; set; } = new Vec4(); // 0x90 (144)
		
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element5SizeOccluderCurve { get; set; } = new Vec4(); // 0xA0 (160)
		
		[ContainerField(176), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element2AlphaOccluderCurve { get; set; } = new Vec4(); // 0xB0 (176)
		
		[ContainerField(192), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element2AlphaScreenPosCurve { get; set; } = new Vec4(); // 0xC0 (192)
		
		[ContainerField(208), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 Element1Size { get; set; } = new Vec2(); // 0xD0 (208)
		
		[ContainerField(224), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element1SizeOccluderCurve { get; set; } = new Vec4(); // 0xE0 (224)
		
		[ContainerField(240), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element1SizeScreenPosCurve { get; set; } = new Vec4(); // 0xF0 (240)
		
		[ContainerField(256), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element1AlphaOccluderCurve { get; set; } = new Vec4(); // 0x100 (256)
		
		[ContainerField(272), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element1AlphaScreenPosCurve { get; set; } = new Vec4(); // 0x110 (272)
		
		[ContainerField(288), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 Element5Size { get; set; } = new Vec2(); // 0x120 (288)
		
		[ContainerField(304), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element4SizeOccluderCurve { get; set; } = new Vec4(); // 0x130 (304)
		
		[ContainerField(320), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 Element3Size { get; set; } = new Vec2(); // 0x140 (320)
		
		[ContainerField(328), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 Element2Size { get; set; } = new Vec2(); // 0x148 (328)
		
		[ContainerField(336), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element4AlphaScreenPosCurve { get; set; } = new Vec4(); // 0x150 (336)
		
		[ContainerField(352), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element2SizeScreenPosCurve { get; set; } = new Vec4(); // 0x160 (352)
		
		[ContainerField(368), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element4SizeScreenPosCurve { get; set; } = new Vec4(); // 0x170 (368)
		
		[ContainerField(384), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 Element4Size { get; set; } = new Vec2(); // 0x180 (384)
		
		[ContainerField(400), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element3AlphaScreenPosCurve { get; set; } = new Vec4(); // 0x190 (400)
		
		[ContainerField(416), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element4AlphaOccluderCurve { get; set; } = new Vec4(); // 0x1A0 (416)
		
		[ContainerField(432), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element3SizeOccluderCurve { get; set; } = new Vec4(); // 0x1B0 (432)
		
		[ContainerField(448), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element3SizeScreenPosCurve { get; set; } = new Vec4(); // 0x1C0 (448)
		
		[ContainerField(464), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Element3AlphaOccluderCurve { get; set; } = new Vec4(); // 0x1D0 (464)
		
		[ContainerField(480)]
		public CtrRef<SurfaceShaderBaseAsset> Element1Shader { get; set; } = new CtrRef<SurfaceShaderBaseAsset>(); // 0x1E0 (480)
		
		[ContainerField(484), LayoutImmutable, Blittable]
		public float OccluderSize { get; set; } // 0x1E4 (484)
		
		[ContainerField(488)]
		public CtrRef<SurfaceShaderBaseAsset> Element2Shader { get; set; } = new CtrRef<SurfaceShaderBaseAsset>(); // 0x1E8 (488)
		
		[ContainerField(492), LayoutImmutable, Blittable]
		public float Element3RayDistance { get; set; } // 0x1EC (492)
		
		[ContainerField(496)]
		public CtrRef<SurfaceShaderBaseAsset> Element4Shader { get; set; } = new CtrRef<SurfaceShaderBaseAsset>(); // 0x1F0 (496)
		
		[ContainerField(500), LayoutImmutable, Blittable]
		public float Element4RayDistance { get; set; } // 0x1F4 (500)
		
		[ContainerField(504), LayoutImmutable, Blittable]
		public float Element2RayDistance { get; set; } // 0x1F8 (504)
		
		[ContainerField(508), LayoutImmutable, Blittable]
		public float Element1RayDistance { get; set; } // 0x1FC (508)
		
		[ContainerField(512), LayoutImmutable, Blittable]
		public float Element5RayDistance { get; set; } // 0x200 (512)
		
		[ContainerField(516)]
		public CtrRef<SurfaceShaderBaseAsset> Element3Shader { get; set; } = new CtrRef<SurfaceShaderBaseAsset>(); // 0x204 (516)
		
		[ContainerField(520)]
		public Realm Realm { get; set; } = new Realm(); // 0x208 (520)
		
		[ContainerField(524)]
		public CtrRef<SurfaceShaderBaseAsset> Element5Shader { get; set; } = new CtrRef<SurfaceShaderBaseAsset>(); // 0x20C (524)
		
		[ContainerField(528), LayoutImmutable, Blittable]
		public bool Element5Enable { get; set; } // 0x210 (528)
		
		[ContainerField(529), LayoutImmutable, Blittable]
		public bool Element3Enable { get; set; } // 0x211 (529)
		
		[ContainerField(530), LayoutImmutable, Blittable]
		public bool Element2Enable { get; set; } // 0x212 (530)
		
		[ContainerField(531), LayoutImmutable, Blittable]
		public bool Element1Enable { get; set; } // 0x213 (531)
		
		[ContainerField(532), LayoutImmutable, Blittable]
		public bool DebugDrawOccluder { get; set; } // 0x214 (532)
		
		[ContainerField(533), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x215 (533)
		
		[ContainerField(534), LayoutImmutable, Blittable]
		public bool Element4Enable { get; set; } // 0x216 (534)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2056610477:
					Element5AlphaScreenPosCurve = (Vec4) p_Value;
					break;

				case 777591848:
					Element5AlphaOccluderCurve = (Vec4) p_Value;
					break;

				case 1381132604:
					Element5SizeScreenPosCurve = (Vec4) p_Value;
					break;

				case 1592508798:
					Element2SizeOccluderCurve = (Vec4) p_Value;
					break;

				case 66701465:
					Element5SizeOccluderCurve = (Vec4) p_Value;
					break;

				case 2083412079:
					Element2AlphaOccluderCurve = (Vec4) p_Value;
					break;

				case 1836962634:
					Element2AlphaScreenPosCurve = (Vec4) p_Value;
					break;

				case 2566133135:
					Element1Size = (Vec2) p_Value;
					break;

				case 559736093:
					Element1SizeOccluderCurve = (Vec4) p_Value;
					break;

				case 1652365624:
					Element1SizeScreenPosCurve = (Vec4) p_Value;
					break;

				case 4252527404:
					Element1AlphaOccluderCurve = (Vec4) p_Value;
					break;

				case 1946326313:
					Element1AlphaScreenPosCurve = (Vec4) p_Value;
					break;

				case 2570876811:
					Element5Size = (Vec2) p_Value;
					break;

				case 2043716408:
					Element4SizeOccluderCurve = (Vec4) p_Value;
					break;

				case 2568509069:
					Element3Size = (Vec2) p_Value;
					break;

				case 2569623180:
					Element2Size = (Vec2) p_Value;
					break;

				case 2336573580:
					Element4AlphaScreenPosCurve = (Vec4) p_Value;
					break;

				case 396362939:
					Element2SizeScreenPosCurve = (Vec4) p_Value;
					break;

				case 3624094653:
					Element4SizeScreenPosCurve = (Vec4) p_Value;
					break;

				case 2571990922:
					Element4Size = (Vec2) p_Value;
					break;

				case 3605704299:
					Element3AlphaScreenPosCurve = (Vec4) p_Value;
					break;

				case 982699753:
					Element4AlphaOccluderCurve = (Vec4) p_Value;
					break;

				case 3910461151:
					Element3SizeOccluderCurve = (Vec4) p_Value;
					break;

				case 2439176762:
					Element3SizeScreenPosCurve = (Vec4) p_Value;
					break;

				case 1588749230:
					Element3AlphaOccluderCurve = (Vec4) p_Value;
					break;

				case 2789512003:
					Element1Shader = (CtrRef<SurfaceShaderBaseAsset>) p_Value;
					break;

				case 2630779365:
					OccluderSize = (float) p_Value;
					break;

				case 2297516480:
					Element2Shader = (CtrRef<SurfaceShaderBaseAsset>) p_Value;
					break;

				case 4136213409:
					Element3RayDistance = (float) p_Value;
					break;

				case 580872518:
					Element4Shader = (CtrRef<SurfaceShaderBaseAsset>) p_Value;
					break;

				case 4220190726:
					Element4RayDistance = (float) p_Value;
					break;

				case 665139136:
					Element2RayDistance = (float) p_Value;
					break;

				case 1346368355:
					Element1RayDistance = (float) p_Value;
					break;

				case 2995741671:
					Element5RayDistance = (float) p_Value;
					break;

				case 1082084801:
					Element3Shader = (CtrRef<SurfaceShaderBaseAsset>) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 3660408135:
					Element5Shader = (CtrRef<SurfaceShaderBaseAsset>) p_Value;
					break;

				case 2811012015:
					Element5Enable = (bool) p_Value;
					break;

				case 375274153:
					Element3Enable = (bool) p_Value;
					break;

				case 1590984808:
					Element2Enable = (bool) p_Value;
					break;

				case 2243703467:
					Element1Enable = (bool) p_Value;
					break;

				case 3156672721:
					DebugDrawOccluder = (bool) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
					break;

				case 4026722670:
					Element4Enable = (bool) p_Value;
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
				case 2056610477:
					return Element5AlphaScreenPosCurve;

				case 777591848:
					return Element5AlphaOccluderCurve;

				case 1381132604:
					return Element5SizeScreenPosCurve;

				case 1592508798:
					return Element2SizeOccluderCurve;

				case 66701465:
					return Element5SizeOccluderCurve;

				case 2083412079:
					return Element2AlphaOccluderCurve;

				case 1836962634:
					return Element2AlphaScreenPosCurve;

				case 2566133135:
					return Element1Size;

				case 559736093:
					return Element1SizeOccluderCurve;

				case 1652365624:
					return Element1SizeScreenPosCurve;

				case 4252527404:
					return Element1AlphaOccluderCurve;

				case 1946326313:
					return Element1AlphaScreenPosCurve;

				case 2570876811:
					return Element5Size;

				case 2043716408:
					return Element4SizeOccluderCurve;

				case 2568509069:
					return Element3Size;

				case 2569623180:
					return Element2Size;

				case 2336573580:
					return Element4AlphaScreenPosCurve;

				case 396362939:
					return Element2SizeScreenPosCurve;

				case 3624094653:
					return Element4SizeScreenPosCurve;

				case 2571990922:
					return Element4Size;

				case 3605704299:
					return Element3AlphaScreenPosCurve;

				case 982699753:
					return Element4AlphaOccluderCurve;

				case 3910461151:
					return Element3SizeOccluderCurve;

				case 2439176762:
					return Element3SizeScreenPosCurve;

				case 1588749230:
					return Element3AlphaOccluderCurve;

				case 2789512003:
					return Element1Shader;

				case 2630779365:
					return OccluderSize;

				case 2297516480:
					return Element2Shader;

				case 4136213409:
					return Element3RayDistance;

				case 580872518:
					return Element4Shader;

				case 4220190726:
					return Element4RayDistance;

				case 665139136:
					return Element2RayDistance;

				case 1346368355:
					return Element1RayDistance;

				case 2995741671:
					return Element5RayDistance;

				case 1082084801:
					return Element3Shader;

				case 229961746:
					return Realm;

				case 3660408135:
					return Element5Shader;

				case 2811012015:
					return Element5Enable;

				case 375274153:
					return Element3Enable;

				case 1590984808:
					return Element2Enable;

				case 2243703467:
					return Element1Enable;

				case 3156672721:
					return DebugDrawOccluder;

				case 2342790116:
					return Enable;

				case 4026722670:
					return Element4Enable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2056610477:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element5AlphaScreenPosCurve));

				case 777591848:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element5AlphaOccluderCurve));

				case 1381132604:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element5SizeScreenPosCurve));

				case 1592508798:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element2SizeOccluderCurve));

				case 66701465:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element5SizeOccluderCurve));

				case 2083412079:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element2AlphaOccluderCurve));

				case 1836962634:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element2AlphaScreenPosCurve));

				case 2566133135:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element1Size));

				case 559736093:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element1SizeOccluderCurve));

				case 1652365624:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element1SizeScreenPosCurve));

				case 4252527404:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element1AlphaOccluderCurve));

				case 1946326313:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element1AlphaScreenPosCurve));

				case 2570876811:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element5Size));

				case 2043716408:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element4SizeOccluderCurve));

				case 2568509069:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element3Size));

				case 2569623180:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element2Size));

				case 2336573580:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element4AlphaScreenPosCurve));

				case 396362939:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element2SizeScreenPosCurve));

				case 3624094653:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element4SizeScreenPosCurve));

				case 2571990922:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element4Size));

				case 3605704299:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element3AlphaScreenPosCurve));

				case 982699753:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element4AlphaOccluderCurve));

				case 3910461151:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element3SizeOccluderCurve));

				case 2439176762:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element3SizeScreenPosCurve));

				case 1588749230:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element3AlphaOccluderCurve));

				case 2789512003:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element1Shader));

				case 2630779365:
					return typeof(SunFlareComponentData).GetProperty(nameof(OccluderSize));

				case 2297516480:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element2Shader));

				case 4136213409:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element3RayDistance));

				case 580872518:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element4Shader));

				case 4220190726:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element4RayDistance));

				case 665139136:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element2RayDistance));

				case 1346368355:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element1RayDistance));

				case 2995741671:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element5RayDistance));

				case 1082084801:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element3Shader));

				case 229961746:
					return typeof(SunFlareComponentData).GetProperty(nameof(Realm));

				case 3660408135:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element5Shader));

				case 2811012015:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element5Enable));

				case 375274153:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element3Enable));

				case 1590984808:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element2Enable));

				case 2243703467:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element1Enable));

				case 3156672721:
					return typeof(SunFlareComponentData).GetProperty(nameof(DebugDrawOccluder));

				case 2342790116:
					return typeof(SunFlareComponentData).GetProperty(nameof(Enable));

				case 4026722670:
					return typeof(SunFlareComponentData).GetProperty(nameof(Element4Enable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
