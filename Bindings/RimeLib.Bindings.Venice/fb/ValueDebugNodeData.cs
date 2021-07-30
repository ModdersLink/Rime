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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 12)]
	public class ValueDebugNodeData : 
		AudioGraphNodeData
	{
		protected RefArray<DebugValueInput> m_Values = new RefArray<DebugValueInput>();
		[ContainerField(Name: "Values", Offset: 8, NameHash: 3142410589, Flags: 65)]
		public RefArray<DebugValueInput> Values { get { return m_Values; } set { if (OnPropertyChanging("ValueDebugNodeData." + nameof(Values), this, m_Values, value)) m_Values = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3142410589:
					Values = (RefArray<DebugValueInput>) p_Value;
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
				case 3142410589:
					return Values;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3142410589:
					return typeof(ValueDebugNodeData).GetProperty(nameof(Values));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
