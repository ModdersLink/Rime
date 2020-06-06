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
	public class CustomSequenceTrackPropertyMapping : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public int TrackPropertyID { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public int SequencePropertyID { get; set; } // 0xC (12)
		
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
