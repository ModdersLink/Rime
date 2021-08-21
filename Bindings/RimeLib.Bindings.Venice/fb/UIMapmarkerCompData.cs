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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 32)]
	public class UIMapmarkerCompData : 
		UIComponentData
	{
		protected List<int> m_ProximityIntervals = new List<int>();
		[ContainerField(Name: "ProximityIntervals", Offset: 28, NameHash: 2970219836, Flags: 65)]
		public List<int> ProximityIntervals { get { return m_ProximityIntervals; } set { if (OnPropertyChanging("UIMapmarkerCompData." + nameof(ProximityIntervals), this, m_ProximityIntervals, value)) m_ProximityIntervals = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2970219836:
					ProximityIntervals = (List<int>) p_Value;
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
				case 2970219836:
					return ProximityIntervals;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2970219836:
					return typeof(UIMapmarkerCompData).GetProperty(nameof(ProximityIntervals));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
