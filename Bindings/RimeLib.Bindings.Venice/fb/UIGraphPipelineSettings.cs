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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(12), ContainerClass]
	public class UIGraphPipelineSettings : 
		DataContainer
	{
		protected bool m_OneBundlePerGraph = new bool();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1787189790)]
		public bool OneBundlePerGraph { get { return m_OneBundlePerGraph; } set { if (OnPropertyChanging("UIGraphPipelineSettings." + nameof(OneBundlePerGraph), this, m_OneBundlePerGraph, value)) m_OneBundlePerGraph = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1787189790:
					OneBundlePerGraph = (bool) p_Value;
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
				case 1787189790:
					return OneBundlePerGraph;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1787189790:
					return typeof(UIGraphPipelineSettings).GetProperty(nameof(OneBundlePerGraph));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
