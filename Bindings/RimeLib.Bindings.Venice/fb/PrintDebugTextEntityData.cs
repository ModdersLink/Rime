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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 48)]
	public class PrintDebugTextEntityData : 
		EntityData
	{
		protected Vec3 m_TextColor = new Vec3();
		[ContainerField(Name: "TextColor", Offset: 16, NameHash: 2527550245, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 TextColor { get { return m_TextColor; } set { if (OnPropertyChanging("PrintDebugTextEntityData." + nameof(TextColor), this, m_TextColor, value)) m_TextColor = value; } } // 0x10 (16)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 32, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("PrintDebugTextEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x20 (32)
		
		protected string m_Text = string.Empty;
		[ContainerField(Name: "Text", Offset: 36, NameHash: 2089309304, Flags: 16509), LayoutImmutable]
		public string Text { get { return m_Text; } set { if (OnPropertyChanging("PrintDebugTextEntityData." + nameof(Text), this, m_Text, value)) m_Text = value; } } // 0x24 (36)
		
		protected bool m_Enabled = new bool();
		[ContainerField(Name: "Enabled", Offset: 40, NameHash: 2662400, Flags: 49325), LayoutImmutable, Blittable]
		public bool Enabled { get { return m_Enabled; } set { if (OnPropertyChanging("PrintDebugTextEntityData." + nameof(Enabled), this, m_Enabled, value)) m_Enabled = value; } } // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2527550245:
					TextColor = (Vec3) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2089309304:
					Text = (string) p_Value;
					break;

				case 2662400:
					Enabled = (bool) p_Value;
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
				case 2527550245:
					return TextColor;

				case 229961746:
					return Realm;

				case 2089309304:
					return Text;

				case 2662400:
					return Enabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2527550245:
					return typeof(PrintDebugTextEntityData).GetProperty(nameof(TextColor));

				case 229961746:
					return typeof(PrintDebugTextEntityData).GetProperty(nameof(Realm));

				case 2089309304:
					return typeof(PrintDebugTextEntityData).GetProperty(nameof(Text));

				case 2662400:
					return typeof(PrintDebugTextEntityData).GetProperty(nameof(Enabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
