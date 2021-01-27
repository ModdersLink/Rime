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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 144)]
	public class DofComponentData : 
		ComponentData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 96, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("DofComponentData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x60 (96)
		
		protected float m_NearDistanceScale = new float();
		[ContainerField(Name: "NearDistanceScale", Offset: 100, NameHash: 4096748582, Flags: 49469), LayoutImmutable, Blittable]
		public float NearDistanceScale { get { return m_NearDistanceScale; } set { if (OnPropertyChanging("DofComponentData." + nameof(NearDistanceScale), this, m_NearDistanceScale, value)) m_NearDistanceScale = value; } } // 0x64 (100)
		
		protected float m_FocusDistance = new float();
		[ContainerField(Name: "FocusDistance", Offset: 104, NameHash: 1402926186, Flags: 49469), LayoutImmutable, Blittable]
		public float FocusDistance { get { return m_FocusDistance; } set { if (OnPropertyChanging("DofComponentData." + nameof(FocusDistance), this, m_FocusDistance, value)) m_FocusDistance = value; } } // 0x68 (104)
		
		protected BlurFilter m_BlurFilter = new BlurFilter();
		[ContainerField(Name: "BlurFilter", Offset: 108, NameHash: 1032953036, Flags: 137)]
		public BlurFilter BlurFilter { get { return m_BlurFilter; } set { if (OnPropertyChanging("DofComponentData." + nameof(BlurFilter), this, m_BlurFilter, value)) m_BlurFilter = value; } } // 0x6C (108)
		
		protected float m_BlurFilterDeviation = new float();
		[ContainerField(Name: "BlurFilterDeviation", Offset: 112, NameHash: 2875622063, Flags: 49469), LayoutImmutable, Blittable]
		public float BlurFilterDeviation { get { return m_BlurFilterDeviation; } set { if (OnPropertyChanging("DofComponentData." + nameof(BlurFilterDeviation), this, m_BlurFilterDeviation, value)) m_BlurFilterDeviation = value; } } // 0x70 (112)
		
		protected float m_FarDistanceScale = new float();
		[ContainerField(Name: "FarDistanceScale", Offset: 116, NameHash: 4048208907, Flags: 49469), LayoutImmutable, Blittable]
		public float FarDistanceScale { get { return m_FarDistanceScale; } set { if (OnPropertyChanging("DofComponentData." + nameof(FarDistanceScale), this, m_FarDistanceScale, value)) m_FarDistanceScale = value; } } // 0x74 (116)
		
		protected float m_BlurAdd = new float();
		[ContainerField(Name: "BlurAdd", Offset: 120, NameHash: 2736421901, Flags: 49469), LayoutImmutable, Blittable]
		public float BlurAdd { get { return m_BlurAdd; } set { if (OnPropertyChanging("DofComponentData." + nameof(BlurAdd), this, m_BlurAdd, value)) m_BlurAdd = value; } } // 0x78 (120)
		
		protected float m_Scale = new float();
		[ContainerField(Name: "Scale", Offset: 124, NameHash: 231223453, Flags: 49469), LayoutImmutable, Blittable]
		public float Scale { get { return m_Scale; } set { if (OnPropertyChanging("DofComponentData." + nameof(Scale), this, m_Scale, value)) m_Scale = value; } } // 0x7C (124)
		
		protected float m_DiffusionDofFocalLength = new float();
		[ContainerField(Name: "DiffusionDofFocalLength", Offset: 128, NameHash: 2682742320, Flags: 49469), LayoutImmutable, Blittable]
		public float DiffusionDofFocalLength { get { return m_DiffusionDofFocalLength; } set { if (OnPropertyChanging("DofComponentData." + nameof(DiffusionDofFocalLength), this, m_DiffusionDofFocalLength, value)) m_DiffusionDofFocalLength = value; } } // 0x80 (128)
		
		protected float m_DiffusionDofAperture = new float();
		[ContainerField(Name: "DiffusionDofAperture", Offset: 132, NameHash: 530293403, Flags: 49469), LayoutImmutable, Blittable]
		public float DiffusionDofAperture { get { return m_DiffusionDofAperture; } set { if (OnPropertyChanging("DofComponentData." + nameof(DiffusionDofAperture), this, m_DiffusionDofAperture, value)) m_DiffusionDofAperture = value; } } // 0x84 (132)
		
		protected bool m_DiffusionDofEnable = new bool();
		[ContainerField(Name: "DiffusionDofEnable", Offset: 136, NameHash: 830589130, Flags: 49325), LayoutImmutable, Blittable]
		public bool DiffusionDofEnable { get { return m_DiffusionDofEnable; } set { if (OnPropertyChanging("DofComponentData." + nameof(DiffusionDofEnable), this, m_DiffusionDofEnable, value)) m_DiffusionDofEnable = value; } } // 0x88 (136)
		
		protected bool m_Enable = new bool();
		[ContainerField(Name: "Enable", Offset: 137, NameHash: 2342790116, Flags: 49325), LayoutImmutable, Blittable]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("DofComponentData." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x89 (137)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 4096748582:
					NearDistanceScale = (float) p_Value;
					break;

				case 1402926186:
					FocusDistance = (float) p_Value;
					break;

				case 1032953036:
					BlurFilter = (BlurFilter) Enum.ToObject(typeof(BlurFilter), p_Value);
					break;

				case 2875622063:
					BlurFilterDeviation = (float) p_Value;
					break;

				case 4048208907:
					FarDistanceScale = (float) p_Value;
					break;

				case 2736421901:
					BlurAdd = (float) p_Value;
					break;

				case 231223453:
					Scale = (float) p_Value;
					break;

				case 2682742320:
					DiffusionDofFocalLength = (float) p_Value;
					break;

				case 530293403:
					DiffusionDofAperture = (float) p_Value;
					break;

				case 830589130:
					DiffusionDofEnable = (bool) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
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
				case 229961746:
					return Realm;

				case 4096748582:
					return NearDistanceScale;

				case 1402926186:
					return FocusDistance;

				case 1032953036:
					return BlurFilter;

				case 2875622063:
					return BlurFilterDeviation;

				case 4048208907:
					return FarDistanceScale;

				case 2736421901:
					return BlurAdd;

				case 231223453:
					return Scale;

				case 2682742320:
					return DiffusionDofFocalLength;

				case 530293403:
					return DiffusionDofAperture;

				case 830589130:
					return DiffusionDofEnable;

				case 2342790116:
					return Enable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(DofComponentData).GetProperty(nameof(Realm));

				case 4096748582:
					return typeof(DofComponentData).GetProperty(nameof(NearDistanceScale));

				case 1402926186:
					return typeof(DofComponentData).GetProperty(nameof(FocusDistance));

				case 1032953036:
					return typeof(DofComponentData).GetProperty(nameof(BlurFilter));

				case 2875622063:
					return typeof(DofComponentData).GetProperty(nameof(BlurFilterDeviation));

				case 4048208907:
					return typeof(DofComponentData).GetProperty(nameof(FarDistanceScale));

				case 2736421901:
					return typeof(DofComponentData).GetProperty(nameof(BlurAdd));

				case 231223453:
					return typeof(DofComponentData).GetProperty(nameof(Scale));

				case 2682742320:
					return typeof(DofComponentData).GetProperty(nameof(DiffusionDofFocalLength));

				case 530293403:
					return typeof(DofComponentData).GetProperty(nameof(DiffusionDofAperture));

				case 830589130:
					return typeof(DofComponentData).GetProperty(nameof(DiffusionDofEnable));

				case 2342790116:
					return typeof(DofComponentData).GetProperty(nameof(Enable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
