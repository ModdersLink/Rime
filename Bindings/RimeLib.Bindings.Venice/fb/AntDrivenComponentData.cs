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
	[ContainerType(16)]
	public class AntDrivenComponentData : 
		ComponentData
	{
		protected AnimationDrivenBinding m_CharacterGameState = new AnimationDrivenBinding();
		[ContainerField(96), ContainerFieldNameHash(1998069317)]
		public AnimationDrivenBinding CharacterGameState { get { return m_CharacterGameState; } set { if (OnPropertyChanging("AntDrivenComponentData." + nameof(CharacterGameState), this, m_CharacterGameState, value)) m_CharacterGameState = value; } } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1998069317:
					CharacterGameState = (AnimationDrivenBinding) p_Value;
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
				case 1998069317:
					return CharacterGameState;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1998069317:
					return typeof(AntDrivenComponentData).GetProperty(nameof(CharacterGameState));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
