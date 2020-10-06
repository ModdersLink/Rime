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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(16), ContainerClass]
	public class MixerSystemAsset : 
		Asset
	{
		protected RefArray<MixGroup> m_Groups = new RefArray<MixGroup>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(2573340009), ContainerRefArray]
		public RefArray<MixGroup> Groups { get { return m_Groups; } set { if (OnPropertyChanging("MixerSystemAsset." + nameof(Groups), this, m_Groups, value)) m_Groups = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2573340009:
					Groups = (RefArray<MixGroup>) p_Value;
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
				case 2573340009:
					return Groups;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2573340009:
					return typeof(MixerSystemAsset).GetProperty(nameof(Groups));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
