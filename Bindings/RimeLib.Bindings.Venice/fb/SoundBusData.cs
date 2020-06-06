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
	public class SoundBusData : 
		AudioGraphNodeData
	{
		[ContainerField(8), LayoutImmutable]
		public string BusName { get; set; } // 0x8 (8)
		
		[ContainerField(12)]
		public SoundGraphPluginRef SubmixPlugin { get; set; } = new SoundGraphPluginRef(); // 0xC (12)
		
		[ContainerField(15), LayoutImmutable, Blittable]
		public sbyte ChannelCount { get; set; } // 0xF (15)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2742307846:
					BusName = (string) p_Value;
					break;

				case 132398548:
					SubmixPlugin = (SoundGraphPluginRef) p_Value;
					break;

				case 1014205285:
					ChannelCount = (sbyte) p_Value;
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
				case 2742307846:
					return BusName;

				case 132398548:
					return SubmixPlugin;

				case 1014205285:
					return ChannelCount;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2742307846:
					return typeof(SoundBusData).GetProperty(nameof(BusName));

				case 132398548:
					return typeof(SoundBusData).GetProperty(nameof(SubmixPlugin));

				case 1014205285:
					return typeof(SoundBusData).GetProperty(nameof(ChannelCount));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
