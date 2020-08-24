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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class CompositeMeshEntityData : 
		SpatialEntityData
	{
		protected CtrRef<CompositeMeshAsset> m_Mesh = new CtrRef<CompositeMeshAsset>();
		[ContainerField(80), MemberInfoFlag(53), ContainerFieldNameHash(2088783990), ContainerCtrRef]
		public CtrRef<CompositeMeshAsset> Mesh { get { return m_Mesh; } set { if (OnPropertyChanging("CompositeMeshEntityData." + nameof(Mesh), this, m_Mesh, value)) m_Mesh = value; } } // 0x50 (80)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088783990:
					Mesh = (CtrRef<CompositeMeshAsset>) p_Value;
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
				case 2088783990:
					return Mesh;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088783990:
					return typeof(CompositeMeshEntityData).GetProperty(nameof(Mesh));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
