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
	[ContainerType(16, 112)]
	public class SurroundingGeometryEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public CtrRef<AllowedVehiclesData> AllowedVehicleList { get; set; } = new();

		[ContainerField(100)]
		public CtrRef<CombatAreaTriggerEntityData> CombatArea { get; set; } = new();

		[ContainerField(104), LayoutImmutable, Blittable]
		public uint CombatAreaIndex { get; set; }

		public static void Deserialize(SurroundingGeometryEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.AllowedVehicleList.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.CombatArea.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.CombatAreaIndex = p_Reader.ReadUInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
