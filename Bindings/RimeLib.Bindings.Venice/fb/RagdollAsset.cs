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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class RagdollAsset : 
		Asset
	{
		protected CtrRef<MaterialContainerPair> m_MaterialPair = new CtrRef<MaterialContainerPair>();
		[ContainerField(Name: "MaterialPair", Offset: 12, NameHash: 161392100, Flags: 53)]
		public CtrRef<MaterialContainerPair> MaterialPair { get { return m_MaterialPair; } set { if (OnPropertyChanging("RagdollAsset." + nameof(MaterialPair), this, m_MaterialPair, value)) m_MaterialPair = value; } } // 0xC (12)
		
		protected bool m_UseServerRagdoll = new bool();
		[ContainerField(Name: "UseServerRagdoll", Offset: 16, NameHash: 1214326076, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseServerRagdoll { get { return m_UseServerRagdoll; } set { if (OnPropertyChanging("RagdollAsset." + nameof(UseServerRagdoll), this, m_UseServerRagdoll, value)) m_UseServerRagdoll = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 161392100:
					MaterialPair = (CtrRef<MaterialContainerPair>) p_Value;
					break;

				case 1214326076:
					UseServerRagdoll = (bool) p_Value;
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
				case 161392100:
					return MaterialPair;

				case 1214326076:
					return UseServerRagdoll;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 161392100:
					return typeof(RagdollAsset).GetProperty(nameof(MaterialPair));

				case 1214326076:
					return typeof(RagdollAsset).GetProperty(nameof(UseServerRagdoll));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
