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
    [ContainerType(4)]
	public class OrderEntityData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable]
		public string DebugName { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float IssueOrderDelay { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float OnCompleteTimeOut { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float OnFailedTimeOut { get; set; } // 0x18 (24)
		
		[ContainerField(28)]
		public ReadinessLevel ReadinessOnStart { get; set; } = new ReadinessLevel(); // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool Enabled { get; set; } // 0x20 (32)
		
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
