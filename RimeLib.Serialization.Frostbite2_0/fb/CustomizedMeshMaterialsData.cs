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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 8)]
	public class CustomizedMeshMaterialsData :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public CtrRef<ObjectBlueprint> MeshBlueprint { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public List<string> MaterialNames { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(MeshBlueprint));
			(RimeWriter Writer, uint ArrayIndex) s_MaterialNames = p_EbxWriter.GetArrayWriter(MaterialNames.GetType(), MaterialNames.Count);
			p_Writer.Write(s_MaterialNames.ArrayIndex);
			foreach (var s_Entry in MaterialNames)
			{
				s_MaterialNames.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
		}
	}
}
