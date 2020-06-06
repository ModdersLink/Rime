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
	public class CrossfaderNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort In1 { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort In2 { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24)]
		public AudioGraphNodePort Ctrl { get; set; } = new AudioGraphNodePort(); // 0x18 (24)
		
		[ContainerField(32)]
		public AudioGraphNodePort Out { get; set; } = new AudioGraphNodePort(); // 0x20 (32)
		
		[ContainerField(40)]
		public SoundGraphPluginRef Plugin1 { get; set; } = new SoundGraphPluginRef(); // 0x28 (40)
		
		[ContainerField(43)]
		public SoundGraphPluginRef Plugin2 { get; set; } = new SoundGraphPluginRef(); // 0x2B (43)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193450867:
					In1 = (AudioGraphNodePort) p_Value;
					break;

				case 193450864:
					In2 = (AudioGraphNodePort) p_Value;
					break;

				case 2088859916:
					Ctrl = (AudioGraphNodePort) p_Value;
					break;

				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
					break;

				case 14514205:
					Plugin1 = (SoundGraphPluginRef) p_Value;
					break;

				case 14514206:
					Plugin2 = (SoundGraphPluginRef) p_Value;
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
				case 193450867:
					return In1;

				case 193450864:
					return In2;

				case 2088859916:
					return Ctrl;

				case 193453899:
					return Out;

				case 14514205:
					return Plugin1;

				case 14514206:
					return Plugin2;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193450867:
					return typeof(CrossfaderNodeData).GetProperty(nameof(In1));

				case 193450864:
					return typeof(CrossfaderNodeData).GetProperty(nameof(In2));

				case 2088859916:
					return typeof(CrossfaderNodeData).GetProperty(nameof(Ctrl));

				case 193453899:
					return typeof(CrossfaderNodeData).GetProperty(nameof(Out));

				case 14514205:
					return typeof(CrossfaderNodeData).GetProperty(nameof(Plugin1));

				case 14514206:
					return typeof(CrossfaderNodeData).GetProperty(nameof(Plugin2));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
