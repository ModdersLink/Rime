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
	[ContainerType(4, 16)]
	public partial class WeaponMiscModifier :
		WeaponModifierBase
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private bool _EnableBreathControl;

		[ObservableProperty]
		[property: ContainerField(9), LayoutImmutable, Blittable, JsonProperty(Order = 9)]
		private bool _CanBeInSupportedShooting;

		[ObservableProperty]
		[property: ContainerField(10), LayoutImmutable, Blittable, JsonProperty(Order = 10)]
		private bool _UnZoomOnBoltAction;

		[ObservableProperty]
		[property: ContainerField(11), LayoutImmutable, Blittable, JsonProperty(Order = 11)]
		private bool _HoldBoltActionUntilZoomRelease;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private bool _IsSilenced;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(EnableBreathControl);
			p_Writer.Write(CanBeInSupportedShooting);
			p_Writer.Write(UnZoomOnBoltAction);
			p_Writer.Write(HoldBoltActionUntilZoomRelease);
			p_Writer.Write(IsSilenced);
			p_Writer.WriteNullBytes(3);
		}
	}
}
