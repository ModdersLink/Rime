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
	public class UIActionData : 
		Asset
	{
		protected List<string> m_ActionKeys = new List<string>();
		[ContainerField(Name: "ActionKeys", Offset: 12, NameHash: 1114688479, Flags: 65)]
		public List<string> ActionKeys { get { return m_ActionKeys; } set { if (OnPropertyChanging("UIActionData." + nameof(ActionKeys), this, m_ActionKeys, value)) m_ActionKeys = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1114688479:
					ActionKeys = (List<string>) p_Value;
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
				case 1114688479:
					return ActionKeys;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1114688479:
					return typeof(UIActionData).GetProperty(nameof(ActionKeys));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
