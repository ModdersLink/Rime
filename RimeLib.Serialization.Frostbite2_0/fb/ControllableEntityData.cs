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
	[ContainerType(16, 144)]
	public partial class ControllableEntityData :
		GamePhysicsEntityData
	{
		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _LowHealthThreshold;

		[ObservableProperty]
		[property: ContainerField(116), JsonProperty(Order = 116)]
		private TeamId _DefaultTeam = new();

		[ObservableProperty]
		[property: ContainerField(120), JsonProperty(Order = 120)]
		private CtrRef<MaterialContainerPair> _MaterialPair = new();

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private bool _ResetTeamOnLastPlayerExits;

		[ObservableProperty]
		[property: ContainerField(125), LayoutImmutable, Blittable, JsonProperty(Order = 125)]
		private bool _FakeImmortal;

		[ObservableProperty]
		[property: ContainerField(126), LayoutImmutable, Blittable, JsonProperty(Order = 126)]
		private bool _UsePrediction;

		[ObservableProperty]
		[property: ContainerField(127), LayoutImmutable, Blittable, JsonProperty(Order = 127)]
		private bool _Immortal;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private bool _ForceForegroundRendering;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(LowHealthThreshold);
			p_Writer.Write((int) DefaultTeam);
			p_Writer.Write(p_EbxWriter.WriteImport(MaterialPair));
			p_Writer.Write(ResetTeamOnLastPlayerExits);
			p_Writer.Write(FakeImmortal);
			p_Writer.Write(UsePrediction);
			p_Writer.Write(Immortal);
			p_Writer.Write(ForceForegroundRendering);
			p_Writer.WriteNullBytes(15);
		}
	}
}
