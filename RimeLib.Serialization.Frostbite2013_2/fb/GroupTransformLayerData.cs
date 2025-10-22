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

namespace fb.Entity;

[ContainerType(8, 64)]
public class GroupTransformLayerData
	: fb.Entity.TransformLayerData
{
	public GroupTransformLayerData()
	{
		//TransformLayerData
		Blendtype = LayeredTransform_BlendType.LayeredTransform_BlendType_WorldOverride;
	}
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public RefArray<TransformLayerData> Children { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Children = p_EbxWriter.GetArrayWriter(Children.GetType(), Children.Count);
		p_Writer.Write(s_Children.ArrayIndex);
		foreach (var s_Entry in Children)
		{
			s_Children.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

