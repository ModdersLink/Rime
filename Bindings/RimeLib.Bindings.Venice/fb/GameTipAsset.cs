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
	public class GameTipAsset : 
		Asset
	{
		protected List<GameTipData> m_Tips = new List<GameTipData>();
		[ContainerField(12), ContainerFieldNameHash(2089313403)]
		public List<GameTipData> Tips { get { return m_Tips; } set { if (OnPropertyChanging("GameTipAsset." + nameof(Tips), this, m_Tips, value)) m_Tips = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2089313403:
					Tips = (List<GameTipData>) p_Value;
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
				case 2089313403:
					return Tips;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2089313403:
					return typeof(GameTipAsset).GetProperty(nameof(Tips));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
