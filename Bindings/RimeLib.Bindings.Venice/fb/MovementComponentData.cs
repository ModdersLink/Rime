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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class MovementComponentData : 
		ComponentData
	{
		protected MovementComponentBinding m_MovementBinding = new MovementComponentBinding();
		[ContainerField(Name: "MovementBinding", Offset: 96, NameHash: 3329760007, Flags: 41)]
		public MovementComponentBinding MovementBinding { get { return m_MovementBinding; } set { if (OnPropertyChanging("MovementComponentData." + nameof(MovementBinding), this, m_MovementBinding, value)) m_MovementBinding = value; } } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3329760007:
					MovementBinding = (MovementComponentBinding) p_Value;
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
				case 3329760007:
					return MovementBinding;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3329760007:
					return typeof(MovementComponentData).GetProperty(nameof(MovementBinding));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
