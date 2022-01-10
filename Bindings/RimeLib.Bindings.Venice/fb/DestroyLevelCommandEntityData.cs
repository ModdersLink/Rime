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
	[ContainerType(16, 112)]
	public class DestroyLevelCommandEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public uint InstanceCountDestroyedPerFrame { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public uint DestroyDelay { get; set; }

		public static void Deserialize(DestroyLevelCommandEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.InstanceCountDestroyedPerFrame = p_Reader.ReadUInt32();
			p_Instance.DestroyDelay = p_Reader.ReadUInt32();
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
