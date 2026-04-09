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
	[ContainerType(1, 3)]
	public partial class SoundGraphPluginRef :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private bool _IsValid;
		
		[ObservableProperty]
		[property: ContainerField(1), LayoutImmutable, Blittable, JsonProperty(Order = 1)]
		private sbyte _VoiceIndex;
		
		[ObservableProperty]
		[property: ContainerField(2), LayoutImmutable, Blittable, JsonProperty(Order = 2)]
		private sbyte _PluginIndex;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(IsValid);
			p_Writer.Write(VoiceIndex);
			p_Writer.Write(PluginIndex);
		}
	}
}
