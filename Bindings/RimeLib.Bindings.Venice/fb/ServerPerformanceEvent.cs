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
	[ContainerType(8), MemberInfoFlag(53), ContainerSize(40), ContainerClass]
	public class ServerPerformanceEvent : 
		MetricEvent
	{
		protected float m_CPUAverage = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2154799904)]
		public float CPUAverage { get { return m_CPUAverage; } set { if (OnPropertyChanging("ServerPerformanceEvent." + nameof(CPUAverage), this, m_CPUAverage, value)) m_CPUAverage = value; } } // 0x10 (16)
		
		protected float m_CPUMemory = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1683758594)]
		public float CPUMemory { get { return m_CPUMemory; } set { if (OnPropertyChanging("ServerPerformanceEvent." + nameof(CPUMemory), this, m_CPUMemory, value)) m_CPUMemory = value; } } // 0x14 (20)
		
		protected uint m_Received = new uint();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(684081738)]
		public uint Received { get { return m_Received; } set { if (OnPropertyChanging("ServerPerformanceEvent." + nameof(Received), this, m_Received, value)) m_Received = value; } } // 0x18 (24)
		
		protected uint m_Sent = new uint();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2089417353)]
		public uint Sent { get { return m_Sent; } set { if (OnPropertyChanging("ServerPerformanceEvent." + nameof(Sent), this, m_Sent, value)) m_Sent = value; } } // 0x1C (28)
		
		protected float m_ReceivedAverage = new float();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(186958889)]
		public float ReceivedAverage { get { return m_ReceivedAverage; } set { if (OnPropertyChanging("ServerPerformanceEvent." + nameof(ReceivedAverage), this, m_ReceivedAverage, value)) m_ReceivedAverage = value; } } // 0x20 (32)
		
		protected float m_SentAverage = new float();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3828469642)]
		public float SentAverage { get { return m_SentAverage; } set { if (OnPropertyChanging("ServerPerformanceEvent." + nameof(SentAverage), this, m_SentAverage, value)) m_SentAverage = value; } } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2154799904:
					CPUAverage = (float) p_Value;
					break;

				case 1683758594:
					CPUMemory = (float) p_Value;
					break;

				case 684081738:
					Received = (uint) p_Value;
					break;

				case 2089417353:
					Sent = (uint) p_Value;
					break;

				case 186958889:
					ReceivedAverage = (float) p_Value;
					break;

				case 3828469642:
					SentAverage = (float) p_Value;
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
				case 2154799904:
					return CPUAverage;

				case 1683758594:
					return CPUMemory;

				case 684081738:
					return Received;

				case 2089417353:
					return Sent;

				case 186958889:
					return ReceivedAverage;

				case 3828469642:
					return SentAverage;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2154799904:
					return typeof(ServerPerformanceEvent).GetProperty(nameof(CPUAverage));

				case 1683758594:
					return typeof(ServerPerformanceEvent).GetProperty(nameof(CPUMemory));

				case 684081738:
					return typeof(ServerPerformanceEvent).GetProperty(nameof(Received));

				case 2089417353:
					return typeof(ServerPerformanceEvent).GetProperty(nameof(Sent));

				case 186958889:
					return typeof(ServerPerformanceEvent).GetProperty(nameof(ReceivedAverage));

				case 3828469642:
					return typeof(ServerPerformanceEvent).GetProperty(nameof(SentAverage));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
