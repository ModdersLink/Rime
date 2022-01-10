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
	[ContainerType(4, 36)]
	public class PersistenceSettings : 
		SystemSettings
	{
		[ContainerField(12)]
		public CtrRef<StatCategoryTreeCollection> StatCategoryTreeCollection { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<PlayerTypeProfile> MPProfile { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<PlayerTypeProfile> SPProfile { get; set; } = new();

		[ContainerField(24)]
		public CtrRef<PlayerTypeProfile> CoopProfile { get; set; } = new();

		[ContainerField(28)]
		public CtrRef<PointSystemParamsAsset> PointSystemParams { get; set; } = new();

		[ContainerField(32)]
		public CtrRef<LicenseConfiguration> LicenseConfig { get; set; } = new();

		public static void Deserialize(PersistenceSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.StatCategoryTreeCollection.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.MPProfile.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.SPProfile.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.CoopProfile.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.PointSystemParams.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.LicenseConfig.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
