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
	[ContainerType(4)]
	public class DebrisSystemAsset : 
		Asset
	{
		protected List<DebrisHavokInfo> m_HavokMeshes = new List<DebrisHavokInfo>();
		[ContainerField(12), ContainerFieldNameHash(3852503739)]
		public List<DebrisHavokInfo> HavokMeshes { get { return m_HavokMeshes; } set { if (OnPropertyChanging("DebrisSystemAsset." + nameof(HavokMeshes), this, m_HavokMeshes, value)) m_HavokMeshes = value; } } // 0xC (12)
		
		protected int m_HavokMeshCount = new int();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(3497183694)]
		public int HavokMeshCount { get { return m_HavokMeshCount; } set { if (OnPropertyChanging("DebrisSystemAsset." + nameof(HavokMeshCount), this, m_HavokMeshCount, value)) m_HavokMeshCount = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3852503739:
					HavokMeshes = (List<DebrisHavokInfo>) p_Value;
					break;

				case 3497183694:
					HavokMeshCount = (int) p_Value;
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
				case 3852503739:
					return HavokMeshes;

				case 3497183694:
					return HavokMeshCount;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3852503739:
					return typeof(DebrisSystemAsset).GetProperty(nameof(HavokMeshes));

				case 3497183694:
					return typeof(DebrisSystemAsset).GetProperty(nameof(HavokMeshCount));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
