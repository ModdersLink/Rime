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
	[ContainerType(4, 168)]
	public class UIInteractionCompData : 
		UI3dIconCompData
	{
		[ContainerField(160), LayoutImmutable, Blittable]
		public float RepairSnapDistance { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public bool RepairSnapCircle { get; set; }

		[ContainerField(165), LayoutImmutable, Blittable]
		public bool PickupShrinkSnap { get; set; }

		public static void Deserialize(UIInteractionCompData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.RepairSnapDistance = p_Reader.ReadSingle();
			p_Instance.RepairSnapCircle = p_Reader.ReadBool();
			p_Instance.PickupShrinkSnap = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
