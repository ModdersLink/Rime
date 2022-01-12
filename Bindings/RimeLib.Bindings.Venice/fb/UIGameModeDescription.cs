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
	[ContainerType(4, 44)]
	public class UIGameModeDescription : 
		UIItemDescription
	{
		[ContainerField(16), LayoutImmutable]
		public string Identifier { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable]
		public string Abbreviation { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable]
		public string Desc { get; set; } = string.Empty;

		[ContainerField(32), LayoutImmutable, Blittable]
		public int BattlelogId { get; set; }

		[ContainerField(36), LayoutImmutable]
		public string TexturePath { get; set; } = string.Empty;

		[ContainerField(40)]
		public List<GameModeVariation> Variations { get; set; } = new();

	}
}
