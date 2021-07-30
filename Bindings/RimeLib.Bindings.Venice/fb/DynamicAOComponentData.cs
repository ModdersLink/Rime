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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 144)]
	public class DynamicAOComponentData : 
		ComponentData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 96, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("DynamicAOComponentData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x60 (96)
		
		protected float m_SsaoMaxDistanceOuter = new float();
		[ContainerField(Name: "SsaoMaxDistanceOuter", Offset: 100, NameHash: 3500535333, Flags: 49469), LayoutImmutable, Blittable]
		public float SsaoMaxDistanceOuter { get { return m_SsaoMaxDistanceOuter; } set { if (OnPropertyChanging("DynamicAOComponentData." + nameof(SsaoMaxDistanceOuter), this, m_SsaoMaxDistanceOuter, value)) m_SsaoMaxDistanceOuter = value; } } // 0x64 (100)
		
		protected float m_SsaoFade = new float();
		[ContainerField(Name: "SsaoFade", Offset: 104, NameHash: 3826461517, Flags: 49469), LayoutImmutable, Blittable]
		public float SsaoFade { get { return m_SsaoFade; } set { if (OnPropertyChanging("DynamicAOComponentData." + nameof(SsaoFade), this, m_SsaoFade, value)) m_SsaoFade = value; } } // 0x68 (104)
		
		protected float m_SsaoRadius = new float();
		[ContainerField(Name: "SsaoRadius", Offset: 108, NameHash: 1368210291, Flags: 49469), LayoutImmutable, Blittable]
		public float SsaoRadius { get { return m_SsaoRadius; } set { if (OnPropertyChanging("DynamicAOComponentData." + nameof(SsaoRadius), this, m_SsaoRadius, value)) m_SsaoRadius = value; } } // 0x6C (108)
		
		protected float m_SsaoMaxDistanceInner = new float();
		[ContainerField(Name: "SsaoMaxDistanceInner", Offset: 112, NameHash: 3499039746, Flags: 49469), LayoutImmutable, Blittable]
		public float SsaoMaxDistanceInner { get { return m_SsaoMaxDistanceInner; } set { if (OnPropertyChanging("DynamicAOComponentData." + nameof(SsaoMaxDistanceInner), this, m_SsaoMaxDistanceInner, value)) m_SsaoMaxDistanceInner = value; } } // 0x70 (112)
		
		protected float m_HbaoRadius = new float();
		[ContainerField(Name: "HbaoRadius", Offset: 116, NameHash: 1912648665, Flags: 49469), LayoutImmutable, Blittable]
		public float HbaoRadius { get { return m_HbaoRadius; } set { if (OnPropertyChanging("DynamicAOComponentData." + nameof(HbaoRadius), this, m_HbaoRadius, value)) m_HbaoRadius = value; } } // 0x74 (116)
		
		protected float m_HbaoAttenuation = new float();
		[ContainerField(Name: "HbaoAttenuation", Offset: 120, NameHash: 1141367555, Flags: 49469), LayoutImmutable, Blittable]
		public float HbaoAttenuation { get { return m_HbaoAttenuation; } set { if (OnPropertyChanging("DynamicAOComponentData." + nameof(HbaoAttenuation), this, m_HbaoAttenuation, value)) m_HbaoAttenuation = value; } } // 0x78 (120)
		
		protected float m_HbaoAngleBias = new float();
		[ContainerField(Name: "HbaoAngleBias", Offset: 124, NameHash: 442044921, Flags: 49469), LayoutImmutable, Blittable]
		public float HbaoAngleBias { get { return m_HbaoAngleBias; } set { if (OnPropertyChanging("DynamicAOComponentData." + nameof(HbaoAngleBias), this, m_HbaoAngleBias, value)) m_HbaoAngleBias = value; } } // 0x7C (124)
		
		protected float m_HbaoPowerExponent = new float();
		[ContainerField(Name: "HbaoPowerExponent", Offset: 128, NameHash: 1792055981, Flags: 49469), LayoutImmutable, Blittable]
		public float HbaoPowerExponent { get { return m_HbaoPowerExponent; } set { if (OnPropertyChanging("DynamicAOComponentData." + nameof(HbaoPowerExponent), this, m_HbaoPowerExponent, value)) m_HbaoPowerExponent = value; } } // 0x80 (128)
		
		protected float m_HbaoContrast = new float();
		[ContainerField(Name: "HbaoContrast", Offset: 132, NameHash: 4195925987, Flags: 49469), LayoutImmutable, Blittable]
		public float HbaoContrast { get { return m_HbaoContrast; } set { if (OnPropertyChanging("DynamicAOComponentData." + nameof(HbaoContrast), this, m_HbaoContrast, value)) m_HbaoContrast = value; } } // 0x84 (132)
		
		protected float m_HbaoMaxFootprintRadius = new float();
		[ContainerField(Name: "HbaoMaxFootprintRadius", Offset: 136, NameHash: 312723150, Flags: 49469), LayoutImmutable, Blittable]
		public float HbaoMaxFootprintRadius { get { return m_HbaoMaxFootprintRadius; } set { if (OnPropertyChanging("DynamicAOComponentData." + nameof(HbaoMaxFootprintRadius), this, m_HbaoMaxFootprintRadius, value)) m_HbaoMaxFootprintRadius = value; } } // 0x88 (136)
		
		protected bool m_Enable = new bool();
		[ContainerField(Name: "Enable", Offset: 140, NameHash: 2342790116, Flags: 49325), LayoutImmutable, Blittable]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("DynamicAOComponentData." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x8C (140)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 3500535333:
					SsaoMaxDistanceOuter = (float) p_Value;
					break;

				case 3826461517:
					SsaoFade = (float) p_Value;
					break;

				case 1368210291:
					SsaoRadius = (float) p_Value;
					break;

				case 3499039746:
					SsaoMaxDistanceInner = (float) p_Value;
					break;

				case 1912648665:
					HbaoRadius = (float) p_Value;
					break;

				case 1141367555:
					HbaoAttenuation = (float) p_Value;
					break;

				case 442044921:
					HbaoAngleBias = (float) p_Value;
					break;

				case 1792055981:
					HbaoPowerExponent = (float) p_Value;
					break;

				case 4195925987:
					HbaoContrast = (float) p_Value;
					break;

				case 312723150:
					HbaoMaxFootprintRadius = (float) p_Value;
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
				case 229961746:
					return Realm;

				case 3500535333:
					return SsaoMaxDistanceOuter;

				case 3826461517:
					return SsaoFade;

				case 1368210291:
					return SsaoRadius;

				case 3499039746:
					return SsaoMaxDistanceInner;

				case 1912648665:
					return HbaoRadius;

				case 1141367555:
					return HbaoAttenuation;

				case 442044921:
					return HbaoAngleBias;

				case 1792055981:
					return HbaoPowerExponent;

				case 4195925987:
					return HbaoContrast;

				case 312723150:
					return HbaoMaxFootprintRadius;

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
				case 229961746:
					return typeof(DynamicAOComponentData).GetProperty(nameof(Realm));

				case 3500535333:
					return typeof(DynamicAOComponentData).GetProperty(nameof(SsaoMaxDistanceOuter));

				case 3826461517:
					return typeof(DynamicAOComponentData).GetProperty(nameof(SsaoFade));

				case 1368210291:
					return typeof(DynamicAOComponentData).GetProperty(nameof(SsaoRadius));

				case 3499039746:
					return typeof(DynamicAOComponentData).GetProperty(nameof(SsaoMaxDistanceInner));

				case 1912648665:
					return typeof(DynamicAOComponentData).GetProperty(nameof(HbaoRadius));

				case 1141367555:
					return typeof(DynamicAOComponentData).GetProperty(nameof(HbaoAttenuation));

				case 442044921:
					return typeof(DynamicAOComponentData).GetProperty(nameof(HbaoAngleBias));

				case 1792055981:
					return typeof(DynamicAOComponentData).GetProperty(nameof(HbaoPowerExponent));

				case 4195925987:
					return typeof(DynamicAOComponentData).GetProperty(nameof(HbaoContrast));

				case 312723150:
					return typeof(DynamicAOComponentData).GetProperty(nameof(HbaoMaxFootprintRadius));

				case 2342790116:
					return typeof(DynamicAOComponentData).GetProperty(nameof(Enable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
