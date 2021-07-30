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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class CustomSequenceTrackLinkMapping : 
		DataContainer
	{
		protected int m_TrackLinkID = new int();
		[ContainerField(Name: "TrackLinkID", Offset: 8, NameHash: 749830855, Flags: 49405), LayoutImmutable, Blittable]
		public int TrackLinkID { get { return m_TrackLinkID; } set { if (OnPropertyChanging("CustomSequenceTrackLinkMapping." + nameof(TrackLinkID), this, m_TrackLinkID, value)) m_TrackLinkID = value; } } // 0x8 (8)
		
		protected int m_SequenceLinkID = new int();
		[ContainerField(Name: "SequenceLinkID", Offset: 12, NameHash: 2081585527, Flags: 49405), LayoutImmutable, Blittable]
		public int SequenceLinkID { get { return m_SequenceLinkID; } set { if (OnPropertyChanging("CustomSequenceTrackLinkMapping." + nameof(SequenceLinkID), this, m_SequenceLinkID, value)) m_SequenceLinkID = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 749830855:
					TrackLinkID = (int) p_Value;
					break;

				case 2081585527:
					SequenceLinkID = (int) p_Value;
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
				case 749830855:
					return TrackLinkID;

				case 2081585527:
					return SequenceLinkID;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 749830855:
					return typeof(CustomSequenceTrackLinkMapping).GetProperty(nameof(TrackLinkID));

				case 2081585527:
					return typeof(CustomSequenceTrackLinkMapping).GetProperty(nameof(SequenceLinkID));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
