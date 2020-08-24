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
	public class StatEventTriggerEntityData : 
		GameEntityData
	{
		protected StatEvent m_StatEvent = new StatEvent();
		[ContainerField(96), MemberInfoFlag(137), ContainerFieldNameHash(4089209307)]
		public StatEvent StatEvent { get { return m_StatEvent; } set { if (OnPropertyChanging("StatEventTriggerEntityData." + nameof(StatEvent), this, m_StatEvent, value)) m_StatEvent = value; } } // 0x60 (96)
		
		protected string m_MiscParamX = string.Empty;
		[ContainerField(100), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2570197190)]
		public string MiscParamX { get { return m_MiscParamX; } set { if (OnPropertyChanging("StatEventTriggerEntityData." + nameof(MiscParamX), this, m_MiscParamX, value)) m_MiscParamX = value; } } // 0x64 (100)
		
		protected string m_MiscParamY = string.Empty;
		[ContainerField(104), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2570197191)]
		public string MiscParamY { get { return m_MiscParamY; } set { if (OnPropertyChanging("StatEventTriggerEntityData." + nameof(MiscParamY), this, m_MiscParamY, value)) m_MiscParamY = value; } } // 0x68 (104)
		
		protected bool m_SendToAll = new bool();
		[ContainerField(108), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1285040867)]
		public bool SendToAll { get { return m_SendToAll; } set { if (OnPropertyChanging("StatEventTriggerEntityData." + nameof(SendToAll), this, m_SendToAll, value)) m_SendToAll = value; } } // 0x6C (108)
		
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
