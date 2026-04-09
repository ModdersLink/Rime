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
	[ContainerType(4, 24)]
	public partial class PersistentCriteriaStatRef :
		AbstractPersistentStatRef
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private CtrRef<CriteriaData> _Criteria = new();

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private CtrRef<StatsCategoryBaseData> _ParamX = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private CtrRef<StatsCategoryBaseData> _ParamY = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private CtrRef<AwardData> _CriteriaOwner = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Criteria));
			p_Writer.Write(p_EbxWriter.WriteImport(ParamX));
			p_Writer.Write(p_EbxWriter.WriteImport(ParamY));
			p_Writer.Write(p_EbxWriter.WriteImport(CriteriaOwner));
		}
	}
}
