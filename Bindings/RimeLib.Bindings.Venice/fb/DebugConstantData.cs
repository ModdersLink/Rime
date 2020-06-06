///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class DebugConstantData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float BotDebugDistance { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float InViewModeFOV { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint GraphDataBuffer { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float MinDecisionTime { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public bool InaccuracyEnabled { get; set; } // 0x1C (28)
		
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
