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

[ContainerType(8, 32)]
public class PropertySortScopeStageData
	: fb.Audio.SoundScopeStageData
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public uint Count { get; set; } = 0;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public ScopeStageSortProperty Property { get; set; } = ScopeStageSortProperty.ScopeStageSortProperty_DistanceToListener;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public PropertySortScopeStageOrder Order { get; set; } = PropertySortScopeStageOrder.PropertySortScopeStageOrder_Ascending;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Count);
		p_Writer.Write((int) Property);
		p_Writer.Write((int) Order);
		p_Writer.WriteNullBytes(4);
	}
}

