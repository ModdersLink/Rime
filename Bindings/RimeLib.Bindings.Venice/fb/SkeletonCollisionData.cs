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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class SkeletonCollisionData : 
		DataContainer
	{
		protected CtrRef<SkeletonAsset> m_SkeletonAsset = new CtrRef<SkeletonAsset>();
		[ContainerField(Name: "SkeletonAsset", Offset: 8, NameHash: 2375870068, Flags: 53)]
		public CtrRef<SkeletonAsset> SkeletonAsset { get { return m_SkeletonAsset; } set { if (OnPropertyChanging("SkeletonCollisionData." + nameof(SkeletonAsset), this, m_SkeletonAsset, value)) m_SkeletonAsset = value; } } // 0x8 (8)
		
		protected List<BoneCollisionData> m_BoneCollisionData = new List<BoneCollisionData>();
		[ContainerField(Name: "BoneCollisionData", Offset: 12, NameHash: 3073290765, Flags: 65)]
		public List<BoneCollisionData> BoneCollisionData { get { return m_BoneCollisionData; } set { if (OnPropertyChanging("SkeletonCollisionData." + nameof(BoneCollisionData), this, m_BoneCollisionData, value)) m_BoneCollisionData = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2375870068:
					SkeletonAsset = (CtrRef<SkeletonAsset>) p_Value;
					break;

				case 3073290765:
					BoneCollisionData = (List<BoneCollisionData>) p_Value;
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

				case 3073290765:
					return BoneCollisionData;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2375870068:
					return typeof(SkeletonCollisionData).GetProperty(nameof(SkeletonAsset));

				case 3073290765:
					return typeof(SkeletonCollisionData).GetProperty(nameof(BoneCollisionData));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
