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
	[ContainerType(16, 160)]
	public class InspectEntityData : 
		GameEntityData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CenterOffset { get; set; } = new();

		[ContainerField(112), LayoutImmutable]
		public string UIName { get; set; } = string.Empty;

		[ContainerField(116), LayoutImmutable, Blittable]
		public float MaxLookAtHeight { get; set; }

		[ContainerField(120)]
		public List<InspectViewPointData> ViewPoints { get; set; } = new();

		[ContainerField(124)]
		public List<CtrRef<TargetCameraData>> Cameras { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable]
		public float MinLookAtHeight { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public float MinDistance { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public float ZoomScrollSpeed { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public float MaxDistance { get; set; }

		[ContainerField(144)]
		public AntRef AnimationSignal { get; set; } = new();

		[ContainerField(148), LayoutImmutable, Blittable]
		public float ZoomScrollAcceleration { get; set; }

		public static void Deserialize(InspectEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.CenterOffset, p_Reader, p_Parser);
			p_Instance.UIName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.MaxLookAtHeight = p_Reader.ReadSingle();
			p_Instance.ViewPoints.Clear();
			(RimeReader Reader, uint Count) s_ViewPoints = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ViewPoints.Count; ++i)
			{
				var s_Value = new InspectViewPointData();
				fb.InspectViewPointData.Deserialize(s_Value, s_ViewPoints.Reader, p_Parser);
				p_Instance.ViewPoints.Add(s_Value);
			}
			
			s_ViewPoints.Reader.Dispose();
			p_Instance.Cameras.Clear();
			(RimeReader Reader, uint Count) s_Cameras = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Cameras.Count; ++i)
			{
				var s_CtrRef = new CtrRef<TargetCameraData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Cameras.Reader.ReadUInt32()));
				p_Instance.Cameras.Add(s_CtrRef);
			}
			
			s_Cameras.Reader.Dispose();
			p_Instance.MinLookAtHeight = p_Reader.ReadSingle();
			p_Instance.MinDistance = p_Reader.ReadSingle();
			p_Instance.ZoomScrollSpeed = p_Reader.ReadSingle();
			p_Instance.MaxDistance = p_Reader.ReadSingle();
			fb.AntRef.Deserialize(p_Instance.AnimationSignal, p_Reader, p_Parser);
			p_Instance.ZoomScrollAcceleration = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
