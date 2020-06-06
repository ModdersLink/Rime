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
	public class StaticEnlightenEntityData : 
		EnlightenEntityData
	{
		[ContainerField(24)]
		public CtrRef<StaticEnlightenData> EnlightenData { get; set; } = new CtrRef<StaticEnlightenData>(); // 0x18 (24)
		
		[ContainerField(28)]
		public CtrRef<EnlightenDataAsset> DynamicEnlightenData { get; set; } = new CtrRef<EnlightenDataAsset>(); // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1802220171:
					EnlightenData = (CtrRef<StaticEnlightenData>) p_Value;
					break;

				case 79303358:
					DynamicEnlightenData = (CtrRef<EnlightenDataAsset>) p_Value;
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
				case 1802220171:
					return EnlightenData;

				case 79303358:
					return DynamicEnlightenData;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1802220171:
					return typeof(StaticEnlightenEntityData).GetProperty(nameof(EnlightenData));

				case 79303358:
					return typeof(StaticEnlightenEntityData).GetProperty(nameof(DynamicEnlightenData));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
