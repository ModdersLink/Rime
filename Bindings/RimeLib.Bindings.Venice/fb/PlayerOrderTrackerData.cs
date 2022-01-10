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
	[ContainerType(4, 56)]
	public class PlayerOrderTrackerData : 
		HudTrackerData
	{
		[ContainerField(44)]
		public UIHudIcon AttackIcon { get; set; } = new();

		[ContainerField(48)]
		public UIHudIcon DefendIcon { get; set; } = new();

		[ContainerField(52)]
		public UIHudIcon MoveToIcon { get; set; } = new();

		public static void Deserialize(PlayerOrderTrackerData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.AttackIcon = (UIHudIcon) p_Reader.ReadInt32();
			p_Instance.DefendIcon = (UIHudIcon) p_Reader.ReadInt32();
			p_Instance.MoveToIcon = (UIHudIcon) p_Reader.ReadInt32();
		}

	}
}
