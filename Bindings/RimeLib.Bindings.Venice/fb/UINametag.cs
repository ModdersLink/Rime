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
	[ContainerType(16)]
	public class UINametag : 
		DataContainer
	{
		protected Vec3 m_TextColor = new Vec3();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2527550245)]
		public Vec3 TextColor { get { return m_TextColor; } set { if (OnPropertyChanging("UINametag." + nameof(TextColor), this, m_TextColor, value)) m_TextColor = value; } } // 0x10 (16)
		
		protected float m_IconFadeDistance = new float();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(1271959627)]
		public float IconFadeDistance { get { return m_IconFadeDistance; } set { if (OnPropertyChanging("UINametag." + nameof(IconFadeDistance), this, m_IconFadeDistance, value)) m_IconFadeDistance = value; } } // 0x20 (32)
		
		protected float m_IconMaxDistance = new float();
		[ContainerField(36), LayoutImmutable, Blittable, ContainerFieldNameHash(3794322777)]
		public float IconMaxDistance { get { return m_IconMaxDistance; } set { if (OnPropertyChanging("UINametag." + nameof(IconMaxDistance), this, m_IconMaxDistance, value)) m_IconMaxDistance = value; } } // 0x24 (36)
		
		protected UIHudIcon m_Icon = new UIHudIcon();
		[ContainerField(40), ContainerFieldNameHash(2088920302)]
		public UIHudIcon Icon { get { return m_Icon; } set { if (OnPropertyChanging("UINametag." + nameof(Icon), this, m_Icon, value)) m_Icon = value; } } // 0x28 (40)
		
		protected float m_TextFadeDistance = new float();
		[ContainerField(44), LayoutImmutable, Blittable, ContainerFieldNameHash(2771100253)]
		public float TextFadeDistance { get { return m_TextFadeDistance; } set { if (OnPropertyChanging("UINametag." + nameof(TextFadeDistance), this, m_TextFadeDistance, value)) m_TextFadeDistance = value; } } // 0x2C (44)
		
		protected float m_HealthFadeDistance = new float();
		[ContainerField(48), LayoutImmutable, Blittable, ContainerFieldNameHash(3613363196)]
		public float HealthFadeDistance { get { return m_HealthFadeDistance; } set { if (OnPropertyChanging("UINametag." + nameof(HealthFadeDistance), this, m_HealthFadeDistance, value)) m_HealthFadeDistance = value; } } // 0x30 (48)
		
		protected float m_HealthMaxDistance = new float();
		[ContainerField(52), LayoutImmutable, Blittable, ContainerFieldNameHash(2811802830)]
		public float HealthMaxDistance { get { return m_HealthMaxDistance; } set { if (OnPropertyChanging("UINametag." + nameof(HealthMaxDistance), this, m_HealthMaxDistance, value)) m_HealthMaxDistance = value; } } // 0x34 (52)
		
		protected float m_TextMaxDistance = new float();
		[ContainerField(56), LayoutImmutable, Blittable, ContainerFieldNameHash(3993118095)]
		public float TextMaxDistance { get { return m_TextMaxDistance; } set { if (OnPropertyChanging("UINametag." + nameof(TextMaxDistance), this, m_TextMaxDistance, value)) m_TextMaxDistance = value; } } // 0x38 (56)
		
		protected float m_TargetInTimer = new float();
		[ContainerField(60), LayoutImmutable, Blittable, ContainerFieldNameHash(956843572)]
		public float TargetInTimer { get { return m_TargetInTimer; } set { if (OnPropertyChanging("UINametag." + nameof(TargetInTimer), this, m_TargetInTimer, value)) m_TargetInTimer = value; } } // 0x3C (60)
		
		protected float m_TargetOutTimer = new float();
		[ContainerField(64), LayoutImmutable, Blittable, ContainerFieldNameHash(1911827965)]
		public float TargetOutTimer { get { return m_TargetOutTimer; } set { if (OnPropertyChanging("UINametag." + nameof(TargetOutTimer), this, m_TargetOutTimer, value)) m_TargetOutTimer = value; } } // 0x40 (64)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2527550245:
					TextColor = (Vec3) p_Value;
					break;

				case 1271959627:
					IconFadeDistance = (float) p_Value;
					break;

				case 3794322777:
					IconMaxDistance = (float) p_Value;
					break;

				case 2088920302:
					Icon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
					break;

				case 2771100253:
					TextFadeDistance = (float) p_Value;
					break;

				case 3613363196:
					HealthFadeDistance = (float) p_Value;
					break;

				case 2811802830:
					HealthMaxDistance = (float) p_Value;
					break;

				case 3993118095:
					TextMaxDistance = (float) p_Value;
					break;

				case 956843572:
					TargetInTimer = (float) p_Value;
					break;

				case 1911827965:
					TargetOutTimer = (float) p_Value;
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
				case 2527550245:
					return TextColor;

				case 1271959627:
					return IconFadeDistance;

				case 3794322777:
					return IconMaxDistance;

				case 2088920302:
					return Icon;

				case 2771100253:
					return TextFadeDistance;

				case 3613363196:
					return HealthFadeDistance;

				case 2811802830:
					return HealthMaxDistance;

				case 3993118095:
					return TextMaxDistance;

				case 956843572:
					return TargetInTimer;

				case 1911827965:
					return TargetOutTimer;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2527550245:
					return typeof(UINametag).GetProperty(nameof(TextColor));

				case 1271959627:
					return typeof(UINametag).GetProperty(nameof(IconFadeDistance));

				case 3794322777:
					return typeof(UINametag).GetProperty(nameof(IconMaxDistance));

				case 2088920302:
					return typeof(UINametag).GetProperty(nameof(Icon));

				case 2771100253:
					return typeof(UINametag).GetProperty(nameof(TextFadeDistance));

				case 3613363196:
					return typeof(UINametag).GetProperty(nameof(HealthFadeDistance));

				case 2811802830:
					return typeof(UINametag).GetProperty(nameof(HealthMaxDistance));

				case 3993118095:
					return typeof(UINametag).GetProperty(nameof(TextMaxDistance));

				case 956843572:
					return typeof(UINametag).GetProperty(nameof(TargetInTimer));

				case 1911827965:
					return typeof(UINametag).GetProperty(nameof(TargetOutTimer));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
