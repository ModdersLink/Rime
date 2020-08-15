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
	[ContainerType(16)]
	public class DestructionMaskVolumeEntityData : 
		GameEntityData
	{
		protected Vec4 m_DustAccumulationCurve = new Vec4();
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2881902809)]
		public Vec4 DustAccumulationCurve { get { return m_DustAccumulationCurve; } set { if (OnPropertyChanging("DestructionMaskVolumeEntityData." + nameof(DustAccumulationCurve), this, m_DustAccumulationCurve, value)) m_DustAccumulationCurve = value; } } // 0x60 (96)
		
		protected Vec4 m_ShaderUserMasks = new Vec4();
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(739662234)]
		public Vec4 ShaderUserMasks { get { return m_ShaderUserMasks; } set { if (OnPropertyChanging("DestructionMaskVolumeEntityData." + nameof(ShaderUserMasks), this, m_ShaderUserMasks, value)) m_ShaderUserMasks = value; } } // 0x70 (112)
		
		protected float m_DustAccumulationLifeTime = new float();
		[ContainerField(128), LayoutImmutable, Blittable, ContainerFieldNameHash(3645148381)]
		public float DustAccumulationLifeTime { get { return m_DustAccumulationLifeTime; } set { if (OnPropertyChanging("DestructionMaskVolumeEntityData." + nameof(DustAccumulationLifeTime), this, m_DustAccumulationLifeTime, value)) m_DustAccumulationLifeTime = value; } } // 0x80 (128)
		
		protected SurfaceShaderInstanceDataStruct m_Shader = new SurfaceShaderInstanceDataStruct();
		[ContainerField(132), ContainerFieldNameHash(3352909900)]
		public SurfaceShaderInstanceDataStruct Shader { get { return m_Shader; } set { if (OnPropertyChanging("DestructionMaskVolumeEntityData." + nameof(Shader), this, m_Shader, value)) m_Shader = value; } } // 0x84 (132)
		
		protected float m_Radius = new float();
		[ContainerField(152), LayoutImmutable, Blittable, ContainerFieldNameHash(3298407133)]
		public float Radius { get { return m_Radius; } set { if (OnPropertyChanging("DestructionMaskVolumeEntityData." + nameof(Radius), this, m_Radius, value)) m_Radius = value; } } // 0x98 (152)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2881902809:
					DustAccumulationCurve = (Vec4) p_Value;
					break;

				case 739662234:
					ShaderUserMasks = (Vec4) p_Value;
					break;

				case 3645148381:
					DustAccumulationLifeTime = (float) p_Value;
					break;

				case 3352909900:
					Shader = (SurfaceShaderInstanceDataStruct) p_Value;
					break;

				case 3298407133:
					Radius = (float) p_Value;
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
				case 2881902809:
					return DustAccumulationCurve;

				case 739662234:
					return ShaderUserMasks;

				case 3645148381:
					return DustAccumulationLifeTime;

				case 3352909900:
					return Shader;

				case 3298407133:
					return Radius;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2881902809:
					return typeof(DestructionMaskVolumeEntityData).GetProperty(nameof(DustAccumulationCurve));

				case 739662234:
					return typeof(DestructionMaskVolumeEntityData).GetProperty(nameof(ShaderUserMasks));

				case 3645148381:
					return typeof(DestructionMaskVolumeEntityData).GetProperty(nameof(DustAccumulationLifeTime));

				case 3352909900:
					return typeof(DestructionMaskVolumeEntityData).GetProperty(nameof(Shader));

				case 3298407133:
					return typeof(DestructionMaskVolumeEntityData).GetProperty(nameof(Radius));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
