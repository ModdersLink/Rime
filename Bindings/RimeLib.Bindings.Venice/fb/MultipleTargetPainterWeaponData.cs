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
	[ContainerType(4)]
	public class MultipleTargetPainterWeaponData : 
		WeaponData
	{
		protected SpottingType m_SpottingBehavior = new SpottingType();
		[ContainerField(16), ContainerFieldNameHash(3595491045)]
		public SpottingType SpottingBehavior { get { return m_SpottingBehavior; } set { if (OnPropertyChanging("MultipleTargetPainterWeaponData." + nameof(SpottingBehavior), this, m_SpottingBehavior, value)) m_SpottingBehavior = value; } } // 0x10 (16)
		
		protected float m_TimeObjectIsPainted = new float();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(641195484)]
		public float TimeObjectIsPainted { get { return m_TimeObjectIsPainted; } set { if (OnPropertyChanging("MultipleTargetPainterWeaponData." + nameof(TimeObjectIsPainted), this, m_TimeObjectIsPainted, value)) m_TimeObjectIsPainted = value; } } // 0x14 (20)
		
		protected float m_Angle = new float();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(205597860)]
		public float Angle { get { return m_Angle; } set { if (OnPropertyChanging("MultipleTargetPainterWeaponData." + nameof(Angle), this, m_Angle, value)) m_Angle = value; } } // 0x18 (24)
		
		protected float m_TimeObjectIsSpotted = new float();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(3440952178)]
		public float TimeObjectIsSpotted { get { return m_TimeObjectIsSpotted; } set { if (OnPropertyChanging("MultipleTargetPainterWeaponData." + nameof(TimeObjectIsSpotted), this, m_TimeObjectIsSpotted, value)) m_TimeObjectIsSpotted = value; } } // 0x1C (28)
		
		protected float m_Range = new float();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(230112826)]
		public float Range { get { return m_Range; } set { if (OnPropertyChanging("MultipleTargetPainterWeaponData." + nameof(Range), this, m_Range, value)) m_Range = value; } } // 0x20 (32)
		
		protected bool m_UseSpotting = new bool();
		[ContainerField(36), LayoutImmutable, Blittable, ContainerFieldNameHash(3045673834)]
		public bool UseSpotting { get { return m_UseSpotting; } set { if (OnPropertyChanging("MultipleTargetPainterWeaponData." + nameof(UseSpotting), this, m_UseSpotting, value)) m_UseSpotting = value; } } // 0x24 (36)
		
		protected bool m_UseLaserPainting = new bool();
		[ContainerField(37), LayoutImmutable, Blittable, ContainerFieldNameHash(952732621)]
		public bool UseLaserPainting { get { return m_UseLaserPainting; } set { if (OnPropertyChanging("MultipleTargetPainterWeaponData." + nameof(UseLaserPainting), this, m_UseLaserPainting, value)) m_UseLaserPainting = value; } } // 0x25 (37)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3595491045:
					SpottingBehavior = (SpottingType) Enum.ToObject(typeof(SpottingType), p_Value);
					break;

				case 641195484:
					TimeObjectIsPainted = (float) p_Value;
					break;

				case 205597860:
					Angle = (float) p_Value;
					break;

				case 3440952178:
					TimeObjectIsSpotted = (float) p_Value;
					break;

				case 230112826:
					Range = (float) p_Value;
					break;

				case 3045673834:
					UseSpotting = (bool) p_Value;
					break;

				case 952732621:
					UseLaserPainting = (bool) p_Value;
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
				case 3595491045:
					return SpottingBehavior;

				case 641195484:
					return TimeObjectIsPainted;

				case 205597860:
					return Angle;

				case 3440952178:
					return TimeObjectIsSpotted;

				case 230112826:
					return Range;

				case 3045673834:
					return UseSpotting;

				case 952732621:
					return UseLaserPainting;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3595491045:
					return typeof(MultipleTargetPainterWeaponData).GetProperty(nameof(SpottingBehavior));

				case 641195484:
					return typeof(MultipleTargetPainterWeaponData).GetProperty(nameof(TimeObjectIsPainted));

				case 205597860:
					return typeof(MultipleTargetPainterWeaponData).GetProperty(nameof(Angle));

				case 3440952178:
					return typeof(MultipleTargetPainterWeaponData).GetProperty(nameof(TimeObjectIsSpotted));

				case 230112826:
					return typeof(MultipleTargetPainterWeaponData).GetProperty(nameof(Range));

				case 3045673834:
					return typeof(MultipleTargetPainterWeaponData).GetProperty(nameof(UseSpotting));

				case 952732621:
					return typeof(MultipleTargetPainterWeaponData).GetProperty(nameof(UseLaserPainting));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
