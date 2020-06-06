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
	public class AiffWriterNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort In { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort Start { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24)]
		public AudioGraphNodePort Stop { get; set; } = new AudioGraphNodePort(); // 0x18 (24)
		
		[ContainerField(32)]
		public SoundGraphPluginRef Plugin { get; set; } = new SoundGraphPluginRef(); // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable]
		public string FileName { get; set; } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (AudioGraphNodePort) p_Value;
					break;

				case 230748069:
					Start = (AudioGraphNodePort) p_Value;
					break;

				case 2089401213:
					Stop = (AudioGraphNodePort) p_Value;
					break;

				case 3384353452:
					Plugin = (SoundGraphPluginRef) p_Value;
					break;

				case 1134474212:
					FileName = (string) p_Value;
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

				case 230748069:
					return Start;

				case 2089401213:
					return Stop;

				case 3384353452:
					return Plugin;

				case 1134474212:
					return FileName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(AiffWriterNodeData).GetProperty(nameof(In));

				case 230748069:
					return typeof(AiffWriterNodeData).GetProperty(nameof(Start));

				case 2089401213:
					return typeof(AiffWriterNodeData).GetProperty(nameof(Stop));

				case 3384353452:
					return typeof(AiffWriterNodeData).GetProperty(nameof(Plugin));

				case 1134474212:
					return typeof(AiffWriterNodeData).GetProperty(nameof(FileName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
