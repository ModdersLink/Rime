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
	[ContainerType(4, 12)]
	public class AudioObstructionMaterialInfo
	{
		[ContainerField(0)]
		public CtrRef<MaterialContainerPair> Material { get; set; } = new();
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float ObstructionFrequency { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float GainReduction { get; set; }
		
		public static void Deserialize(AudioObstructionMaterialInfo p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Material.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.ObstructionFrequency = p_Reader.ReadSingle();
			p_Instance.GainReduction = p_Reader.ReadSingle();
		}
	}
}
