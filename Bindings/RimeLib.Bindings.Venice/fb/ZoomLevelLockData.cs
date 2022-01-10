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
	public class ZoomLevelLockData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float OutlineTaggedDistance { get; set; }
		
		[ContainerField(4)]
		public LockType LockType { get; set; } = new();
		
		public static void Deserialize(ZoomLevelLockData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.OutlineTaggedDistance = p_Reader.ReadSingle();
			p_Instance.LockType = (LockType) p_Reader.ReadInt32();
		}
	}
}
