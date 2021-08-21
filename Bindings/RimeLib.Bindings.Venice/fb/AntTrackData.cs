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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 44)]
	public class AntTrackData : 
		CustomSequenceTrackData
	{
		protected RefArray<AntTrackItemData> m_AntTrackItemDatas = new RefArray<AntTrackItemData>();
		[ContainerField(Name: "AntTrackItemDatas", Offset: 40, NameHash: 3918294759, Flags: 65)]
		public RefArray<AntTrackItemData> AntTrackItemDatas { get { return m_AntTrackItemDatas; } set { if (OnPropertyChanging("AntTrackData." + nameof(AntTrackItemDatas), this, m_AntTrackItemDatas, value)) m_AntTrackItemDatas = value; } } // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3918294759:
					AntTrackItemDatas = (RefArray<AntTrackItemData>) p_Value;
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
				case 3918294759:
					return AntTrackItemDatas;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3918294759:
					return typeof(AntTrackData).GetProperty(nameof(AntTrackItemDatas));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
