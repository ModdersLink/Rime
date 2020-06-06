///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(8)]
	public class NetworkPerformanceEvent : 
		MetricEvent
	{
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint Received { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint Sent { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float ReceivedAverage { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float SentAverage { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public GUID PerformanceLink { get; set; } // 0x20 (32)
		
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
