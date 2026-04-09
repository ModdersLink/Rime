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
	[ContainerType(4, 32)]
	public partial class DebugConstantData :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _BotDebugDistance;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _InViewModeFOV;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private uint _GraphDataBuffer;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _MinDecisionTime;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private bool _InaccuracyEnabled;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(BotDebugDistance);
			p_Writer.Write(InViewModeFOV);
			p_Writer.Write(GraphDataBuffer);
			p_Writer.Write(MinDecisionTime);
			p_Writer.Write(InaccuracyEnabled);
			p_Writer.WriteNullBytes(3);
		}
	}
}
