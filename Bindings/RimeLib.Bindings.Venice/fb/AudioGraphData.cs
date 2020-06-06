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
	public class AudioGraphData : 
		DataContainer
	{
		[ContainerField(8)]
		public RefArray<AudioGraphNodeData> Nodes { get; set; } = new RefArray<AudioGraphNodeData>(); // 0x8 (8)
		
		[ContainerField(12)]
		public RefArray<AudioGraphParameter> PublicParameters { get; set; } = new RefArray<AudioGraphParameter>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<AudioGraphEvent> PublicEvents { get; set; } = new RefArray<AudioGraphEvent>(); // 0x10 (16)
		
		[ContainerField(20)]
		public RefArray<AudioGraphAssetParameter> PublicAssetParameters { get; set; } = new RefArray<AudioGraphAssetParameter>(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public ushort PublicValueCount { get; set; } // 0x18 (24)
		
		[ContainerField(26), LayoutImmutable, Blittable]
		public ushort ValueCount { get; set; } // 0x1A (26)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 215794742:
					Nodes = (RefArray<AudioGraphNodeData>) p_Value;
					break;

				case 3369464478:
					PublicParameters = (RefArray<AudioGraphParameter>) p_Value;
					break;

				case 3604259899:
					PublicEvents = (RefArray<AudioGraphEvent>) p_Value;
					break;

				case 2006735054:
					PublicAssetParameters = (RefArray<AudioGraphAssetParameter>) p_Value;
					break;

				case 4219205324:
					PublicValueCount = (ushort) p_Value;
					break;

				case 2096746893:
					ValueCount = (ushort) p_Value;
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
				case 215794742:
					return Nodes;

				case 3369464478:
					return PublicParameters;

				case 3604259899:
					return PublicEvents;

				case 2006735054:
					return PublicAssetParameters;

				case 4219205324:
					return PublicValueCount;

				case 2096746893:
					return ValueCount;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 215794742:
					return typeof(AudioGraphData).GetProperty(nameof(Nodes));

				case 3369464478:
					return typeof(AudioGraphData).GetProperty(nameof(PublicParameters));

				case 3604259899:
					return typeof(AudioGraphData).GetProperty(nameof(PublicEvents));

				case 2006735054:
					return typeof(AudioGraphData).GetProperty(nameof(PublicAssetParameters));

				case 4219205324:
					return typeof(AudioGraphData).GetProperty(nameof(PublicValueCount));

				case 2096746893:
					return typeof(AudioGraphData).GetProperty(nameof(ValueCount));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
