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

namespace fb
{
	[ContainerType(16, 192)]
	public class GameInteractionEntityData :
		InteractionEntityData
	{
		[ContainerField(128), JsonProperty(Order = 128)]
		public BlinkType Blink { get; set; } = new();

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public float CapturepointVerticalOffset { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public float DelayBetweenUses { get; set; }

		[ContainerField(140), JsonProperty(Order = 140)]
		public TeamId TeamId { get; set; } = new();

		[ContainerField(144), JsonProperty(Order = 144)]
		public EntryInputActionEnum InputAction { get; set; } = new();

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public float HoldToInteractTime { get; set; }

		[ContainerField(152), JsonProperty(Order = 152)]
		public InteractionEntityType InteractionEntityType { get; set; } = new();

		[ContainerField(156), LayoutImmutable, JsonProperty(Order = 156)]
		public string InteractionSid { get; set; } = string.Empty;

		[ContainerField(160), LayoutImmutable, JsonProperty(Order = 160)]
		public string InteractingSid { get; set; } = string.Empty;

		[ContainerField(164), LayoutImmutable, JsonProperty(Order = 164)]
		public string FriendlyTextSid { get; set; } = string.Empty;

		[ContainerField(168), LayoutImmutable, JsonProperty(Order = 168)]
		public string NameSid { get; set; } = string.Empty;

		[ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		public float InteractionVerticalOffset { get; set; }

		[ContainerField(176), LayoutImmutable, JsonProperty(Order = 176)]
		public string EnemyTextSid { get; set; } = string.Empty;

		[ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		public bool ShrinkSnap { get; set; }

		[ContainerField(181), LayoutImmutable, Blittable, JsonProperty(Order = 181)]
		public bool ShowAsCapturePoint { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Blink);
			p_Writer.Write(CapturepointVerticalOffset);
			p_Writer.Write(DelayBetweenUses);
			p_Writer.Write((int) TeamId);
			p_Writer.Write((int) InputAction);
			p_Writer.Write(HoldToInteractTime);
			p_Writer.Write((int) InteractionEntityType);
			p_Writer.Write(p_EbxWriter.WriteString(InteractionSid));
			p_Writer.Write(p_EbxWriter.WriteString(InteractingSid));
			p_Writer.Write(p_EbxWriter.WriteString(FriendlyTextSid));
			p_Writer.Write(p_EbxWriter.WriteString(NameSid));
			p_Writer.Write(InteractionVerticalOffset);
			p_Writer.Write(p_EbxWriter.WriteString(EnemyTextSid));
			p_Writer.Write(ShrinkSnap);
			p_Writer.Write(ShowAsCapturePoint);
			p_Writer.WriteNullBytes(10);
		}
	}
}
