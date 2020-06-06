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
	public class ShaderColorUnlockPartCollection : 
		ShaderCustomizationUnlockPartCollection
	{
		[ContainerField(20)]
		public CtrRef<ColorReference> DefaultColorReference { get; set; } = new CtrRef<ColorReference>(); // 0x14 (20)
		
		[ContainerField(24)]
		public RefArray<ColorUnlockPartData> UnlockParts { get; set; } = new RefArray<ColorUnlockPartData>(); // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1493675992:
					DefaultColorReference = (CtrRef<ColorReference>) p_Value;
					break;

				case 4116003953:
					UnlockParts = (RefArray<ColorUnlockPartData>) p_Value;
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
				case 1493675992:
					return DefaultColorReference;

				case 4116003953:
					return UnlockParts;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1493675992:
					return typeof(ShaderColorUnlockPartCollection).GetProperty(nameof(DefaultColorReference));

				case 4116003953:
					return typeof(ShaderColorUnlockPartCollection).GetProperty(nameof(UnlockParts));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
