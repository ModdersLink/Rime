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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 164)]
	public partial class UITrackingtagCompData :
		UI3dIconCompData
	{
		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private bool _ShowUnlockedLockAlways;

		[ObservableProperty]
		[property: ContainerField(161), LayoutImmutable, Blittable, JsonProperty(Order = 161)]
		private bool _ShowUnlockedLockOnRadar;

		[ObservableProperty]
		[property: ContainerField(162), LayoutImmutable, Blittable, JsonProperty(Order = 162)]
		private bool _ShowUnlockedLockOnHeat;

		[ObservableProperty]
		[property: ContainerField(163), LayoutImmutable, Blittable, JsonProperty(Order = 163)]
		private bool _ShowUnlockedLockOnLaserPainted;

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
