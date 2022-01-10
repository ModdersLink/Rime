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
	public class BreakablePartComponentData : 
		DestructionPartComponentData
	{
		[ContainerField(112), LayoutImmutable, Blittable]
		public uint HealthPercentage { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public bool Collapsable { get; set; }

		[ContainerField(117), LayoutImmutable, Blittable]
		public bool DestroyNearbyStaticEntities { get; set; }

		public static void Deserialize(BreakablePartComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.HealthPercentage = p_Reader.ReadUInt32();
			p_Instance.Collapsable = p_Reader.ReadBool();
			p_Instance.DestroyNearbyStaticEntities = p_Reader.ReadBool();
			p_Reader.Seek(10, SeekOrigin.Current);
		}

	}
}
