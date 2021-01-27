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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 96)]
	public class LensFlareEntityData : 
		SpatialEntityData
	{
		protected List<LensFlareElement> m_Elements = new List<LensFlareElement>();
		[ContainerField(Name: "Elements", Offset: 80, NameHash: 2347524808, Flags: 65)]
		public List<LensFlareElement> Elements { get { return m_Elements; } set { if (OnPropertyChanging("LensFlareEntityData." + nameof(Elements), this, m_Elements, value)) m_Elements = value; } } // 0x50 (80)
		
		protected float m_OccluderSize = new float();
		[ContainerField(Name: "OccluderSize", Offset: 84, NameHash: 2630779365, Flags: 49469), LayoutImmutable, Blittable]
		public float OccluderSize { get { return m_OccluderSize; } set { if (OnPropertyChanging("LensFlareEntityData." + nameof(OccluderSize), this, m_OccluderSize, value)) m_OccluderSize = value; } } // 0x54 (84)
		
		protected bool m_Visible = new bool();
		[ContainerField(Name: "Visible", Offset: 88, NameHash: 901540267, Flags: 49325), LayoutImmutable, Blittable]
		public bool Visible { get { return m_Visible; } set { if (OnPropertyChanging("LensFlareEntityData." + nameof(Visible), this, m_Visible, value)) m_Visible = value; } } // 0x58 (88)
		
		protected bool m_HalfRes = new bool();
		[ContainerField(Name: "HalfRes", Offset: 89, NameHash: 2152832706, Flags: 49325), LayoutImmutable, Blittable]
		public bool HalfRes { get { return m_HalfRes; } set { if (OnPropertyChanging("LensFlareEntityData." + nameof(HalfRes), this, m_HalfRes, value)) m_HalfRes = value; } } // 0x59 (89)
		
		protected bool m_DebugDrawOccluder = new bool();
		[ContainerField(Name: "DebugDrawOccluder", Offset: 90, NameHash: 3156672721, Flags: 49325), LayoutImmutable, Blittable]
		public bool DebugDrawOccluder { get { return m_DebugDrawOccluder; } set { if (OnPropertyChanging("LensFlareEntityData." + nameof(DebugDrawOccluder), this, m_DebugDrawOccluder, value)) m_DebugDrawOccluder = value; } } // 0x5A (90)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2347524808:
					Elements = (List<LensFlareElement>) p_Value;
					break;

				case 2630779365:
					OccluderSize = (float) p_Value;
					break;

				case 901540267:
					Visible = (bool) p_Value;
					break;

				case 2152832706:
					HalfRes = (bool) p_Value;
					break;

				case 3156672721:
					DebugDrawOccluder = (bool) p_Value;
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
				case 2347524808:
					return Elements;

				case 2630779365:
					return OccluderSize;

				case 901540267:
					return Visible;

				case 2152832706:
					return HalfRes;

				case 3156672721:
					return DebugDrawOccluder;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2347524808:
					return typeof(LensFlareEntityData).GetProperty(nameof(Elements));

				case 2630779365:
					return typeof(LensFlareEntityData).GetProperty(nameof(OccluderSize));

				case 901540267:
					return typeof(LensFlareEntityData).GetProperty(nameof(Visible));

				case 2152832706:
					return typeof(LensFlareEntityData).GetProperty(nameof(HalfRes));

				case 3156672721:
					return typeof(LensFlareEntityData).GetProperty(nameof(DebugDrawOccluder));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
