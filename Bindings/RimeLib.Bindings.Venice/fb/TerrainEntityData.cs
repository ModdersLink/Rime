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
	[ContainerType(16, 128)]
	public class TerrainEntityData : 
		GamePhysicsEntityData
	{
		[ContainerField(112)]
		public CtrRef<TerrainData> TerrainAsset { get; set; } = new();

		[ContainerField(116)]
		public CtrRef<MaterialContainerPair> WaterMaterial { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable]
		public bool Visible { get; set; }

		public static void Deserialize(TerrainEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.TerrainAsset.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.WaterMaterial.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Visible = p_Reader.ReadBool();
			p_Reader.Seek(7, SeekOrigin.Current);
		}

	}
}
