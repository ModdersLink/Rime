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
	public class StatEventTriggerEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public StatEvent StatEvent { get; set; } = new StatEvent(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable]
		public string MiscParamX { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable]
		public string MiscParamY { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public bool SendToAll { get; set; } // 0x6C (108)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4089209307:
					StatEvent = (StatEvent) Enum.ToObject(typeof(StatEvent), p_Value);
					break;

				case 2570197190:
					MiscParamX = (string) p_Value;
					break;

				case 2570197191:
					MiscParamY = (string) p_Value;
					break;

				case 1285040867:
					SendToAll = (bool) p_Value;
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
				case 4089209307:
					return StatEvent;

				case 2570197190:
					return MiscParamX;

				case 2570197191:
					return MiscParamY;

				case 1285040867:
					return SendToAll;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4089209307:
					return typeof(StatEventTriggerEntityData).GetProperty(nameof(StatEvent));

				case 2570197190:
					return typeof(StatEventTriggerEntityData).GetProperty(nameof(MiscParamX));

				case 2570197191:
					return typeof(StatEventTriggerEntityData).GetProperty(nameof(MiscParamY));

				case 1285040867:
					return typeof(StatEventTriggerEntityData).GetProperty(nameof(SendToAll));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
