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
	public class ScreenEffectComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 ScreenEffectParams { get; set; } = new Vec4(); // 0x60 (96)
		
		[ContainerField(112)]
		public ScreenEffectFrameType FrameType { get; set; } = new ScreenEffectFrameType(); // 0x70 (112)
		
		[ContainerField(116)]
		public CtrRef<SurfaceShaderBaseAsset> Shader { get; set; } = new CtrRef<SurfaceShaderBaseAsset>(); // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float FrameWidth { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public float OuterFrameOpacity { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float InnerFrameOpacity { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float Angle { get; set; } // 0x84 (132)
		
		[ContainerField(136)]
		public Realm Realm { get; set; } = new Realm(); // 0x88 (136)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2179275266:
					ScreenEffectParams = (Vec4) p_Value;
					break;

				case 21868832:
					FrameType = (ScreenEffectFrameType) Enum.ToObject(typeof(ScreenEffectFrameType), p_Value);
					break;

				case 3352909900:
					Shader = (CtrRef<SurfaceShaderBaseAsset>) p_Value;
					break;

				case 727037822:
					FrameWidth = (float) p_Value;
					break;

				case 2645729368:
					OuterFrameOpacity = (float) p_Value;
					break;

				case 2573293567:
					InnerFrameOpacity = (float) p_Value;
					break;

				case 205597860:
					Angle = (float) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
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
				case 2179275266:
					return ScreenEffectParams;

				case 21868832:
					return FrameType;

				case 3352909900:
					return Shader;

				case 727037822:
					return FrameWidth;

				case 2645729368:
					return OuterFrameOpacity;

				case 2573293567:
					return InnerFrameOpacity;

				case 205597860:
					return Angle;

				case 229961746:
					return Realm;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2179275266:
					return typeof(ScreenEffectComponentData).GetProperty(nameof(ScreenEffectParams));

				case 21868832:
					return typeof(ScreenEffectComponentData).GetProperty(nameof(FrameType));

				case 3352909900:
					return typeof(ScreenEffectComponentData).GetProperty(nameof(Shader));

				case 727037822:
					return typeof(ScreenEffectComponentData).GetProperty(nameof(FrameWidth));

				case 2645729368:
					return typeof(ScreenEffectComponentData).GetProperty(nameof(OuterFrameOpacity));

				case 2573293567:
					return typeof(ScreenEffectComponentData).GetProperty(nameof(InnerFrameOpacity));

				case 205597860:
					return typeof(ScreenEffectComponentData).GetProperty(nameof(Angle));

				case 229961746:
					return typeof(ScreenEffectComponentData).GetProperty(nameof(Realm));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
