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
	public class DynamicAOComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public Realm Realm { get; set; } = new Realm(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float SsaoMaxDistanceOuter { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float SsaoFade { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float SsaoRadius { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float SsaoMaxDistanceInner { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float HbaoRadius { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float HbaoAttenuation { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public float HbaoAngleBias { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float HbaoPowerExponent { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float HbaoContrast { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public float HbaoMaxFootprintRadius { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x8C (140)
		
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
