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
	[ContainerType(4, 44)]
	public class DebrisSystemSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint MeshDrawCountLimit { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float TimeScale { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float MeshCullingDistance { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public uint DrawStats { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public uint MeshBatchCountLimit { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float MeshStreamingPriorityMultiplier { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public bool MeshRenderingEnable { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable]
		public bool EnableJobs { get; set; }

		[ContainerField(34), LayoutImmutable, Blittable]
		public bool MeshShadowEnable { get; set; }

		[ContainerField(35), LayoutImmutable, Blittable]
		public bool MeshViewCullingEnable { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public bool MeshHavokRenderingEnable { get; set; }

		[ContainerField(37), LayoutImmutable, Blittable]
		public bool MeshDrawTransforms { get; set; }

		[ContainerField(38), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

		[ContainerField(39), LayoutImmutable, Blittable]
		public bool MeshDrawBoundingBoxes { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public bool MeshDrawCullStats { get; set; }

		public static void Deserialize(DebrisSystemSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MeshDrawCountLimit = p_Reader.ReadUInt32();
			p_Instance.TimeScale = p_Reader.ReadSingle();
			p_Instance.MeshCullingDistance = p_Reader.ReadSingle();
			p_Instance.DrawStats = p_Reader.ReadUInt32();
			p_Instance.MeshBatchCountLimit = p_Reader.ReadUInt32();
			p_Instance.MeshStreamingPriorityMultiplier = p_Reader.ReadSingle();
			p_Instance.MeshRenderingEnable = p_Reader.ReadBool();
			p_Instance.EnableJobs = p_Reader.ReadBool();
			p_Instance.MeshShadowEnable = p_Reader.ReadBool();
			p_Instance.MeshViewCullingEnable = p_Reader.ReadBool();
			p_Instance.MeshHavokRenderingEnable = p_Reader.ReadBool();
			p_Instance.MeshDrawTransforms = p_Reader.ReadBool();
			p_Instance.Enable = p_Reader.ReadBool();
			p_Instance.MeshDrawBoundingBoxes = p_Reader.ReadBool();
			p_Instance.MeshDrawCullStats = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
