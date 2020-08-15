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
	public class TerrainQuadDecalAtlasTileTemplateData : 
		Asset
	{
		protected TerrainQuadDecalAtlasTile m_AtlasTile = new TerrainQuadDecalAtlasTile();
		[ContainerField(12), ContainerFieldNameHash(3027817338)]
		public TerrainQuadDecalAtlasTile AtlasTile { get { return m_AtlasTile; } set { if (OnPropertyChanging("TerrainQuadDecalAtlasTileTemplateData." + nameof(AtlasTile), this, m_AtlasTile, value)) m_AtlasTile = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3027817338:
					AtlasTile = (TerrainQuadDecalAtlasTile) p_Value;
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
				case 3027817338:
					return AtlasTile;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3027817338:
					return typeof(TerrainQuadDecalAtlasTileTemplateData).GetProperty(nameof(AtlasTile));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
