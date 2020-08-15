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
	public class UnlockableTextureSliceCollection : 
		DataContainer
	{
		protected int m_DefaultValue = new int();
		[ContainerField(8), LayoutImmutable, Blittable, ContainerFieldNameHash(2066049125)]
		public int DefaultValue { get { return m_DefaultValue; } set { if (OnPropertyChanging("UnlockableTextureSliceCollection." + nameof(DefaultValue), this, m_DefaultValue, value)) m_DefaultValue = value; } } // 0x8 (8)
		
		protected RefArray<TextureSliceUnlockPartData> m_PossibleValues = new RefArray<TextureSliceUnlockPartData>();
		[ContainerField(12), ContainerFieldNameHash(349877344)]
		public RefArray<TextureSliceUnlockPartData> PossibleValues { get { return m_PossibleValues; } set { if (OnPropertyChanging("UnlockableTextureSliceCollection." + nameof(PossibleValues), this, m_PossibleValues, value)) m_PossibleValues = value; } } // 0xC (12)
		
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
