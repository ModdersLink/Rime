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
	public class EdgeModelLightMapData : 
		DataContainer
	{
		protected List<Vec4> m_LightMapUvs = new List<Vec4>();
		[ContainerField(8), MemberInfoFlag(65), ContainerFieldNameHash(397898871), ContainerArray]
		public List<Vec4> LightMapUvs { get { return m_LightMapUvs; } set { if (OnPropertyChanging("EdgeModelLightMapData." + nameof(LightMapUvs), this, m_LightMapUvs, value)) m_LightMapUvs = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 397898871:
					LightMapUvs = (List<Vec4>) p_Value;
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
				case 397898871:
					return LightMapUvs;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 397898871:
					return typeof(EdgeModelLightMapData).GetProperty(nameof(LightMapUvs));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
