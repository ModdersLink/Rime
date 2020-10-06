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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(12), ContainerClass]
	public class MixerSetPropertyNodeData : 
		AudioGraphNodeData
	{
		protected RefArray<MixerSetPropertyEntry> m_Entries = new RefArray<MixerSetPropertyEntry>();
		[ContainerField(8), MemberInfoFlag(65), ContainerFieldNameHash(8238103), ContainerRefArray]
		public RefArray<MixerSetPropertyEntry> Entries { get { return m_Entries; } set { if (OnPropertyChanging("MixerSetPropertyNodeData." + nameof(Entries), this, m_Entries, value)) m_Entries = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 8238103:
					Entries = (RefArray<MixerSetPropertyEntry>) p_Value;
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

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 8238103:
					return typeof(MixerSetPropertyNodeData).GetProperty(nameof(Entries));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
