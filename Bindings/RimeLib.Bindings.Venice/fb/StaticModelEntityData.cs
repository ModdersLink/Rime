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
	public class StaticModelEntityData : 
		GamePhysicsEntityData
	{
		[ContainerField(112)]
		public List<CtrRef<PartLinkData>> PartLinks { get; set; } = new();

		[ContainerField(116)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable]
		public uint BoneCount { get; set; }

		[ContainerField(124)]
		public List<LinearTransform> BasePoseTransforms { get; set; } = new();

		[ContainerField(128)]
		public StaticModelNetworkInfo NetworkInfo { get; set; } = new();

		[ContainerField(144)]
		public List<PhysicsPartInfo> PhysicsPartInfos { get; set; } = new();

		[ContainerField(148), LayoutImmutable, Blittable]
		public bool ExcludeFromNearbyObjectDestruction { get; set; }

		[ContainerField(149), LayoutImmutable, Blittable]
		public bool AnimatePhysics { get; set; }

		[ContainerField(150), LayoutImmutable, Blittable]
		public bool Visible { get; set; }

		public static void Deserialize(StaticModelEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.PartLinks.Clear();
			(RimeReader Reader, uint Count) s_PartLinks = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_PartLinks.Count; ++i)
			{
				var s_CtrRef = new CtrRef<PartLinkData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_PartLinks.Reader.ReadUInt32()));
				p_Instance.PartLinks.Add(s_CtrRef);
			}
			
			s_PartLinks.Reader.Dispose();
			p_Instance.Mesh.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.BoneCount = p_Reader.ReadUInt32();
			p_Instance.BasePoseTransforms.Clear();
			(RimeReader Reader, uint Count) s_BasePoseTransforms = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_BasePoseTransforms.Count; ++i)
			{
				var s_Value = new LinearTransform();
				fb.LinearTransform.Deserialize(s_Value, s_BasePoseTransforms.Reader, p_Parser);
				p_Instance.BasePoseTransforms.Add(s_Value);
			}
			
			s_BasePoseTransforms.Reader.Dispose();
			fb.StaticModelNetworkInfo.Deserialize(p_Instance.NetworkInfo, p_Reader, p_Parser);
			p_Instance.PhysicsPartInfos.Clear();
			(RimeReader Reader, uint Count) s_PhysicsPartInfos = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_PhysicsPartInfos.Count; ++i)
			{
				var s_Value = new PhysicsPartInfo();
				fb.PhysicsPartInfo.Deserialize(s_Value, s_PhysicsPartInfos.Reader, p_Parser);
				p_Instance.PhysicsPartInfos.Add(s_Value);
			}
			
			s_PhysicsPartInfos.Reader.Dispose();
			p_Instance.ExcludeFromNearbyObjectDestruction = p_Reader.ReadBool();
			p_Instance.AnimatePhysics = p_Reader.ReadBool();
			p_Instance.Visible = p_Reader.ReadBool();
			p_Reader.Seek(9, SeekOrigin.Current);
		}

	}
}
