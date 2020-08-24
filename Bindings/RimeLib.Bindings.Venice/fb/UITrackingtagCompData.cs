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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class UITrackingtagCompData : 
		UI3dIconCompData
	{
		protected bool m_ShowUnlockedLockAlways = new bool();
		[ContainerField(160), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3902477869)]
		public bool ShowUnlockedLockAlways { get { return m_ShowUnlockedLockAlways; } set { if (OnPropertyChanging("UITrackingtagCompData." + nameof(ShowUnlockedLockAlways), this, m_ShowUnlockedLockAlways, value)) m_ShowUnlockedLockAlways = value; } } // 0xA0 (160)
		
		protected bool m_ShowUnlockedLockOnRadar = new bool();
		[ContainerField(161), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1593315801)]
		public bool ShowUnlockedLockOnRadar { get { return m_ShowUnlockedLockOnRadar; } set { if (OnPropertyChanging("UITrackingtagCompData." + nameof(ShowUnlockedLockOnRadar), this, m_ShowUnlockedLockOnRadar, value)) m_ShowUnlockedLockOnRadar = value; } } // 0xA1 (161)
		
		protected bool m_ShowUnlockedLockOnHeat = new bool();
		[ContainerField(162), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3692569061)]
		public bool ShowUnlockedLockOnHeat { get { return m_ShowUnlockedLockOnHeat; } set { if (OnPropertyChanging("UITrackingtagCompData." + nameof(ShowUnlockedLockOnHeat), this, m_ShowUnlockedLockOnHeat, value)) m_ShowUnlockedLockOnHeat = value; } } // 0xA2 (162)
		
		protected bool m_ShowUnlockedLockOnLaserPainted = new bool();
		[ContainerField(163), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3622611671)]
		public bool ShowUnlockedLockOnLaserPainted { get { return m_ShowUnlockedLockOnLaserPainted; } set { if (OnPropertyChanging("UITrackingtagCompData." + nameof(ShowUnlockedLockOnLaserPainted), this, m_ShowUnlockedLockOnLaserPainted, value)) m_ShowUnlockedLockOnLaserPainted = value; } } // 0xA3 (163)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3902477869:
					ShowUnlockedLockAlways = (bool) p_Value;
					break;

				case 1593315801:
					ShowUnlockedLockOnRadar = (bool) p_Value;
					break;

				case 3692569061:
					ShowUnlockedLockOnHeat = (bool) p_Value;
					break;

				case 3622611671:
					ShowUnlockedLockOnLaserPainted = (bool) p_Value;
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
				case 3902477869:
					return ShowUnlockedLockAlways;

				case 1593315801:
					return ShowUnlockedLockOnRadar;

				case 3692569061:
					return ShowUnlockedLockOnHeat;

				case 3622611671:
					return ShowUnlockedLockOnLaserPainted;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3902477869:
					return typeof(UITrackingtagCompData).GetProperty(nameof(ShowUnlockedLockAlways));

				case 1593315801:
					return typeof(UITrackingtagCompData).GetProperty(nameof(ShowUnlockedLockOnRadar));

				case 3692569061:
					return typeof(UITrackingtagCompData).GetProperty(nameof(ShowUnlockedLockOnHeat));

				case 3622611671:
					return typeof(UITrackingtagCompData).GetProperty(nameof(ShowUnlockedLockOnLaserPainted));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
