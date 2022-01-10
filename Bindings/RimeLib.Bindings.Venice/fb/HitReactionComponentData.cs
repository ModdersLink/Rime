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
	[ContainerType(16, 144)]
	public class HitReactionComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public HitReactionComponentBinding HitReactionBinding { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable]
		public bool Enabled { get; set; }

		public static void Deserialize(HitReactionComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.HitReactionComponentBinding.Deserialize(p_Instance.HitReactionBinding, p_Reader, p_Parser);
			p_Instance.Enabled = p_Reader.ReadBool();
			p_Reader.Seek(15, SeekOrigin.Current);
		}

	}
}
