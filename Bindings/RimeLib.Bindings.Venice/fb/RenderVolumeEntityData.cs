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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 128)]
	public class RenderVolumeEntityData : 
		SpatialEntityData
	{
		protected Vec4 m_UserMasks = new Vec4();
		[ContainerField(Name: "UserMasks", Offset: 80, NameHash: 1589111411, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 UserMasks { get { return m_UserMasks; } set { if (OnPropertyChanging("RenderVolumeEntityData." + nameof(UserMasks), this, m_UserMasks, value)) m_UserMasks = value; } } // 0x50 (80)
		
		protected SurfaceShaderInstanceDataStruct m_Shader = new SurfaceShaderInstanceDataStruct();
		[ContainerField(Name: "Shader", Offset: 96, NameHash: 3352909900, Flags: 41)]
		public SurfaceShaderInstanceDataStruct Shader { get { return m_Shader; } set { if (OnPropertyChanging("RenderVolumeEntityData." + nameof(Shader), this, m_Shader, value)) m_Shader = value; } } // 0x60 (96)
		
		protected RenderVolumeTransformType m_TransformType = new RenderVolumeTransformType();
		[ContainerField(Name: "TransformType", Offset: 116, NameHash: 3623123985, Flags: 137)]
		public RenderVolumeTransformType TransformType { get { return m_TransformType; } set { if (OnPropertyChanging("RenderVolumeEntityData." + nameof(TransformType), this, m_TransformType, value)) m_TransformType = value; } } // 0x74 (116)
		
		protected bool m_Enabled = new bool();
		[ContainerField(Name: "Enabled", Offset: 120, NameHash: 2662400, Flags: 49325), LayoutImmutable, Blittable]
		public bool Enabled { get { return m_Enabled; } set { if (OnPropertyChanging("RenderVolumeEntityData." + nameof(Enabled), this, m_Enabled, value)) m_Enabled = value; } } // 0x78 (120)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1589111411:
					UserMasks = (Vec4) p_Value;
					break;

				case 3352909900:
					Shader = (SurfaceShaderInstanceDataStruct) p_Value;
					break;

				case 3623123985:
					TransformType = (RenderVolumeTransformType) Enum.ToObject(typeof(RenderVolumeTransformType), p_Value);
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
				case 1589111411:
					return UserMasks;

				case 3352909900:
					return Shader;

				case 3623123985:
					return TransformType;

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
				case 1589111411:
					return typeof(RenderVolumeEntityData).GetProperty(nameof(UserMasks));

				case 3352909900:
					return typeof(RenderVolumeEntityData).GetProperty(nameof(Shader));

				case 3623123985:
					return typeof(RenderVolumeEntityData).GetProperty(nameof(TransformType));

				case 2662400:
					return typeof(RenderVolumeEntityData).GetProperty(nameof(Enabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
