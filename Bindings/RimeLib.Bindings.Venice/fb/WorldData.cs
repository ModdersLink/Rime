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
	[ContainerType(4, 48)]
	public class WorldData : 
		SubWorldData
	{
		[ContainerField(44)]
		public CtrRef<MaterialGridData> RuntimeMaterialGrid { get; set; } = new();

		public static void Deserialize(WorldData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.RuntimeMaterialGrid.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
