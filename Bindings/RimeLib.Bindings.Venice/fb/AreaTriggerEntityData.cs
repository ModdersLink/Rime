///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class AreaTriggerEntityData : 
		TriggerEntityData
	{
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform GeometryTransform { get; set; } = new LinearTransform(); // 0x70 (112)
		
		[ContainerField(176)]
		public AreaTriggerInclude Include { get; set; } = new AreaTriggerInclude(); // 0xB0 (176)
		
		[ContainerField(180), LayoutImmutable, Blittable]
		public float InsideAreaEventRepeatTime { get; set; } // 0xB4 (180)
		
		[ContainerField(184), LayoutImmutable, Blittable]
		public float Radius { get; set; } // 0xB8 (184)
		
		[ContainerField(188), LayoutImmutable, Blittable]
		public bool UseCharacterEntity { get; set; } // 0xBC (188)
		
		[ContainerField(189), LayoutImmutable, Blittable]
		public bool OneInsideAreaEventPerSoldier { get; set; } // 0xBD (189)
		
		[ContainerField(190), LayoutImmutable, Blittable]
		public bool TriggerOnlyOnLeave { get; set; } // 0xBE (190)
		
		[ContainerField(191), LayoutImmutable, Blittable]
		public bool ResetOnEnable { get; set; } // 0xBF (191)
		
		[ContainerField(192), LayoutImmutable, Blittable]
		public bool TriggerOnLeaveOnDeath { get; set; } // 0xC0 (192)
		
		[ContainerField(193), LayoutImmutable, Blittable]
		public bool TriggerOnLeaveOnDisable { get; set; } // 0xC1 (193)
		
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
