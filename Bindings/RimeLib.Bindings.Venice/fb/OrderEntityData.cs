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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 36)]
	public class OrderEntityData : 
		EntityData
	{
		protected string m_DebugName = string.Empty;
		[ContainerField(Name: "DebugName", Offset: 12, NameHash: 859955379, Flags: 16509), LayoutImmutable]
		public string DebugName { get { return m_DebugName; } set { if (OnPropertyChanging("OrderEntityData." + nameof(DebugName), this, m_DebugName, value)) m_DebugName = value; } } // 0xC (12)
		
		protected float m_IssueOrderDelay = new float();
		[ContainerField(Name: "IssueOrderDelay", Offset: 16, NameHash: 364586375, Flags: 49469), LayoutImmutable, Blittable]
		public float IssueOrderDelay { get { return m_IssueOrderDelay; } set { if (OnPropertyChanging("OrderEntityData." + nameof(IssueOrderDelay), this, m_IssueOrderDelay, value)) m_IssueOrderDelay = value; } } // 0x10 (16)
		
		protected float m_OnCompleteTimeOut = new float();
		[ContainerField(Name: "OnCompleteTimeOut", Offset: 20, NameHash: 2812561110, Flags: 49469), LayoutImmutable, Blittable]
		public float OnCompleteTimeOut { get { return m_OnCompleteTimeOut; } set { if (OnPropertyChanging("OrderEntityData." + nameof(OnCompleteTimeOut), this, m_OnCompleteTimeOut, value)) m_OnCompleteTimeOut = value; } } // 0x14 (20)
		
		protected float m_OnFailedTimeOut = new float();
		[ContainerField(Name: "OnFailedTimeOut", Offset: 24, NameHash: 187326428, Flags: 49469), LayoutImmutable, Blittable]
		public float OnFailedTimeOut { get { return m_OnFailedTimeOut; } set { if (OnPropertyChanging("OrderEntityData." + nameof(OnFailedTimeOut), this, m_OnFailedTimeOut, value)) m_OnFailedTimeOut = value; } } // 0x18 (24)
		
		protected ReadinessLevel m_ReadinessOnStart = new ReadinessLevel();
		[ContainerField(Name: "ReadinessOnStart", Offset: 28, NameHash: 3753000372, Flags: 137)]
		public ReadinessLevel ReadinessOnStart { get { return m_ReadinessOnStart; } set { if (OnPropertyChanging("OrderEntityData." + nameof(ReadinessOnStart), this, m_ReadinessOnStart, value)) m_ReadinessOnStart = value; } } // 0x1C (28)
		
		protected bool m_Enabled = new bool();
		[ContainerField(Name: "Enabled", Offset: 32, NameHash: 2662400, Flags: 49325), LayoutImmutable, Blittable]
		public bool Enabled { get { return m_Enabled; } set { if (OnPropertyChanging("OrderEntityData." + nameof(Enabled), this, m_Enabled, value)) m_Enabled = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 859955379:
					DebugName = (string) p_Value;
					break;

				case 364586375:
					IssueOrderDelay = (float) p_Value;
					break;

				case 2812561110:
					OnCompleteTimeOut = (float) p_Value;
					break;

				case 187326428:
					OnFailedTimeOut = (float) p_Value;
					break;

				case 3753000372:
					ReadinessOnStart = (ReadinessLevel) Enum.ToObject(typeof(ReadinessLevel), p_Value);
					break;

				case 2662400:
					Enabled = (bool) p_Value;
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
				case 859955379:
					return DebugName;

				case 364586375:
					return IssueOrderDelay;

				case 2812561110:
					return OnCompleteTimeOut;

				case 187326428:
					return OnFailedTimeOut;

				case 3753000372:
					return ReadinessOnStart;

				case 2662400:
					return Enabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 859955379:
					return typeof(OrderEntityData).GetProperty(nameof(DebugName));

				case 364586375:
					return typeof(OrderEntityData).GetProperty(nameof(IssueOrderDelay));

				case 2812561110:
					return typeof(OrderEntityData).GetProperty(nameof(OnCompleteTimeOut));

				case 187326428:
					return typeof(OrderEntityData).GetProperty(nameof(OnFailedTimeOut));

				case 3753000372:
					return typeof(OrderEntityData).GetProperty(nameof(ReadinessOnStart));

				case 2662400:
					return typeof(OrderEntityData).GetProperty(nameof(Enabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
