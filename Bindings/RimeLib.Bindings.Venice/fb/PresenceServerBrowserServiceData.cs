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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 48)]
	public class PresenceServerBrowserServiceData : 
		PresenceServiceData
	{
		protected MatchmakingCriteria m_FilterCriterias = new MatchmakingCriteria();
		[ContainerField(Name: "FilterCriterias", Offset: 12, NameHash: 4095044485, Flags: 41)]
		public MatchmakingCriteria FilterCriterias { get { return m_FilterCriterias; } set { if (OnPropertyChanging("PresenceServerBrowserServiceData." + nameof(FilterCriterias), this, m_FilterCriterias, value)) m_FilterCriterias = value; } } // 0xC (12)
		
		protected uint m_ListCapacity = new uint();
		[ContainerField(Name: "ListCapacity", Offset: 44, NameHash: 2930314355, Flags: 49421), LayoutImmutable, Blittable]
		public uint ListCapacity { get { return m_ListCapacity; } set { if (OnPropertyChanging("PresenceServerBrowserServiceData." + nameof(ListCapacity), this, m_ListCapacity, value)) m_ListCapacity = value; } } // 0x2C (44)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4095044485:
					FilterCriterias = (MatchmakingCriteria) p_Value;
					break;

				case 2930314355:
					ListCapacity = (uint) p_Value;
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
				case 4095044485:
					return FilterCriterias;

				case 2930314355:
					return ListCapacity;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4095044485:
					return typeof(PresenceServerBrowserServiceData).GetProperty(nameof(FilterCriterias));

				case 2930314355:
					return typeof(PresenceServerBrowserServiceData).GetProperty(nameof(ListCapacity));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
