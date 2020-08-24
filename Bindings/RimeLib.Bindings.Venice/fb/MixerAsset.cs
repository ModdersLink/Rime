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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class MixerAsset : 
		Asset
	{
		protected CtrRef<MixerGraphData> m_Graph = new CtrRef<MixerGraphData>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(208111145), ContainerCtrRef]
		public CtrRef<MixerGraphData> Graph { get { return m_Graph; } set { if (OnPropertyChanging("MixerAsset." + nameof(Graph), this, m_Graph, value)) m_Graph = value; } } // 0xC (12)
		
		protected RefArray<MixerPreset> m_Presets = new RefArray<MixerPreset>();
		[ContainerField(16), MemberInfoFlag(65), ContainerFieldNameHash(3463460435), ContainerRefArray]
		public RefArray<MixerPreset> Presets { get { return m_Presets; } set { if (OnPropertyChanging("MixerAsset." + nameof(Presets), this, m_Presets, value)) m_Presets = value; } } // 0x10 (16)
		
		protected CtrRef<MixerPreset> m_DefaultPreset = new CtrRef<MixerPreset>();
		[ContainerField(20), MemberInfoFlag(53), ContainerFieldNameHash(4117030027), ContainerCtrRef]
		public CtrRef<MixerPreset> DefaultPreset { get { return m_DefaultPreset; } set { if (OnPropertyChanging("MixerAsset." + nameof(DefaultPreset), this, m_DefaultPreset, value)) m_DefaultPreset = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 208111145:
					Graph = (CtrRef<MixerGraphData>) p_Value;
					break;

				case 3463460435:
					Presets = (RefArray<MixerPreset>) p_Value;
					break;

				case 4117030027:
					DefaultPreset = (CtrRef<MixerPreset>) p_Value;
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

				case 3463460435:
					return Presets;

				case 4117030027:
					return DefaultPreset;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 208111145:
					return typeof(MixerAsset).GetProperty(nameof(Graph));

				case 3463460435:
					return typeof(MixerAsset).GetProperty(nameof(Presets));

				case 4117030027:
					return typeof(MixerAsset).GetProperty(nameof(DefaultPreset));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
