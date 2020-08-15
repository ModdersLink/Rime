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
	public class SoldierSpawnAppearanceTemplateData : 
		Asset
	{
		protected uint m_Body = new uint();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(2088812853)]
		public uint Body { get { return m_Body; } set { if (OnPropertyChanging("SoldierSpawnAppearanceTemplateData." + nameof(Body), this, m_Body, value)) m_Body = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088812853:
					Body = (uint) p_Value;
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
				case 2088812853:
					return Body;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088812853:
					return typeof(SoldierSpawnAppearanceTemplateData).GetProperty(nameof(Body));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
