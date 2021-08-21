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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 144)]
	public class ScreenEffectComponentData : 
		ComponentData
	{
		protected Vec4 m_ScreenEffectParams = new Vec4();
		[ContainerField(Name: "ScreenEffectParams", Offset: 96, NameHash: 2179275266, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 ScreenEffectParams { get { return m_ScreenEffectParams; } set { if (OnPropertyChanging("ScreenEffectComponentData." + nameof(ScreenEffectParams), this, m_ScreenEffectParams, value)) m_ScreenEffectParams = value; } } // 0x60 (96)
		
		protected ScreenEffectFrameType m_FrameType = new ScreenEffectFrameType();
		[ContainerField(Name: "FrameType", Offset: 112, NameHash: 21868832, Flags: 137)]
		public ScreenEffectFrameType FrameType { get { return m_FrameType; } set { if (OnPropertyChanging("ScreenEffectComponentData." + nameof(FrameType), this, m_FrameType, value)) m_FrameType = value; } } // 0x70 (112)
		
		protected CtrRef<SurfaceShaderBaseAsset> m_Shader = new CtrRef<SurfaceShaderBaseAsset>();
		[ContainerField(Name: "Shader", Offset: 116, NameHash: 3352909900, Flags: 53)]
		public CtrRef<SurfaceShaderBaseAsset> Shader { get { return m_Shader; } set { if (OnPropertyChanging("ScreenEffectComponentData." + nameof(Shader), this, m_Shader, value)) m_Shader = value; } } // 0x74 (116)
		
		protected float m_FrameWidth = new float();
		[ContainerField(Name: "FrameWidth", Offset: 120, NameHash: 727037822, Flags: 49469), LayoutImmutable, Blittable]
		public float FrameWidth { get { return m_FrameWidth; } set { if (OnPropertyChanging("ScreenEffectComponentData." + nameof(FrameWidth), this, m_FrameWidth, value)) m_FrameWidth = value; } } // 0x78 (120)
		
		protected float m_OuterFrameOpacity = new float();
		[ContainerField(Name: "OuterFrameOpacity", Offset: 124, NameHash: 2645729368, Flags: 49469), LayoutImmutable, Blittable]
		public float OuterFrameOpacity { get { return m_OuterFrameOpacity; } set { if (OnPropertyChanging("ScreenEffectComponentData." + nameof(OuterFrameOpacity), this, m_OuterFrameOpacity, value)) m_OuterFrameOpacity = value; } } // 0x7C (124)
		
		protected float m_InnerFrameOpacity = new float();
		[ContainerField(Name: "InnerFrameOpacity", Offset: 128, NameHash: 2573293567, Flags: 49469), LayoutImmutable, Blittable]
		public float InnerFrameOpacity { get { return m_InnerFrameOpacity; } set { if (OnPropertyChanging("ScreenEffectComponentData." + nameof(InnerFrameOpacity), this, m_InnerFrameOpacity, value)) m_InnerFrameOpacity = value; } } // 0x80 (128)
		
		protected float m_Angle = new float();
		[ContainerField(Name: "Angle", Offset: 132, NameHash: 205597860, Flags: 49469), LayoutImmutable, Blittable]
		public float Angle { get { return m_Angle; } set { if (OnPropertyChanging("ScreenEffectComponentData." + nameof(Angle), this, m_Angle, value)) m_Angle = value; } } // 0x84 (132)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 136, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("ScreenEffectComponentData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x88 (136)
		
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
