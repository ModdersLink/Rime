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
	[ContainerType(16, 80)]
	public partial class EnlightenInputInstance :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private LinearTransform _Transform = new();
		
		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, JsonProperty(Order = 64)]
		private string _Asset = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, JsonProperty(Order = 68)]
		private string _ObjectVariation = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private int _SystemId;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Transform.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Asset));
			p_Writer.Write(p_EbxWriter.WriteString(ObjectVariation));
			p_Writer.Write(SystemId);
			p_Writer.WriteNullBytes(4);
		}
	}
}
