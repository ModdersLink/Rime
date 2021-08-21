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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 48)]
	public class PackagingRule : 
		Asset
	{
		protected Vec3 m_DebugColor = new Vec3();
		[ContainerField(Name: "DebugColor", Offset: 16, NameHash: 2612071465, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 DebugColor { get { return m_DebugColor; } set { if (OnPropertyChanging("PackagingRule." + nameof(DebugColor), this, m_DebugColor, value)) m_DebugColor = value; } } // 0x10 (16)
		
		protected bool m_CanTargetSelf = new bool();
		[ContainerField(Name: "CanTargetSelf", Offset: 32, NameHash: 3198168004, Flags: 49325), LayoutImmutable, Blittable]
		public bool CanTargetSelf { get { return m_CanTargetSelf; } set { if (OnPropertyChanging("PackagingRule." + nameof(CanTargetSelf), this, m_CanTargetSelf, value)) m_CanTargetSelf = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2612071465:
					DebugColor = (Vec3) p_Value;
					break;

				case 3198168004:
					CanTargetSelf = (bool) p_Value;
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
				case 2612071465:
					return DebugColor;

				case 3198168004:
					return CanTargetSelf;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2612071465:
					return typeof(PackagingRule).GetProperty(nameof(DebugColor));

				case 3198168004:
					return typeof(PackagingRule).GetProperty(nameof(CanTargetSelf));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
