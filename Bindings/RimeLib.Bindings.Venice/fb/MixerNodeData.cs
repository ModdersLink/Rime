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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(20), ContainerClass]
	public class MixerNodeData : 
		AudioGraphNodeData
	{
		protected RefArray<MixerEntry> m_Entries = new RefArray<MixerEntry>();
		[ContainerField(8), MemberInfoFlag(65), ContainerFieldNameHash(8238103), ContainerRefArray]
		public RefArray<MixerEntry> Entries { get { return m_Entries; } set { if (OnPropertyChanging("MixerNodeData." + nameof(Entries), this, m_Entries, value)) m_Entries = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Out = new AudioGraphNodePort();
		[ContainerField(12), MemberInfoFlag(41), ContainerFieldNameHash(193453899)]
		public AudioGraphNodePort Out { get { return m_Out; } set { if (OnPropertyChanging("MixerNodeData." + nameof(Out), this, m_Out, value)) m_Out = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 8238103:
					Entries = (RefArray<MixerEntry>) p_Value;
					break;

				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
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
				case 8238103:
					return Entries;

				case 193453899:
					return Out;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 8238103:
					return typeof(MixerNodeData).GetProperty(nameof(Entries));

				case 193453899:
					return typeof(MixerNodeData).GetProperty(nameof(Out));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
