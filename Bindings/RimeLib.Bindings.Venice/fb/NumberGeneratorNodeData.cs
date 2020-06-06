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
	public class NumberGeneratorNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort Trigger { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float Min { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float Max { get; set; } // 0x14 (20)
		
		[ContainerField(24)]
		public NumberGeneratorMode Mode { get; set; } = new NumberGeneratorMode(); // 0x18 (24)
		
		[ContainerField(28)]
		public AudioGraphNodePort Y { get; set; } = new AudioGraphNodePort(); // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2606354109:
					Trigger = (AudioGraphNodePort) p_Value;
					break;

				case 193446607:
					Min = (float) p_Value;
					break;

				case 193446865:
					Max = (float) p_Value;
					break;

				case 2088772358:
					Mode = (NumberGeneratorMode) Enum.ToObject(typeof(NumberGeneratorMode), p_Value);
					break;

				case 177660:
					Y = (AudioGraphNodePort) p_Value;
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
				case 2606354109:
					return Trigger;

				case 193446607:
					return Min;

				case 193446865:
					return Max;

				case 2088772358:
					return Mode;

				case 177660:
					return Y;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2606354109:
					return typeof(NumberGeneratorNodeData).GetProperty(nameof(Trigger));

				case 193446607:
					return typeof(NumberGeneratorNodeData).GetProperty(nameof(Min));

				case 193446865:
					return typeof(NumberGeneratorNodeData).GetProperty(nameof(Max));

				case 2088772358:
					return typeof(NumberGeneratorNodeData).GetProperty(nameof(Mode));

				case 177660:
					return typeof(NumberGeneratorNodeData).GetProperty(nameof(Y));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
