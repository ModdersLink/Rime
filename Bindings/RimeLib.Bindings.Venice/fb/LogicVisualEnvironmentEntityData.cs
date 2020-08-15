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
	public class LogicVisualEnvironmentEntityData : 
		EntityData
	{
		protected CtrRef<VisualEnvironmentBlueprint> m_VisualEnvironment = new CtrRef<VisualEnvironmentBlueprint>();
		[ContainerField(12), ContainerFieldNameHash(1724714788)]
		public CtrRef<VisualEnvironmentBlueprint> VisualEnvironment { get { return m_VisualEnvironment; } set { if (OnPropertyChanging("LogicVisualEnvironmentEntityData." + nameof(VisualEnvironment), this, m_VisualEnvironment, value)) m_VisualEnvironment = value; } } // 0xC (12)
		
		protected float m_Visibility = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(1708270083)]
		public float Visibility { get { return m_Visibility; } set { if (OnPropertyChanging("LogicVisualEnvironmentEntityData." + nameof(Visibility), this, m_Visibility, value)) m_Visibility = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1724714788:
					VisualEnvironment = (CtrRef<VisualEnvironmentBlueprint>) p_Value;
					break;

				case 1708270083:
					Visibility = (float) p_Value;
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
				case 1724714788:
					return VisualEnvironment;

				case 1708270083:
					return Visibility;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1724714788:
					return typeof(LogicVisualEnvironmentEntityData).GetProperty(nameof(VisualEnvironment));

				case 1708270083:
					return typeof(LogicVisualEnvironmentEntityData).GetProperty(nameof(Visibility));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
