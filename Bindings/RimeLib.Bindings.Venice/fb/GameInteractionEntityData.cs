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

	}
}
