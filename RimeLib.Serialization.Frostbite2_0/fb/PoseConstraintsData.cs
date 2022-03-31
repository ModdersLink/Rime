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
	[ContainerType(1, 3)]
	public class PoseConstraintsData :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public bool StandPose { get; set; }
		
		[ContainerField(1), LayoutImmutable, Blittable, JsonProperty(Order = 1)]
		public bool CrouchPose { get; set; }
		
		[ContainerField(2), LayoutImmutable, Blittable, JsonProperty(Order = 2)]
		public bool PronePose { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(StandPose);
			p_Writer.Write(CrouchPose);
			p_Writer.Write(PronePose);
		}
	}
}
