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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class AmmoCrateEntityData : 
		GameEntityData
	{
		protected CtrRef<MapMarkerEntityData> m_Marker = new CtrRef<MapMarkerEntityData>();
		[ContainerField(96), MemberInfoFlag(53), ContainerFieldNameHash(2643283879), ContainerCtrRef]
		public CtrRef<MapMarkerEntityData> Marker { get { return m_Marker; } set { if (OnPropertyChanging("AmmoCrateEntityData." + nameof(Marker), this, m_Marker, value)) m_Marker = value; } } // 0x60 (96)
		
		protected CtrRef<StaticModelEntityData> m_Model = new CtrRef<StaticModelEntityData>();
		[ContainerField(100), MemberInfoFlag(53), ContainerFieldNameHash(210011050), ContainerCtrRef]
		public CtrRef<StaticModelEntityData> Model { get { return m_Model; } set { if (OnPropertyChanging("AmmoCrateEntityData." + nameof(Model), this, m_Model, value)) m_Model = value; } } // 0x64 (100)
		
		protected float m_RefillDelay = new float();
		[ContainerField(104), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1895357000)]
		public float RefillDelay { get { return m_RefillDelay; } set { if (OnPropertyChanging("AmmoCrateEntityData." + nameof(RefillDelay), this, m_RefillDelay, value)) m_RefillDelay = value; } } // 0x68 (104)
		
		protected float m_Radius = new float();
		[ContainerField(108), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3298407133)]
		public float Radius { get { return m_Radius; } set { if (OnPropertyChanging("AmmoCrateEntityData." + nameof(Radius), this, m_Radius, value)) m_Radius = value; } } // 0x6C (108)
		
		protected bool m_EnableReplenish = new bool();
		[ContainerField(112), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(720329910)]
		public bool EnableReplenish { get { return m_EnableReplenish; } set { if (OnPropertyChanging("AmmoCrateEntityData." + nameof(EnableReplenish), this, m_EnableReplenish, value)) m_EnableReplenish = value; } } // 0x70 (112)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2643283879:
					Marker = (CtrRef<MapMarkerEntityData>) p_Value;
					break;

				case 210011050:
					Model = (CtrRef<StaticModelEntityData>) p_Value;
					break;

				case 1895357000:
					RefillDelay = (float) p_Value;
					break;

				case 3298407133:
					Radius = (float) p_Value;
					break;

				case 720329910:
					EnableReplenish = (bool) p_Value;
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
				case 2643283879:
					return Marker;

				case 210011050:
					return Model;

				case 1895357000:
					return RefillDelay;

				case 3298407133:
					return Radius;

				case 720329910:
					return EnableReplenish;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2643283879:
					return typeof(AmmoCrateEntityData).GetProperty(nameof(Marker));

				case 210011050:
					return typeof(AmmoCrateEntityData).GetProperty(nameof(Model));

				case 1895357000:
					return typeof(AmmoCrateEntityData).GetProperty(nameof(RefillDelay));

				case 3298407133:
					return typeof(AmmoCrateEntityData).GetProperty(nameof(Radius));

				case 720329910:
					return typeof(AmmoCrateEntityData).GetProperty(nameof(EnableReplenish));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
