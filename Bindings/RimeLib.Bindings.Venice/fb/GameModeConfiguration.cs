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
	public class GameModeConfiguration : 
		Asset
	{
		protected List<GameModeInformation> m_Information = new List<GameModeInformation>();
		[ContainerField(Name: "Information", Offset: 12, NameHash: 2207688585, Flags: 65)]
		public List<GameModeInformation> Information { get { return m_Information; } set { if (OnPropertyChanging("GameModeConfiguration." + nameof(Information), this, m_Information, value)) m_Information = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2207688585:
					Information = (List<GameModeInformation>) p_Value;
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
				case 2207688585:
					return Information;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2207688585:
					return typeof(GameModeConfiguration).GetProperty(nameof(Information));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
