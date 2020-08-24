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
	public class CustomSequenceTrackEventMapping : 
		DataContainer
	{
		protected int m_TrackEventID = new int();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3785607275)]
		public int TrackEventID { get { return m_TrackEventID; } set { if (OnPropertyChanging("CustomSequenceTrackEventMapping." + nameof(TrackEventID), this, m_TrackEventID, value)) m_TrackEventID = value; } } // 0x8 (8)
		
		protected int m_SequenceEventID = new int();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(959482075)]
		public int SequenceEventID { get { return m_SequenceEventID; } set { if (OnPropertyChanging("CustomSequenceTrackEventMapping." + nameof(SequenceEventID), this, m_SequenceEventID, value)) m_SequenceEventID = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3785607275:
					TrackEventID = (int) p_Value;
					break;

				case 959482075:
					SequenceEventID = (int) p_Value;
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
				case 3785607275:
					return TrackEventID;

				case 959482075:
					return SequenceEventID;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3785607275:
					return typeof(CustomSequenceTrackEventMapping).GetProperty(nameof(TrackEventID));

				case 959482075:
					return typeof(CustomSequenceTrackEventMapping).GetProperty(nameof(SequenceEventID));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
