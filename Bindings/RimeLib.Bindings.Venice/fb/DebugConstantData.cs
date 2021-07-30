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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 32)]
	public class DebugConstantData : 
		Asset
	{
		protected float m_BotDebugDistance = new float();
		[ContainerField(Name: "BotDebugDistance", Offset: 12, NameHash: 348493774, Flags: 49469), LayoutImmutable, Blittable]
		public float BotDebugDistance { get { return m_BotDebugDistance; } set { if (OnPropertyChanging("DebugConstantData." + nameof(BotDebugDistance), this, m_BotDebugDistance, value)) m_BotDebugDistance = value; } } // 0xC (12)
		
		protected float m_InViewModeFOV = new float();
		[ContainerField(Name: "InViewModeFOV", Offset: 16, NameHash: 1924732979, Flags: 49469), LayoutImmutable, Blittable]
		public float InViewModeFOV { get { return m_InViewModeFOV; } set { if (OnPropertyChanging("DebugConstantData." + nameof(InViewModeFOV), this, m_InViewModeFOV, value)) m_InViewModeFOV = value; } } // 0x10 (16)
		
		protected uint m_GraphDataBuffer = new uint();
		[ContainerField(Name: "GraphDataBuffer", Offset: 20, NameHash: 4041264409, Flags: 49421), LayoutImmutable, Blittable]
		public uint GraphDataBuffer { get { return m_GraphDataBuffer; } set { if (OnPropertyChanging("DebugConstantData." + nameof(GraphDataBuffer), this, m_GraphDataBuffer, value)) m_GraphDataBuffer = value; } } // 0x14 (20)
		
		protected float m_MinDecisionTime = new float();
		[ContainerField(Name: "MinDecisionTime", Offset: 24, NameHash: 762980938, Flags: 49469), LayoutImmutable, Blittable]
		public float MinDecisionTime { get { return m_MinDecisionTime; } set { if (OnPropertyChanging("DebugConstantData." + nameof(MinDecisionTime), this, m_MinDecisionTime, value)) m_MinDecisionTime = value; } } // 0x18 (24)
		
		protected bool m_InaccuracyEnabled = new bool();
		[ContainerField(Name: "InaccuracyEnabled", Offset: 28, NameHash: 2816178938, Flags: 49325), LayoutImmutable, Blittable]
		public bool InaccuracyEnabled { get { return m_InaccuracyEnabled; } set { if (OnPropertyChanging("DebugConstantData." + nameof(InaccuracyEnabled), this, m_InaccuracyEnabled, value)) m_InaccuracyEnabled = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 348493774:
					BotDebugDistance = (float) p_Value;
					break;

				case 1924732979:
					InViewModeFOV = (float) p_Value;
					break;

				case 4041264409:
					GraphDataBuffer = (uint) p_Value;
					break;

				case 762980938:
					MinDecisionTime = (float) p_Value;
					break;

				case 2816178938:
					InaccuracyEnabled = (bool) p_Value;
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
				case 348493774:
					return BotDebugDistance;

				case 1924732979:
					return InViewModeFOV;

				case 4041264409:
					return GraphDataBuffer;

				case 762980938:
					return MinDecisionTime;

				case 2816178938:
					return InaccuracyEnabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 348493774:
					return typeof(DebugConstantData).GetProperty(nameof(BotDebugDistance));

				case 1924732979:
					return typeof(DebugConstantData).GetProperty(nameof(InViewModeFOV));

				case 4041264409:
					return typeof(DebugConstantData).GetProperty(nameof(GraphDataBuffer));

				case 762980938:
					return typeof(DebugConstantData).GetProperty(nameof(MinDecisionTime));

				case 2816178938:
					return typeof(DebugConstantData).GetProperty(nameof(InaccuracyEnabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
