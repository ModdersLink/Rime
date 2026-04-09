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
	[ContainerType(4, 100)]
	public partial class SupportedShootingCommonData :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private AimingConstraintsData _AimingConstraints = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private EntryInputActionEnum _EnterSupportedShootingAction = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private SupportedShootingBinding _Binding = new();

		[ObservableProperty]
		[property: ContainerField(68), JsonProperty(Order = 68)]
		private SupportedShootingProximityChecking _Stand = new();

		[ObservableProperty]
		[property: ContainerField(84), JsonProperty(Order = 84)]
		private SupportedShootingProximityChecking _Crouch = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			AimingConstraints.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) EnterSupportedShootingAction);
			Binding.Serialize(p_Writer, p_EbxWriter);
			Stand.Serialize(p_Writer, p_EbxWriter);
			Crouch.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
