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
	[ContainerType(16, 112)]
	public partial class SurroundingGeometryEntityData :
		GameEntityData
	{
		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private CtrRef<AllowedVehiclesData> _AllowedVehicleList = new();

		[ObservableProperty]
		[property: ContainerField(100), JsonProperty(Order = 100)]
		private CtrRef<CombatAreaTriggerEntityData> _CombatArea = new();

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private uint _CombatAreaIndex;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(AllowedVehicleList));
			p_Writer.Write(p_EbxWriter.WriteImport(CombatArea));
			p_Writer.Write(CombatAreaIndex);
			p_Writer.WriteNullBytes(4);
		}
	}
}
