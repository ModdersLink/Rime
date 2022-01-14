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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(8, 144)]
	public class SensingTemplateData :
		GameSensingTemplateData
	{
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public double AwareForgetTime { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public double LostForgetTime { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public double TimeUntilUnseenIsLost { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float MaximumMergeDistance { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float MaximumAlertDistance { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float MaximumReadinessRaiseDistance { get; set; }

		[ContainerField(52), JsonProperty(Order = 52)]
		public SensingLimits ReadyLimits { get; set; } = new();

		[ContainerField(80), JsonProperty(Order = 80)]
		public SensingLimits RelaxedLimits { get; set; } = new();

		[ContainerField(108), LayoutImmutable, JsonProperty(Order = 108)]
		public string DebugText { get; set; } = string.Empty;

		[ContainerField(112), JsonProperty(Order = 112)]
		public SensingLimits CombatLimits { get; set; } = new();

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public bool UseSenseSharing { get; set; }

		[ContainerField(141), LayoutImmutable, Blittable, JsonProperty(Order = 141)]
		public bool NoticeBullets { get; set; }

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
