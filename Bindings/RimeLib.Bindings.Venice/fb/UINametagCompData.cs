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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 240)]
	public class UINametagCompData : 
		UI3dIconCompData
	{
		protected Vec4 m_SquadTint = new Vec4();
		[ContainerField(Name: "SquadTint", Offset: 160, NameHash: 1279667216, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 SquadTint { get { return m_SquadTint; } set { if (OnPropertyChanging("UINametagCompData." + nameof(SquadTint), this, m_SquadTint, value)) m_SquadTint = value; } } // 0xA0 (160)
		
		protected Vec4 m_EnemyTint = new Vec4();
		[ContainerField(Name: "EnemyTint", Offset: 176, NameHash: 1877107960, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 EnemyTint { get { return m_EnemyTint; } set { if (OnPropertyChanging("UINametagCompData." + nameof(EnemyTint), this, m_EnemyTint, value)) m_EnemyTint = value; } } // 0xB0 (176)
		
		protected Vec4 m_FriendlyTint = new Vec4();
		[ContainerField(Name: "FriendlyTint", Offset: 192, NameHash: 3885116261, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 FriendlyTint { get { return m_FriendlyTint; } set { if (OnPropertyChanging("UINametagCompData." + nameof(FriendlyTint), this, m_FriendlyTint, value)) m_FriendlyTint = value; } } // 0xC0 (192)
		
		protected int m_OrderCooldown = new int();
		[ContainerField(Name: "OrderCooldown", Offset: 208, NameHash: 913984022, Flags: 49405), LayoutImmutable, Blittable]
		public int OrderCooldown { get { return m_OrderCooldown; } set { if (OnPropertyChanging("UINametagCompData." + nameof(OrderCooldown), this, m_OrderCooldown, value)) m_OrderCooldown = value; } } // 0xD0 (208)
		
		protected int m_TooltipCooldown = new int();
		[ContainerField(Name: "TooltipCooldown", Offset: 212, NameHash: 4214670893, Flags: 49405), LayoutImmutable, Blittable]
		public int TooltipCooldown { get { return m_TooltipCooldown; } set { if (OnPropertyChanging("UINametagCompData." + nameof(TooltipCooldown), this, m_TooltipCooldown, value)) m_TooltipCooldown = value; } } // 0xD4 (212)
		
		protected float m_HealthBarSize = new float();
		[ContainerField(Name: "HealthBarSize", Offset: 216, NameHash: 89080141, Flags: 49469), LayoutImmutable, Blittable]
		public float HealthBarSize { get { return m_HealthBarSize; } set { if (OnPropertyChanging("UINametagCompData." + nameof(HealthBarSize), this, m_HealthBarSize, value)) m_HealthBarSize = value; } } // 0xD8 (216)
		
		protected float m_NameFontSize = new float();
		[ContainerField(Name: "NameFontSize", Offset: 220, NameHash: 1804567924, Flags: 49469), LayoutImmutable, Blittable]
		public float NameFontSize { get { return m_NameFontSize; } set { if (OnPropertyChanging("UINametagCompData." + nameof(NameFontSize), this, m_NameFontSize, value)) m_NameFontSize = value; } } // 0xDC (220)
		
		protected float m_NameGlowSize = new float();
		[ContainerField(Name: "NameGlowSize", Offset: 224, NameHash: 2750852340, Flags: 49469), LayoutImmutable, Blittable]
		public float NameGlowSize { get { return m_NameGlowSize; } set { if (OnPropertyChanging("UINametagCompData." + nameof(NameGlowSize), this, m_NameGlowSize, value)) m_NameGlowSize = value; } } // 0xE0 (224)
		
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
