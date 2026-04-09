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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 36)]
	public partial class PersistenceSettings :
		SystemSettings
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private CtrRef<StatCategoryTreeCollection> _StatCategoryTreeCollection = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private CtrRef<PlayerTypeProfile> _MPProfile = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private CtrRef<PlayerTypeProfile> _SPProfile = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private CtrRef<PlayerTypeProfile> _CoopProfile = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private CtrRef<PointSystemParamsAsset> _PointSystemParams = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private CtrRef<LicenseConfiguration> _LicenseConfig = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(StatCategoryTreeCollection));
			p_Writer.Write(p_EbxWriter.WriteImport(MPProfile));
			p_Writer.Write(p_EbxWriter.WriteImport(SPProfile));
			p_Writer.Write(p_EbxWriter.WriteImport(CoopProfile));
			p_Writer.Write(p_EbxWriter.WriteImport(PointSystemParams));
			p_Writer.Write(p_EbxWriter.WriteImport(LicenseConfig));
		}
	}
}
