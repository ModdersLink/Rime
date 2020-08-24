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
	public class CustomizationTable : 
		DataContainer
	{
		protected RefArray<CustomizationUnlockParts> m_UnlockParts = new RefArray<CustomizationUnlockParts>();
		[ContainerField(8), MemberInfoFlag(65), ContainerFieldNameHash(4116003953), ContainerRefArray]
		public RefArray<CustomizationUnlockParts> UnlockParts { get { return m_UnlockParts; } set { if (OnPropertyChanging("CustomizationTable." + nameof(UnlockParts), this, m_UnlockParts, value)) m_UnlockParts = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4116003953:
					UnlockParts = (RefArray<CustomizationUnlockParts>) p_Value;
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
				case 4116003953:
					return typeof(CustomizationTable).GetProperty(nameof(UnlockParts));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
