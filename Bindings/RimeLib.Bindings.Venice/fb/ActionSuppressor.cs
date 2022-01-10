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
	[ContainerType(4, 8)]
	public class ActionSuppressor
	{
		[ContainerField(0)]
		public EntryInputActionEnum ActionToSuppress { get; set; } = new();
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float SuppressingValue { get; set; }
		
		public static void Deserialize(ActionSuppressor p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ActionToSuppress = (EntryInputActionEnum) p_Reader.ReadInt32();
			p_Instance.SuppressingValue = p_Reader.ReadSingle();
		}
	}
}
