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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 64)]
	public class LocalForceData : 
		ProcessorData
	{
		protected Vec3 m_LocalForce = new Vec3();
		[ContainerField(Name: "LocalForce", Offset: 48, NameHash: 4022902837, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 LocalForce { get { return m_LocalForce; } set { if (OnPropertyChanging("LocalForceData." + nameof(LocalForce), this, m_LocalForce, value)) m_LocalForce = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4022902837:
					LocalForce = (Vec3) p_Value;
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
				case 4022902837:
					return LocalForce;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4022902837:
					return typeof(LocalForceData).GetProperty(nameof(LocalForce));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
