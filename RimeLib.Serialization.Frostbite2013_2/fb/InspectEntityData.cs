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
using fb.GameShared;
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(16, 112)]
public class InspectEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public RefArray<TargetCameraData> Cameras { get; set; } = new();
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 CenterOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<InspectViewPointData> ViewPoints { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float MinLookAtHeight { get; set; } = 1.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float MaxLookAtHeight { get; set; } = 1.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float MinDistance { get; set; } = 1.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float MaxDistance { get; set; } = 3.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float ZoomScrollSpeed { get; set; } = 0.100f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float ZoomScrollAcceleration { get; set; } = 2.000f;
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public AntRef AnimationSignal { get; set; } = new();
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public string UIName { get; set; } = string.Empty;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Cameras = p_EbxWriter.GetArrayWriter(Cameras.GetType(), Cameras.Count);
		p_Writer.Write(s_Cameras.ArrayIndex);
		foreach (var s_Entry in Cameras)
		{
			s_Cameras.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		CenterOffset.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_ViewPoints = p_EbxWriter.GetArrayWriter(ViewPoints.GetType(), ViewPoints.Count);
		p_Writer.Write(s_ViewPoints.ArrayIndex);
		foreach (var s_Entry in ViewPoints)
		{
			s_Entry.Serialize(s_ViewPoints.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(MinLookAtHeight);
		p_Writer.Write(MaxLookAtHeight);
		p_Writer.Write(MinDistance);
		p_Writer.Write(MaxDistance);
		p_Writer.Write(ZoomScrollSpeed);
		p_Writer.Write(ZoomScrollAcceleration);
		AnimationSignal.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(UIName));
	}
}

