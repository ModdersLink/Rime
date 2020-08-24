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
	public class UnlockableColorCollection : 
		DataContainer
	{
		protected CtrRef<ColorReference> m_DefaultValue = new CtrRef<ColorReference>();
		[ContainerField(8), MemberInfoFlag(53), ContainerFieldNameHash(2066049125), ContainerCtrRef]
		public CtrRef<ColorReference> DefaultValue { get { return m_DefaultValue; } set { if (OnPropertyChanging("UnlockableColorCollection." + nameof(DefaultValue), this, m_DefaultValue, value)) m_DefaultValue = value; } } // 0x8 (8)
		
		protected RefArray<ColorUnlockPartData> m_PossibleValues = new RefArray<ColorUnlockPartData>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(349877344), ContainerRefArray]
		public RefArray<ColorUnlockPartData> PossibleValues { get { return m_PossibleValues; } set { if (OnPropertyChanging("UnlockableColorCollection." + nameof(PossibleValues), this, m_PossibleValues, value)) m_PossibleValues = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2066049125:
					DefaultValue = (CtrRef<ColorReference>) p_Value;
					break;

				case 349877344:
					PossibleValues = (RefArray<ColorUnlockPartData>) p_Value;
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
					return typeof(UnlockableColorCollection).GetProperty(nameof(DefaultValue));

				case 349877344:
					return typeof(UnlockableColorCollection).GetProperty(nameof(PossibleValues));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
