///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class UITrackingtagCompData : 
		UI3dIconCompData
	{
		[ContainerField(160), LayoutImmutable, Blittable]
		public bool ShowUnlockedLockAlways { get; set; } // 0xA0 (160)
		
		[ContainerField(161), LayoutImmutable, Blittable]
		public bool ShowUnlockedLockOnRadar { get; set; } // 0xA1 (161)
		
		[ContainerField(162), LayoutImmutable, Blittable]
		public bool ShowUnlockedLockOnHeat { get; set; } // 0xA2 (162)
		
		[ContainerField(163), LayoutImmutable, Blittable]
		public bool ShowUnlockedLockOnLaserPainted { get; set; } // 0xA3 (163)
		
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
