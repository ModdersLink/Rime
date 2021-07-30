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
	public class SoundPrimeEntityData : 
		EntityData
	{
		protected RefArray<SoundDataAsset> m_DataAssets = new RefArray<SoundDataAsset>();
		[ContainerField(Name: "DataAssets", Offset: 12, NameHash: 4187781142, Flags: 65)]
		public RefArray<SoundDataAsset> DataAssets { get { return m_DataAssets; } set { if (OnPropertyChanging("SoundPrimeEntityData." + nameof(DataAssets), this, m_DataAssets, value)) m_DataAssets = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4187781142:
					DataAssets = (RefArray<SoundDataAsset>) p_Value;
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
				case 4187781142:
					return DataAssets;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4187781142:
					return typeof(SoundPrimeEntityData).GetProperty(nameof(DataAssets));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
