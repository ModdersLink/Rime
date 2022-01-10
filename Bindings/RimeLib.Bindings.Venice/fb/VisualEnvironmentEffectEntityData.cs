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
	[ContainerType(16, 176)]
	public class VisualEnvironmentEffectEntityData : 
		EffectEntityData
	{
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 LifetimeCurve { get; set; } = new();

		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 CullDistanceCurve { get; set; } = new();

		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 CullAngleCurve { get; set; } = new();

		[ContainerField(160), LayoutImmutable, Blittable]
		public float Lifetime { get; set; }

		[ContainerField(164)]
		public CtrRef<VisualEnvironmentBlueprint> VisualEnvironment { get; set; } = new();

		[ContainerField(168), LayoutImmutable, Blittable]
		public bool SampleOnStartOnly { get; set; }

		public static void Deserialize(VisualEnvironmentEffectEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec4.Deserialize(p_Instance.LifetimeCurve, p_Reader, p_Parser);
			fb.Vec4.Deserialize(p_Instance.CullDistanceCurve, p_Reader, p_Parser);
			fb.Vec4.Deserialize(p_Instance.CullAngleCurve, p_Reader, p_Parser);
			p_Instance.Lifetime = p_Reader.ReadSingle();
			p_Instance.VisualEnvironment.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.SampleOnStartOnly = p_Reader.ReadBool();
			p_Reader.Seek(7, SeekOrigin.Current);
		}

	}
}
