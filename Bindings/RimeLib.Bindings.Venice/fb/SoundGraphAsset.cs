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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class SoundGraphAsset : 
		SoundAsset
	{
		protected CtrRef<SoundGraphData> m_Graph = new CtrRef<SoundGraphData>();
		[ContainerField(Name: "Graph", Offset: 16, NameHash: 208111145, Flags: 53)]
		public CtrRef<SoundGraphData> Graph { get { return m_Graph; } set { if (OnPropertyChanging("SoundGraphAsset." + nameof(Graph), this, m_Graph, value)) m_Graph = value; } } // 0x10 (16)
		
		protected CtrRef<MixerAsset> m_Mixer = new CtrRef<MixerAsset>();
		[ContainerField(Name: "Mixer", Offset: 20, NameHash: 209965422, Flags: 53)]
		public CtrRef<MixerAsset> Mixer { get { return m_Mixer; } set { if (OnPropertyChanging("SoundGraphAsset." + nameof(Mixer), this, m_Mixer, value)) m_Mixer = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 208111145:
					Graph = (CtrRef<SoundGraphData>) p_Value;
					break;

				case 209965422:
					Mixer = (CtrRef<MixerAsset>) p_Value;
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
				case 208111145:
					return Graph;

				case 209965422:
					return Mixer;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 208111145:
					return typeof(SoundGraphAsset).GetProperty(nameof(Graph));

				case 209965422:
					return typeof(SoundGraphAsset).GetProperty(nameof(Mixer));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
