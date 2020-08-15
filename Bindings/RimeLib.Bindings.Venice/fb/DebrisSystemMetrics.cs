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
	public class DebrisSystemMetrics : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public int HavokParticleCount { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public int HavokParticlePartCount { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3946001929:
					HavokParticleCount = (int) p_Value;
					break;

				case 580687198:
					HavokParticlePartCount = (int) p_Value;
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
				case 3946001929:
					return HavokParticleCount;

				case 580687198:
					return HavokParticlePartCount;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3946001929:
					return typeof(DebrisSystemMetrics).GetProperty(nameof(HavokParticleCount));

				case 580687198:
					return typeof(DebrisSystemMetrics).GetProperty(nameof(HavokParticlePartCount));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
