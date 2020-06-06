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
	public class CreateRawFileParams : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string AssetName { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable]
		public string SourceFile { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool CreateResource { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3654276786:
					AssetName = (string) p_Value;
					break;

				case 1522844286:
					SourceFile = (string) p_Value;
					break;

				case 4248986347:
					CreateResource = (bool) p_Value;
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
				case 3654276786:
					return AssetName;

				case 1522844286:
					return SourceFile;

				case 4248986347:
					return CreateResource;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3654276786:
					return typeof(CreateRawFileParams).GetProperty(nameof(AssetName));

				case 1522844286:
					return typeof(CreateRawFileParams).GetProperty(nameof(SourceFile));

				case 4248986347:
					return typeof(CreateRawFileParams).GetProperty(nameof(CreateResource));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
