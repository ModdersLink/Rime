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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class LevelReportingAsset : 
		Asset
	{
		protected RefArray<LevelDescriptionAsset> m_BuiltLevels = new RefArray<LevelDescriptionAsset>();
		[ContainerField(Name: "BuiltLevels", Offset: 12, NameHash: 3293235878, Flags: 65)]
		public RefArray<LevelDescriptionAsset> BuiltLevels { get { return m_BuiltLevels; } set { if (OnPropertyChanging("LevelReportingAsset." + nameof(BuiltLevels), this, m_BuiltLevels, value)) m_BuiltLevels = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3293235878:
					BuiltLevels = (RefArray<LevelDescriptionAsset>) p_Value;
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
				case 3293235878:
					return BuiltLevels;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3293235878:
					return typeof(LevelReportingAsset).GetProperty(nameof(BuiltLevels));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
