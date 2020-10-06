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
	[ContainerType(8), MemberInfoFlag(53), ContainerSize(56), ContainerClass]
	public class PerformanceProfileState : 
		MetricState
	{
		protected uint m_ProcessorCount = new uint();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(391539216)]
		public uint ProcessorCount { get { return m_ProcessorCount; } set { if (OnPropertyChanging("PerformanceProfileState." + nameof(ProcessorCount), this, m_ProcessorCount, value)) m_ProcessorCount = value; } } // 0x18 (24)
		
		protected uint m_ProcessorCoreCount = new uint();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2243702507)]
		public uint ProcessorCoreCount { get { return m_ProcessorCoreCount; } set { if (OnPropertyChanging("PerformanceProfileState." + nameof(ProcessorCoreCount), this, m_ProcessorCoreCount, value)) m_ProcessorCoreCount = value; } } // 0x1C (28)
		
		protected uint m_ProcessorClock = new uint();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(391374875)]
		public uint ProcessorClock { get { return m_ProcessorClock; } set { if (OnPropertyChanging("PerformanceProfileState." + nameof(ProcessorClock), this, m_ProcessorClock, value)) m_ProcessorClock = value; } } // 0x20 (32)
		
		protected uint m_TotalMemMB = new uint();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(4037894605)]
		public uint TotalMemMB { get { return m_TotalMemMB; } set { if (OnPropertyChanging("PerformanceProfileState." + nameof(TotalMemMB), this, m_TotalMemMB, value)) m_TotalMemMB = value; } } // 0x24 (36)
		
		protected uint m_GpuMemMB = new uint();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(4164397837)]
		public uint GpuMemMB { get { return m_GpuMemMB; } set { if (OnPropertyChanging("PerformanceProfileState." + nameof(GpuMemMB), this, m_GpuMemMB, value)) m_GpuMemMB = value; } } // 0x28 (40)
		
		protected string m_GraphicAdapterName = string.Empty;
		[ContainerField(44), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(631166483)]
		public string GraphicAdapterName { get { return m_GraphicAdapterName; } set { if (OnPropertyChanging("PerformanceProfileState." + nameof(GraphicAdapterName), this, m_GraphicAdapterName, value)) m_GraphicAdapterName = value; } } // 0x2C (44)
		
		protected string m_Platform = string.Empty;
		[ContainerField(48), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(942751002)]
		public string Platform { get { return m_Platform; } set { if (OnPropertyChanging("PerformanceProfileState." + nameof(Platform), this, m_Platform, value)) m_Platform = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 391539216:
					ProcessorCount = (uint) p_Value;
					break;

				case 2243702507:
					ProcessorCoreCount = (uint) p_Value;
					break;

				case 391374875:
					ProcessorClock = (uint) p_Value;
					break;

				case 4037894605:
					TotalMemMB = (uint) p_Value;
					break;

				case 4164397837:
					GpuMemMB = (uint) p_Value;
					break;

				case 631166483:
					GraphicAdapterName = (string) p_Value;
					break;

				case 942751002:
					Platform = (string) p_Value;
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
				case 391539216:
					return ProcessorCount;

				case 2243702507:
					return ProcessorCoreCount;

				case 391374875:
					return ProcessorClock;

				case 4037894605:
					return TotalMemMB;

				case 4164397837:
					return GpuMemMB;

				case 631166483:
					return GraphicAdapterName;

				case 942751002:
					return Platform;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 391539216:
					return typeof(PerformanceProfileState).GetProperty(nameof(ProcessorCount));

				case 2243702507:
					return typeof(PerformanceProfileState).GetProperty(nameof(ProcessorCoreCount));

				case 391374875:
					return typeof(PerformanceProfileState).GetProperty(nameof(ProcessorClock));

				case 4037894605:
					return typeof(PerformanceProfileState).GetProperty(nameof(TotalMemMB));

				case 4164397837:
					return typeof(PerformanceProfileState).GetProperty(nameof(GpuMemMB));

				case 631166483:
					return typeof(PerformanceProfileState).GetProperty(nameof(GraphicAdapterName));

				case 942751002:
					return typeof(PerformanceProfileState).GetProperty(nameof(Platform));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
