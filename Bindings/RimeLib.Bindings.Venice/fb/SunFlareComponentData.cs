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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class SunFlareComponentData : 
		ComponentData
	{
		protected Vec4 m_Element5AlphaScreenPosCurve = new Vec4();
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2056610477)]
		public Vec4 Element5AlphaScreenPosCurve { get { return m_Element5AlphaScreenPosCurve; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element5AlphaScreenPosCurve), this, m_Element5AlphaScreenPosCurve, value)) m_Element5AlphaScreenPosCurve = value; } } // 0x60 (96)
		
		protected Vec4 m_Element5AlphaOccluderCurve = new Vec4();
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(777591848)]
		public Vec4 Element5AlphaOccluderCurve { get { return m_Element5AlphaOccluderCurve; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element5AlphaOccluderCurve), this, m_Element5AlphaOccluderCurve, value)) m_Element5AlphaOccluderCurve = value; } } // 0x70 (112)
		
		protected Vec4 m_Element5SizeScreenPosCurve = new Vec4();
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(1381132604)]
		public Vec4 Element5SizeScreenPosCurve { get { return m_Element5SizeScreenPosCurve; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element5SizeScreenPosCurve), this, m_Element5SizeScreenPosCurve, value)) m_Element5SizeScreenPosCurve = value; } } // 0x80 (128)
		
		protected Vec4 m_Element2SizeOccluderCurve = new Vec4();
		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(1592508798)]
		public Vec4 Element2SizeOccluderCurve { get { return m_Element2SizeOccluderCurve; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element2SizeOccluderCurve), this, m_Element2SizeOccluderCurve, value)) m_Element2SizeOccluderCurve = value; } } // 0x90 (144)
		
		protected Vec4 m_Element5SizeOccluderCurve = new Vec4();
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(66701465)]
		public Vec4 Element5SizeOccluderCurve { get { return m_Element5SizeOccluderCurve; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element5SizeOccluderCurve), this, m_Element5SizeOccluderCurve, value)) m_Element5SizeOccluderCurve = value; } } // 0xA0 (160)
		
		protected Vec4 m_Element2AlphaOccluderCurve = new Vec4();
		[ContainerField(176), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2083412079)]
		public Vec4 Element2AlphaOccluderCurve { get { return m_Element2AlphaOccluderCurve; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element2AlphaOccluderCurve), this, m_Element2AlphaOccluderCurve, value)) m_Element2AlphaOccluderCurve = value; } } // 0xB0 (176)
		
		protected Vec4 m_Element2AlphaScreenPosCurve = new Vec4();
		[ContainerField(192), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(1836962634)]
		public Vec4 Element2AlphaScreenPosCurve { get { return m_Element2AlphaScreenPosCurve; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element2AlphaScreenPosCurve), this, m_Element2AlphaScreenPosCurve, value)) m_Element2AlphaScreenPosCurve = value; } } // 0xC0 (192)
		
		protected Vec2 m_Element1Size = new Vec2();
		[ContainerField(208), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2566133135)]
		public Vec2 Element1Size { get { return m_Element1Size; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element1Size), this, m_Element1Size, value)) m_Element1Size = value; } } // 0xD0 (208)
		
		protected Vec4 m_Element1SizeOccluderCurve = new Vec4();
		[ContainerField(224), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(559736093)]
		public Vec4 Element1SizeOccluderCurve { get { return m_Element1SizeOccluderCurve; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element1SizeOccluderCurve), this, m_Element1SizeOccluderCurve, value)) m_Element1SizeOccluderCurve = value; } } // 0xE0 (224)
		
		protected Vec4 m_Element1SizeScreenPosCurve = new Vec4();
		[ContainerField(240), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(1652365624)]
		public Vec4 Element1SizeScreenPosCurve { get { return m_Element1SizeScreenPosCurve; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element1SizeScreenPosCurve), this, m_Element1SizeScreenPosCurve, value)) m_Element1SizeScreenPosCurve = value; } } // 0xF0 (240)
		
		protected Vec4 m_Element1AlphaOccluderCurve = new Vec4();
		[ContainerField(256), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(4252527404)]
		public Vec4 Element1AlphaOccluderCurve { get { return m_Element1AlphaOccluderCurve; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element1AlphaOccluderCurve), this, m_Element1AlphaOccluderCurve, value)) m_Element1AlphaOccluderCurve = value; } } // 0x100 (256)
		
		protected Vec4 m_Element1AlphaScreenPosCurve = new Vec4();
		[ContainerField(272), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(1946326313)]
		public Vec4 Element1AlphaScreenPosCurve { get { return m_Element1AlphaScreenPosCurve; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element1AlphaScreenPosCurve), this, m_Element1AlphaScreenPosCurve, value)) m_Element1AlphaScreenPosCurve = value; } } // 0x110 (272)
		
		protected Vec2 m_Element5Size = new Vec2();
		[ContainerField(288), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2570876811)]
		public Vec2 Element5Size { get { return m_Element5Size; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element5Size), this, m_Element5Size, value)) m_Element5Size = value; } } // 0x120 (288)
		
		protected Vec4 m_Element4SizeOccluderCurve = new Vec4();
		[ContainerField(304), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2043716408)]
		public Vec4 Element4SizeOccluderCurve { get { return m_Element4SizeOccluderCurve; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element4SizeOccluderCurve), this, m_Element4SizeOccluderCurve, value)) m_Element4SizeOccluderCurve = value; } } // 0x130 (304)
		
		protected Vec2 m_Element3Size = new Vec2();
		[ContainerField(320), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2568509069)]
		public Vec2 Element3Size { get { return m_Element3Size; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element3Size), this, m_Element3Size, value)) m_Element3Size = value; } } // 0x140 (320)
		
		protected Vec2 m_Element2Size = new Vec2();
		[ContainerField(328), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2569623180)]
		public Vec2 Element2Size { get { return m_Element2Size; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element2Size), this, m_Element2Size, value)) m_Element2Size = value; } } // 0x148 (328)
		
		protected Vec4 m_Element4AlphaScreenPosCurve = new Vec4();
		[ContainerField(336), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2336573580)]
		public Vec4 Element4AlphaScreenPosCurve { get { return m_Element4AlphaScreenPosCurve; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element4AlphaScreenPosCurve), this, m_Element4AlphaScreenPosCurve, value)) m_Element4AlphaScreenPosCurve = value; } } // 0x150 (336)
		
		protected Vec4 m_Element2SizeScreenPosCurve = new Vec4();
		[ContainerField(352), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(396362939)]
		public Vec4 Element2SizeScreenPosCurve { get { return m_Element2SizeScreenPosCurve; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element2SizeScreenPosCurve), this, m_Element2SizeScreenPosCurve, value)) m_Element2SizeScreenPosCurve = value; } } // 0x160 (352)
		
		protected Vec4 m_Element4SizeScreenPosCurve = new Vec4();
		[ContainerField(368), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(3624094653)]
		public Vec4 Element4SizeScreenPosCurve { get { return m_Element4SizeScreenPosCurve; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element4SizeScreenPosCurve), this, m_Element4SizeScreenPosCurve, value)) m_Element4SizeScreenPosCurve = value; } } // 0x170 (368)
		
		protected Vec2 m_Element4Size = new Vec2();
		[ContainerField(384), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2571990922)]
		public Vec2 Element4Size { get { return m_Element4Size; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element4Size), this, m_Element4Size, value)) m_Element4Size = value; } } // 0x180 (384)
		
		protected Vec4 m_Element3AlphaScreenPosCurve = new Vec4();
		[ContainerField(400), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(3605704299)]
		public Vec4 Element3AlphaScreenPosCurve { get { return m_Element3AlphaScreenPosCurve; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element3AlphaScreenPosCurve), this, m_Element3AlphaScreenPosCurve, value)) m_Element3AlphaScreenPosCurve = value; } } // 0x190 (400)
		
		protected Vec4 m_Element4AlphaOccluderCurve = new Vec4();
		[ContainerField(416), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(982699753)]
		public Vec4 Element4AlphaOccluderCurve { get { return m_Element4AlphaOccluderCurve; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element4AlphaOccluderCurve), this, m_Element4AlphaOccluderCurve, value)) m_Element4AlphaOccluderCurve = value; } } // 0x1A0 (416)
		
		protected Vec4 m_Element3SizeOccluderCurve = new Vec4();
		[ContainerField(432), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(3910461151)]
		public Vec4 Element3SizeOccluderCurve { get { return m_Element3SizeOccluderCurve; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element3SizeOccluderCurve), this, m_Element3SizeOccluderCurve, value)) m_Element3SizeOccluderCurve = value; } } // 0x1B0 (432)
		
		protected Vec4 m_Element3SizeScreenPosCurve = new Vec4();
		[ContainerField(448), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2439176762)]
		public Vec4 Element3SizeScreenPosCurve { get { return m_Element3SizeScreenPosCurve; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element3SizeScreenPosCurve), this, m_Element3SizeScreenPosCurve, value)) m_Element3SizeScreenPosCurve = value; } } // 0x1C0 (448)
		
		protected Vec4 m_Element3AlphaOccluderCurve = new Vec4();
		[ContainerField(464), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(1588749230)]
		public Vec4 Element3AlphaOccluderCurve { get { return m_Element3AlphaOccluderCurve; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element3AlphaOccluderCurve), this, m_Element3AlphaOccluderCurve, value)) m_Element3AlphaOccluderCurve = value; } } // 0x1D0 (464)
		
		protected CtrRef<SurfaceShaderBaseAsset> m_Element1Shader = new CtrRef<SurfaceShaderBaseAsset>();
		[ContainerField(480), MemberInfoFlag(53), ContainerFieldNameHash(2789512003), ContainerCtrRef]
		public CtrRef<SurfaceShaderBaseAsset> Element1Shader { get { return m_Element1Shader; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element1Shader), this, m_Element1Shader, value)) m_Element1Shader = value; } } // 0x1E0 (480)
		
		protected float m_OccluderSize = new float();
		[ContainerField(484), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2630779365)]
		public float OccluderSize { get { return m_OccluderSize; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(OccluderSize), this, m_OccluderSize, value)) m_OccluderSize = value; } } // 0x1E4 (484)
		
		protected CtrRef<SurfaceShaderBaseAsset> m_Element2Shader = new CtrRef<SurfaceShaderBaseAsset>();
		[ContainerField(488), MemberInfoFlag(53), ContainerFieldNameHash(2297516480), ContainerCtrRef]
		public CtrRef<SurfaceShaderBaseAsset> Element2Shader { get { return m_Element2Shader; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element2Shader), this, m_Element2Shader, value)) m_Element2Shader = value; } } // 0x1E8 (488)
		
		protected float m_Element3RayDistance = new float();
		[ContainerField(492), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4136213409)]
		public float Element3RayDistance { get { return m_Element3RayDistance; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element3RayDistance), this, m_Element3RayDistance, value)) m_Element3RayDistance = value; } } // 0x1EC (492)
		
		protected CtrRef<SurfaceShaderBaseAsset> m_Element4Shader = new CtrRef<SurfaceShaderBaseAsset>();
		[ContainerField(496), MemberInfoFlag(53), ContainerFieldNameHash(580872518), ContainerCtrRef]
		public CtrRef<SurfaceShaderBaseAsset> Element4Shader { get { return m_Element4Shader; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element4Shader), this, m_Element4Shader, value)) m_Element4Shader = value; } } // 0x1F0 (496)
		
		protected float m_Element4RayDistance = new float();
		[ContainerField(500), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4220190726)]
		public float Element4RayDistance { get { return m_Element4RayDistance; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element4RayDistance), this, m_Element4RayDistance, value)) m_Element4RayDistance = value; } } // 0x1F4 (500)
		
		protected float m_Element2RayDistance = new float();
		[ContainerField(504), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(665139136)]
		public float Element2RayDistance { get { return m_Element2RayDistance; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element2RayDistance), this, m_Element2RayDistance, value)) m_Element2RayDistance = value; } } // 0x1F8 (504)
		
		protected float m_Element1RayDistance = new float();
		[ContainerField(508), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1346368355)]
		public float Element1RayDistance { get { return m_Element1RayDistance; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element1RayDistance), this, m_Element1RayDistance, value)) m_Element1RayDistance = value; } } // 0x1FC (508)
		
		protected float m_Element5RayDistance = new float();
		[ContainerField(512), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2995741671)]
		public float Element5RayDistance { get { return m_Element5RayDistance; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element5RayDistance), this, m_Element5RayDistance, value)) m_Element5RayDistance = value; } } // 0x200 (512)
		
		protected CtrRef<SurfaceShaderBaseAsset> m_Element3Shader = new CtrRef<SurfaceShaderBaseAsset>();
		[ContainerField(516), MemberInfoFlag(53), ContainerFieldNameHash(1082084801), ContainerCtrRef]
		public CtrRef<SurfaceShaderBaseAsset> Element3Shader { get { return m_Element3Shader; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element3Shader), this, m_Element3Shader, value)) m_Element3Shader = value; } } // 0x204 (516)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(520), MemberInfoFlag(137), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x208 (520)
		
		protected CtrRef<SurfaceShaderBaseAsset> m_Element5Shader = new CtrRef<SurfaceShaderBaseAsset>();
		[ContainerField(524), MemberInfoFlag(53), ContainerFieldNameHash(3660408135), ContainerCtrRef]
		public CtrRef<SurfaceShaderBaseAsset> Element5Shader { get { return m_Element5Shader; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element5Shader), this, m_Element5Shader, value)) m_Element5Shader = value; } } // 0x20C (524)
		
		protected bool m_Element5Enable = new bool();
		[ContainerField(528), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2811012015)]
		public bool Element5Enable { get { return m_Element5Enable; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element5Enable), this, m_Element5Enable, value)) m_Element5Enable = value; } } // 0x210 (528)
		
		protected bool m_Element3Enable = new bool();
		[ContainerField(529), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(375274153)]
		public bool Element3Enable { get { return m_Element3Enable; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element3Enable), this, m_Element3Enable, value)) m_Element3Enable = value; } } // 0x211 (529)
		
		protected bool m_Element2Enable = new bool();
		[ContainerField(530), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1590984808)]
		public bool Element2Enable { get { return m_Element2Enable; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element2Enable), this, m_Element2Enable, value)) m_Element2Enable = value; } } // 0x212 (530)
		
		protected bool m_Element1Enable = new bool();
		[ContainerField(531), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2243703467)]
		public bool Element1Enable { get { return m_Element1Enable; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element1Enable), this, m_Element1Enable, value)) m_Element1Enable = value; } } // 0x213 (531)
		
		protected bool m_DebugDrawOccluder = new bool();
		[ContainerField(532), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3156672721)]
		public bool DebugDrawOccluder { get { return m_DebugDrawOccluder; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(DebugDrawOccluder), this, m_DebugDrawOccluder, value)) m_DebugDrawOccluder = value; } } // 0x214 (532)
		
		protected bool m_Enable = new bool();
		[ContainerField(533), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2342790116)]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x215 (533)
		
		protected bool m_Element4Enable = new bool();
		[ContainerField(534), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4026722670)]
		public bool Element4Enable { get { return m_Element4Enable; } set { if (OnPropertyChanging("SunFlareComponentData." + nameof(Element4Enable), this, m_Element4Enable, value)) m_Element4Enable = value; } } // 0x216 (534)
		
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
