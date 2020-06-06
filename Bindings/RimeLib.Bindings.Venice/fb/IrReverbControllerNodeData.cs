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
	public class IrReverbControllerNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort Reverb0 { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort Amplitude0 { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24)]
		public AudioGraphNodePort Reverb1 { get; set; } = new AudioGraphNodePort(); // 0x18 (24)
		
		[ContainerField(32)]
		public AudioGraphNodePort Amplitude1 { get; set; } = new AudioGraphNodePort(); // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1309052001:
					Reverb0 = (AudioGraphNodePort) p_Value;
					break;

				case 1577794412:
					Amplitude0 = (AudioGraphNodePort) p_Value;
					break;

				case 1309052000:
					Reverb1 = (AudioGraphNodePort) p_Value;
					break;

				case 1577794413:
					Amplitude1 = (AudioGraphNodePort) p_Value;
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
				case 1309052001:
					return Reverb0;

				case 1577794412:
					return Amplitude0;

				case 1309052000:
					return Reverb1;

				case 1577794413:
					return Amplitude1;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1309052001:
					return typeof(IrReverbControllerNodeData).GetProperty(nameof(Reverb0));

				case 1577794412:
					return typeof(IrReverbControllerNodeData).GetProperty(nameof(Amplitude0));

				case 1309052000:
					return typeof(IrReverbControllerNodeData).GetProperty(nameof(Reverb1));

				case 1577794413:
					return typeof(IrReverbControllerNodeData).GetProperty(nameof(Amplitude1));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
