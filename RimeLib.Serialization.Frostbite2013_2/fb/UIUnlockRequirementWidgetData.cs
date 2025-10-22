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

using fb.GameShared;
using fb.Core;
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(16, 144)]
public class UIUnlockRequirementWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<BFUIElement3SliceStatbarStyle> StatbarStyle { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public UIElementColor ProgressionColor { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(StatbarStyle));
		p_Writer.WriteNullBytes(4);
		ProgressionColor.Serialize(p_Writer, p_EbxWriter);
	}
}

