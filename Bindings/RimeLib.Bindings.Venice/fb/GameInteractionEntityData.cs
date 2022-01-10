///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 192)]
	public class GameInteractionEntityData : 
		InteractionEntityData
	{
		[ContainerField(128)]
		public BlinkType Blink { get; set; } = new();

		[ContainerField(132), LayoutImmutable, Blittable]
		public float CapturepointVerticalOffset { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public float DelayBetweenUses { get; set; }

		[ContainerField(140)]
		public TeamId TeamId { get; set; } = new();

		[ContainerField(144)]
		public EntryInputActionEnum InputAction { get; set; } = new();

		[ContainerField(148), LayoutImmutable, Blittable]
		public float HoldToInteractTime { get; set; }

		[ContainerField(152)]
		public InteractionEntityType InteractionEntityType { get; set; } = new();

		[ContainerField(156), LayoutImmutable]
		public string InteractionSid { get; set; } = string.Empty;

		[ContainerField(160), LayoutImmutable]
		public string InteractingSid { get; set; } = string.Empty;

		[ContainerField(164), LayoutImmutable]
		public string FriendlyTextSid { get; set; } = string.Empty;

		[ContainerField(168), LayoutImmutable]
		public string NameSid { get; set; } = string.Empty;

		[ContainerField(172), LayoutImmutable, Blittable]
		public float InteractionVerticalOffset { get; set; }

		[ContainerField(176), LayoutImmutable]
		public string EnemyTextSid { get; set; } = string.Empty;

		[ContainerField(180), LayoutImmutable, Blittable]
		public bool ShrinkSnap { get; set; }

		[ContainerField(181), LayoutImmutable, Blittable]
		public bool ShowAsCapturePoint { get; set; }

		public static void Deserialize(GameInteractionEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Blink = (BlinkType) p_Reader.ReadInt32();
			p_Instance.CapturepointVerticalOffset = p_Reader.ReadSingle();
			p_Instance.DelayBetweenUses = p_Reader.ReadSingle();
			p_Instance.TeamId = (TeamId) p_Reader.ReadInt32();
			p_Instance.InputAction = (EntryInputActionEnum) p_Reader.ReadInt32();
			p_Instance.HoldToInteractTime = p_Reader.ReadSingle();
			p_Instance.InteractionEntityType = (InteractionEntityType) p_Reader.ReadInt32();
			p_Instance.InteractionSid = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.InteractingSid = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.FriendlyTextSid = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.NameSid = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.InteractionVerticalOffset = p_Reader.ReadSingle();
			p_Instance.EnemyTextSid = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.ShrinkSnap = p_Reader.ReadBool();
			p_Instance.ShowAsCapturePoint = p_Reader.ReadBool();
			p_Reader.Seek(10, SeekOrigin.Current);
		}

	}
}
