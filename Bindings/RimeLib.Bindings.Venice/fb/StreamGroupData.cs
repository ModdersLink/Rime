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
	public class StreamGroupData : 
		DataContainer
	{
		protected RefArray<Asset> m_Assets = new RefArray<Asset>();
		[ContainerField(8), MemberInfoFlag(65), ContainerFieldNameHash(2502242534), ContainerRefArray]
		public RefArray<Asset> Assets { get { return m_Assets; } set { if (OnPropertyChanging("StreamGroupData." + nameof(Assets), this, m_Assets, value)) m_Assets = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2502242534:
					Assets = (RefArray<Asset>) p_Value;
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
				case 2502242534:
					return Assets;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2502242534:
					return typeof(StreamGroupData).GetProperty(nameof(Assets));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
