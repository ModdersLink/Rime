///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class HIKData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float ReachT { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float ReachR { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float Pull { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float Resist { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3293760940:
					ReachT = (float) p_Value;
					break;

				case 3293760938:
					ReachR = (float) p_Value;
					break;

				case 2089427552:
					Pull = (float) p_Value;
					break;

				case 3293260655:
					Resist = (float) p_Value;
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
				case 3293760940:
					return ReachT;

				case 3293760938:
					return ReachR;

				case 2089427552:
					return Pull;

				case 3293260655:
					return Resist;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3293760940:
					return typeof(HIKData).GetProperty(nameof(ReachT));

				case 3293760938:
					return typeof(HIKData).GetProperty(nameof(ReachR));

				case 2089427552:
					return typeof(HIKData).GetProperty(nameof(Pull));

				case 3293260655:
					return typeof(HIKData).GetProperty(nameof(Resist));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
