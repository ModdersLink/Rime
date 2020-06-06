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
	public class HavokAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float Scale { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<DataContainer> ExternalAssets { get; set; } = new RefArray<DataContainer>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 231223453:
					Scale = (float) p_Value;
					break;

				case 1938270811:
					ExternalAssets = (RefArray<DataContainer>) p_Value;
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
				case 231223453:
					return Scale;

				case 1938270811:
					return ExternalAssets;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 231223453:
					return typeof(HavokAsset).GetProperty(nameof(Scale));

				case 1938270811:
					return typeof(HavokAsset).GetProperty(nameof(ExternalAssets));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
