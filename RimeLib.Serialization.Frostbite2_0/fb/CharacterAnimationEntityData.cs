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
	[ContainerType(16, 112)]
	public class CharacterAnimationEntityData :
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public LinearTransform EntitySpaceTransform { get; set; } = new();

		[ContainerField(80), JsonProperty(Order = 80)]
		public AntRef Controller { get; set; } = new();

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public float TrackLength { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public float ExternalTime { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public float WarpAnimationBlendTime { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public bool RestoreControllerOnFinish { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(4);
			EntitySpaceTransform.Serialize(p_Writer, p_EbxWriter);
			Controller.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(TrackLength);
			p_Writer.Write(ExternalTime);
			p_Writer.Write(WarpAnimationBlendTime);
			p_Writer.Write(RestoreControllerOnFinish);
			p_Writer.WriteNullBytes(15);
		}
	}
}
