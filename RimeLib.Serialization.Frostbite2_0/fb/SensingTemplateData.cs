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
	[ContainerType(8, 144)]
	public partial class SensingTemplateData :
		GameSensingTemplateData
	{
		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private double _AwareForgetTime;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private double _LostForgetTime;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private double _TimeUntilUnseenIsLost;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _MaximumMergeDistance;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _MaximumAlertDistance;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _MaximumReadinessRaiseDistance;

		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private SensingLimits _ReadyLimits = new();

		[ObservableProperty]
		[property: ContainerField(80), JsonProperty(Order = 80)]
		private SensingLimits _RelaxedLimits = new();

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, JsonProperty(Order = 108)]
		private string _DebugText = string.Empty;

		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private SensingLimits _CombatLimits = new();

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private bool _UseSenseSharing;

		[ObservableProperty]
		[property: ContainerField(141), LayoutImmutable, Blittable, JsonProperty(Order = 141)]
		private bool _NoticeBullets;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(4);
			p_Writer.Write(AwareForgetTime);
			p_Writer.Write(LostForgetTime);
			p_Writer.Write(TimeUntilUnseenIsLost);
			p_Writer.Write(MaximumMergeDistance);
			p_Writer.Write(MaximumAlertDistance);
			p_Writer.Write(MaximumReadinessRaiseDistance);
			ReadyLimits.Serialize(p_Writer, p_EbxWriter);
			RelaxedLimits.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(DebugText));
			CombatLimits.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(UseSenseSharing);
			p_Writer.Write(NoticeBullets);
			p_Writer.WriteNullBytes(2);
		}
	}
}
