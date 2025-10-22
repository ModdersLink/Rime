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

namespace fb.GameShared;

[ContainerType(8, 32)]
public class SoldierMovementSequenceData
	: fb.GameShared.MovementActionData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public CtrRef<RecordedInputData> RecordedInput { get; set; } = new();
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public int InputRecordingIndex { get; set; } = 1;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public bool IgnoreRecordingIndexFilter { get; set; } = false;
	
	[ContainerField(0x1d), LayoutImmutable, Blittable, JsonProperty(Order = 29)]
	public bool ReportWhenFinished { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(RecordedInput));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(InputRecordingIndex);
		p_Writer.Write(IgnoreRecordingIndexFilter);
		p_Writer.Write(ReportWhenFinished);
		p_Writer.WriteNullBytes(2);
	}
}

