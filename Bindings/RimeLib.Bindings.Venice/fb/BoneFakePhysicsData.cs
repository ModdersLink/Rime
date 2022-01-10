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
	[ContainerType(4, 20)]
	public class BoneFakePhysicsData : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<FakePhysicsData> FakePhysics { get; set; } = new();

		[ContainerField(12), LayoutImmutable]
		public string BoneName { get; set; } = string.Empty;

		[ContainerField(16), LayoutImmutable, Blittable]
		public int BoneId { get; set; }

		public static void Deserialize(BoneFakePhysicsData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.FakePhysics.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.BoneName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.BoneId = p_Reader.ReadInt32();
		}

	}
}
