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
	public class PlayerOrderTrackerData : 
		HudTrackerData
	{
		protected UIHudIcon m_AttackIcon = new UIHudIcon();
		[ContainerField(44), ContainerFieldNameHash(1150263942)]
		public UIHudIcon AttackIcon { get { return m_AttackIcon; } set { if (OnPropertyChanging("PlayerOrderTrackerData." + nameof(AttackIcon), this, m_AttackIcon, value)) m_AttackIcon = value; } } // 0x2C (44)
		
		protected UIHudIcon m_DefendIcon = new UIHudIcon();
		[ContainerField(48), ContainerFieldNameHash(2423818630)]
		public UIHudIcon DefendIcon { get { return m_DefendIcon; } set { if (OnPropertyChanging("PlayerOrderTrackerData." + nameof(DefendIcon), this, m_DefendIcon, value)) m_DefendIcon = value; } } // 0x30 (48)
		
		protected UIHudIcon m_MoveToIcon = new UIHudIcon();
		[ContainerField(52), ContainerFieldNameHash(2367850372)]
		public UIHudIcon MoveToIcon { get { return m_MoveToIcon; } set { if (OnPropertyChanging("PlayerOrderTrackerData." + nameof(MoveToIcon), this, m_MoveToIcon, value)) m_MoveToIcon = value; } } // 0x34 (52)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1150263942:
					AttackIcon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
					break;

				case 2423818630:
					DefendIcon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
					break;

				case 2367850372:
					MoveToIcon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
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
				case 1150263942:
					return AttackIcon;

				case 2423818630:
					return DefendIcon;

				case 2367850372:
					return MoveToIcon;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1150263942:
					return typeof(PlayerOrderTrackerData).GetProperty(nameof(AttackIcon));

				case 2423818630:
					return typeof(PlayerOrderTrackerData).GetProperty(nameof(DefendIcon));

				case 2367850372:
					return typeof(PlayerOrderTrackerData).GetProperty(nameof(MoveToIcon));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
