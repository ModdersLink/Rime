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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 208)]
	public class AreaTriggerEntityData : 
		TriggerEntityData
	{
		protected LinearTransform m_GeometryTransform = new LinearTransform();
		[ContainerField(Name: "GeometryTransform", Offset: 112, NameHash: 2190311347, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform GeometryTransform { get { return m_GeometryTransform; } set { if (OnPropertyChanging("AreaTriggerEntityData." + nameof(GeometryTransform), this, m_GeometryTransform, value)) m_GeometryTransform = value; } } // 0x70 (112)
		
		protected AreaTriggerInclude m_Include = new AreaTriggerInclude();
		[ContainerField(Name: "Include", Offset: 176, NameHash: 1669541689, Flags: 137)]
		public AreaTriggerInclude Include { get { return m_Include; } set { if (OnPropertyChanging("AreaTriggerEntityData." + nameof(Include), this, m_Include, value)) m_Include = value; } } // 0xB0 (176)
		
		protected float m_InsideAreaEventRepeatTime = new float();
		[ContainerField(Name: "InsideAreaEventRepeatTime", Offset: 180, NameHash: 287904832, Flags: 49469), LayoutImmutable, Blittable]
		public float InsideAreaEventRepeatTime { get { return m_InsideAreaEventRepeatTime; } set { if (OnPropertyChanging("AreaTriggerEntityData." + nameof(InsideAreaEventRepeatTime), this, m_InsideAreaEventRepeatTime, value)) m_InsideAreaEventRepeatTime = value; } } // 0xB4 (180)
		
		protected float m_Radius = new float();
		[ContainerField(Name: "Radius", Offset: 184, NameHash: 3298407133, Flags: 49469), LayoutImmutable, Blittable]
		public float Radius { get { return m_Radius; } set { if (OnPropertyChanging("AreaTriggerEntityData." + nameof(Radius), this, m_Radius, value)) m_Radius = value; } } // 0xB8 (184)
		
		protected bool m_UseCharacterEntity = new bool();
		[ContainerField(Name: "UseCharacterEntity", Offset: 188, NameHash: 3044350724, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseCharacterEntity { get { return m_UseCharacterEntity; } set { if (OnPropertyChanging("AreaTriggerEntityData." + nameof(UseCharacterEntity), this, m_UseCharacterEntity, value)) m_UseCharacterEntity = value; } } // 0xBC (188)
		
		protected bool m_OneInsideAreaEventPerSoldier = new bool();
		[ContainerField(Name: "OneInsideAreaEventPerSoldier", Offset: 189, NameHash: 1525530667, Flags: 49325), LayoutImmutable, Blittable]
		public bool OneInsideAreaEventPerSoldier { get { return m_OneInsideAreaEventPerSoldier; } set { if (OnPropertyChanging("AreaTriggerEntityData." + nameof(OneInsideAreaEventPerSoldier), this, m_OneInsideAreaEventPerSoldier, value)) m_OneInsideAreaEventPerSoldier = value; } } // 0xBD (189)
		
		protected bool m_TriggerOnlyOnLeave = new bool();
		[ContainerField(Name: "TriggerOnlyOnLeave", Offset: 190, NameHash: 1941446419, Flags: 49325), LayoutImmutable, Blittable]
		public bool TriggerOnlyOnLeave { get { return m_TriggerOnlyOnLeave; } set { if (OnPropertyChanging("AreaTriggerEntityData." + nameof(TriggerOnlyOnLeave), this, m_TriggerOnlyOnLeave, value)) m_TriggerOnlyOnLeave = value; } } // 0xBE (190)
		
		protected bool m_ResetOnEnable = new bool();
		[ContainerField(Name: "ResetOnEnable", Offset: 191, NameHash: 3898886736, Flags: 49325), LayoutImmutable, Blittable]
		public bool ResetOnEnable { get { return m_ResetOnEnable; } set { if (OnPropertyChanging("AreaTriggerEntityData." + nameof(ResetOnEnable), this, m_ResetOnEnable, value)) m_ResetOnEnable = value; } } // 0xBF (191)
		
		protected bool m_TriggerOnLeaveOnDeath = new bool();
		[ContainerField(Name: "TriggerOnLeaveOnDeath", Offset: 192, NameHash: 2131908922, Flags: 49325), LayoutImmutable, Blittable]
		public bool TriggerOnLeaveOnDeath { get { return m_TriggerOnLeaveOnDeath; } set { if (OnPropertyChanging("AreaTriggerEntityData." + nameof(TriggerOnLeaveOnDeath), this, m_TriggerOnLeaveOnDeath, value)) m_TriggerOnLeaveOnDeath = value; } } // 0xC0 (192)
		
		protected bool m_TriggerOnLeaveOnDisable = new bool();
		[ContainerField(Name: "TriggerOnLeaveOnDisable", Offset: 193, NameHash: 2543745682, Flags: 49325), LayoutImmutable, Blittable]
		public bool TriggerOnLeaveOnDisable { get { return m_TriggerOnLeaveOnDisable; } set { if (OnPropertyChanging("AreaTriggerEntityData." + nameof(TriggerOnLeaveOnDisable), this, m_TriggerOnLeaveOnDisable, value)) m_TriggerOnLeaveOnDisable = value; } } // 0xC1 (193)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2190311347:
					GeometryTransform = (LinearTransform) p_Value;
					break;

				case 1669541689:
					Include = (AreaTriggerInclude) Enum.ToObject(typeof(AreaTriggerInclude), p_Value);
					break;

				case 287904832:
					InsideAreaEventRepeatTime = (float) p_Value;
					break;

				case 3298407133:
					Radius = (float) p_Value;
					break;

				case 3044350724:
					UseCharacterEntity = (bool) p_Value;
					break;

				case 1525530667:
					OneInsideAreaEventPerSoldier = (bool) p_Value;
					break;

				case 1941446419:
					TriggerOnlyOnLeave = (bool) p_Value;
					break;

				case 3898886736:
					ResetOnEnable = (bool) p_Value;
					break;

				case 2131908922:
					TriggerOnLeaveOnDeath = (bool) p_Value;
					break;

				case 2543745682:
					TriggerOnLeaveOnDisable = (bool) p_Value;
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
				case 2190311347:
					return GeometryTransform;

				case 1669541689:
					return Include;

				case 287904832:
					return InsideAreaEventRepeatTime;

				case 3298407133:
					return Radius;

				case 3044350724:
					return UseCharacterEntity;

				case 1525530667:
					return OneInsideAreaEventPerSoldier;

				case 1941446419:
					return TriggerOnlyOnLeave;

				case 3898886736:
					return ResetOnEnable;

				case 2131908922:
					return TriggerOnLeaveOnDeath;

				case 2543745682:
					return TriggerOnLeaveOnDisable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2190311347:
					return typeof(AreaTriggerEntityData).GetProperty(nameof(GeometryTransform));

				case 1669541689:
					return typeof(AreaTriggerEntityData).GetProperty(nameof(Include));

				case 287904832:
					return typeof(AreaTriggerEntityData).GetProperty(nameof(InsideAreaEventRepeatTime));

				case 3298407133:
					return typeof(AreaTriggerEntityData).GetProperty(nameof(Radius));

				case 3044350724:
					return typeof(AreaTriggerEntityData).GetProperty(nameof(UseCharacterEntity));

				case 1525530667:
					return typeof(AreaTriggerEntityData).GetProperty(nameof(OneInsideAreaEventPerSoldier));

				case 1941446419:
					return typeof(AreaTriggerEntityData).GetProperty(nameof(TriggerOnlyOnLeave));

				case 3898886736:
					return typeof(AreaTriggerEntityData).GetProperty(nameof(ResetOnEnable));

				case 2131908922:
					return typeof(AreaTriggerEntityData).GetProperty(nameof(TriggerOnLeaveOnDeath));

				case 2543745682:
					return typeof(AreaTriggerEntityData).GetProperty(nameof(TriggerOnLeaveOnDisable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
