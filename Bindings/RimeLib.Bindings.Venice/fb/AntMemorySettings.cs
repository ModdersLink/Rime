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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class AntMemorySettings : 
		DataContainer
	{
		protected int m_RTPoolLayersControllers = new int();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2134937184)]
		public int RTPoolLayersControllers { get { return m_RTPoolLayersControllers; } set { if (OnPropertyChanging("AntMemorySettings." + nameof(RTPoolLayersControllers), this, m_RTPoolLayersControllers, value)) m_RTPoolLayersControllers = value; } } // 0x8 (8)
		
		protected int m_RTPoolStateflowControllers = new int();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(399895253)]
		public int RTPoolStateflowControllers { get { return m_RTPoolStateflowControllers; } set { if (OnPropertyChanging("AntMemorySettings." + nameof(RTPoolStateflowControllers), this, m_RTPoolStateflowControllers, value)) m_RTPoolStateflowControllers = value; } } // 0xC (12)
		
		protected int m_RTPoolStateflowNodeControllers = new int();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3245671861)]
		public int RTPoolStateflowNodeControllers { get { return m_RTPoolStateflowNodeControllers; } set { if (OnPropertyChanging("AntMemorySettings." + nameof(RTPoolStateflowNodeControllers), this, m_RTPoolStateflowNodeControllers, value)) m_RTPoolStateflowNodeControllers = value; } } // 0x10 (16)
		
		protected int m_RTPoolTransitionControllers = new int();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(509962655)]
		public int RTPoolTransitionControllers { get { return m_RTPoolTransitionControllers; } set { if (OnPropertyChanging("AntMemorySettings." + nameof(RTPoolTransitionControllers), this, m_RTPoolTransitionControllers, value)) m_RTPoolTransitionControllers = value; } } // 0x14 (20)
		
		protected int m_RTPoolClipControllers = new int();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2397424326)]
		public int RTPoolClipControllers { get { return m_RTPoolClipControllers; } set { if (OnPropertyChanging("AntMemorySettings." + nameof(RTPoolClipControllers), this, m_RTPoolClipControllers, value)) m_RTPoolClipControllers = value; } } // 0x18 (24)
		
		protected int m_RTPoolChooserControllers = new int();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2848570943)]
		public int RTPoolChooserControllers { get { return m_RTPoolChooserControllers; } set { if (OnPropertyChanging("AntMemorySettings." + nameof(RTPoolChooserControllers), this, m_RTPoolChooserControllers, value)) m_RTPoolChooserControllers = value; } } // 0x1C (28)
		
		protected int m_RTPoolLoopingControllers = new int();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(392141612)]
		public int RTPoolLoopingControllers { get { return m_RTPoolLoopingControllers; } set { if (OnPropertyChanging("AntMemorySettings." + nameof(RTPoolLoopingControllers), this, m_RTPoolLoopingControllers, value)) m_RTPoolLoopingControllers = value; } } // 0x20 (32)
		
		protected int m_RTPoolTransparentControllers = new int();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3696829270)]
		public int RTPoolTransparentControllers { get { return m_RTPoolTransparentControllers; } set { if (OnPropertyChanging("AntMemorySettings." + nameof(RTPoolTransparentControllers), this, m_RTPoolTransparentControllers, value)) m_RTPoolTransparentControllers = value; } } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2134937184:
					RTPoolLayersControllers = (int) p_Value;
					break;

				case 399895253:
					RTPoolStateflowControllers = (int) p_Value;
					break;

				case 3245671861:
					RTPoolStateflowNodeControllers = (int) p_Value;
					break;

				case 509962655:
					RTPoolTransitionControllers = (int) p_Value;
					break;

				case 2397424326:
					RTPoolClipControllers = (int) p_Value;
					break;

				case 2848570943:
					RTPoolChooserControllers = (int) p_Value;
					break;

				case 392141612:
					RTPoolLoopingControllers = (int) p_Value;
					break;

				case 3696829270:
					RTPoolTransparentControllers = (int) p_Value;
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
				case 2134937184:
					return RTPoolLayersControllers;

				case 399895253:
					return RTPoolStateflowControllers;

				case 3245671861:
					return RTPoolStateflowNodeControllers;

				case 509962655:
					return RTPoolTransitionControllers;

				case 2397424326:
					return RTPoolClipControllers;

				case 2848570943:
					return RTPoolChooserControllers;

				case 392141612:
					return RTPoolLoopingControllers;

				case 3696829270:
					return RTPoolTransparentControllers;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2134937184:
					return typeof(AntMemorySettings).GetProperty(nameof(RTPoolLayersControllers));

				case 399895253:
					return typeof(AntMemorySettings).GetProperty(nameof(RTPoolStateflowControllers));

				case 3245671861:
					return typeof(AntMemorySettings).GetProperty(nameof(RTPoolStateflowNodeControllers));

				case 509962655:
					return typeof(AntMemorySettings).GetProperty(nameof(RTPoolTransitionControllers));

				case 2397424326:
					return typeof(AntMemorySettings).GetProperty(nameof(RTPoolClipControllers));

				case 2848570943:
					return typeof(AntMemorySettings).GetProperty(nameof(RTPoolChooserControllers));

				case 392141612:
					return typeof(AntMemorySettings).GetProperty(nameof(RTPoolLoopingControllers));

				case 3696829270:
					return typeof(AntMemorySettings).GetProperty(nameof(RTPoolTransparentControllers));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
