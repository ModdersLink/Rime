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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(48), ContainerClass]
	public class WorldData : 
		SubWorldData
	{
		protected CtrRef<MaterialGridData> m_RuntimeMaterialGrid = new CtrRef<MaterialGridData>();
		[ContainerField(44), MemberInfoFlag(53), ContainerFieldNameHash(1453435306), ContainerCtrRef]
		public CtrRef<MaterialGridData> RuntimeMaterialGrid { get { return m_RuntimeMaterialGrid; } set { if (OnPropertyChanging("WorldData." + nameof(RuntimeMaterialGrid), this, m_RuntimeMaterialGrid, value)) m_RuntimeMaterialGrid = value; } } // 0x2C (44)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1453435306:
					RuntimeMaterialGrid = (CtrRef<MaterialGridData>) p_Value;
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
				case 1453435306:
					return RuntimeMaterialGrid;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1453435306:
					return typeof(WorldData).GetProperty(nameof(RuntimeMaterialGrid));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
