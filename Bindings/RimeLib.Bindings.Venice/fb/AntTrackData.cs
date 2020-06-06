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
	public class AntTrackData : 
		CustomSequenceTrackData
	{
		[ContainerField(40)]
		public RefArray<AntTrackItemData> AntTrackItemDatas { get; set; } = new RefArray<AntTrackItemData>(); // 0x28 (40)
		
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
