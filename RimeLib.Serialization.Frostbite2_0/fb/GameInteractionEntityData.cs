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
	[ContainerType(16, 192)]
	public partial class GameInteractionEntityData :
		InteractionEntityData
	{
		[ObservableProperty]
		[property: ContainerField(128), JsonProperty(Order = 128)]
		private BlinkType _Blink = new();

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private float _CapturepointVerticalOffset;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private float _DelayBetweenUses;

		[ObservableProperty]
		[property: ContainerField(140), JsonProperty(Order = 140)]
		private TeamId _TeamId = new();

		[ObservableProperty]
		[property: ContainerField(144), JsonProperty(Order = 144)]
		private EntryInputActionEnum _InputAction = new();

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private float _HoldToInteractTime;

		[ObservableProperty]
		[property: ContainerField(152), JsonProperty(Order = 152)]
		private InteractionEntityType _InteractionEntityType = new();

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, JsonProperty(Order = 156)]
		private string _InteractionSid = string.Empty;

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, JsonProperty(Order = 160)]
		private string _InteractingSid = string.Empty;

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, JsonProperty(Order = 164)]
		private string _FriendlyTextSid = string.Empty;

		[ObservableProperty]
		[property: ContainerField(168), LayoutImmutable, JsonProperty(Order = 168)]
		private string _NameSid = string.Empty;

		[ObservableProperty]
		[property: ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		private float _InteractionVerticalOffset;

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, JsonProperty(Order = 176)]
		private string _EnemyTextSid = string.Empty;

		[ObservableProperty]
		[property: ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		private bool _ShrinkSnap;

		[ObservableProperty]
		[property: ContainerField(181), LayoutImmutable, Blittable, JsonProperty(Order = 181)]
		private bool _ShowAsCapturePoint;

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
