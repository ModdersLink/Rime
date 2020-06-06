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
	public class UINametag : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 TextColor { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float IconFadeDistance { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float IconMaxDistance { get; set; } // 0x24 (36)
		
		[ContainerField(40)]
		public UIHudIcon Icon { get; set; } = new UIHudIcon(); // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float TextFadeDistance { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float HealthFadeDistance { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float HealthMaxDistance { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float TextMaxDistance { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float TargetInTimer { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float TargetOutTimer { get; set; } // 0x40 (64)
		
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
