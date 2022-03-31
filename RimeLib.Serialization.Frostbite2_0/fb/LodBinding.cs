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
	[ContainerType(4, 12)]
	public class LodBinding :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public AntRef DisableControllerUpdate { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public AntRef DisablePoseUpdate { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public AntRef DistanceFromCamera { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			DisableControllerUpdate.Serialize(p_Writer, p_EbxWriter);
			DisablePoseUpdate.Serialize(p_Writer, p_EbxWriter);
			DistanceFromCamera.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
