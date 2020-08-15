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
	[ContainerType(4)]
	public class SkinnedSocketObjectData : 
		SocketObjectData
	{
		protected int m_FaceposerLibraryIndex = new int();
		[ContainerField(72), LayoutImmutable, Blittable, ContainerFieldNameHash(1714120990)]
		public int FaceposerLibraryIndex { get { return m_FaceposerLibraryIndex; } set { if (OnPropertyChanging("SkinnedSocketObjectData." + nameof(FaceposerLibraryIndex), this, m_FaceposerLibraryIndex, value)) m_FaceposerLibraryIndex = value; } } // 0x48 (72)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1714120990:
					FaceposerLibraryIndex = (int) p_Value;
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
				case 1714120990:
					return FaceposerLibraryIndex;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1714120990:
					return typeof(SkinnedSocketObjectData).GetProperty(nameof(FaceposerLibraryIndex));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
