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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(40), ContainerClass]
	public class WindowSettings : 
		SystemSettings
	{
		protected int m_PosX = new int();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2089458993)]
		public int PosX { get { return m_PosX; } set { if (OnPropertyChanging("WindowSettings." + nameof(PosX), this, m_PosX, value)) m_PosX = value; } } // 0xC (12)
		
		protected int m_PosY = new int();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2089458992)]
		public int PosY { get { return m_PosY; } set { if (OnPropertyChanging("WindowSettings." + nameof(PosY), this, m_PosY, value)) m_PosY = value; } } // 0x10 (16)
		
		protected uint m_Width = new uint();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(226981187)]
		public uint Width { get { return m_Width; } set { if (OnPropertyChanging("WindowSettings." + nameof(Width), this, m_Width, value)) m_Width = value; } } // 0x14 (20)
		
		protected uint m_Height = new uint();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3054065626)]
		public uint Height { get { return m_Height; } set { if (OnPropertyChanging("WindowSettings." + nameof(Height), this, m_Height, value)) m_Height = value; } } // 0x18 (24)
		
		protected bool m_BordersEnable = new bool();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1633866683)]
		public bool BordersEnable { get { return m_BordersEnable; } set { if (OnPropertyChanging("WindowSettings." + nameof(BordersEnable), this, m_BordersEnable, value)) m_BordersEnable = value; } } // 0x1C (28)
		
		protected bool m_AutoSize = new bool();
		[ContainerField(29), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3538087823)]
		public bool AutoSize { get { return m_AutoSize; } set { if (OnPropertyChanging("WindowSettings." + nameof(AutoSize), this, m_AutoSize, value)) m_AutoSize = value; } } // 0x1D (29)
		
		protected bool m_FullscreenAutoSize = new bool();
		[ContainerField(30), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3126319920)]
		public bool FullscreenAutoSize { get { return m_FullscreenAutoSize; } set { if (OnPropertyChanging("WindowSettings." + nameof(FullscreenAutoSize), this, m_FullscreenAutoSize, value)) m_FullscreenAutoSize = value; } } // 0x1E (30)
		
		protected bool m_FullscreenWhenJoiningServer = new bool();
		[ContainerField(31), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4162898953)]
		public bool FullscreenWhenJoiningServer { get { return m_FullscreenWhenJoiningServer; } set { if (OnPropertyChanging("WindowSettings." + nameof(FullscreenWhenJoiningServer), this, m_FullscreenWhenJoiningServer, value)) m_FullscreenWhenJoiningServer = value; } } // 0x1F (31)
		
		protected bool m_EnableEscape = new bool();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3728915013)]
		public bool EnableEscape { get { return m_EnableEscape; } set { if (OnPropertyChanging("WindowSettings." + nameof(EnableEscape), this, m_EnableEscape, value)) m_EnableEscape = value; } } // 0x20 (32)
		
		protected bool m_EnableInputOnActivate = new bool();
		[ContainerField(33), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3421649674)]
		public bool EnableInputOnActivate { get { return m_EnableInputOnActivate; } set { if (OnPropertyChanging("WindowSettings." + nameof(EnableInputOnActivate), this, m_EnableInputOnActivate, value)) m_EnableInputOnActivate = value; } } // 0x21 (33)
		
		protected bool m_HibernateOnClose = new bool();
		[ContainerField(34), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3110056536)]
		public bool HibernateOnClose { get { return m_HibernateOnClose; } set { if (OnPropertyChanging("WindowSettings." + nameof(HibernateOnClose), this, m_HibernateOnClose, value)) m_HibernateOnClose = value; } } // 0x22 (34)
		
		protected bool m_Hidden = new bool();
		[ContainerField(35), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3049491663)]
		public bool Hidden { get { return m_Hidden; } set { if (OnPropertyChanging("WindowSettings." + nameof(Hidden), this, m_Hidden, value)) m_Hidden = value; } } // 0x23 (35)
		
		protected bool m_Minimized = new bool();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1910180473)]
		public bool Minimized { get { return m_Minimized; } set { if (OnPropertyChanging("WindowSettings." + nameof(Minimized), this, m_Minimized, value)) m_Minimized = value; } } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2089458993:
					PosX = (int) p_Value;
					break;

				case 2089458992:
					PosY = (int) p_Value;
					break;

				case 226981187:
					Width = (uint) p_Value;
					break;

				case 3054065626:
					Height = (uint) p_Value;
					break;

				case 1633866683:
					BordersEnable = (bool) p_Value;
					break;

				case 3538087823:
					AutoSize = (bool) p_Value;
					break;

				case 3126319920:
					FullscreenAutoSize = (bool) p_Value;
					break;

				case 4162898953:
					FullscreenWhenJoiningServer = (bool) p_Value;
					break;

				case 3728915013:
					EnableEscape = (bool) p_Value;
					break;

				case 3421649674:
					EnableInputOnActivate = (bool) p_Value;
					break;

				case 3110056536:
					HibernateOnClose = (bool) p_Value;
					break;

				case 3049491663:
					Hidden = (bool) p_Value;
					break;

				case 1910180473:
					Minimized = (bool) p_Value;
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
				case 2089458993:
					return PosX;

				case 2089458992:
					return PosY;

				case 226981187:
					return Width;

				case 3054065626:
					return Height;

				case 1633866683:
					return BordersEnable;

				case 3538087823:
					return AutoSize;

				case 3126319920:
					return FullscreenAutoSize;

				case 4162898953:
					return FullscreenWhenJoiningServer;

				case 3728915013:
					return EnableEscape;

				case 3421649674:
					return EnableInputOnActivate;

				case 3110056536:
					return HibernateOnClose;

				case 3049491663:
					return Hidden;

				case 1910180473:
					return Minimized;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2089458993:
					return typeof(WindowSettings).GetProperty(nameof(PosX));

				case 2089458992:
					return typeof(WindowSettings).GetProperty(nameof(PosY));

				case 226981187:
					return typeof(WindowSettings).GetProperty(nameof(Width));

				case 3054065626:
					return typeof(WindowSettings).GetProperty(nameof(Height));

				case 1633866683:
					return typeof(WindowSettings).GetProperty(nameof(BordersEnable));

				case 3538087823:
					return typeof(WindowSettings).GetProperty(nameof(AutoSize));

				case 3126319920:
					return typeof(WindowSettings).GetProperty(nameof(FullscreenAutoSize));

				case 4162898953:
					return typeof(WindowSettings).GetProperty(nameof(FullscreenWhenJoiningServer));

				case 3728915013:
					return typeof(WindowSettings).GetProperty(nameof(EnableEscape));

				case 3421649674:
					return typeof(WindowSettings).GetProperty(nameof(EnableInputOnActivate));

				case 3110056536:
					return typeof(WindowSettings).GetProperty(nameof(HibernateOnClose));

				case 3049491663:
					return typeof(WindowSettings).GetProperty(nameof(Hidden));

				case 1910180473:
					return typeof(WindowSettings).GetProperty(nameof(Minimized));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
