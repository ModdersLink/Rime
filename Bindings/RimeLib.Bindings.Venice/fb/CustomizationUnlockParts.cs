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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class CustomizationUnlockParts : 
		DataContainer
	{
		protected string m_UICategorySid = string.Empty;
		[ContainerField(Name: "UICategorySid", Offset: 8, NameHash: 795269975, Flags: 16509), LayoutImmutable]
		public string UICategorySid { get { return m_UICategorySid; } set { if (OnPropertyChanging("CustomizationUnlockParts." + nameof(UICategorySid), this, m_UICategorySid, value)) m_UICategorySid = value; } } // 0x8 (8)
		
		protected RefArray<UnlockAssetBase> m_SelectableUnlocks = new RefArray<UnlockAssetBase>();
		[ContainerField(Name: "SelectableUnlocks", Offset: 12, NameHash: 1920005412, Flags: 65)]
		public RefArray<UnlockAssetBase> SelectableUnlocks { get { return m_SelectableUnlocks; } set { if (OnPropertyChanging("CustomizationUnlockParts." + nameof(SelectableUnlocks), this, m_SelectableUnlocks, value)) m_SelectableUnlocks = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 795269975:
					UICategorySid = (string) p_Value;
					break;

				case 1920005412:
					SelectableUnlocks = (RefArray<UnlockAssetBase>) p_Value;
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
				case 795269975:
					return UICategorySid;

				case 1920005412:
					return SelectableUnlocks;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 795269975:
					return typeof(CustomizationUnlockParts).GetProperty(nameof(UICategorySid));

				case 1920005412:
					return typeof(CustomizationUnlockParts).GetProperty(nameof(SelectableUnlocks));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
