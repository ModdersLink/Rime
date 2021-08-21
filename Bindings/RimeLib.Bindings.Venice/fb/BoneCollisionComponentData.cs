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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class BoneCollisionComponentData : 
		ComponentData
	{
		protected CtrRef<SkeletonCollisionData> m_SkeletonCollisionData = new CtrRef<SkeletonCollisionData>();
		[ContainerField(Name: "SkeletonCollisionData", Offset: 96, NameHash: 2418871594, Flags: 53)]
		public CtrRef<SkeletonCollisionData> SkeletonCollisionData { get { return m_SkeletonCollisionData; } set { if (OnPropertyChanging("BoneCollisionComponentData." + nameof(SkeletonCollisionData), this, m_SkeletonCollisionData, value)) m_SkeletonCollisionData = value; } } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2418871594:
					SkeletonCollisionData = (CtrRef<SkeletonCollisionData>) p_Value;
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
				case 2418871594:
					return SkeletonCollisionData;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2418871594:
					return typeof(BoneCollisionComponentData).GetProperty(nameof(SkeletonCollisionData));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
