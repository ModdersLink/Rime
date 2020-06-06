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
	public class BlueprintAndVariationPair : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<Asset> BaseAsset { get; set; } = new CtrRef<Asset>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<ObjectVariation> Variation { get; set; } = new CtrRef<ObjectVariation>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1696234240:
					BaseAsset = (CtrRef<Asset>) p_Value;
					break;

				case 2945980116:
					Variation = (CtrRef<ObjectVariation>) p_Value;
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
				case 1696234240:
					return BaseAsset;

				case 2945980116:
					return Variation;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1696234240:
					return typeof(BlueprintAndVariationPair).GetProperty(nameof(BaseAsset));

				case 2945980116:
					return typeof(BlueprintAndVariationPair).GetProperty(nameof(Variation));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
