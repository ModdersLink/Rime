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

namespace fb.Audio;

[ContainerType(8, 56)]
public class OrientationNodeData
	: fb.Audio.AudioGraphNodeData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public AudioGraphNodePort ListenerRelativeYaw { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AudioGraphNodePort ListenerRelativePitch { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public AudioGraphNodePort ListenerRelativeRoll { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public AudioGraphNodePort TowardsListenerAngle { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public AudioGraphNodePort ListenerAngularVelocity { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		ListenerRelativeYaw.Serialize(p_Writer, p_EbxWriter);
		ListenerRelativePitch.Serialize(p_Writer, p_EbxWriter);
		ListenerRelativeRoll.Serialize(p_Writer, p_EbxWriter);
		TowardsListenerAngle.Serialize(p_Writer, p_EbxWriter);
		ListenerAngularVelocity.Serialize(p_Writer, p_EbxWriter);
	}
}

