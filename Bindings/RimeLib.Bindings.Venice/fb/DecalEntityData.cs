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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 128)]
	public class DecalEntityData : 
		GameEntityData
	{
		protected CtrRef<SurfaceShaderBaseAsset> m_Shader = new CtrRef<SurfaceShaderBaseAsset>();
		[ContainerField(Name: "Shader", Offset: 96, NameHash: 3352909900, Flags: 53)]
		public CtrRef<SurfaceShaderBaseAsset> Shader { get { return m_Shader; } set { if (OnPropertyChanging("DecalEntityData." + nameof(Shader), this, m_Shader, value)) m_Shader = value; } } // 0x60 (96)
		
		protected DecalAtlasTile m_AtlasTile = new DecalAtlasTile();
		[ContainerField(Name: "AtlasTile", Offset: 100, NameHash: 3027817338, Flags: 41)]
		public DecalAtlasTile AtlasTile { get { return m_AtlasTile; } set { if (OnPropertyChanging("DecalEntityData." + nameof(AtlasTile), this, m_AtlasTile, value)) m_AtlasTile = value; } } // 0x64 (100)
		
		protected sbyte m_MaterialIndex = new sbyte();
		[ContainerField(Name: "MaterialIndex", Offset: 120, NameHash: 1001372496, Flags: 49341), LayoutImmutable, Blittable]
		public sbyte MaterialIndex { get { return m_MaterialIndex; } set { if (OnPropertyChanging("DecalEntityData." + nameof(MaterialIndex), this, m_MaterialIndex, value)) m_MaterialIndex = value; } } // 0x78 (120)
		
		protected sbyte m_SortingPriority = new sbyte();
		[ContainerField(Name: "SortingPriority", Offset: 121, NameHash: 3523655821, Flags: 49341), LayoutImmutable, Blittable]
		public sbyte SortingPriority { get { return m_SortingPriority; } set { if (OnPropertyChanging("DecalEntityData." + nameof(SortingPriority), this, m_SortingPriority, value)) m_SortingPriority = value; } } // 0x79 (121)
		
		protected bool m_Projected = new bool();
		[ContainerField(Name: "Projected", Offset: 122, NameHash: 4152361265, Flags: 49325), LayoutImmutable, Blittable]
		public bool Projected { get { return m_Projected; } set { if (OnPropertyChanging("DecalEntityData." + nameof(Projected), this, m_Projected, value)) m_Projected = value; } } // 0x7A (122)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3352909900:
					Shader = (CtrRef<SurfaceShaderBaseAsset>) p_Value;
					break;

				case 3027817338:
					AtlasTile = (DecalAtlasTile) p_Value;
					break;

				case 1001372496:
					MaterialIndex = (sbyte) p_Value;
					break;

				case 3523655821:
					SortingPriority = (sbyte) p_Value;
					break;

				case 4152361265:
					Projected = (bool) p_Value;
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
				case 3352909900:
					return Shader;

				case 3027817338:
					return AtlasTile;

				case 1001372496:
					return MaterialIndex;

				case 3523655821:
					return SortingPriority;

				case 4152361265:
					return Projected;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3352909900:
					return typeof(DecalEntityData).GetProperty(nameof(Shader));

				case 3027817338:
					return typeof(DecalEntityData).GetProperty(nameof(AtlasTile));

				case 1001372496:
					return typeof(DecalEntityData).GetProperty(nameof(MaterialIndex));

				case 3523655821:
					return typeof(DecalEntityData).GetProperty(nameof(SortingPriority));

				case 4152361265:
					return typeof(DecalEntityData).GetProperty(nameof(Projected));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
