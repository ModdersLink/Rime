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
	[ContainerType(16, 144)]
	public class ClimbLadderComponentData :
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public int ClimbPhase { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public int ConnectPhase { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float ConnectJointDisplacement { get; set; }

		[ContainerField(108), JsonProperty(Order = 108)]
		public ClimbLadderBinding Binding { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ClimbPhase);
			p_Writer.Write(ConnectPhase);
			p_Writer.Write(ConnectJointDisplacement);
			Binding.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(12);
		}
	}
}
