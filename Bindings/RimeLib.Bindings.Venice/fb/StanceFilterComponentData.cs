///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class StanceFilterComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public List<int> ValidStances { get; set; } = new List<int>(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float StanceChangeTime { get; set; } // 0x64 (100)
		
		[ContainerField(104)]
		public List<ActionSuppressor> ActionsToFilter { get; set; } = new List<ActionSuppressor>(); // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public bool FilterSpecificActions { get; set; } // 0x6C (108)
		
		[ContainerField(109), LayoutImmutable, Blittable]
		public bool UndoParentStanceFilter { get; set; } // 0x6D (109)
		
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
