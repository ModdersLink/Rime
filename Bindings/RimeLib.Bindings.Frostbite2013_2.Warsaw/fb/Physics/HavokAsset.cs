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

namespace fb.Physics;

[ContainerType(8, 48)]
public class HavokAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<int> NumShapeKeysInContactPointProperties { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public ResourceRef Resource { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public RefArray<DataContainer> ExternalAssets { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_NumShapeKeysInContactPointProperties = p_EbxWriter.GetArrayWriter(NumShapeKeysInContactPointProperties.GetType(), NumShapeKeysInContactPointProperties.Count);
		p_Writer.Write(s_NumShapeKeysInContactPointProperties.ArrayIndex);
		foreach (var s_Entry in NumShapeKeysInContactPointProperties)
		{
			s_NumShapeKeysInContactPointProperties.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		Resource.Serialize(p_Writer);
		(RimeWriter Writer, uint ArrayIndex) s_ExternalAssets = p_EbxWriter.GetArrayWriter(ExternalAssets.GetType(), ExternalAssets.Count);
		p_Writer.Write(s_ExternalAssets.ArrayIndex);
		foreach (var s_Entry in ExternalAssets)
		{
			s_ExternalAssets.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

