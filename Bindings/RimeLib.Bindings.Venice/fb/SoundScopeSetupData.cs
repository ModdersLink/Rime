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
	public class SoundScopeSetupData : 
		DataContainer
	{
		protected string m_Name = new string();
		[ContainerField(8), LayoutImmutable, ContainerFieldNameHash(2088949890)]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("SoundScopeSetupData." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x8 (8)
		
		protected List<SoundScopeStrategyMapping> m_Mappings = new List<SoundScopeStrategyMapping>();
		[ContainerField(12), ContainerFieldNameHash(673881690)]
		public List<SoundScopeStrategyMapping> Mappings { get { return m_Mappings; } set { if (OnPropertyChanging("SoundScopeSetupData." + nameof(Mappings), this, m_Mappings, value)) m_Mappings = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 673881690:
					Mappings = (List<SoundScopeStrategyMapping>) p_Value;
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
				case 2088949890:
					return Name;

				case 673881690:
					return Mappings;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(SoundScopeSetupData).GetProperty(nameof(Name));

				case 673881690:
					return typeof(SoundScopeSetupData).GetProperty(nameof(Mappings));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
