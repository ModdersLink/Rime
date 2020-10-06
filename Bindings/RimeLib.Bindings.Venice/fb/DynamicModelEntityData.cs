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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(128), ContainerClass]
	public class DynamicModelEntityData : 
		DynamicGamePhysicsEntityData
	{
		protected CtrRef<PartComponentData> m_Part = new CtrRef<PartComponentData>();
		[ContainerField(112), MemberInfoFlag(53), ContainerFieldNameHash(2089448370), ContainerCtrRef]
		public CtrRef<PartComponentData> Part { get { return m_Part; } set { if (OnPropertyChanging("DynamicModelEntityData." + nameof(Part), this, m_Part, value)) m_Part = value; } } // 0x70 (112)
		
		protected CtrRef<MeshAsset> m_Mesh = new CtrRef<MeshAsset>();
		[ContainerField(116), MemberInfoFlag(53), ContainerFieldNameHash(2088783990), ContainerCtrRef]
		public CtrRef<MeshAsset> Mesh { get { return m_Mesh; } set { if (OnPropertyChanging("DynamicModelEntityData." + nameof(Mesh), this, m_Mesh, value)) m_Mesh = value; } } // 0x74 (116)
		
		protected bool m_NoCollision = new bool();
		[ContainerField(120), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3513186074)]
		public bool NoCollision { get { return m_NoCollision; } set { if (OnPropertyChanging("DynamicModelEntityData." + nameof(NoCollision), this, m_NoCollision, value)) m_NoCollision = value; } } // 0x78 (120)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2089448370:
					Part = (CtrRef<PartComponentData>) p_Value;
					break;

				case 2088783990:
					Mesh = (CtrRef<MeshAsset>) p_Value;
					break;

				case 3513186074:
					NoCollision = (bool) p_Value;
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
				case 2089448370:
					return Part;

				case 2088783990:
					return Mesh;

				case 3513186074:
					return NoCollision;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2089448370:
					return typeof(DynamicModelEntityData).GetProperty(nameof(Part));

				case 2088783990:
					return typeof(DynamicModelEntityData).GetProperty(nameof(Mesh));

				case 3513186074:
					return typeof(DynamicModelEntityData).GetProperty(nameof(NoCollision));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
