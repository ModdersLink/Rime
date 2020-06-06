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
	public class ScaleClampNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort In { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort InMin { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24)]
		public AudioGraphNodePort InMax { get; set; } = new AudioGraphNodePort(); // 0x18 (24)
		
		[ContainerField(32)]
		public AudioGraphNodePort OutMin { get; set; } = new AudioGraphNodePort(); // 0x20 (32)
		
		[ContainerField(40)]
		public AudioGraphNodePort OutMax { get; set; } = new AudioGraphNodePort(); // 0x28 (40)
		
		[ContainerField(48)]
		public AudioGraphNodePort Out { get; set; } = new AudioGraphNodePort(); // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (AudioGraphNodePort) p_Value;
					break;

				case 214484264:
					InMin = (AudioGraphNodePort) p_Value;
					break;

				case 214484534:
					InMax = (AudioGraphNodePort) p_Value;
					break;

				case 2895749057:
					OutMin = (AudioGraphNodePort) p_Value;
					break;

				case 2895748831:
					OutMax = (AudioGraphNodePort) p_Value;
					break;

				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
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
				case 5862146:
					return In;

				case 214484264:
					return InMin;

				case 214484534:
					return InMax;

				case 2895749057:
					return OutMin;

				case 2895748831:
					return OutMax;

				case 193453899:
					return Out;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(ScaleClampNodeData).GetProperty(nameof(In));

				case 214484264:
					return typeof(ScaleClampNodeData).GetProperty(nameof(InMin));

				case 214484534:
					return typeof(ScaleClampNodeData).GetProperty(nameof(InMax));

				case 2895749057:
					return typeof(ScaleClampNodeData).GetProperty(nameof(OutMin));

				case 2895748831:
					return typeof(ScaleClampNodeData).GetProperty(nameof(OutMax));

				case 193453899:
					return typeof(ScaleClampNodeData).GetProperty(nameof(Out));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
