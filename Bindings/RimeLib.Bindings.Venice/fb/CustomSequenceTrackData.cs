///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 40)]
	public class CustomSequenceTrackData : 
		EntityData
	{
		protected string m_TrackName = string.Empty;
		[ContainerField(Name: "TrackName", Offset: 12, NameHash: 1755529293, Flags: 16509), LayoutImmutable]
		public string TrackName { get { return m_TrackName; } set { if (OnPropertyChanging("CustomSequenceTrackData." + nameof(TrackName), this, m_TrackName, value)) m_TrackName = value; } } // 0xC (12)
		
		protected RefArray<CustomSequenceTrackLinkMapping> m_InputLinkMap = new RefArray<CustomSequenceTrackLinkMapping>();
		[ContainerField(Name: "InputLinkMap", Offset: 16, NameHash: 1743335471, Flags: 65)]
		public RefArray<CustomSequenceTrackLinkMapping> InputLinkMap { get { return m_InputLinkMap; } set { if (OnPropertyChanging("CustomSequenceTrackData." + nameof(InputLinkMap), this, m_InputLinkMap, value)) m_InputLinkMap = value; } } // 0x10 (16)
		
		protected RefArray<CustomSequenceTrackLinkMapping> m_OutputLinkMap = new RefArray<CustomSequenceTrackLinkMapping>();
		[ContainerField(Name: "OutputLinkMap", Offset: 20, NameHash: 2997861030, Flags: 65)]
		public RefArray<CustomSequenceTrackLinkMapping> OutputLinkMap { get { return m_OutputLinkMap; } set { if (OnPropertyChanging("CustomSequenceTrackData." + nameof(OutputLinkMap), this, m_OutputLinkMap, value)) m_OutputLinkMap = value; } } // 0x14 (20)
		
		protected RefArray<CustomSequenceTrackEventMapping> m_EventMap = new RefArray<CustomSequenceTrackEventMapping>();
		[ContainerField(Name: "EventMap", Offset: 24, NameHash: 1687029045, Flags: 65)]
		public RefArray<CustomSequenceTrackEventMapping> EventMap { get { return m_EventMap; } set { if (OnPropertyChanging("CustomSequenceTrackData." + nameof(EventMap), this, m_EventMap, value)) m_EventMap = value; } } // 0x18 (24)
		
		protected RefArray<CustomSequenceTrackPropertyMapping> m_SourcePropertyMap = new RefArray<CustomSequenceTrackPropertyMapping>();
		[ContainerField(Name: "SourcePropertyMap", Offset: 28, NameHash: 130951907, Flags: 65)]
		public RefArray<CustomSequenceTrackPropertyMapping> SourcePropertyMap { get { return m_SourcePropertyMap; } set { if (OnPropertyChanging("CustomSequenceTrackData." + nameof(SourcePropertyMap), this, m_SourcePropertyMap, value)) m_SourcePropertyMap = value; } } // 0x1C (28)
		
		protected RefArray<CustomSequenceTrackPropertyMapping> m_TargetPropertyMap = new RefArray<CustomSequenceTrackPropertyMapping>();
		[ContainerField(Name: "TargetPropertyMap", Offset: 32, NameHash: 1050699055, Flags: 65)]
		public RefArray<CustomSequenceTrackPropertyMapping> TargetPropertyMap { get { return m_TargetPropertyMap; } set { if (OnPropertyChanging("CustomSequenceTrackData." + nameof(TargetPropertyMap), this, m_TargetPropertyMap, value)) m_TargetPropertyMap = value; } } // 0x20 (32)
		
		protected RefArray<CustomSequenceTrackPropertyMapping> m_SourceAndTargetPropertyMap = new RefArray<CustomSequenceTrackPropertyMapping>();
		[ContainerField(Name: "SourceAndTargetPropertyMap", Offset: 36, NameHash: 3803134969, Flags: 65)]
		public RefArray<CustomSequenceTrackPropertyMapping> SourceAndTargetPropertyMap { get { return m_SourceAndTargetPropertyMap; } set { if (OnPropertyChanging("CustomSequenceTrackData." + nameof(SourceAndTargetPropertyMap), this, m_SourceAndTargetPropertyMap, value)) m_SourceAndTargetPropertyMap = value; } } // 0x24 (36)
		
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
