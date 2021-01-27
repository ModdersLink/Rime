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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class AntInteractionData : 
		GameEntityData
	{
		protected AntInteractionBinding m_AntBindings = new AntInteractionBinding();
		[ContainerField(Name: "AntBindings", Offset: 96, NameHash: 2658793676, Flags: 41)]
		public AntInteractionBinding AntBindings { get { return m_AntBindings; } set { if (OnPropertyChanging("AntInteractionData." + nameof(AntBindings), this, m_AntBindings, value)) m_AntBindings = value; } } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2658793676:
					AntBindings = (AntInteractionBinding) p_Value;
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
				case 2658793676:
					return AntBindings;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2658793676:
					return typeof(AntInteractionData).GetProperty(nameof(AntBindings));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
