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
	public class WindowSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public int PosX { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public int PosY { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint Width { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint Height { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public bool BordersEnable { get; set; } // 0x1C (28)
		
		[ContainerField(29), LayoutImmutable, Blittable]
		public bool AutoSize { get; set; } // 0x1D (29)
		
		[ContainerField(30), LayoutImmutable, Blittable]
		public bool FullscreenAutoSize { get; set; } // 0x1E (30)
		
		[ContainerField(31), LayoutImmutable, Blittable]
		public bool FullscreenWhenJoiningServer { get; set; } // 0x1F (31)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool EnableEscape { get; set; } // 0x20 (32)
		
		[ContainerField(33), LayoutImmutable, Blittable]
		public bool EnableInputOnActivate { get; set; } // 0x21 (33)
		
		[ContainerField(34), LayoutImmutable, Blittable]
		public bool HibernateOnClose { get; set; } // 0x22 (34)
		
		[ContainerField(35), LayoutImmutable, Blittable]
		public bool Hidden { get; set; } // 0x23 (35)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public bool Minimized { get; set; } // 0x24 (36)
		
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
