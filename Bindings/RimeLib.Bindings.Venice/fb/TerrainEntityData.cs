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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 128)]
	public class TerrainEntityData : 
		GamePhysicsEntityData
	{
		protected CtrRef<TerrainData> m_TerrainAsset = new CtrRef<TerrainData>();
		[ContainerField(Name: "TerrainAsset", Offset: 112, NameHash: 84434530, Flags: 53)]
		public CtrRef<TerrainData> TerrainAsset { get { return m_TerrainAsset; } set { if (OnPropertyChanging("TerrainEntityData." + nameof(TerrainAsset), this, m_TerrainAsset, value)) m_TerrainAsset = value; } } // 0x70 (112)
		
		protected CtrRef<MaterialContainerPair> m_WaterMaterial = new CtrRef<MaterialContainerPair>();
		[ContainerField(Name: "WaterMaterial", Offset: 116, NameHash: 2658409947, Flags: 53)]
		public CtrRef<MaterialContainerPair> WaterMaterial { get { return m_WaterMaterial; } set { if (OnPropertyChanging("TerrainEntityData." + nameof(WaterMaterial), this, m_WaterMaterial, value)) m_WaterMaterial = value; } } // 0x74 (116)
		
		protected bool m_Visible = new bool();
		[ContainerField(Name: "Visible", Offset: 120, NameHash: 901540267, Flags: 49325), LayoutImmutable, Blittable]
		public bool Visible { get { return m_Visible; } set { if (OnPropertyChanging("TerrainEntityData." + nameof(Visible), this, m_Visible, value)) m_Visible = value; } } // 0x78 (120)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 84434530:
					TerrainAsset = (CtrRef<TerrainData>) p_Value;
					break;

				case 2658409947:
					WaterMaterial = (CtrRef<MaterialContainerPair>) p_Value;
					break;

				case 901540267:
					Visible = (bool) p_Value;
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
				case 84434530:
					return TerrainAsset;

				case 2658409947:
					return WaterMaterial;

				case 901540267:
					return Visible;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 84434530:
					return typeof(TerrainEntityData).GetProperty(nameof(TerrainAsset));

				case 2658409947:
					return typeof(TerrainEntityData).GetProperty(nameof(WaterMaterial));

				case 901540267:
					return typeof(TerrainEntityData).GetProperty(nameof(Visible));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
