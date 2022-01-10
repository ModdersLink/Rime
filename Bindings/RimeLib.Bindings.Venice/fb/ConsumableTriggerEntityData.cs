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
	[ContainerType(16, 128)]
	public class ConsumableTriggerEntityData : 
		TriggerEntityData
	{
		[ContainerField(112)]
		public ConsumableGroup ConsumableGroup { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable]
		public bool Persistent { get; set; }

		public static void Deserialize(ConsumableTriggerEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ConsumableGroup = (ConsumableGroup) p_Reader.ReadInt32();
			p_Instance.Persistent = p_Reader.ReadBool();
			p_Reader.Seek(11, SeekOrigin.Current);
		}

	}
}
