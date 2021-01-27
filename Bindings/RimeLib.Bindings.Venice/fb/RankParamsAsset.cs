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
	public class RankParamsAsset : 
		Asset
	{
		protected RefArray<RankLevelData> m_Ranks = new RefArray<RankLevelData>();
		[ContainerField(Name: "Ranks", Offset: 12, NameHash: 230112416, Flags: 65)]
		public RefArray<RankLevelData> Ranks { get { return m_Ranks; } set { if (OnPropertyChanging("RankParamsAsset." + nameof(Ranks), this, m_Ranks, value)) m_Ranks = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 230112416:
					Ranks = (RefArray<RankLevelData>) p_Value;
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
				case 230112416:
					return Ranks;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 230112416:
					return typeof(RankParamsAsset).GetProperty(nameof(Ranks));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
