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
	[ContainerType(4, 24)]
	public class MaterialRelationVehicleData : 
		PhysicsMaterialRelationPropertyData
	{
		[ContainerField(8)]
		public CtrRef<EffectBlueprint> ChassiEffect { get; set; } = new();

		[ContainerField(12)]
		public CtrRef<EffectBlueprint> TrackEffect { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<EffectBlueprint> WheelEffect { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<EffectBlueprint> GroundEffect { get; set; } = new();

		public static void Deserialize(MaterialRelationVehicleData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ChassiEffect.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.TrackEffect.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.WheelEffect.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.GroundEffect.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
