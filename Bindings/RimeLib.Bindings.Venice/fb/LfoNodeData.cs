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
	public class LfoNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort Hz { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort Amplitude { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24)]
		public AudioGraphNodePort Out { get; set; } = new AudioGraphNodePort(); // 0x18 (24)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float Min { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float Max { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public bool StartAtRandomValue { get; set; } // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862391:
					Hz = (AudioGraphNodePort) p_Value;
					break;

				case 698564572:
					Amplitude = (AudioGraphNodePort) p_Value;
					break;

				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
					break;

				case 193446607:
					Min = (float) p_Value;
					break;

				case 193446865:
					Max = (float) p_Value;
					break;

				case 2693653696:
					StartAtRandomValue = (bool) p_Value;
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
				case 5862391:
					return Hz;

				case 698564572:
					return Amplitude;

				case 193453899:
					return Out;

				case 193446607:
					return Min;

				case 193446865:
					return Max;

				case 2693653696:
					return StartAtRandomValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862391:
					return typeof(LfoNodeData).GetProperty(nameof(Hz));

				case 698564572:
					return typeof(LfoNodeData).GetProperty(nameof(Amplitude));

				case 193453899:
					return typeof(LfoNodeData).GetProperty(nameof(Out));

				case 193446607:
					return typeof(LfoNodeData).GetProperty(nameof(Min));

				case 193446865:
					return typeof(LfoNodeData).GetProperty(nameof(Max));

				case 2693653696:
					return typeof(LfoNodeData).GetProperty(nameof(StartAtRandomValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
