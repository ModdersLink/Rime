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
	[ContainerType(16)]
	public class RagdollComponentData : 
		ComponentData
	{
		protected CtrRef<SkeletonAsset> m_SkeletonAsset = new CtrRef<SkeletonAsset>();
		[ContainerField(96), ContainerFieldNameHash(2375870068)]
		public CtrRef<SkeletonAsset> SkeletonAsset { get { return m_SkeletonAsset; } set { if (OnPropertyChanging("RagdollComponentData." + nameof(SkeletonAsset), this, m_SkeletonAsset, value)) m_SkeletonAsset = value; } } // 0x60 (96)
		
		protected CtrRef<RagdollAsset> m_RagdollAsset = new CtrRef<RagdollAsset>();
		[ContainerField(100), ContainerFieldNameHash(4111789834)]
		public CtrRef<RagdollAsset> RagdollAsset { get { return m_RagdollAsset; } set { if (OnPropertyChanging("RagdollComponentData." + nameof(RagdollAsset), this, m_RagdollAsset, value)) m_RagdollAsset = value; } } // 0x64 (100)
		
		protected CtrRef<SkeletonCollisionData> m_SkeletonCollisionData = new CtrRef<SkeletonCollisionData>();
		[ContainerField(104), ContainerFieldNameHash(2418871594)]
		public CtrRef<SkeletonCollisionData> SkeletonCollisionData { get { return m_SkeletonCollisionData; } set { if (OnPropertyChanging("RagdollComponentData." + nameof(SkeletonCollisionData), this, m_SkeletonCollisionData, value)) m_SkeletonCollisionData = value; } } // 0x68 (104)
		
		protected RagdollBinding m_Binding = new RagdollBinding();
		[ContainerField(108), ContainerFieldNameHash(2590060228)]
		public RagdollBinding Binding { get { return m_Binding; } set { if (OnPropertyChanging("RagdollComponentData." + nameof(Binding), this, m_Binding, value)) m_Binding = value; } } // 0x6C (108)
		
		protected string m_LeftLegBoneName = new string();
		[ContainerField(128), LayoutImmutable, ContainerFieldNameHash(718235633)]
		public string LeftLegBoneName { get { return m_LeftLegBoneName; } set { if (OnPropertyChanging("RagdollComponentData." + nameof(LeftLegBoneName), this, m_LeftLegBoneName, value)) m_LeftLegBoneName = value; } } // 0x80 (128)
		
		protected string m_RightLegBoneName = new string();
		[ContainerField(132), LayoutImmutable, ContainerFieldNameHash(3038502186)]
		public string RightLegBoneName { get { return m_RightLegBoneName; } set { if (OnPropertyChanging("RagdollComponentData." + nameof(RightLegBoneName), this, m_RightLegBoneName, value)) m_RightLegBoneName = value; } } // 0x84 (132)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2375870068:
					SkeletonAsset = (CtrRef<SkeletonAsset>) p_Value;
					break;

				case 4111789834:
					RagdollAsset = (CtrRef<RagdollAsset>) p_Value;
					break;

				case 2418871594:
					SkeletonCollisionData = (CtrRef<SkeletonCollisionData>) p_Value;
					break;

				case 2590060228:
					Binding = (RagdollBinding) p_Value;
					break;

				case 718235633:
					LeftLegBoneName = (string) p_Value;
					break;

				case 3038502186:
					RightLegBoneName = (string) p_Value;
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

				case 4111789834:
					return RagdollAsset;

				case 2418871594:
					return SkeletonCollisionData;

				case 2590060228:
					return Binding;

				case 718235633:
					return LeftLegBoneName;

				case 3038502186:
					return RightLegBoneName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2375870068:
					return typeof(RagdollComponentData).GetProperty(nameof(SkeletonAsset));

				case 4111789834:
					return typeof(RagdollComponentData).GetProperty(nameof(RagdollAsset));

				case 2418871594:
					return typeof(RagdollComponentData).GetProperty(nameof(SkeletonCollisionData));

				case 2590060228:
					return typeof(RagdollComponentData).GetProperty(nameof(Binding));

				case 718235633:
					return typeof(RagdollComponentData).GetProperty(nameof(LeftLegBoneName));

				case 3038502186:
					return typeof(RagdollComponentData).GetProperty(nameof(RightLegBoneName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
