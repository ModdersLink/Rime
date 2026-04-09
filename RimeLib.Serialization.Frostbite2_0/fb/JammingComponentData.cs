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
	[ContainerType(16, 176)]
	public partial class JammingComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private SmokeJammingData _SmokeJamming = new();

		[ObservableProperty]
		[property: ContainerField(116), JsonProperty(Order = 116)]
		private AirMissileJammingData _AirMissileJamming = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			SmokeJamming.Serialize(p_Writer, p_EbxWriter);
			AirMissileJamming.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(12);
		}
	}
}
