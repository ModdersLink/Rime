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
	[ContainerType(4, 28)]
	public class VoiceOverDialogClip : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float Offset { get; set; }

		[ContainerField(12)]
		public List<VoiceOverDialogTake> Takes { get; set; } = new();

		[ContainerField(16)]
		public RefArray<VoiceOverDialogClip> OffsetReferences { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<VoiceOverDialogClipEvents> Events { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public sbyte SequenceIndex { get; set; }

	}
}
