///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 12)]
	public class MeshVariationInfo
	{
		[ContainerField(0)]
		public CtrRef<MeshAsset> MeshAsset { get; set; } = new();
		
		[ContainerField(4)]
		public CtrRef<MeshAsset> OrigMeshAsset { get; set; } = new();
		
		[ContainerField(8)]
		public CtrRef<ObjectVariation> VariationAsset { get; set; } = new();
		
		public static void Deserialize(MeshVariationInfo p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MeshAsset.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.OrigMeshAsset.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.VariationAsset.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}
	}
}
