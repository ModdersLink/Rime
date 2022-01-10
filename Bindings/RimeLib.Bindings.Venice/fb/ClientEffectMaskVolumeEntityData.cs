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
	public class ClientEffectMaskVolumeEntityData : 
		GameEntityData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 ApplyEffectCurve { get; set; } = new();

		[ContainerField(112), LayoutImmutable, Blittable]
		public float LifeTimeInSeconds { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float UpdatePeriodInSeconds { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public float Radius { get; set; }

		public static void Deserialize(ClientEffectMaskVolumeEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec4.Deserialize(p_Instance.ApplyEffectCurve, p_Reader, p_Parser);
			p_Instance.LifeTimeInSeconds = p_Reader.ReadSingle();
			p_Instance.UpdatePeriodInSeconds = p_Reader.ReadSingle();
			p_Instance.Radius = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
