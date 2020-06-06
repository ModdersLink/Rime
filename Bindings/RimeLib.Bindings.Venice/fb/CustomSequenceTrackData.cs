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
	public class CustomSequenceTrackData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable]
		public string TrackName { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<CustomSequenceTrackLinkMapping> InputLinkMap { get; set; } = new RefArray<CustomSequenceTrackLinkMapping>(); // 0x10 (16)
		
		[ContainerField(20)]
		public RefArray<CustomSequenceTrackLinkMapping> OutputLinkMap { get; set; } = new RefArray<CustomSequenceTrackLinkMapping>(); // 0x14 (20)
		
		[ContainerField(24)]
		public RefArray<CustomSequenceTrackEventMapping> EventMap { get; set; } = new RefArray<CustomSequenceTrackEventMapping>(); // 0x18 (24)
		
		[ContainerField(28)]
		public RefArray<CustomSequenceTrackPropertyMapping> SourcePropertyMap { get; set; } = new RefArray<CustomSequenceTrackPropertyMapping>(); // 0x1C (28)
		
		[ContainerField(32)]
		public RefArray<CustomSequenceTrackPropertyMapping> TargetPropertyMap { get; set; } = new RefArray<CustomSequenceTrackPropertyMapping>(); // 0x20 (32)
		
		[ContainerField(36)]
		public RefArray<CustomSequenceTrackPropertyMapping> SourceAndTargetPropertyMap { get; set; } = new RefArray<CustomSequenceTrackPropertyMapping>(); // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1755529293:
					TrackName = (string) p_Value;
					break;

				case 1743335471:
					InputLinkMap = (RefArray<CustomSequenceTrackLinkMapping>) p_Value;
					break;

				case 2997861030:
					OutputLinkMap = (RefArray<CustomSequenceTrackLinkMapping>) p_Value;
					break;

				case 1687029045:
					EventMap = (RefArray<CustomSequenceTrackEventMapping>) p_Value;
					break;

				case 130951907:
					SourcePropertyMap = (RefArray<CustomSequenceTrackPropertyMapping>) p_Value;
					break;

				case 1050699055:
					TargetPropertyMap = (RefArray<CustomSequenceTrackPropertyMapping>) p_Value;
					break;

				case 3803134969:
					SourceAndTargetPropertyMap = (RefArray<CustomSequenceTrackPropertyMapping>) p_Value;
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
				case 1755529293:
					return TrackName;

				case 1743335471:
					return InputLinkMap;

				case 2997861030:
					return OutputLinkMap;

				case 1687029045:
					return EventMap;

				case 130951907:
					return SourcePropertyMap;

				case 1050699055:
					return TargetPropertyMap;

				case 3803134969:
					return SourceAndTargetPropertyMap;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1755529293:
					return typeof(CustomSequenceTrackData).GetProperty(nameof(TrackName));

				case 1743335471:
					return typeof(CustomSequenceTrackData).GetProperty(nameof(InputLinkMap));

				case 2997861030:
					return typeof(CustomSequenceTrackData).GetProperty(nameof(OutputLinkMap));

				case 1687029045:
					return typeof(CustomSequenceTrackData).GetProperty(nameof(EventMap));

				case 130951907:
					return typeof(CustomSequenceTrackData).GetProperty(nameof(SourcePropertyMap));

				case 1050699055:
					return typeof(CustomSequenceTrackData).GetProperty(nameof(TargetPropertyMap));

				case 3803134969:
					return typeof(CustomSequenceTrackData).GetProperty(nameof(SourceAndTargetPropertyMap));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
