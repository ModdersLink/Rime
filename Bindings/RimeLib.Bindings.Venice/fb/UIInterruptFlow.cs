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
	public class UIInterruptFlow : 
		Asset
	{
		protected List<InterruptFlow> m_interruptFlow = new List<InterruptFlow>();
		[ContainerField(12), ContainerFieldNameHash(3294905584)]
		public List<InterruptFlow> interruptFlow { get { return m_interruptFlow; } set { if (OnPropertyChanging("UIInterruptFlow." + nameof(interruptFlow), this, m_interruptFlow, value)) m_interruptFlow = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3294905584:
					interruptFlow = (List<InterruptFlow>) p_Value;
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
				case 3294905584:
					return interruptFlow;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3294905584:
					return typeof(UIInterruptFlow).GetProperty(nameof(interruptFlow));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
