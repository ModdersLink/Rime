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
	[ContainerType(Alignment: 8,  Flags: 53, Size: 48)]
	public class NetworkPerformanceEvent : 
		MetricEvent
	{
		protected uint m_Received = new uint();
		[ContainerField(Name: "Received", Offset: 16, NameHash: 684081738, Flags: 49421), LayoutImmutable, Blittable]
		public uint Received { get { return m_Received; } set { if (OnPropertyChanging("NetworkPerformanceEvent." + nameof(Received), this, m_Received, value)) m_Received = value; } } // 0x10 (16)
		
		protected uint m_Sent = new uint();
		[ContainerField(Name: "Sent", Offset: 20, NameHash: 2089417353, Flags: 49421), LayoutImmutable, Blittable]
		public uint Sent { get { return m_Sent; } set { if (OnPropertyChanging("NetworkPerformanceEvent." + nameof(Sent), this, m_Sent, value)) m_Sent = value; } } // 0x14 (20)
		
		protected float m_ReceivedAverage = new float();
		[ContainerField(Name: "ReceivedAverage", Offset: 24, NameHash: 186958889, Flags: 49469), LayoutImmutable, Blittable]
		public float ReceivedAverage { get { return m_ReceivedAverage; } set { if (OnPropertyChanging("NetworkPerformanceEvent." + nameof(ReceivedAverage), this, m_ReceivedAverage, value)) m_ReceivedAverage = value; } } // 0x18 (24)
		
		protected float m_SentAverage = new float();
		[ContainerField(Name: "SentAverage", Offset: 28, NameHash: 3828469642, Flags: 49469), LayoutImmutable, Blittable]
		public float SentAverage { get { return m_SentAverage; } set { if (OnPropertyChanging("NetworkPerformanceEvent." + nameof(SentAverage), this, m_SentAverage, value)) m_SentAverage = value; } } // 0x1C (28)
		
		protected GUID m_PerformanceLink = new GUID();
		[ContainerField(Name: "PerformanceLink", Offset: 32, NameHash: 3478312829, Flags: 49501), LayoutImmutable, Blittable]
		public GUID PerformanceLink { get { return m_PerformanceLink; } set { if (OnPropertyChanging("NetworkPerformanceEvent." + nameof(PerformanceLink), this, m_PerformanceLink, value)) m_PerformanceLink = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
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
				case 684081738:
					return Received;

				case 2089417353:
					return Sent;

				case 186958889:
					return ReceivedAverage;

				case 3828469642:
					return SentAverage;

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
				case 684081738:
					return typeof(NetworkPerformanceEvent).GetProperty(nameof(Received));

				case 2089417353:
					return typeof(NetworkPerformanceEvent).GetProperty(nameof(Sent));

				case 186958889:
					return typeof(NetworkPerformanceEvent).GetProperty(nameof(ReceivedAverage));

				case 3828469642:
					return typeof(NetworkPerformanceEvent).GetProperty(nameof(SentAverage));

				case 3478312829:
					return typeof(NetworkPerformanceEvent).GetProperty(nameof(PerformanceLink));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
