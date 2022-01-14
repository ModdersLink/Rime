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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 152)]
	public class GunSwayCrouchProneData :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public GunSwayBaseMoveData NoZoom { get; set; } = new();
		
		[ContainerField(76), JsonProperty(Order = 76)]
		public GunSwayBaseMoveData Zoom { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			NoZoom.Serialize(p_Writer, p_EbxWriter);
			Zoom.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
