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
	public class MinMaxNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort X { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort Y { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24)]
		public AudioGraphNodePort Max { get; set; } = new AudioGraphNodePort(); // 0x18 (24)
		
		[ContainerField(32)]
		public AudioGraphNodePort Min { get; set; } = new AudioGraphNodePort(); // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 177661:
					X = (AudioGraphNodePort) p_Value;
					break;

				case 177660:
					Y = (AudioGraphNodePort) p_Value;
					break;

				case 193446865:
					Max = (AudioGraphNodePort) p_Value;
					break;

				case 193446607:
					Min = (AudioGraphNodePort) p_Value;
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
				case 177661:
					return X;

				case 177660:
					return Y;

				case 193446865:
					return Max;

				case 193446607:
					return Min;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 177661:
					return typeof(MinMaxNodeData).GetProperty(nameof(X));

				case 177660:
					return typeof(MinMaxNodeData).GetProperty(nameof(Y));

				case 193446865:
					return typeof(MinMaxNodeData).GetProperty(nameof(Max));

				case 193446607:
					return typeof(MinMaxNodeData).GetProperty(nameof(Min));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
