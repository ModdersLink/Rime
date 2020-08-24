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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class MasterSkeletonAsset : 
		Asset
	{
		protected CtrRef<SkeletonAsset> m_MasterSkeleton = new CtrRef<SkeletonAsset>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(1934150648), ContainerCtrRef]
		public CtrRef<SkeletonAsset> MasterSkeleton { get { return m_MasterSkeleton; } set { if (OnPropertyChanging("MasterSkeletonAsset." + nameof(MasterSkeleton), this, m_MasterSkeleton, value)) m_MasterSkeleton = value; } } // 0xC (12)
		
		protected List<SubSkeleton> m_SubSkeletons = new List<SubSkeleton>();
		[ContainerField(16), MemberInfoFlag(65), ContainerFieldNameHash(2966147091), ContainerArray]
		public List<SubSkeleton> SubSkeletons { get { return m_SubSkeletons; } set { if (OnPropertyChanging("MasterSkeletonAsset." + nameof(SubSkeletons), this, m_SubSkeletons, value)) m_SubSkeletons = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1934150648:
					MasterSkeleton = (CtrRef<SkeletonAsset>) p_Value;
					break;

				case 2966147091:
					SubSkeletons = (List<SubSkeleton>) p_Value;
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
				case 1934150648:
					return MasterSkeleton;

				case 2966147091:
					return SubSkeletons;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1934150648:
					return typeof(MasterSkeletonAsset).GetProperty(nameof(MasterSkeleton));

				case 2966147091:
					return typeof(MasterSkeletonAsset).GetProperty(nameof(SubSkeletons));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
