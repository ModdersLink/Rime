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
	[ContainerType(16, 224)]
	public class PlayerEntryComponentData : 
		EntryComponentData
	{
		[ContainerField(192), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 AnimationAccelerationMultiplier { get; set; } = new();

		[ContainerField(208)]
		public AntEntryIdEnum AntEntryId { get; set; } = new();

		[ContainerField(212), LayoutImmutable]
		public string AntEntryID { get; set; } = string.Empty;

		[ContainerField(216)]
		public CtrRef<AntEnumeration> AntEntryEnumeration { get; set; } = new();

		[ContainerField(220), LayoutImmutable, Blittable]
		public float ShieldedTransitionExitTime { get; set; }

		public static void Deserialize(PlayerEntryComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.AnimationAccelerationMultiplier, p_Reader, p_Parser);
			p_Instance.AntEntryId = (AntEntryIdEnum) p_Reader.ReadInt32();
			p_Instance.AntEntryID = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.AntEntryEnumeration.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.ShieldedTransitionExitTime = p_Reader.ReadSingle();
		}

	}
}
