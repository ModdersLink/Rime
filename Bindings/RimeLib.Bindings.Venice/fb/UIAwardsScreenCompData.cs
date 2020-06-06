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
	public class UIAwardsScreenCompData : 
		UIComponentData
	{
		[ContainerField(28)]
		public RefArray<StatsCategoryBaseData> TrackableAwardRow { get; set; } = new RefArray<StatsCategoryBaseData>(); // 0x1C (28)
		
		[ContainerField(32)]
		public RefArray<StatsCategoryBaseData> TrackableAwardCol { get; set; } = new RefArray<StatsCategoryBaseData>(); // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 383950411:
					TrackableAwardRow = (RefArray<StatsCategoryBaseData>) p_Value;
					break;

				case 383933953:
					TrackableAwardCol = (RefArray<StatsCategoryBaseData>) p_Value;
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
				case 383950411:
					return TrackableAwardRow;

				case 383933953:
					return TrackableAwardCol;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 383950411:
					return typeof(UIAwardsScreenCompData).GetProperty(nameof(TrackableAwardRow));

				case 383933953:
					return typeof(UIAwardsScreenCompData).GetProperty(nameof(TrackableAwardCol));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
