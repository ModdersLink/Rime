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
	[ContainerType(4, 280)]
	public partial class GunSwayStandData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private GunSwayBaseMoveJumpData _NoZoom = new();
		
		[ObservableProperty]
		[property: ContainerField(140), JsonProperty(Order = 140)]
		private GunSwayBaseMoveJumpData _Zoom = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			NoZoom.Serialize(p_Writer, p_EbxWriter);
			Zoom.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
