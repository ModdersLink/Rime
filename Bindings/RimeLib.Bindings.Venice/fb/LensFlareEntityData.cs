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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(96), ContainerClass]
	public class LensFlareEntityData : 
		SpatialEntityData
	{
		protected List<LensFlareElement> m_Elements = new List<LensFlareElement>();
		[ContainerField(80), MemberInfoFlag(65), ContainerFieldNameHash(2347524808), ContainerArray]
		public List<LensFlareElement> Elements { get { return m_Elements; } set { if (OnPropertyChanging("LensFlareEntityData." + nameof(Elements), this, m_Elements, value)) m_Elements = value; } } // 0x50 (80)
		
		protected float m_OccluderSize = new float();
		[ContainerField(84), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2630779365)]
		public float OccluderSize { get { return m_OccluderSize; } set { if (OnPropertyChanging("LensFlareEntityData." + nameof(OccluderSize), this, m_OccluderSize, value)) m_OccluderSize = value; } } // 0x54 (84)
		
		protected bool m_Visible = new bool();
		[ContainerField(88), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(901540267)]
		public bool Visible { get { return m_Visible; } set { if (OnPropertyChanging("LensFlareEntityData." + nameof(Visible), this, m_Visible, value)) m_Visible = value; } } // 0x58 (88)
		
		protected bool m_HalfRes = new bool();
		[ContainerField(89), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2152832706)]
		public bool HalfRes { get { return m_HalfRes; } set { if (OnPropertyChanging("LensFlareEntityData." + nameof(HalfRes), this, m_HalfRes, value)) m_HalfRes = value; } } // 0x59 (89)
		
		protected bool m_DebugDrawOccluder = new bool();
		[ContainerField(90), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3156672721)]
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
