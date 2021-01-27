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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 28)]
	public class AudioGraphData : 
		DataContainer
	{
		protected RefArray<AudioGraphNodeData> m_Nodes = new RefArray<AudioGraphNodeData>();
		[ContainerField(Name: "Nodes", Offset: 8, NameHash: 215794742, Flags: 65)]
		public RefArray<AudioGraphNodeData> Nodes { get { return m_Nodes; } set { if (OnPropertyChanging("AudioGraphData." + nameof(Nodes), this, m_Nodes, value)) m_Nodes = value; } } // 0x8 (8)
		
		protected RefArray<AudioGraphParameter> m_PublicParameters = new RefArray<AudioGraphParameter>();
		[ContainerField(Name: "PublicParameters", Offset: 12, NameHash: 3369464478, Flags: 65)]
		public RefArray<AudioGraphParameter> PublicParameters { get { return m_PublicParameters; } set { if (OnPropertyChanging("AudioGraphData." + nameof(PublicParameters), this, m_PublicParameters, value)) m_PublicParameters = value; } } // 0xC (12)
		
		protected RefArray<AudioGraphEvent> m_PublicEvents = new RefArray<AudioGraphEvent>();
		[ContainerField(Name: "PublicEvents", Offset: 16, NameHash: 3604259899, Flags: 65)]
		public RefArray<AudioGraphEvent> PublicEvents { get { return m_PublicEvents; } set { if (OnPropertyChanging("AudioGraphData." + nameof(PublicEvents), this, m_PublicEvents, value)) m_PublicEvents = value; } } // 0x10 (16)
		
		protected RefArray<AudioGraphAssetParameter> m_PublicAssetParameters = new RefArray<AudioGraphAssetParameter>();
		[ContainerField(Name: "PublicAssetParameters", Offset: 20, NameHash: 2006735054, Flags: 65)]
		public RefArray<AudioGraphAssetParameter> PublicAssetParameters { get { return m_PublicAssetParameters; } set { if (OnPropertyChanging("AudioGraphData." + nameof(PublicAssetParameters), this, m_PublicAssetParameters, value)) m_PublicAssetParameters = value; } } // 0x14 (20)
		
		protected ushort m_PublicValueCount = new ushort();
		[ContainerField(Name: "PublicValueCount", Offset: 24, NameHash: 4219205324, Flags: 49389), LayoutImmutable, Blittable]
		public ushort PublicValueCount { get { return m_PublicValueCount; } set { if (OnPropertyChanging("AudioGraphData." + nameof(PublicValueCount), this, m_PublicValueCount, value)) m_PublicValueCount = value; } } // 0x18 (24)
		
		protected ushort m_ValueCount = new ushort();
		[ContainerField(Name: "ValueCount", Offset: 26, NameHash: 2096746893, Flags: 49389), LayoutImmutable, Blittable]
		public ushort ValueCount { get { return m_ValueCount; } set { if (OnPropertyChanging("AudioGraphData." + nameof(ValueCount), this, m_ValueCount, value)) m_ValueCount = value; } } // 0x1A (26)
		
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
