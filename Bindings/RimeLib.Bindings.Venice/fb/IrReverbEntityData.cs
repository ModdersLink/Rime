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
	[ContainerType(4, 28)]
	public class IrReverbEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public CtrRef<ImpulseResponseAsset> ImpulseResponse { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public float Gain { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float Volume { get; set; }

		[ContainerField(24)]
		public FadeCurveType FadeCurve { get; set; } = new();

		public static void Deserialize(IrReverbEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ImpulseResponse.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Gain = p_Reader.ReadSingle();
			p_Instance.Volume = p_Reader.ReadSingle();
			p_Instance.FadeCurve = (FadeCurveType) p_Reader.ReadInt32();
		}

	}
}
