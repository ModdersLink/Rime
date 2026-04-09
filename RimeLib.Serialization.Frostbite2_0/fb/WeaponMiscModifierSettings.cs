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
	[ContainerType(1, 5)]
	public partial class WeaponMiscModifierSettings :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private bool _EnableBreathControl;
		
		[ObservableProperty]
		[property: ContainerField(1), LayoutImmutable, Blittable, JsonProperty(Order = 1)]
		private bool _CanBeInSupportedShooting;
		
		[ObservableProperty]
		[property: ContainerField(2), LayoutImmutable, Blittable, JsonProperty(Order = 2)]
		private bool _UnZoomOnBoltAction;
		
		[ObservableProperty]
		[property: ContainerField(3), LayoutImmutable, Blittable, JsonProperty(Order = 3)]
		private bool _HoldBoltActionUntilZoomRelease;
		
		[ObservableProperty]
		[property: ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		private bool _IsSilenced;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(EnableBreathControl);
			p_Writer.Write(CanBeInSupportedShooting);
			p_Writer.Write(UnZoomOnBoltAction);
			p_Writer.Write(HoldBoltActionUntilZoomRelease);
			p_Writer.Write(IsSilenced);
		}
	}
}
