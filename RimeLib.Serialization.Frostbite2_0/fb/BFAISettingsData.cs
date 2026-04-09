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
	[ContainerType(4, 100)]
	public partial class BFAISettingsData :
		AISettingsData
	{
		[ObservableProperty]
		[property: ContainerField(80), JsonProperty(Order = 80)]
		private CtrRef<MovementConstantData> _MovementConstants = new();

		[ObservableProperty]
		[property: ContainerField(84), JsonProperty(Order = 84)]
		private CtrRef<TurretControlConstantData> _TurretControlConstants = new();

		[ObservableProperty]
		[property: ContainerField(88), JsonProperty(Order = 88)]
		private CtrRef<SearchAndDestroyConstantData> _SearchAndDestroyConstants = new();

		[ObservableProperty]
		[property: ContainerField(92), JsonProperty(Order = 92)]
		private CtrRef<FollowConstantData> _FollowConstants = new();

		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private CtrRef<CombatConstantData> _CombatConstants = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(MovementConstants));
			p_Writer.Write(p_EbxWriter.WriteImport(TurretControlConstants));
			p_Writer.Write(p_EbxWriter.WriteImport(SearchAndDestroyConstants));
			p_Writer.Write(p_EbxWriter.WriteImport(FollowConstants));
			p_Writer.Write(p_EbxWriter.WriteImport(CombatConstants));
		}
	}
}
