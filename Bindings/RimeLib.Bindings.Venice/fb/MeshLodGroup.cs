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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 40)]
	public class MeshLodGroup : 
		Asset
	{
		protected float m_Lod1Distance = new float();
		[ContainerField(Name: "Lod1Distance", Offset: 12, NameHash: 3299281840, Flags: 49469), LayoutImmutable, Blittable]
		public float Lod1Distance { get { return m_Lod1Distance; } set { if (OnPropertyChanging("MeshLodGroup." + nameof(Lod1Distance), this, m_Lod1Distance, value)) m_Lod1Distance = value; } } // 0xC (12)
		
		protected float m_Lod2Distance = new float();
		[ContainerField(Name: "Lod2Distance", Offset: 16, NameHash: 4081582771, Flags: 49469), LayoutImmutable, Blittable]
		public float Lod2Distance { get { return m_Lod2Distance; } set { if (OnPropertyChanging("MeshLodGroup." + nameof(Lod2Distance), this, m_Lod2Distance, value)) m_Lod2Distance = value; } } // 0x10 (16)
		
		protected float m_Lod3Distance = new float();
		[ContainerField(Name: "Lod3Distance", Offset: 20, NameHash: 2570967730, Flags: 49469), LayoutImmutable, Blittable]
		public float Lod3Distance { get { return m_Lod3Distance; } set { if (OnPropertyChanging("MeshLodGroup." + nameof(Lod3Distance), this, m_Lod3Distance, value)) m_Lod3Distance = value; } } // 0x14 (20)
		
		protected float m_Lod4Distance = new float();
		[ContainerField(Name: "Lod4Distance", Offset: 24, NameHash: 4154142901, Flags: 49469), LayoutImmutable, Blittable]
		public float Lod4Distance { get { return m_Lod4Distance; } set { if (OnPropertyChanging("MeshLodGroup." + nameof(Lod4Distance), this, m_Lod4Distance, value)) m_Lod4Distance = value; } } // 0x18 (24)
		
		protected float m_Lod5Distance = new float();
		[ContainerField(Name: "Lod5Distance", Offset: 28, NameHash: 890948276, Flags: 49469), LayoutImmutable, Blittable]
		public float Lod5Distance { get { return m_Lod5Distance; } set { if (OnPropertyChanging("MeshLodGroup." + nameof(Lod5Distance), this, m_Lod5Distance, value)) m_Lod5Distance = value; } } // 0x1C (28)
		
		protected float m_ShadowDistance = new float();
		[ContainerField(Name: "ShadowDistance", Offset: 32, NameHash: 4181554240, Flags: 49469), LayoutImmutable, Blittable]
		public float ShadowDistance { get { return m_ShadowDistance; } set { if (OnPropertyChanging("MeshLodGroup." + nameof(ShadowDistance), this, m_ShadowDistance, value)) m_ShadowDistance = value; } } // 0x20 (32)
		
		protected float m_CullScreenArea = new float();
		[ContainerField(Name: "CullScreenArea", Offset: 36, NameHash: 3413873864, Flags: 49469), LayoutImmutable, Blittable]
		public float CullScreenArea { get { return m_CullScreenArea; } set { if (OnPropertyChanging("MeshLodGroup." + nameof(CullScreenArea), this, m_CullScreenArea, value)) m_CullScreenArea = value; } } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3299281840:
					Lod1Distance = (float) p_Value;
					break;

				case 4081582771:
					Lod2Distance = (float) p_Value;
					break;

				case 2570967730:
					Lod3Distance = (float) p_Value;
					break;

				case 4154142901:
					Lod4Distance = (float) p_Value;
					break;

				case 890948276:
					Lod5Distance = (float) p_Value;
					break;

				case 4181554240:
					ShadowDistance = (float) p_Value;
					break;

				case 3413873864:
					CullScreenArea = (float) p_Value;
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
				case 3299281840:
					return Lod1Distance;

				case 4081582771:
					return Lod2Distance;

				case 2570967730:
					return Lod3Distance;

				case 4154142901:
					return Lod4Distance;

				case 890948276:
					return Lod5Distance;

				case 4181554240:
					return ShadowDistance;

				case 3413873864:
					return CullScreenArea;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3299281840:
					return typeof(MeshLodGroup).GetProperty(nameof(Lod1Distance));

				case 4081582771:
					return typeof(MeshLodGroup).GetProperty(nameof(Lod2Distance));

				case 2570967730:
					return typeof(MeshLodGroup).GetProperty(nameof(Lod3Distance));

				case 4154142901:
					return typeof(MeshLodGroup).GetProperty(nameof(Lod4Distance));

				case 890948276:
					return typeof(MeshLodGroup).GetProperty(nameof(Lod5Distance));

				case 4181554240:
					return typeof(MeshLodGroup).GetProperty(nameof(ShadowDistance));

				case 3413873864:
					return typeof(MeshLodGroup).GetProperty(nameof(CullScreenArea));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
