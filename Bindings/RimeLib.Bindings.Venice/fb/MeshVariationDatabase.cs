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
	public class MeshVariationDatabase : 
		Asset
	{
		[ContainerField(12)]
		public RefArray<MeshVariationDatabaseEntry> Entries { get; set; } = new RefArray<MeshVariationDatabaseEntry>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<MeshVariationDatabaseEntry> RedirectEntries { get; set; } = new RefArray<MeshVariationDatabaseEntry>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 8238103:
					Entries = (RefArray<MeshVariationDatabaseEntry>) p_Value;
					break;

				case 1590518733:
					RedirectEntries = (RefArray<MeshVariationDatabaseEntry>) p_Value;
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
				case 8238103:
					return Entries;

				case 1590518733:
					return RedirectEntries;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 8238103:
					return typeof(MeshVariationDatabase).GetProperty(nameof(Entries));

				case 1590518733:
					return typeof(MeshVariationDatabase).GetProperty(nameof(RedirectEntries));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
