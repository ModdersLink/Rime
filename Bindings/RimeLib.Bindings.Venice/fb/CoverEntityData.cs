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
	[ContainerType(16)]
	public class CoverEntityData : 
		SpatialEntityData
	{
		protected float m_Width = new float();
		[ContainerField(80), LayoutImmutable, Blittable, ContainerFieldNameHash(226981187)]
		public float Width { get { return m_Width; } set { if (OnPropertyChanging("CoverEntityData." + nameof(Width), this, m_Width, value)) m_Width = value; } } // 0x50 (80)
		
		protected CoverType m_CoverType = new CoverType();
		[ContainerField(84), ContainerFieldNameHash(2741637520)]
		public CoverType CoverType { get { return m_CoverType; } set { if (OnPropertyChanging("CoverEntityData." + nameof(CoverType), this, m_CoverType, value)) m_CoverType = value; } } // 0x54 (84)
		
		protected List<CoverSlot> m_Slots = new List<CoverSlot>();
		[ContainerField(88), ContainerFieldNameHash(231607282)]
		public List<CoverSlot> Slots { get { return m_Slots; } set { if (OnPropertyChanging("CoverEntityData." + nameof(Slots), this, m_Slots, value)) m_Slots = value; } } // 0x58 (88)
		
		protected bool m_RightEdgeBlocked = new bool();
		[ContainerField(92), LayoutImmutable, Blittable, ContainerFieldNameHash(1465616558)]
		public bool RightEdgeBlocked { get { return m_RightEdgeBlocked; } set { if (OnPropertyChanging("CoverEntityData." + nameof(RightEdgeBlocked), this, m_RightEdgeBlocked, value)) m_RightEdgeBlocked = value; } } // 0x5C (92)
		
		protected bool m_TopBlocked = new bool();
		[ContainerField(93), LayoutImmutable, Blittable, ContainerFieldNameHash(121893062)]
		public bool TopBlocked { get { return m_TopBlocked; } set { if (OnPropertyChanging("CoverEntityData." + nameof(TopBlocked), this, m_TopBlocked, value)) m_TopBlocked = value; } } // 0x5D (93)
		
		protected bool m_LeftEdgeBlocked = new bool();
		[ContainerField(94), LayoutImmutable, Blittable, ContainerFieldNameHash(1700814261)]
		public bool LeftEdgeBlocked { get { return m_LeftEdgeBlocked; } set { if (OnPropertyChanging("CoverEntityData." + nameof(LeftEdgeBlocked), this, m_LeftEdgeBlocked, value)) m_LeftEdgeBlocked = value; } } // 0x5E (94)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 226981187:
					Width = (float) p_Value;
					break;

				case 2741637520:
					CoverType = (CoverType) Enum.ToObject(typeof(CoverType), p_Value);
					break;

				case 231607282:
					Slots = (List<CoverSlot>) p_Value;
					break;

				case 1465616558:
					RightEdgeBlocked = (bool) p_Value;
					break;

				case 121893062:
					TopBlocked = (bool) p_Value;
					break;

				case 1700814261:
					LeftEdgeBlocked = (bool) p_Value;
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
				case 226981187:
					return Width;

				case 2741637520:
					return CoverType;

				case 231607282:
					return Slots;

				case 1465616558:
					return RightEdgeBlocked;

				case 121893062:
					return TopBlocked;

				case 1700814261:
					return LeftEdgeBlocked;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 226981187:
					return typeof(CoverEntityData).GetProperty(nameof(Width));

				case 2741637520:
					return typeof(CoverEntityData).GetProperty(nameof(CoverType));

				case 231607282:
					return typeof(CoverEntityData).GetProperty(nameof(Slots));

				case 1465616558:
					return typeof(CoverEntityData).GetProperty(nameof(RightEdgeBlocked));

				case 121893062:
					return typeof(CoverEntityData).GetProperty(nameof(TopBlocked));

				case 1700814261:
					return typeof(CoverEntityData).GetProperty(nameof(LeftEdgeBlocked));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
