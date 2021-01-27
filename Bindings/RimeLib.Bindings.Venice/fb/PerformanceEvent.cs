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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 96)]
	public class PerformanceEvent : 
		MetricEvent
	{
		protected Vec3 m_Position = new Vec3();
		[ContainerField(Name: "Position", Offset: 16, NameHash: 3402582524, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Position { get { return m_Position; } set { if (OnPropertyChanging("PerformanceEvent." + nameof(Position), this, m_Position, value)) m_Position = value; } } // 0x10 (16)
		
		protected float m_FreeCPUMemory = new float();
		[ContainerField(Name: "FreeCPUMemory", Offset: 32, NameHash: 3299715286, Flags: 49469), LayoutImmutable, Blittable]
		public float FreeCPUMemory { get { return m_FreeCPUMemory; } set { if (OnPropertyChanging("PerformanceEvent." + nameof(FreeCPUMemory), this, m_FreeCPUMemory, value)) m_FreeCPUMemory = value; } } // 0x20 (32)
		
		protected float m_CPUAverage = new float();
		[ContainerField(Name: "CPUAverage", Offset: 36, NameHash: 2154799904, Flags: 49469), LayoutImmutable, Blittable]
		public float CPUAverage { get { return m_CPUAverage; } set { if (OnPropertyChanging("PerformanceEvent." + nameof(CPUAverage), this, m_CPUAverage, value)) m_CPUAverage = value; } } // 0x24 (36)
		
		protected float m_AllocCPUMemory = new float();
		[ContainerField(Name: "AllocCPUMemory", Offset: 40, NameHash: 964546863, Flags: 49469), LayoutImmutable, Blittable]
		public float AllocCPUMemory { get { return m_AllocCPUMemory; } set { if (OnPropertyChanging("PerformanceEvent." + nameof(AllocCPUMemory), this, m_AllocCPUMemory, value)) m_AllocCPUMemory = value; } } // 0x28 (40)
		
		protected float m_FreeGPUMemory = new float();
		[ContainerField(Name: "FreeGPUMemory", Offset: 44, NameHash: 1089095890, Flags: 49469), LayoutImmutable, Blittable]
		public float FreeGPUMemory { get { return m_FreeGPUMemory; } set { if (OnPropertyChanging("PerformanceEvent." + nameof(FreeGPUMemory), this, m_FreeGPUMemory, value)) m_FreeGPUMemory = value; } } // 0x2C (44)
		
		protected float m_GPUAverage = new float();
		[ContainerField(Name: "GPUAverage", Offset: 48, NameHash: 3225125796, Flags: 49469), LayoutImmutable, Blittable]
		public float GPUAverage { get { return m_GPUAverage; } set { if (OnPropertyChanging("PerformanceEvent." + nameof(GPUAverage), this, m_GPUAverage, value)) m_GPUAverage = value; } } // 0x30 (48)
		
		protected int m_DrawCallCount = new int();
		[ContainerField(Name: "DrawCallCount", Offset: 52, NameHash: 182572740, Flags: 49405), LayoutImmutable, Blittable]
		public int DrawCallCount { get { return m_DrawCallCount; } set { if (OnPropertyChanging("PerformanceEvent." + nameof(DrawCallCount), this, m_DrawCallCount, value)) m_DrawCallCount = value; } } // 0x34 (52)
		
		protected int m_PrimitiveCount = new int();
		[ContainerField(Name: "PrimitiveCount", Offset: 56, NameHash: 1563515559, Flags: 49405), LayoutImmutable, Blittable]
		public int PrimitiveCount { get { return m_PrimitiveCount; } set { if (OnPropertyChanging("PerformanceEvent." + nameof(PrimitiveCount), this, m_PrimitiveCount, value)) m_PrimitiveCount = value; } } // 0x38 (56)
		
		protected float m_AllocGPUMemory = new float();
		[ContainerField(Name: "AllocGPUMemory", Offset: 60, NameHash: 3048894763, Flags: 49469), LayoutImmutable, Blittable]
		public float AllocGPUMemory { get { return m_AllocGPUMemory; } set { if (OnPropertyChanging("PerformanceEvent." + nameof(AllocGPUMemory), this, m_AllocGPUMemory, value)) m_AllocGPUMemory = value; } } // 0x3C (60)
		
		protected string m_PerformanceLocation = string.Empty;
		[ContainerField(Name: "PerformanceLocation", Offset: 64, NameHash: 69700128, Flags: 16509), LayoutImmutable]
		public string PerformanceLocation { get { return m_PerformanceLocation; } set { if (OnPropertyChanging("PerformanceEvent." + nameof(PerformanceLocation), this, m_PerformanceLocation, value)) m_PerformanceLocation = value; } } // 0x40 (64)
		
		protected GUID m_PerformanceLink = new GUID();
		[ContainerField(Name: "PerformanceLink", Offset: 68, NameHash: 3478312829, Flags: 49501), LayoutImmutable, Blittable]
		public GUID PerformanceLink { get { return m_PerformanceLink; } set { if (OnPropertyChanging("PerformanceEvent." + nameof(PerformanceLink), this, m_PerformanceLink, value)) m_PerformanceLink = value; } } // 0x44 (68)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3402582524:
					Position = (Vec3) p_Value;
					break;

				case 3299715286:
					FreeCPUMemory = (float) p_Value;
					break;

				case 2154799904:
					CPUAverage = (float) p_Value;
					break;

				case 964546863:
					AllocCPUMemory = (float) p_Value;
					break;

				case 1089095890:
					FreeGPUMemory = (float) p_Value;
					break;

				case 3225125796:
					GPUAverage = (float) p_Value;
					break;

				case 182572740:
					DrawCallCount = (int) p_Value;
					break;

				case 1563515559:
					PrimitiveCount = (int) p_Value;
					break;

				case 3048894763:
					AllocGPUMemory = (float) p_Value;
					break;

				case 69700128:
					PerformanceLocation = (string) p_Value;
					break;

				case 3478312829:
					PerformanceLink = (GUID) p_Value;
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
				case 3402582524:
					return Position;

				case 3299715286:
					return FreeCPUMemory;

				case 2154799904:
					return CPUAverage;

				case 964546863:
					return AllocCPUMemory;

				case 1089095890:
					return FreeGPUMemory;

				case 3225125796:
					return GPUAverage;

				case 182572740:
					return DrawCallCount;

				case 1563515559:
					return PrimitiveCount;

				case 3048894763:
					return AllocGPUMemory;

				case 69700128:
					return PerformanceLocation;

				case 3478312829:
					return PerformanceLink;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3402582524:
					return typeof(PerformanceEvent).GetProperty(nameof(Position));

				case 3299715286:
					return typeof(PerformanceEvent).GetProperty(nameof(FreeCPUMemory));

				case 2154799904:
					return typeof(PerformanceEvent).GetProperty(nameof(CPUAverage));

				case 964546863:
					return typeof(PerformanceEvent).GetProperty(nameof(AllocCPUMemory));

				case 1089095890:
					return typeof(PerformanceEvent).GetProperty(nameof(FreeGPUMemory));

				case 3225125796:
					return typeof(PerformanceEvent).GetProperty(nameof(GPUAverage));

				case 182572740:
					return typeof(PerformanceEvent).GetProperty(nameof(DrawCallCount));

				case 1563515559:
					return typeof(PerformanceEvent).GetProperty(nameof(PrimitiveCount));

				case 3048894763:
					return typeof(PerformanceEvent).GetProperty(nameof(AllocGPUMemory));

				case 69700128:
					return typeof(PerformanceEvent).GetProperty(nameof(PerformanceLocation));

				case 3478312829:
					return typeof(PerformanceEvent).GetProperty(nameof(PerformanceLink));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
