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
	public class VisualTerrainEntityData : 
		EntityData
	{
		protected CtrRef<TerrainData> m_Terrain = new CtrRef<TerrainData>();
		[ContainerField(12), ContainerFieldNameHash(3173545970)]
		public CtrRef<TerrainData> Terrain { get { return m_Terrain; } set { if (OnPropertyChanging("VisualTerrainEntityData." + nameof(Terrain), this, m_Terrain, value)) m_Terrain = value; } } // 0xC (12)
		
		protected CtrRef<VisualTerrainSettings> m_Settings = new CtrRef<VisualTerrainSettings>();
		[ContainerField(16), ContainerFieldNameHash(649772672)]
		public CtrRef<VisualTerrainSettings> Settings { get { return m_Settings; } set { if (OnPropertyChanging("VisualTerrainEntityData." + nameof(Settings), this, m_Settings, value)) m_Settings = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3173545970:
					Terrain = (CtrRef<TerrainData>) p_Value;
					break;

				case 649772672:
					Settings = (CtrRef<VisualTerrainSettings>) p_Value;
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
				case 3173545970:
					return Terrain;

				case 649772672:
					return Settings;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3173545970:
					return typeof(VisualTerrainEntityData).GetProperty(nameof(Terrain));

				case 649772672:
					return typeof(VisualTerrainEntityData).GetProperty(nameof(Settings));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
