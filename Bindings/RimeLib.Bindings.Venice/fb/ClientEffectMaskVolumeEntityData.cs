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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 128)]
	public class ClientEffectMaskVolumeEntityData : 
		GameEntityData
	{
		protected Vec4 m_ApplyEffectCurve = new Vec4();
		[ContainerField(Name: "ApplyEffectCurve", Offset: 96, NameHash: 2484955953, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 ApplyEffectCurve { get { return m_ApplyEffectCurve; } set { if (OnPropertyChanging("ClientEffectMaskVolumeEntityData." + nameof(ApplyEffectCurve), this, m_ApplyEffectCurve, value)) m_ApplyEffectCurve = value; } } // 0x60 (96)
		
		protected float m_LifeTimeInSeconds = new float();
		[ContainerField(Name: "LifeTimeInSeconds", Offset: 112, NameHash: 3163808466, Flags: 49469), LayoutImmutable, Blittable]
		public float LifeTimeInSeconds { get { return m_LifeTimeInSeconds; } set { if (OnPropertyChanging("ClientEffectMaskVolumeEntityData." + nameof(LifeTimeInSeconds), this, m_LifeTimeInSeconds, value)) m_LifeTimeInSeconds = value; } } // 0x70 (112)
		
		protected float m_UpdatePeriodInSeconds = new float();
		[ContainerField(Name: "UpdatePeriodInSeconds", Offset: 116, NameHash: 1890008213, Flags: 49469), LayoutImmutable, Blittable]
		public float UpdatePeriodInSeconds { get { return m_UpdatePeriodInSeconds; } set { if (OnPropertyChanging("ClientEffectMaskVolumeEntityData." + nameof(UpdatePeriodInSeconds), this, m_UpdatePeriodInSeconds, value)) m_UpdatePeriodInSeconds = value; } } // 0x74 (116)
		
		protected float m_Radius = new float();
		[ContainerField(Name: "Radius", Offset: 120, NameHash: 3298407133, Flags: 49469), LayoutImmutable, Blittable]
		public float Radius { get { return m_Radius; } set { if (OnPropertyChanging("ClientEffectMaskVolumeEntityData." + nameof(Radius), this, m_Radius, value)) m_Radius = value; } } // 0x78 (120)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2484955953:
					ApplyEffectCurve = (Vec4) p_Value;
					break;

				case 3163808466:
					LifeTimeInSeconds = (float) p_Value;
					break;

				case 1890008213:
					UpdatePeriodInSeconds = (float) p_Value;
					break;

				case 3298407133:
					Radius = (float) p_Value;
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
				case 2484955953:
					return ApplyEffectCurve;

				case 3163808466:
					return LifeTimeInSeconds;

				case 1890008213:
					return UpdatePeriodInSeconds;

				case 3298407133:
					return Radius;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2484955953:
					return typeof(ClientEffectMaskVolumeEntityData).GetProperty(nameof(ApplyEffectCurve));

				case 3163808466:
					return typeof(ClientEffectMaskVolumeEntityData).GetProperty(nameof(LifeTimeInSeconds));

				case 1890008213:
					return typeof(ClientEffectMaskVolumeEntityData).GetProperty(nameof(UpdatePeriodInSeconds));

				case 3298407133:
					return typeof(ClientEffectMaskVolumeEntityData).GetProperty(nameof(Radius));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
