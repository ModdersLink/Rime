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
	public class UINametagCompData : 
		UI3dIconCompData
	{
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 SquadTint { get; set; } = new Vec4(); // 0xA0 (160)
		
		[ContainerField(176), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 EnemyTint { get; set; } = new Vec4(); // 0xB0 (176)
		
		[ContainerField(192), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 FriendlyTint { get; set; } = new Vec4(); // 0xC0 (192)
		
		[ContainerField(208), LayoutImmutable, Blittable]
		public int OrderCooldown { get; set; } // 0xD0 (208)
		
		[ContainerField(212), LayoutImmutable, Blittable]
		public int TooltipCooldown { get; set; } // 0xD4 (212)
		
		[ContainerField(216), LayoutImmutable, Blittable]
		public float HealthBarSize { get; set; } // 0xD8 (216)
		
		[ContainerField(220), LayoutImmutable, Blittable]
		public float NameFontSize { get; set; } // 0xDC (220)
		
		[ContainerField(224), LayoutImmutable, Blittable]
		public float NameGlowSize { get; set; } // 0xE0 (224)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1279667216:
					SquadTint = (Vec4) p_Value;
					break;

				case 1877107960:
					EnemyTint = (Vec4) p_Value;
					break;

				case 3885116261:
					FriendlyTint = (Vec4) p_Value;
					break;

				case 913984022:
					OrderCooldown = (int) p_Value;
					break;

				case 4214670893:
					TooltipCooldown = (int) p_Value;
					break;

				case 89080141:
					HealthBarSize = (float) p_Value;
					break;

				case 1804567924:
					NameFontSize = (float) p_Value;
					break;

				case 2750852340:
					NameGlowSize = (float) p_Value;
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
				case 1279667216:
					return SquadTint;

				case 1877107960:
					return EnemyTint;

				case 3885116261:
					return FriendlyTint;

				case 913984022:
					return OrderCooldown;

				case 4214670893:
					return TooltipCooldown;

				case 89080141:
					return HealthBarSize;

				case 1804567924:
					return NameFontSize;

				case 2750852340:
					return NameGlowSize;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1279667216:
					return typeof(UINametagCompData).GetProperty(nameof(SquadTint));

				case 1877107960:
					return typeof(UINametagCompData).GetProperty(nameof(EnemyTint));

				case 3885116261:
					return typeof(UINametagCompData).GetProperty(nameof(FriendlyTint));

				case 913984022:
					return typeof(UINametagCompData).GetProperty(nameof(OrderCooldown));

				case 4214670893:
					return typeof(UINametagCompData).GetProperty(nameof(TooltipCooldown));

				case 89080141:
					return typeof(UINametagCompData).GetProperty(nameof(HealthBarSize));

				case 1804567924:
					return typeof(UINametagCompData).GetProperty(nameof(NameFontSize));

				case 2750852340:
					return typeof(UINametagCompData).GetProperty(nameof(NameGlowSize));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
