///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 164)]
	public class UITrackingtagCompData : 
		UI3dIconCompData
	{
		[ContainerField(160), LayoutImmutable, Blittable]
		public bool ShowUnlockedLockAlways { get; set; }

		[ContainerField(161), LayoutImmutable, Blittable]
		public bool ShowUnlockedLockOnRadar { get; set; }

		[ContainerField(162), LayoutImmutable, Blittable]
		public bool ShowUnlockedLockOnHeat { get; set; }

		[ContainerField(163), LayoutImmutable, Blittable]
		public bool ShowUnlockedLockOnLaserPainted { get; set; }

		public static void Deserialize(UITrackingtagCompData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ShowUnlockedLockAlways = p_Reader.ReadBool();
			p_Instance.ShowUnlockedLockOnRadar = p_Reader.ReadBool();
			p_Instance.ShowUnlockedLockOnHeat = p_Reader.ReadBool();
			p_Instance.ShowUnlockedLockOnLaserPainted = p_Reader.ReadBool();
		}

	}
}
