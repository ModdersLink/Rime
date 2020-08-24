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
	public class ColorUnlockPartData : 
		DataContainer
	{
		protected CtrRef<ColorReference> m_ColorReference = new CtrRef<ColorReference>();
		[ContainerField(8), MemberInfoFlag(53), ContainerFieldNameHash(16575987), ContainerCtrRef]
		public CtrRef<ColorReference> ColorReference { get { return m_ColorReference; } set { if (OnPropertyChanging("ColorUnlockPartData." + nameof(ColorReference), this, m_ColorReference, value)) m_ColorReference = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 16575987:
					ColorReference = (CtrRef<ColorReference>) p_Value;
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
				case 16575987:
					return ColorReference;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 16575987:
					return typeof(ColorUnlockPartData).GetProperty(nameof(ColorReference));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
