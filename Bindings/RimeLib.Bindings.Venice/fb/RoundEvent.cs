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
	[ContainerType(Alignment: 8,  Flags: 53, Size: 24)]
	public class RoundEvent : 
		MetricEvent
	{
		protected string m_LevelName = string.Empty;
		[ContainerField(Name: "LevelName", Offset: 16, NameHash: 1599082292, Flags: 16509), LayoutImmutable]
		public string LevelName { get { return m_LevelName; } set { if (OnPropertyChanging("RoundEvent." + nameof(LevelName), this, m_LevelName, value)) m_LevelName = value; } } // 0x10 (16)
		
		protected int m_JuiceSessionId = new int();
		[ContainerField(Name: "JuiceSessionId", Offset: 20, NameHash: 2516727206, Flags: 49405), LayoutImmutable, Blittable]
		public int JuiceSessionId { get { return m_JuiceSessionId; } set { if (OnPropertyChanging("RoundEvent." + nameof(JuiceSessionId), this, m_JuiceSessionId, value)) m_JuiceSessionId = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1599082292:
					LevelName = (string) p_Value;
					break;

				case 2516727206:
					JuiceSessionId = (int) p_Value;
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
				case 1599082292:
					return LevelName;

				case 2516727206:
					return JuiceSessionId;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1599082292:
					return typeof(RoundEvent).GetProperty(nameof(LevelName));

				case 2516727206:
					return typeof(RoundEvent).GetProperty(nameof(JuiceSessionId));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
