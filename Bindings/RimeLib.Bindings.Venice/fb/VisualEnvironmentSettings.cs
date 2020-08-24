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
	public class VisualEnvironmentSettings : 
		DataContainer
	{
		protected float m_SunRotationX = new float();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2283294049)]
		public float SunRotationX { get { return m_SunRotationX; } set { if (OnPropertyChanging("VisualEnvironmentSettings." + nameof(SunRotationX), this, m_SunRotationX, value)) m_SunRotationX = value; } } // 0x8 (8)
		
		protected float m_SunRotationY = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2283294048)]
		public float SunRotationY { get { return m_SunRotationY; } set { if (OnPropertyChanging("VisualEnvironmentSettings." + nameof(SunRotationY), this, m_SunRotationY, value)) m_SunRotationY = value; } } // 0xC (12)
		
		protected bool m_DrawStats = new bool();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2413142628)]
		public bool DrawStats { get { return m_DrawStats; } set { if (OnPropertyChanging("VisualEnvironmentSettings." + nameof(DrawStats), this, m_DrawStats, value)) m_DrawStats = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2283294049:
					SunRotationX = (float) p_Value;
					break;

				case 2283294048:
					SunRotationY = (float) p_Value;
					break;

				case 2413142628:
					DrawStats = (bool) p_Value;
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
				case 2283294049:
					return SunRotationX;

				case 2283294048:
					return SunRotationY;

				case 2413142628:
					return DrawStats;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2283294049:
					return typeof(VisualEnvironmentSettings).GetProperty(nameof(SunRotationX));

				case 2283294048:
					return typeof(VisualEnvironmentSettings).GetProperty(nameof(SunRotationY));

				case 2413142628:
					return typeof(VisualEnvironmentSettings).GetProperty(nameof(DrawStats));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
