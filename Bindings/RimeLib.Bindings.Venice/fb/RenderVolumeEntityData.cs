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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class RenderVolumeEntityData : 
		SpatialEntityData
	{
		protected Vec4 m_UserMasks = new Vec4();
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(1589111411)]
		public Vec4 UserMasks { get { return m_UserMasks; } set { if (OnPropertyChanging("RenderVolumeEntityData." + nameof(UserMasks), this, m_UserMasks, value)) m_UserMasks = value; } } // 0x50 (80)
		
		protected SurfaceShaderInstanceDataStruct m_Shader = new SurfaceShaderInstanceDataStruct();
		[ContainerField(96), MemberInfoFlag(41), ContainerFieldNameHash(3352909900)]
		public SurfaceShaderInstanceDataStruct Shader { get { return m_Shader; } set { if (OnPropertyChanging("RenderVolumeEntityData." + nameof(Shader), this, m_Shader, value)) m_Shader = value; } } // 0x60 (96)
		
		protected RenderVolumeTransformType m_TransformType = new RenderVolumeTransformType();
		[ContainerField(116), MemberInfoFlag(137), ContainerFieldNameHash(3623123985)]
		public RenderVolumeTransformType TransformType { get { return m_TransformType; } set { if (OnPropertyChanging("RenderVolumeEntityData." + nameof(TransformType), this, m_TransformType, value)) m_TransformType = value; } } // 0x74 (116)
		
		protected bool m_Enabled = new bool();
		[ContainerField(120), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2662400)]
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
