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
	public class ModelAnimationEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform AnimationEntitySpace { get; set; } = new();

		[ContainerField(80)]
		public GameplayBones BoneToPlace { get; set; } = new();

		[ContainerField(84)]
		public Realm Realm { get; set; } = new();

		[ContainerField(88)]
		public ModelAnimationTransformType ModelAnimationTransformType { get; set; } = new();

		[ContainerField(92), LayoutImmutable, Blittable]
		public int InstanceSeed { get; set; }

		[ContainerField(96), LayoutImmutable]
		public string DefaultAnimation { get; set; } = string.Empty;

		[ContainerField(100), LayoutImmutable, Blittable]
		public int AnimationIndex { get; set; }

		[ContainerField(104)]
		public CtrRef<AntAnimationSetAsset> AnimationSet { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable]
		public float ExternalTime { get; set; }

		[ContainerField(112), LayoutImmutable]
		public string RootMeshBoneName { get; set; } = string.Empty;

		[ContainerField(116)]
		public ModelAnimationUpdateOrder JointWorldTransformUpdateOrder { get; set; } = new();

		[ContainerField(120), LayoutImmutable]
		public string ConnectBoneName { get; set; } = string.Empty;

		[ContainerField(124)]
		public List<int> JointOutputPropertyIds { get; set; } = new();

		[ContainerField(128), LayoutImmutable]
		public string TrajectoryBoneName { get; set; } = string.Empty;

		[ContainerField(132), LayoutImmutable, Blittable]
		public bool AnimationEntitySpaceActive { get; set; }

		[ContainerField(133), LayoutImmutable, Blittable]
		public bool PlayFirstFrame { get; set; }

		[ContainerField(134), LayoutImmutable, Blittable]
		public bool Looping { get; set; }

		[ContainerField(135), LayoutImmutable, Blittable]
		public bool EnableJointWorldTransformOutput { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public bool ResetAfterStop { get; set; }

		[ContainerField(137), LayoutImmutable, Blittable]
		public bool AutoStart { get; set; }

		[ContainerField(138), LayoutImmutable, Blittable]
		public bool ShowDebugTransforms { get; set; }

		[ContainerField(139), LayoutImmutable, Blittable]
		public bool ApplyRotationCompensation { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public bool ApplyPreTransformation { get; set; }

		[ContainerField(141), LayoutImmutable, Blittable]
		public bool DisableCulling { get; set; }

		public static void Deserialize(ModelAnimationEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.LinearTransform.Deserialize(p_Instance.AnimationEntitySpace, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.BoneToPlace = (GameplayBones) p_Reader.ReadInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.ModelAnimationTransformType = (ModelAnimationTransformType) p_Reader.ReadInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.InstanceSeed = p_Reader.ReadInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.DefaultAnimation = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.AnimationIndex = p_Reader.ReadInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.AnimationSet.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.ExternalTime = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.RootMeshBoneName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.JointWorldTransformUpdateOrder = (ModelAnimationUpdateOrder) p_Reader.ReadInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.ConnectBoneName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.JointOutputPropertyIds.Clear();
			(RimeReader Reader, uint Count) s_JointOutputPropertyIds = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_JointOutputPropertyIds.Count; ++i)
			{
				var s_Value = s_JointOutputPropertyIds.Reader.ReadInt32();
				p_Instance.JointOutputPropertyIds.Add(s_Value);
			}
			
			s_JointOutputPropertyIds.Reader.Dispose();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.TrajectoryBoneName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.AnimationEntitySpaceActive = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.PlayFirstFrame = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.Looping = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.EnableJointWorldTransformOutput = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.ResetAfterStop = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.AutoStart = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.ShowDebugTransforms = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.ApplyRotationCompensation = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.ApplyPreTransformation = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.DisableCulling = p_Reader.ReadBool();
			p_Reader.Seek(6, SeekOrigin.Current);
		}

	}
}
