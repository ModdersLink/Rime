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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 64)]
	public class UpdateAlphaLevelMinData : 
		ProcessorData
	{
		protected float m_MinLevel = new float();
		[ContainerField(Name: "MinLevel", Offset: 48, NameHash: 3341324025, Flags: 49469), LayoutImmutable, Blittable]
		public float MinLevel { get { return m_MinLevel; } set { if (OnPropertyChanging("UpdateAlphaLevelMinData." + nameof(MinLevel), this, m_MinLevel, value)) m_MinLevel = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3341324025:
					MinLevel = (float) p_Value;
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
				case 3341324025:
					return MinLevel;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3341324025:
					return typeof(UpdateAlphaLevelMinData).GetProperty(nameof(MinLevel));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
