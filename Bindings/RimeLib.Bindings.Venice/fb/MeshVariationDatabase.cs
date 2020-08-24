///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class MeshVariationDatabase : 
		Asset
	{
		protected RefArray<MeshVariationDatabaseEntry> m_Entries = new RefArray<MeshVariationDatabaseEntry>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(8238103), ContainerRefArray]
		public RefArray<MeshVariationDatabaseEntry> Entries { get { return m_Entries; } set { if (OnPropertyChanging("MeshVariationDatabase." + nameof(Entries), this, m_Entries, value)) m_Entries = value; } } // 0xC (12)
		
		protected RefArray<MeshVariationDatabaseEntry> m_RedirectEntries = new RefArray<MeshVariationDatabaseEntry>();
		[ContainerField(16), MemberInfoFlag(65), ContainerFieldNameHash(1590518733), ContainerRefArray]
		public RefArray<MeshVariationDatabaseEntry> RedirectEntries { get { return m_RedirectEntries; } set { if (OnPropertyChanging("MeshVariationDatabase." + nameof(RedirectEntries), this, m_RedirectEntries, value)) m_RedirectEntries = value; } } // 0x10 (16)
		
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
