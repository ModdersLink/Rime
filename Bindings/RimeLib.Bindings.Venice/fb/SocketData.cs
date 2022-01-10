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
	public class SocketData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform BoneRigidTransform { get; set; } = new();

		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform Transform { get; set; } = new();

		[ContainerField(144)]
		public CtrRef<UnlockAssetBase> UnlockAsset { get; set; } = new();

		[ContainerField(148), LayoutImmutable, Blittable]
		public int BoneId { get; set; }

		[ContainerField(152), LayoutImmutable]
		public string BoneName { get; set; } = string.Empty;

		[ContainerField(156)]
		public List<CtrRef<SocketObjectDataBase>> AvailableObjects { get; set; } = new();

		[ContainerField(160)]
		public GearSlot GearSlot { get; set; } = new();

		[ContainerField(164)]
		public SocketType SocketType { get; set; } = new();

		[ContainerField(168), LayoutImmutable, Blittable]
		public bool UsesDefaultObject { get; set; }

		[ContainerField(169), LayoutImmutable, Blittable]
		public bool Excluded { get; set; }

		[ContainerField(170), LayoutImmutable, Blittable]
		public bool DefaultEnableSocketEntities { get; set; }

		[ContainerField(171), LayoutImmutable, Blittable]
		public bool ForceSocketEntitiesEnabled { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable]
		public bool HideByZoomTransition { get; set; }

		[ContainerField(173), LayoutImmutable, Blittable]
		public bool HideByLightToggle { get; set; }

		public static void Deserialize(SocketData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.LinearTransform.Deserialize(p_Instance.BoneRigidTransform, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.LinearTransform.Deserialize(p_Instance.Transform, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.UnlockAsset.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.BoneId = p_Reader.ReadInt32();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.BoneName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.AvailableObjects.Clear();
			(RimeReader Reader, uint Count) s_AvailableObjects = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_AvailableObjects.Count; ++i)
			{
				var s_CtrRef = new CtrRef<SocketObjectDataBase>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_AvailableObjects.Reader.ReadUInt32()));
				p_Instance.AvailableObjects.Add(s_CtrRef);
			}
			
			s_AvailableObjects.Reader.Dispose();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.GearSlot = (GearSlot) p_Reader.ReadInt32();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.SocketType = (SocketType) p_Reader.ReadInt32();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.UsesDefaultObject = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.Excluded = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.DefaultEnableSocketEntities = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.ForceSocketEntitiesEnabled = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.HideByZoomTransition = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.HideByLightToggle = p_Reader.ReadBool();
			p_Reader.Seek(10, SeekOrigin.Current);
		}

	}
}
