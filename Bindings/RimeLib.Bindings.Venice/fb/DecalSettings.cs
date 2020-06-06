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
	public class DecalSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint StaticBufferMaxVertexCount { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint RingBufferMaxVertexCount { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool DrawEnable { get; set; } // 0x14 (20)
		
		[ContainerField(21), LayoutImmutable, Blittable]
		public bool SystemEnable2 { get; set; } // 0x15 (21)
		
		[ContainerField(22), LayoutImmutable, Blittable]
		public bool SystemEnable { get; set; } // 0x16 (22)
		
		[ContainerField(23), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x17 (23)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public bool DebugMemUsageEnable { get; set; } // 0x18 (24)
		
		[ContainerField(25), LayoutImmutable, Blittable]
		public bool DebugWarningsEnable { get; set; } // 0x19 (25)
		
		[ContainerField(26), LayoutImmutable, Blittable]
		public bool NvidiaStreamOutputWorkaroundEnable { get; set; } // 0x1A (26)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2343369026:
					StaticBufferMaxVertexCount = (uint) p_Value;
					break;

				case 3904589288:
					RingBufferMaxVertexCount = (uint) p_Value;
					break;

				case 1347356004:
					DrawEnable = (bool) p_Value;
					break;

				case 360785139:
					SystemEnable2 = (bool) p_Value;
					break;

				case 3785298081:
					SystemEnable = (bool) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
					break;

				case 284136405:
					DebugMemUsageEnable = (bool) p_Value;
					break;

				case 3949276556:
					DebugWarningsEnable = (bool) p_Value;
					break;

				case 2641376344:
					NvidiaStreamOutputWorkaroundEnable = (bool) p_Value;
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
				case 2343369026:
					return StaticBufferMaxVertexCount;

				case 3904589288:
					return RingBufferMaxVertexCount;

				case 1347356004:
					return DrawEnable;

				case 360785139:
					return SystemEnable2;

				case 3785298081:
					return SystemEnable;

				case 2342790116:
					return Enable;

				case 284136405:
					return DebugMemUsageEnable;

				case 3949276556:
					return DebugWarningsEnable;

				case 2641376344:
					return NvidiaStreamOutputWorkaroundEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2343369026:
					return typeof(DecalSettings).GetProperty(nameof(StaticBufferMaxVertexCount));

				case 3904589288:
					return typeof(DecalSettings).GetProperty(nameof(RingBufferMaxVertexCount));

				case 1347356004:
					return typeof(DecalSettings).GetProperty(nameof(DrawEnable));

				case 360785139:
					return typeof(DecalSettings).GetProperty(nameof(SystemEnable2));

				case 3785298081:
					return typeof(DecalSettings).GetProperty(nameof(SystemEnable));

				case 2342790116:
					return typeof(DecalSettings).GetProperty(nameof(Enable));

				case 284136405:
					return typeof(DecalSettings).GetProperty(nameof(DebugMemUsageEnable));

				case 3949276556:
					return typeof(DecalSettings).GetProperty(nameof(DebugWarningsEnable));

				case 2641376344:
					return typeof(DecalSettings).GetProperty(nameof(NvidiaStreamOutputWorkaroundEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
