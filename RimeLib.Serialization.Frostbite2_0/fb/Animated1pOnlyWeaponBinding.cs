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

namespace fb
{
	[ContainerType(4, 16)]
	public class Animated1pOnlyWeaponBinding :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public AntRef UndeployFinished { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public AntRef CameraFreeWeight { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public AntRef Deploy1P { get; set; } = new();
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public AntRef HideWeapon1p { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			UndeployFinished.Serialize(p_Writer, p_EbxWriter);
			CameraFreeWeight.Serialize(p_Writer, p_EbxWriter);
			Deploy1P.Serialize(p_Writer, p_EbxWriter);
			HideWeapon1p.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
