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

using fb.Entity;
using fb.Core;

namespace fb.GameShared;

[ContainerType(16, 128)]
public class CharacterCameraComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public RefArray<TargetCameraData> Cameras { get; set; } = new();
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public CharacterCameraForwardAxis CameraForwardAxis { get; set; } = CharacterCameraForwardAxis.CharacterCameraForwardAxis_ZAxis;
	
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
		p_Writer.Write((int) CameraForwardAxis);
		p_Writer.WriteNullBytes(4);
	}
}

