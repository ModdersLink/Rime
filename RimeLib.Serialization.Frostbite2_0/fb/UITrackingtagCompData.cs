///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 164)]
	public class UITrackingtagCompData :
		UI3dIconCompData
	{
		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public bool ShowUnlockedLockAlways { get; set; }

		[ContainerField(161), LayoutImmutable, Blittable, JsonProperty(Order = 161)]
		public bool ShowUnlockedLockOnRadar { get; set; }

		[ContainerField(162), LayoutImmutable, Blittable, JsonProperty(Order = 162)]
		public bool ShowUnlockedLockOnHeat { get; set; }

		[ContainerField(163), LayoutImmutable, Blittable, JsonProperty(Order = 163)]
		public bool ShowUnlockedLockOnLaserPainted { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ShowUnlockedLockAlways);
			p_Writer.Write(ShowUnlockedLockOnRadar);
			p_Writer.Write(ShowUnlockedLockOnHeat);
			p_Writer.Write(ShowUnlockedLockOnLaserPainted);
		}
	}
}
