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
	public class AmmoCrateEntityData : 
		GameEntityData
	{
		protected CtrRef<MapMarkerEntityData> m_Marker = new CtrRef<MapMarkerEntityData>();
		[ContainerField(Name: "Marker", Offset: 96, NameHash: 2643283879, Flags: 53)]
		public CtrRef<MapMarkerEntityData> Marker { get { return m_Marker; } set { if (OnPropertyChanging("AmmoCrateEntityData." + nameof(Marker), this, m_Marker, value)) m_Marker = value; } } // 0x60 (96)
		
		protected CtrRef<StaticModelEntityData> m_Model = new CtrRef<StaticModelEntityData>();
		[ContainerField(Name: "Model", Offset: 100, NameHash: 210011050, Flags: 53)]
		public CtrRef<StaticModelEntityData> Model { get { return m_Model; } set { if (OnPropertyChanging("AmmoCrateEntityData." + nameof(Model), this, m_Model, value)) m_Model = value; } } // 0x64 (100)
		
		protected float m_RefillDelay = new float();
		[ContainerField(Name: "RefillDelay", Offset: 104, NameHash: 1895357000, Flags: 49469), LayoutImmutable, Blittable]
		public float RefillDelay { get { return m_RefillDelay; } set { if (OnPropertyChanging("AmmoCrateEntityData." + nameof(RefillDelay), this, m_RefillDelay, value)) m_RefillDelay = value; } } // 0x68 (104)
		
		protected float m_Radius = new float();
		[ContainerField(Name: "Radius", Offset: 108, NameHash: 3298407133, Flags: 49469), LayoutImmutable, Blittable]
		public float Radius { get { return m_Radius; } set { if (OnPropertyChanging("AmmoCrateEntityData." + nameof(Radius), this, m_Radius, value)) m_Radius = value; } } // 0x6C (108)
		
		protected bool m_EnableReplenish = new bool();
		[ContainerField(Name: "EnableReplenish", Offset: 112, NameHash: 720329910, Flags: 49325), LayoutImmutable, Blittable]
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
