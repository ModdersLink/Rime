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
	[ContainerType(16, 208)]
	public class DamageEffectComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 RightDamage { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 TopDamage { get; set; } = new();

		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 LeftDamage { get; set; } = new();

		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 BottomDamage { get; set; } = new();

		[ContainerField(160), LayoutImmutable, Blittable]
		public float OuterFrameOpacity { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public float InnerFrameOpacity { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable]
		public float FrameWidth { get; set; }

		[ContainerField(172)]
		public CtrRef<SurfaceShaderBaseAsset> Shader { get; set; } = new();

		[ContainerField(176), LayoutImmutable, Blittable]
		public float StartCriticalEffectHealthThreshold { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable]
		public float EndCriticalEffectHealthThreshold { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable]
		public float MinDamagePercentageThreshold { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable]
		public float FallofTime { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable]
		public float MaxOpacityDamagePercentage { get; set; }

		[ContainerField(196)]
		public Realm Realm { get; set; } = new();

		[ContainerField(200), LayoutImmutable, Blittable]
		public bool DebugDamage { get; set; }

		public static void Deserialize(DamageEffectComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec4.Deserialize(p_Instance.RightDamage, p_Reader, p_Parser);
			fb.Vec4.Deserialize(p_Instance.TopDamage, p_Reader, p_Parser);
			fb.Vec4.Deserialize(p_Instance.LeftDamage, p_Reader, p_Parser);
			fb.Vec4.Deserialize(p_Instance.BottomDamage, p_Reader, p_Parser);
			p_Instance.OuterFrameOpacity = p_Reader.ReadSingle();
			p_Instance.InnerFrameOpacity = p_Reader.ReadSingle();
			p_Instance.FrameWidth = p_Reader.ReadSingle();
			p_Instance.Shader.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.StartCriticalEffectHealthThreshold = p_Reader.ReadSingle();
			p_Instance.EndCriticalEffectHealthThreshold = p_Reader.ReadSingle();
			p_Instance.MinDamagePercentageThreshold = p_Reader.ReadSingle();
			p_Instance.FallofTime = p_Reader.ReadSingle();
			p_Instance.MaxOpacityDamagePercentage = p_Reader.ReadSingle();
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Instance.DebugDamage = p_Reader.ReadBool();
			p_Reader.Seek(7, SeekOrigin.Current);
		}

	}
}
