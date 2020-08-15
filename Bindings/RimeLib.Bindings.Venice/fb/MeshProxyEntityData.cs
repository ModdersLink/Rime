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
	public class MeshProxyEntityData : 
		SpatialEntityData
	{
		protected CtrRef<MeshAsset> m_Mesh = new CtrRef<MeshAsset>();
		[ContainerField(80), ContainerFieldNameHash(2088783990)]
		public CtrRef<MeshAsset> Mesh { get { return m_Mesh; } set { if (OnPropertyChanging("MeshProxyEntityData." + nameof(Mesh), this, m_Mesh, value)) m_Mesh = value; } } // 0x50 (80)
		
		protected List<LinearTransform> m_BasePoseTransforms = new List<LinearTransform>();
		[ContainerField(84), ContainerFieldNameHash(2949884966)]
		public List<LinearTransform> BasePoseTransforms { get { return m_BasePoseTransforms; } set { if (OnPropertyChanging("MeshProxyEntityData." + nameof(BasePoseTransforms), this, m_BasePoseTransforms, value)) m_BasePoseTransforms = value; } } // 0x54 (84)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088783990:
					Mesh = (CtrRef<MeshAsset>) p_Value;
					break;

				case 2949884966:
					BasePoseTransforms = (List<LinearTransform>) p_Value;
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

				case 2949884966:
					return BasePoseTransforms;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088783990:
					return typeof(MeshProxyEntityData).GetProperty(nameof(Mesh));

				case 2949884966:
					return typeof(MeshProxyEntityData).GetProperty(nameof(BasePoseTransforms));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
