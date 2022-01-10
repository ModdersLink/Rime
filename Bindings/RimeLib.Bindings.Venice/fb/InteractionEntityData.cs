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
	public class InteractionEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float UseWithinRadius { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float UseWithinAngle { get; set; }

		[ContainerField(104)]
		public CtrRef<SoundAsset> PreInteractionSoundEffect { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable]
		public uint MaxUses { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public bool AllowInteractionViaRemoteEntry { get; set; }

		[ContainerField(113), LayoutImmutable, Blittable]
		public bool TestIfOccluded { get; set; }

		public static void Deserialize(InteractionEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.UseWithinRadius = p_Reader.ReadSingle();
			p_Instance.UseWithinAngle = p_Reader.ReadSingle();
			p_Instance.PreInteractionSoundEffect.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.MaxUses = p_Reader.ReadUInt32();
			p_Instance.AllowInteractionViaRemoteEntry = p_Reader.ReadBool();
			p_Instance.TestIfOccluded = p_Reader.ReadBool();
			p_Reader.Seek(14, SeekOrigin.Current);
		}

	}
}
