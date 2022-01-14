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
	[ContainerType(4, 36)]
	public class SupportedShootingBinding :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public AntRef Supported { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public AntRef SupportedPos { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public AntRef ForwardVector { get; set; } = new();
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public AntRef Yaw { get; set; } = new();
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public AntRef Pitch { get; set; } = new();
		
		[ContainerField(20), JsonProperty(Order = 20)]
		public AntRef DistToObject { get; set; } = new();
		
		[ContainerField(24), JsonProperty(Order = 24)]
		public AntRef HeightOfObject { get; set; } = new();
		
		[ContainerField(28), JsonProperty(Order = 28)]
		public AntRef Undeploying { get; set; } = new();
		
		[ContainerField(32), JsonProperty(Order = 32)]
		public AntRef AnimatedCamera { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Supported.Serialize(p_Writer, p_EbxWriter);
			SupportedPos.Serialize(p_Writer, p_EbxWriter);
			ForwardVector.Serialize(p_Writer, p_EbxWriter);
			Yaw.Serialize(p_Writer, p_EbxWriter);
			Pitch.Serialize(p_Writer, p_EbxWriter);
			DistToObject.Serialize(p_Writer, p_EbxWriter);
			HeightOfObject.Serialize(p_Writer, p_EbxWriter);
			Undeploying.Serialize(p_Writer, p_EbxWriter);
			AnimatedCamera.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
