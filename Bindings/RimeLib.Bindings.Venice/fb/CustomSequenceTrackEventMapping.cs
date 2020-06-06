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
	public class CustomSequenceTrackEventMapping : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public int TrackEventID { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public int SequenceEventID { get; set; } // 0xC (12)
		
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
