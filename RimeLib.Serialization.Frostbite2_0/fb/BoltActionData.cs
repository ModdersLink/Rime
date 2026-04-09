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
	public partial class BoltActionData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private float _BoltActionDelay;
		
		[ObservableProperty]
		[property: ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		private float _BoltActionTime;
		
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private bool _HoldBoltActionUntilFireRelease;
		
		[ObservableProperty]
		[property: ContainerField(9), LayoutImmutable, Blittable, JsonProperty(Order = 9)]
		private bool _HoldBoltActionUntilZoomRelease;
		
		[ObservableProperty]
		[property: ContainerField(10), LayoutImmutable, Blittable, JsonProperty(Order = 10)]
		private bool _ForceBoltActionOnFireTrigger;
		
		[ObservableProperty]
		[property: ContainerField(11), LayoutImmutable, Blittable, JsonProperty(Order = 11)]
		private bool _UnZoomOnBoltAction;
		
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private bool _ReturnToZoomAfterBoltAction;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(BoltActionDelay);
			p_Writer.Write(BoltActionTime);
			p_Writer.Write(HoldBoltActionUntilFireRelease);
			p_Writer.Write(HoldBoltActionUntilZoomRelease);
			p_Writer.Write(ForceBoltActionOnFireTrigger);
			p_Writer.Write(UnZoomOnBoltAction);
			p_Writer.Write(ReturnToZoomAfterBoltAction);
			p_Writer.WriteNullBytes(3);
		}
	}
}
