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

using fb.Core;
using fb.Ant;

namespace fb.GameShared;

[ContainerType(8, 56)]
public class AnimatedPoseTransition
	: fb.GameShared.PoseTransitionBase
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AntRef TransitionAnimation { get; set; } = new();
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float AnimationBlendInTime { get; set; } = -1.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float TransitionAnimationDuration { get; set; } = 0.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		TransitionAnimation.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(AnimationBlendInTime);
		p_Writer.Write(TransitionAnimationDuration);
		p_Writer.WriteNullBytes(4);
	}
}

