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
	[ContainerType(16, 144)]
	public class DynamicAOComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public Realm Realm { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public float SsaoMaxDistanceOuter { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float SsaoFade { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public float SsaoRadius { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public float SsaoMaxDistanceInner { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float HbaoRadius { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public float HbaoAttenuation { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public float HbaoAngleBias { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public float HbaoPowerExponent { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public float HbaoContrast { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public float HbaoMaxFootprintRadius { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

		public static void Deserialize(DynamicAOComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Instance.SsaoMaxDistanceOuter = p_Reader.ReadSingle();
			p_Instance.SsaoFade = p_Reader.ReadSingle();
			p_Instance.SsaoRadius = p_Reader.ReadSingle();
			p_Instance.SsaoMaxDistanceInner = p_Reader.ReadSingle();
			p_Instance.HbaoRadius = p_Reader.ReadSingle();
			p_Instance.HbaoAttenuation = p_Reader.ReadSingle();
			p_Instance.HbaoAngleBias = p_Reader.ReadSingle();
			p_Instance.HbaoPowerExponent = p_Reader.ReadSingle();
			p_Instance.HbaoContrast = p_Reader.ReadSingle();
			p_Instance.HbaoMaxFootprintRadius = p_Reader.ReadSingle();
			p_Instance.Enable = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
