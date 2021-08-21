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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class DebugTextEntityData : 
		SpatialEntityData
	{
		protected Vec3 m_TextColor = new Vec3();
		[ContainerField(Name: "TextColor", Offset: 80, NameHash: 2527550245, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 TextColor { get { return m_TextColor; } set { if (OnPropertyChanging("DebugTextEntityData." + nameof(TextColor), this, m_TextColor, value)) m_TextColor = value; } } // 0x50 (80)
		
		protected string m_DebugText = string.Empty;
		[ContainerField(Name: "DebugText", Offset: 96, NameHash: 859165769, Flags: 16509), LayoutImmutable]
		public string DebugText { get { return m_DebugText; } set { if (OnPropertyChanging("DebugTextEntityData." + nameof(DebugText), this, m_DebugText, value)) m_DebugText = value; } } // 0x60 (96)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 100, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("DebugTextEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x64 (100)
		
		protected float m_Scale = new float();
		[ContainerField(Name: "Scale", Offset: 104, NameHash: 231223453, Flags: 49469), LayoutImmutable, Blittable]
		public float Scale { get { return m_Scale; } set { if (OnPropertyChanging("DebugTextEntityData." + nameof(Scale), this, m_Scale, value)) m_Scale = value; } } // 0x68 (104)
		
		protected bool m_Visible = new bool();
		[ContainerField(Name: "Visible", Offset: 108, NameHash: 901540267, Flags: 49325), LayoutImmutable, Blittable]
		public bool Visible { get { return m_Visible; } set { if (OnPropertyChanging("DebugTextEntityData." + nameof(Visible), this, m_Visible, value)) m_Visible = value; } } // 0x6C (108)
		
		protected bool m_Centered = new bool();
		[ContainerField(Name: "Centered", Offset: 109, NameHash: 2363373967, Flags: 49325), LayoutImmutable, Blittable]
		public bool Centered { get { return m_Centered; } set { if (OnPropertyChanging("DebugTextEntityData." + nameof(Centered), this, m_Centered, value)) m_Centered = value; } } // 0x6D (109)
		
		protected bool m_DepthTest = new bool();
		[ContainerField(Name: "DepthTest", Offset: 110, NameHash: 969307550, Flags: 49325), LayoutImmutable, Blittable]
		public bool DepthTest { get { return m_DepthTest; } set { if (OnPropertyChanging("DebugTextEntityData." + nameof(DepthTest), this, m_DepthTest, value)) m_DepthTest = value; } } // 0x6E (110)
		
		protected bool m_ScaleWithDistance = new bool();
		[ContainerField(Name: "ScaleWithDistance", Offset: 111, NameHash: 646053404, Flags: 49325), LayoutImmutable, Blittable]
		public bool ScaleWithDistance { get { return m_ScaleWithDistance; } set { if (OnPropertyChanging("DebugTextEntityData." + nameof(ScaleWithDistance), this, m_ScaleWithDistance, value)) m_ScaleWithDistance = value; } } // 0x6F (111)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2527550245:
					TextColor = (Vec3) p_Value;
					break;

				case 859165769:
					DebugText = (string) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 231223453:
					Scale = (float) p_Value;
					break;

				case 901540267:
					Visible = (bool) p_Value;
					break;

				case 2363373967:
					Centered = (bool) p_Value;
					break;

				case 969307550:
					DepthTest = (bool) p_Value;
					break;

				case 646053404:
					ScaleWithDistance = (bool) p_Value;
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

				case 859165769:
					return DebugText;

				case 229961746:
					return Realm;

				case 231223453:
					return Scale;

				case 901540267:
					return Visible;

				case 2363373967:
					return Centered;

				case 969307550:
					return DepthTest;

				case 646053404:
					return ScaleWithDistance;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2527550245:
					return typeof(DebugTextEntityData).GetProperty(nameof(TextColor));

				case 859165769:
					return typeof(DebugTextEntityData).GetProperty(nameof(DebugText));

				case 229961746:
					return typeof(DebugTextEntityData).GetProperty(nameof(Realm));

				case 231223453:
					return typeof(DebugTextEntityData).GetProperty(nameof(Scale));

				case 901540267:
					return typeof(DebugTextEntityData).GetProperty(nameof(Visible));

				case 2363373967:
					return typeof(DebugTextEntityData).GetProperty(nameof(Centered));

				case 969307550:
					return typeof(DebugTextEntityData).GetProperty(nameof(DepthTest));

				case 646053404:
					return typeof(DebugTextEntityData).GetProperty(nameof(ScaleWithDistance));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
