///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class DebugTextEntityData : 
		SpatialEntityData
	{
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 TextColor { get; set; } = new Vec3(); // 0x50 (80)
		
		[ContainerField(96), LayoutImmutable]
		public string DebugText { get; set; } // 0x60 (96)
		
		[ContainerField(100)]
		public Realm Realm { get; set; } = new Realm(); // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float Scale { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public bool Visible { get; set; } // 0x6C (108)
		
		[ContainerField(109), LayoutImmutable, Blittable]
		public bool Centered { get; set; } // 0x6D (109)
		
		[ContainerField(110), LayoutImmutable, Blittable]
		public bool DepthTest { get; set; } // 0x6E (110)
		
		[ContainerField(111), LayoutImmutable, Blittable]
		public bool ScaleWithDistance { get; set; } // 0x6F (111)
		
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
