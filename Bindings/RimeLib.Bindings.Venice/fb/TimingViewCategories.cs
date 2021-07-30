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
	public class TimingViewCategories : 
		Asset
	{
		protected RefArray<TimingViewCategory> m_TimingCategories = new RefArray<TimingViewCategory>();
		[ContainerField(Name: "TimingCategories", Offset: 12, NameHash: 1114703811, Flags: 65)]
		public RefArray<TimingViewCategory> TimingCategories { get { return m_TimingCategories; } set { if (OnPropertyChanging("TimingViewCategories." + nameof(TimingCategories), this, m_TimingCategories, value)) m_TimingCategories = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1114703811:
					TimingCategories = (RefArray<TimingViewCategory>) p_Value;
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
				case 1114703811:
					return TimingCategories;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1114703811:
					return typeof(TimingViewCategories).GetProperty(nameof(TimingCategories));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
