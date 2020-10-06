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
	public class PlayerViewData : 
		DataContainer
	{
		protected RefArray<SubViewData> m_SubViews = new RefArray<SubViewData>();
		[ContainerField(8), MemberInfoFlag(65), ContainerFieldNameHash(1752723775), ContainerRefArray]
		public RefArray<SubViewData> SubViews { get { return m_SubViews; } set { if (OnPropertyChanging("PlayerViewData." + nameof(SubViews), this, m_SubViews, value)) m_SubViews = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1752723775:
					SubViews = (RefArray<SubViewData>) p_Value;
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
				case 1752723775:
					return SubViews;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1752723775:
					return typeof(PlayerViewData).GetProperty(nameof(SubViews));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
