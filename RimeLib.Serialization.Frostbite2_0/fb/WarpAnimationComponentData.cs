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
	[ContainerType(16, 240)]
	public class WarpAnimationComponentData :
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public LinearTransform ConnectTransform { get; set; } = new();

		[ContainerField(160), JsonProperty(Order = 160)]
		public CannedAnimationBinding CannedAnimBinding { get; set; } = new();

		[ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		public int AnimationEntitySpacePriority { get; set; }

		[ContainerField(204), JsonProperty(Order = 204)]
		public WarpAnimationBinding WarpBinding { get; set; } = new();

		[ContainerField(224), JsonProperty(Order = 224)]
		public GameplayBones BoneToAlign { get; set; } = new();

		[ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		public bool RequireAnimationWeight { get; set; }

		[ContainerField(229), LayoutImmutable, Blittable, JsonProperty(Order = 229)]
		public bool ForceAnimationTransform { get; set; }

		[ContainerField(230), LayoutImmutable, Blittable, JsonProperty(Order = 230)]
		public bool ExternalConnectTransform { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			ConnectTransform.Serialize(p_Writer, p_EbxWriter);
			CannedAnimBinding.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(AnimationEntitySpacePriority);
			WarpBinding.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) BoneToAlign);
			p_Writer.Write(RequireAnimationWeight);
			p_Writer.Write(ForceAnimationTransform);
			p_Writer.Write(ExternalConnectTransform);
			p_Writer.WriteNullBytes(9);
		}
	}
}
