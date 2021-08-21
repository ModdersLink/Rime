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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class CustomSequenceTrackPropertyMapping : 
		DataContainer
	{
		protected int m_TrackPropertyID = new int();
		[ContainerField(Name: "TrackPropertyID", Offset: 8, NameHash: 3764113472, Flags: 49405), LayoutImmutable, Blittable]
		public int TrackPropertyID { get { return m_TrackPropertyID; } set { if (OnPropertyChanging("CustomSequenceTrackPropertyMapping." + nameof(TrackPropertyID), this, m_TrackPropertyID, value)) m_TrackPropertyID = value; } } // 0x8 (8)
		
		protected int m_SequencePropertyID = new int();
		[ContainerField(Name: "SequencePropertyID", Offset: 12, NameHash: 2623680624, Flags: 49405), LayoutImmutable, Blittable]
		public int SequencePropertyID { get { return m_SequencePropertyID; } set { if (OnPropertyChanging("CustomSequenceTrackPropertyMapping." + nameof(SequencePropertyID), this, m_SequencePropertyID, value)) m_SequencePropertyID = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3764113472:
					TrackPropertyID = (int) p_Value;
					break;

				case 2623680624:
					SequencePropertyID = (int) p_Value;
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
				case 3764113472:
					return TrackPropertyID;

				case 2623680624:
					return SequencePropertyID;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3764113472:
					return typeof(CustomSequenceTrackPropertyMapping).GetProperty(nameof(TrackPropertyID));

				case 2623680624:
					return typeof(CustomSequenceTrackPropertyMapping).GetProperty(nameof(SequencePropertyID));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
