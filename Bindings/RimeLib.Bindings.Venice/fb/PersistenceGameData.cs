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
	public class PersistenceGameData : 
		Asset
	{
		protected RefArray<Asset> m_Assets = new RefArray<Asset>();
		[ContainerField(Name: "Assets", Offset: 12, NameHash: 2502242534, Flags: 65)]
		public RefArray<Asset> Assets { get { return m_Assets; } set { if (OnPropertyChanging("PersistenceGameData." + nameof(Assets), this, m_Assets, value)) m_Assets = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2502242534:
					Assets = (RefArray<Asset>) p_Value;
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
				case 2502242534:
					return Assets;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2502242534:
					return typeof(PersistenceGameData).GetProperty(nameof(Assets));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
