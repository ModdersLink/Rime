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
	public class ValueUnlockAsset : 
		UnlockAssetBase
	{
		[ContainerField(40)]
		public RefArray<UnlockValuePair> UnlockValues { get; set; } = new RefArray<UnlockValuePair>(); // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2757489261:
					UnlockValues = (RefArray<UnlockValuePair>) p_Value;
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
				case 2757489261:
					return UnlockValues;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2757489261:
					return typeof(ValueUnlockAsset).GetProperty(nameof(UnlockValues));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
