///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class CustomSequenceTrackLinkMapping : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public int TrackLinkID { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public int SequenceLinkID { get; set; } // 0xC (12)
		
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
