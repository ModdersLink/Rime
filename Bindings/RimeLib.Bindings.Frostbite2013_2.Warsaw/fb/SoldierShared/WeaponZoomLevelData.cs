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
using fb.GameShared;

namespace fb.SoldierShared;

[ContainerType(8, 80)]
public class WeaponZoomLevelData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float RenderFov { get; set; } = 55.000f;
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<FOVTransitionData> RenderFovTransition { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<float> ZoomInOutMeshTransitionFactors { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float ZoomDisabledTransitionTimer { get; set; } = 0.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public SightType SightType { get; set; } = fb.SoldierShared.SightType.SightType_None;
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public WeaponAnimationSettingsData AnimationSettings { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(RenderFov);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(RenderFovTransition));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ZoomInOutMeshTransitionFactors = p_EbxWriter.GetArrayWriter(ZoomInOutMeshTransitionFactors.GetType(), ZoomInOutMeshTransitionFactors.Count);
		p_Writer.Write(s_ZoomInOutMeshTransitionFactors.ArrayIndex);
		foreach (var s_Entry in ZoomInOutMeshTransitionFactors)
		{
			s_ZoomInOutMeshTransitionFactors.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ZoomDisabledTransitionTimer);
		p_Writer.Write((int) SightType);
		AnimationSettings.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
	}
}

