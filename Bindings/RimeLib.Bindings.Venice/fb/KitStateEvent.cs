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
	[ContainerType(8, 24)]
	public class KitStateEvent : 
		MetricEvent
	{
		[ContainerField(16), LayoutImmutable]
		public string Kit { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable, Blittable]
		public float SecondsAsKit { get; set; }

		public static void Deserialize(KitStateEvent p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Kit = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.SecondsAsKit = p_Reader.ReadSingle();
		}

	}
}
