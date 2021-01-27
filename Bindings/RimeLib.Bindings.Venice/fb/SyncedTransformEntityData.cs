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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 96)]
	public class SyncedTransformEntityData : 
		EntityData
	{
		protected LinearTransform m_In = new LinearTransform();
		[ContainerField(Name: "In", Offset: 16, NameHash: 5862146, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform In { get { return m_In; } set { if (OnPropertyChanging("SyncedTransformEntityData." + nameof(In), this, m_In, value)) m_In = value; } } // 0x10 (16)
		
		protected bool m_Interpolate = new bool();
		[ContainerField(Name: "Interpolate", Offset: 80, NameHash: 2332438914, Flags: 49325), LayoutImmutable, Blittable]
		public bool Interpolate { get { return m_Interpolate; } set { if (OnPropertyChanging("SyncedTransformEntityData." + nameof(Interpolate), this, m_Interpolate, value)) m_Interpolate = value; } } // 0x50 (80)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (LinearTransform) p_Value;
					break;

				case 2332438914:
					Interpolate = (bool) p_Value;
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
				case 5862146:
					return In;

				case 2332438914:
					return Interpolate;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(SyncedTransformEntityData).GetProperty(nameof(In));

				case 2332438914:
					return typeof(SyncedTransformEntityData).GetProperty(nameof(Interpolate));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
