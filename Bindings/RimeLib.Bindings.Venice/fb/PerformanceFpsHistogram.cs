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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(32), ContainerStruct]
	public class PerformanceFpsHistogram : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float Below5 { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float Below10 { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float Below15 { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float Below20 { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float Below25 { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float Below30 { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float Below60 { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float Above60 { get; set; } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2668044995:
					Below5 = (float) p_Value;
					break;

				case 2146139031:
					Below10 = (float) p_Value;
					break;

				case 2146139026:
					Below15 = (float) p_Value;
					break;

				case 2146138996:
					Below20 = (float) p_Value;
					break;

				case 2146138993:
					Below25 = (float) p_Value;
					break;

				case 2146138965:
					Below30 = (float) p_Value;
					break;

				case 2146138864:
					Below60 = (float) p_Value;
					break;

				case 402579644:
					Above60 = (float) p_Value;
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
				case 2668044995:
					return Below5;

				case 2146139031:
					return Below10;

				case 2146139026:
					return Below15;

				case 2146138996:
					return Below20;

				case 2146138993:
					return Below25;

				case 2146138965:
					return Below30;

				case 2146138864:
					return Below60;

				case 402579644:
					return Above60;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2668044995:
					return typeof(PerformanceFpsHistogram).GetProperty(nameof(Below5));

				case 2146139031:
					return typeof(PerformanceFpsHistogram).GetProperty(nameof(Below10));

				case 2146139026:
					return typeof(PerformanceFpsHistogram).GetProperty(nameof(Below15));

				case 2146138996:
					return typeof(PerformanceFpsHistogram).GetProperty(nameof(Below20));

				case 2146138993:
					return typeof(PerformanceFpsHistogram).GetProperty(nameof(Below25));

				case 2146138965:
					return typeof(PerformanceFpsHistogram).GetProperty(nameof(Below30));

				case 2146138864:
					return typeof(PerformanceFpsHistogram).GetProperty(nameof(Below60));

				case 402579644:
					return typeof(PerformanceFpsHistogram).GetProperty(nameof(Above60));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
