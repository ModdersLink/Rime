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
	public class DecalSettings : 
		SystemSettings
	{
		protected uint m_StaticBufferMaxVertexCount = new uint();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(2343369026)]
		public uint StaticBufferMaxVertexCount { get { return m_StaticBufferMaxVertexCount; } set { if (OnPropertyChanging("DecalSettings." + nameof(StaticBufferMaxVertexCount), this, m_StaticBufferMaxVertexCount, value)) m_StaticBufferMaxVertexCount = value; } } // 0xC (12)
		
		protected uint m_RingBufferMaxVertexCount = new uint();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(3904589288)]
		public uint RingBufferMaxVertexCount { get { return m_RingBufferMaxVertexCount; } set { if (OnPropertyChanging("DecalSettings." + nameof(RingBufferMaxVertexCount), this, m_RingBufferMaxVertexCount, value)) m_RingBufferMaxVertexCount = value; } } // 0x10 (16)
		
		protected bool m_DrawEnable = new bool();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(1347356004)]
		public bool DrawEnable { get { return m_DrawEnable; } set { if (OnPropertyChanging("DecalSettings." + nameof(DrawEnable), this, m_DrawEnable, value)) m_DrawEnable = value; } } // 0x14 (20)
		
		protected bool m_SystemEnable2 = new bool();
		[ContainerField(21), LayoutImmutable, Blittable, ContainerFieldNameHash(360785139)]
		public bool SystemEnable2 { get { return m_SystemEnable2; } set { if (OnPropertyChanging("DecalSettings." + nameof(SystemEnable2), this, m_SystemEnable2, value)) m_SystemEnable2 = value; } } // 0x15 (21)
		
		protected bool m_SystemEnable = new bool();
		[ContainerField(22), LayoutImmutable, Blittable, ContainerFieldNameHash(3785298081)]
		public bool SystemEnable { get { return m_SystemEnable; } set { if (OnPropertyChanging("DecalSettings." + nameof(SystemEnable), this, m_SystemEnable, value)) m_SystemEnable = value; } } // 0x16 (22)
		
		protected bool m_Enable = new bool();
		[ContainerField(23), LayoutImmutable, Blittable, ContainerFieldNameHash(2342790116)]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("DecalSettings." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x17 (23)
		
		protected bool m_DebugMemUsageEnable = new bool();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(284136405)]
		public bool DebugMemUsageEnable { get { return m_DebugMemUsageEnable; } set { if (OnPropertyChanging("DecalSettings." + nameof(DebugMemUsageEnable), this, m_DebugMemUsageEnable, value)) m_DebugMemUsageEnable = value; } } // 0x18 (24)
		
		protected bool m_DebugWarningsEnable = new bool();
		[ContainerField(25), LayoutImmutable, Blittable, ContainerFieldNameHash(3949276556)]
		public bool DebugWarningsEnable { get { return m_DebugWarningsEnable; } set { if (OnPropertyChanging("DecalSettings." + nameof(DebugWarningsEnable), this, m_DebugWarningsEnable, value)) m_DebugWarningsEnable = value; } } // 0x19 (25)
		
		protected bool m_NvidiaStreamOutputWorkaroundEnable = new bool();
		[ContainerField(26), LayoutImmutable, Blittable, ContainerFieldNameHash(2641376344)]
		public bool NvidiaStreamOutputWorkaroundEnable { get { return m_NvidiaStreamOutputWorkaroundEnable; } set { if (OnPropertyChanging("DecalSettings." + nameof(NvidiaStreamOutputWorkaroundEnable), this, m_NvidiaStreamOutputWorkaroundEnable, value)) m_NvidiaStreamOutputWorkaroundEnable = value; } } // 0x1A (26)
		
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
