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
	public class UnlockableTextureSliceCollection : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public int DefaultValue { get; set; } // 0x8 (8)
		
		[ContainerField(12)]
		public RefArray<TextureSliceUnlockPartData> PossibleValues { get; set; } = new RefArray<TextureSliceUnlockPartData>(); // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2066049125:
					DefaultValue = (int) p_Value;
					break;

				case 349877344:
					PossibleValues = (RefArray<TextureSliceUnlockPartData>) p_Value;
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
				case 2066049125:
					return DefaultValue;

				case 349877344:
					return PossibleValues;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2066049125:
					return typeof(UnlockableTextureSliceCollection).GetProperty(nameof(DefaultValue));

				case 349877344:
					return typeof(UnlockableTextureSliceCollection).GetProperty(nameof(PossibleValues));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
