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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(28), ContainerClass]
	public class ShaderColorUnlockPartCollection : 
		ShaderCustomizationUnlockPartCollection
	{
		protected CtrRef<ColorReference> m_DefaultColorReference = new CtrRef<ColorReference>();
		[ContainerField(20), MemberInfoFlag(53), ContainerFieldNameHash(1493675992), ContainerCtrRef]
		public CtrRef<ColorReference> DefaultColorReference { get { return m_DefaultColorReference; } set { if (OnPropertyChanging("ShaderColorUnlockPartCollection." + nameof(DefaultColorReference), this, m_DefaultColorReference, value)) m_DefaultColorReference = value; } } // 0x14 (20)
		
		protected RefArray<ColorUnlockPartData> m_UnlockParts = new RefArray<ColorUnlockPartData>();
		[ContainerField(24), MemberInfoFlag(65), ContainerFieldNameHash(4116003953), ContainerRefArray]
		public RefArray<ColorUnlockPartData> UnlockParts { get { return m_UnlockParts; } set { if (OnPropertyChanging("ShaderColorUnlockPartCollection." + nameof(UnlockParts), this, m_UnlockParts, value)) m_UnlockParts = value; } } // 0x18 (24)
		
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
