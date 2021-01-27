///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 36)]
	public class AntAnimationSetAsset : 
		Asset
	{
		protected CtrRef<SkeletonAsset> m_SkeletonAsset = new CtrRef<SkeletonAsset>();
		[ContainerField(Name: "SkeletonAsset", Offset: 12, NameHash: 2375870068, Flags: 53)]
		public CtrRef<SkeletonAsset> SkeletonAsset { get { return m_SkeletonAsset; } set { if (OnPropertyChanging("AntAnimationSetAsset." + nameof(SkeletonAsset), this, m_SkeletonAsset, value)) m_SkeletonAsset = value; } } // 0xC (12)
		
		protected int m_ActorAssetIndex = new int();
		[ContainerField(Name: "ActorAssetIndex", Offset: 16, NameHash: 1719210944, Flags: 49405), LayoutImmutable, Blittable]
		public int ActorAssetIndex { get { return m_ActorAssetIndex; } set { if (OnPropertyChanging("AntAnimationSetAsset." + nameof(ActorAssetIndex), this, m_ActorAssetIndex, value)) m_ActorAssetIndex = value; } } // 0x10 (16)
		
		protected List<int> m_ClipAssetIndices = new List<int>();
		[ContainerField(Name: "ClipAssetIndices", Offset: 20, NameHash: 3918246524, Flags: 65)]
		public List<int> ClipAssetIndices { get { return m_ClipAssetIndices; } set { if (OnPropertyChanging("AntAnimationSetAsset." + nameof(ClipAssetIndices), this, m_ClipAssetIndices, value)) m_ClipAssetIndices = value; } } // 0x14 (20)
		
		protected List<int> m_LoopingClipAssetIndices = new List<int>();
		[ContainerField(Name: "LoopingClipAssetIndices", Offset: 24, NameHash: 346444768, Flags: 65)]
		public List<int> LoopingClipAssetIndices { get { return m_LoopingClipAssetIndices; } set { if (OnPropertyChanging("AntAnimationSetAsset." + nameof(LoopingClipAssetIndices), this, m_LoopingClipAssetIndices, value)) m_LoopingClipAssetIndices = value; } } // 0x18 (24)
		
		protected int m_SceneOpMatrixAssetIndex = new int();
		[ContainerField(Name: "SceneOpMatrixAssetIndex", Offset: 28, NameHash: 1085428945, Flags: 49405), LayoutImmutable, Blittable]
		public int SceneOpMatrixAssetIndex { get { return m_SceneOpMatrixAssetIndex; } set { if (OnPropertyChanging("AntAnimationSetAsset." + nameof(SceneOpMatrixAssetIndex), this, m_SceneOpMatrixAssetIndex, value)) m_SceneOpMatrixAssetIndex = value; } } // 0x1C (28)
		
		protected bool m_UseTraj2Ref = new bool();
		[ContainerField(Name: "UseTraj2Ref", Offset: 32, NameHash: 880398792, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseTraj2Ref { get { return m_UseTraj2Ref; } set { if (OnPropertyChanging("AntAnimationSetAsset." + nameof(UseTraj2Ref), this, m_UseTraj2Ref, value)) m_UseTraj2Ref = value; } } // 0x20 (32)
		
		protected bool m_AllowAnimationCulling = new bool();
		[ContainerField(Name: "AllowAnimationCulling", Offset: 33, NameHash: 524938044, Flags: 49325), LayoutImmutable, Blittable]
		public bool AllowAnimationCulling { get { return m_AllowAnimationCulling; } set { if (OnPropertyChanging("AntAnimationSetAsset." + nameof(AllowAnimationCulling), this, m_AllowAnimationCulling, value)) m_AllowAnimationCulling = value; } } // 0x21 (33)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2375870068:
					SkeletonAsset = (CtrRef<SkeletonAsset>) p_Value;
					break;

				case 1719210944:
					ActorAssetIndex = (int) p_Value;
					break;

				case 3918246524:
					ClipAssetIndices = (List<int>) p_Value;
					break;

				case 346444768:
					LoopingClipAssetIndices = (List<int>) p_Value;
					break;

				case 1085428945:
					SceneOpMatrixAssetIndex = (int) p_Value;
					break;

				case 880398792:
					UseTraj2Ref = (bool) p_Value;
					break;

				case 524938044:
					AllowAnimationCulling = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2375870068:
					return SkeletonAsset;

				case 1719210944:
					return ActorAssetIndex;

				case 3918246524:
					return ClipAssetIndices;

				case 346444768:
					return LoopingClipAssetIndices;

				case 1085428945:
					return SceneOpMatrixAssetIndex;

				case 880398792:
					return UseTraj2Ref;

				case 524938044:
					return AllowAnimationCulling;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2375870068:
					return typeof(AntAnimationSetAsset).GetProperty(nameof(SkeletonAsset));

				case 1719210944:
					return typeof(AntAnimationSetAsset).GetProperty(nameof(ActorAssetIndex));

				case 3918246524:
					return typeof(AntAnimationSetAsset).GetProperty(nameof(ClipAssetIndices));

				case 346444768:
					return typeof(AntAnimationSetAsset).GetProperty(nameof(LoopingClipAssetIndices));

				case 1085428945:
					return typeof(AntAnimationSetAsset).GetProperty(nameof(SceneOpMatrixAssetIndex));

				case 880398792:
					return typeof(AntAnimationSetAsset).GetProperty(nameof(UseTraj2Ref));

				case 524938044:
					return typeof(AntAnimationSetAsset).GetProperty(nameof(AllowAnimationCulling));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
