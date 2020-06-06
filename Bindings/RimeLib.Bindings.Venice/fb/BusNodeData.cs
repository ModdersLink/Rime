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
	public class BusNodeData : 
		SoundBusData
	{
		[ContainerField(16)]
		public AudioGraphNodePort Out { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24)]
		public SoundGraphPluginRef VuPlugin { get; set; } = new SoundGraphPluginRef(); // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
					break;

				case 2033640783:
					VuPlugin = (SoundGraphPluginRef) p_Value;
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
				case 193453899:
					return Out;

				case 2033640783:
					return VuPlugin;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193453899:
					return typeof(BusNodeData).GetProperty(nameof(Out));

				case 2033640783:
					return typeof(BusNodeData).GetProperty(nameof(VuPlugin));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
