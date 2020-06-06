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
	public class SoundGraphLinkedPluginAttribute : FrostbiteContainer
	{
		[ContainerField(0)]
		public SoundGraphPluginRef Plugin { get; set; } = new SoundGraphPluginRef(); // 0x0 (0)
		
		[ContainerField(4)]
		public CtrRef<AudioGraphNodeData> Node { get; set; } = new CtrRef<AudioGraphNodeData>(); // 0x4 (4)
		
		[ContainerField(8)]
		public AudioGraphNodePort Port { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public sbyte AttributeIndex { get; set; } // 0x10 (16)
		
		[ContainerField(17), LayoutImmutable, Blittable]
		public bool AllowExtremeValues { get; set; } // 0x11 (17)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3384353452:
					Plugin = (SoundGraphPluginRef) p_Value;
					break;

				case 2088947621:
					Node = (CtrRef<AudioGraphNodeData>) p_Value;
					break;

				case 2089459004:
					Port = (AudioGraphNodePort) p_Value;
					break;

				case 2787489767:
					AttributeIndex = (sbyte) p_Value;
					break;

				case 1873573874:
					AllowExtremeValues = (bool) p_Value;
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
				case 3384353452:
					return Plugin;

				case 2088947621:
					return Node;

				case 2089459004:
					return Port;

				case 2787489767:
					return AttributeIndex;

				case 1873573874:
					return AllowExtremeValues;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3384353452:
					return typeof(SoundGraphLinkedPluginAttribute).GetProperty(nameof(Plugin));

				case 2088947621:
					return typeof(SoundGraphLinkedPluginAttribute).GetProperty(nameof(Node));

				case 2089459004:
					return typeof(SoundGraphLinkedPluginAttribute).GetProperty(nameof(Port));

				case 2787489767:
					return typeof(SoundGraphLinkedPluginAttribute).GetProperty(nameof(AttributeIndex));

				case 1873573874:
					return typeof(SoundGraphLinkedPluginAttribute).GetProperty(nameof(AllowExtremeValues));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
