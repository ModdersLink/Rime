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
	public partial class UnderFireTriggerEntityData :
		TriggerEntityData
	{
		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _Radius;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _CoolDownTime;

		[ObservableProperty]
		[property: ContainerField(120), JsonProperty(Order = 120)]
		private CtrRef<MaterialContainerPair> _TriggerOnMaterialOnly = new();

		[ObservableProperty]
		[property: ContainerField(124), JsonProperty(Order = 124)]
		private AreaTriggerInclude _TriggeredBy = new();

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private bool _DisableIfTrackEntityIsLost;

		[ObservableProperty]
		[property: ContainerField(129), LayoutImmutable, Blittable, JsonProperty(Order = 129)]
		private bool _RandomYaw;

		[ObservableProperty]
		[property: ContainerField(130), LayoutImmutable, Blittable, JsonProperty(Order = 130)]
		private bool _IndicateHit;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Radius);
			p_Writer.Write(CoolDownTime);
			p_Writer.Write(p_EbxWriter.WriteImport(TriggerOnMaterialOnly));
			p_Writer.Write((int) TriggeredBy);
			p_Writer.Write(DisableIfTrackEntityIsLost);
			p_Writer.Write(RandomYaw);
			p_Writer.Write(IndicateHit);
			p_Writer.WriteNullBytes(13);
		}
	}
}
