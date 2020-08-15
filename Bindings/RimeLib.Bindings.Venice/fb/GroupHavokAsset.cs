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
	public class GroupHavokAsset : 
		HavokAsset
	{
		protected List<AssetAabbs> m_Aabb = new List<AssetAabbs>();
		[ContainerField(20), ContainerFieldNameHash(2088635333)]
		public List<AssetAabbs> Aabb { get { return m_Aabb; } set { if (OnPropertyChanging("GroupHavokAsset." + nameof(Aabb), this, m_Aabb, value)) m_Aabb = value; } } // 0x14 (20)
		
		protected List<ushort> m_ExternalAssetScaleIndex = new List<ushort>();
		[ContainerField(24), ContainerFieldNameHash(29154286)]
		public List<ushort> ExternalAssetScaleIndex { get { return m_ExternalAssetScaleIndex; } set { if (OnPropertyChanging("GroupHavokAsset." + nameof(ExternalAssetScaleIndex), this, m_ExternalAssetScaleIndex, value)) m_ExternalAssetScaleIndex = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088635333:
					Aabb = (List<AssetAabbs>) p_Value;
					break;

				case 29154286:
					ExternalAssetScaleIndex = (List<ushort>) p_Value;
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
				case 2088635333:
					return Aabb;

				case 29154286:
					return ExternalAssetScaleIndex;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088635333:
					return typeof(GroupHavokAsset).GetProperty(nameof(Aabb));

				case 29154286:
					return typeof(GroupHavokAsset).GetProperty(nameof(ExternalAssetScaleIndex));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
