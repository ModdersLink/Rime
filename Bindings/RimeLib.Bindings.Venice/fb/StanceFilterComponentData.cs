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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class StanceFilterComponentData : 
		ComponentData
	{
		protected List<int> m_ValidStances = new List<int>();
		[ContainerField(Name: "ValidStances", Offset: 96, NameHash: 4192498222, Flags: 65)]
		public List<int> ValidStances { get { return m_ValidStances; } set { if (OnPropertyChanging("StanceFilterComponentData." + nameof(ValidStances), this, m_ValidStances, value)) m_ValidStances = value; } } // 0x60 (96)
		
		protected float m_StanceChangeTime = new float();
		[ContainerField(Name: "StanceChangeTime", Offset: 100, NameHash: 58412120, Flags: 49469), LayoutImmutable, Blittable]
		public float StanceChangeTime { get { return m_StanceChangeTime; } set { if (OnPropertyChanging("StanceFilterComponentData." + nameof(StanceChangeTime), this, m_StanceChangeTime, value)) m_StanceChangeTime = value; } } // 0x64 (100)
		
		protected List<ActionSuppressor> m_ActionsToFilter = new List<ActionSuppressor>();
		[ContainerField(Name: "ActionsToFilter", Offset: 104, NameHash: 2075922899, Flags: 65)]
		public List<ActionSuppressor> ActionsToFilter { get { return m_ActionsToFilter; } set { if (OnPropertyChanging("StanceFilterComponentData." + nameof(ActionsToFilter), this, m_ActionsToFilter, value)) m_ActionsToFilter = value; } } // 0x68 (104)
		
		protected bool m_FilterSpecificActions = new bool();
		[ContainerField(Name: "FilterSpecificActions", Offset: 108, NameHash: 1330805128, Flags: 49325), LayoutImmutable, Blittable]
		public bool FilterSpecificActions { get { return m_FilterSpecificActions; } set { if (OnPropertyChanging("StanceFilterComponentData." + nameof(FilterSpecificActions), this, m_FilterSpecificActions, value)) m_FilterSpecificActions = value; } } // 0x6C (108)
		
		protected bool m_UndoParentStanceFilter = new bool();
		[ContainerField(Name: "UndoParentStanceFilter", Offset: 109, NameHash: 1383671783, Flags: 49325), LayoutImmutable, Blittable]
		public bool UndoParentStanceFilter { get { return m_UndoParentStanceFilter; } set { if (OnPropertyChanging("StanceFilterComponentData." + nameof(UndoParentStanceFilter), this, m_UndoParentStanceFilter, value)) m_UndoParentStanceFilter = value; } } // 0x6D (109)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4192498222:
					ValidStances = (List<int>) p_Value;
					break;

				case 58412120:
					StanceChangeTime = (float) p_Value;
					break;

				case 2075922899:
					ActionsToFilter = (List<ActionSuppressor>) p_Value;
					break;

				case 1330805128:
					FilterSpecificActions = (bool) p_Value;
					break;

				case 1383671783:
					UndoParentStanceFilter = (bool) p_Value;
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
				case 4192498222:
					return ValidStances;

				case 58412120:
					return StanceChangeTime;

				case 2075922899:
					return ActionsToFilter;

				case 1330805128:
					return FilterSpecificActions;

				case 1383671783:
					return UndoParentStanceFilter;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4192498222:
					return typeof(StanceFilterComponentData).GetProperty(nameof(ValidStances));

				case 58412120:
					return typeof(StanceFilterComponentData).GetProperty(nameof(StanceChangeTime));

				case 2075922899:
					return typeof(StanceFilterComponentData).GetProperty(nameof(ActionsToFilter));

				case 1330805128:
					return typeof(StanceFilterComponentData).GetProperty(nameof(FilterSpecificActions));

				case 1383671783:
					return typeof(StanceFilterComponentData).GetProperty(nameof(UndoParentStanceFilter));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
