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
	[ContainerType(4)]
	public class DebugRenderSettings : 
		DataContainer
	{
		protected float m_TextQueueTimeVisible = new float();
		[ContainerField(8), LayoutImmutable, Blittable, ContainerFieldNameHash(1402582002)]
		public float TextQueueTimeVisible { get { return m_TextQueueTimeVisible; } set { if (OnPropertyChanging("DebugRenderSettings." + nameof(TextQueueTimeVisible), this, m_TextQueueTimeVisible, value)) m_TextQueueTimeVisible = value; } } // 0x8 (8)
		
		protected uint m_Ps3SpuFrameBufferSize = new uint();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(2717954171)]
		public uint Ps3SpuFrameBufferSize { get { return m_Ps3SpuFrameBufferSize; } set { if (OnPropertyChanging("DebugRenderSettings." + nameof(Ps3SpuFrameBufferSize), this, m_Ps3SpuFrameBufferSize, value)) m_Ps3SpuFrameBufferSize = value; } } // 0xC (12)
		
		protected float m_TextViewDistance = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(853125686)]
		public float TextViewDistance { get { return m_TextViewDistance; } set { if (OnPropertyChanging("DebugRenderSettings." + nameof(TextViewDistance), this, m_TextViewDistance, value)) m_TextViewDistance = value; } } // 0x10 (16)
		
		protected uint m_TextQueueMaxLineCount = new uint();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(1799437200)]
		public uint TextQueueMaxLineCount { get { return m_TextQueueMaxLineCount; } set { if (OnPropertyChanging("DebugRenderSettings." + nameof(TextQueueMaxLineCount), this, m_TextQueueMaxLineCount, value)) m_TextQueueMaxLineCount = value; } } // 0x14 (20)
		
		protected uint m_DxMaxVertexCount = new uint();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(981947110)]
		public uint DxMaxVertexCount { get { return m_DxMaxVertexCount; } set { if (OnPropertyChanging("DebugRenderSettings." + nameof(DxMaxVertexCount), this, m_DxMaxVertexCount, value)) m_DxMaxVertexCount = value; } } // 0x18 (24)
		
		protected int m_ProcessJobCount = new int();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(3110006474)]
		public int ProcessJobCount { get { return m_ProcessJobCount; } set { if (OnPropertyChanging("DebugRenderSettings." + nameof(ProcessJobCount), this, m_ProcessJobCount, value)) m_ProcessJobCount = value; } } // 0x1C (28)
		
		protected bool m_DrawStatsEnable = new bool();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(711726149)]
		public bool DrawStatsEnable { get { return m_DrawStatsEnable; } set { if (OnPropertyChanging("DebugRenderSettings." + nameof(DrawStatsEnable), this, m_DrawStatsEnable, value)) m_DrawStatsEnable = value; } } // 0x20 (32)
		
		protected bool m_Ps3SpuEnable = new bool();
		[ContainerField(33), LayoutImmutable, Blittable, ContainerFieldNameHash(3244714114)]
		public bool Ps3SpuEnable { get { return m_Ps3SpuEnable; } set { if (OnPropertyChanging("DebugRenderSettings." + nameof(Ps3SpuEnable), this, m_Ps3SpuEnable, value)) m_Ps3SpuEnable = value; } } // 0x21 (33)
		
		protected bool m_Enable = new bool();
		[ContainerField(34), LayoutImmutable, Blittable, ContainerFieldNameHash(2342790116)]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("DebugRenderSettings." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x22 (34)
		
		protected bool m_TextQueueLocationTop = new bool();
		[ContainerField(35), LayoutImmutable, Blittable, ContainerFieldNameHash(607168255)]
		public bool TextQueueLocationTop { get { return m_TextQueueLocationTop; } set { if (OnPropertyChanging("DebugRenderSettings." + nameof(TextQueueLocationTop), this, m_TextQueueLocationTop, value)) m_TextQueueLocationTop = value; } } // 0x23 (35)
		
		protected bool m_DxLine2dAntialiasingEnable = new bool();
		[ContainerField(36), LayoutImmutable, Blittable, ContainerFieldNameHash(944294596)]
		public bool DxLine2dAntialiasingEnable { get { return m_DxLine2dAntialiasingEnable; } set { if (OnPropertyChanging("DebugRenderSettings." + nameof(DxLine2dAntialiasingEnable), this, m_DxLine2dAntialiasingEnable, value)) m_DxLine2dAntialiasingEnable = value; } } // 0x24 (36)
		
		protected bool m_DxLine3dAntialiasingEnable = new bool();
		[ContainerField(37), LayoutImmutable, Blittable, ContainerFieldNameHash(542123237)]
		public bool DxLine3dAntialiasingEnable { get { return m_DxLine3dAntialiasingEnable; } set { if (OnPropertyChanging("DebugRenderSettings." + nameof(DxLine3dAntialiasingEnable), this, m_DxLine3dAntialiasingEnable, value)) m_DxLine3dAntialiasingEnable = value; } } // 0x25 (37)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1402582002:
					TextQueueTimeVisible = (float) p_Value;
					break;

				case 2717954171:
					Ps3SpuFrameBufferSize = (uint) p_Value;
					break;

				case 853125686:
					TextViewDistance = (float) p_Value;
					break;

				case 1799437200:
					TextQueueMaxLineCount = (uint) p_Value;
					break;

				case 981947110:
					DxMaxVertexCount = (uint) p_Value;
					break;

				case 3110006474:
					ProcessJobCount = (int) p_Value;
					break;

				case 711726149:
					DrawStatsEnable = (bool) p_Value;
					break;

				case 3244714114:
					Ps3SpuEnable = (bool) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
					break;

				case 607168255:
					TextQueueLocationTop = (bool) p_Value;
					break;

				case 944294596:
					DxLine2dAntialiasingEnable = (bool) p_Value;
					break;

				case 542123237:
					DxLine3dAntialiasingEnable = (bool) p_Value;
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
				case 1402582002:
					return TextQueueTimeVisible;

				case 2717954171:
					return Ps3SpuFrameBufferSize;

				case 853125686:
					return TextViewDistance;

				case 1799437200:
					return TextQueueMaxLineCount;

				case 981947110:
					return DxMaxVertexCount;

				case 3110006474:
					return ProcessJobCount;

				case 711726149:
					return DrawStatsEnable;

				case 3244714114:
					return Ps3SpuEnable;

				case 2342790116:
					return Enable;

				case 607168255:
					return TextQueueLocationTop;

				case 944294596:
					return DxLine2dAntialiasingEnable;

				case 542123237:
					return DxLine3dAntialiasingEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1402582002:
					return typeof(DebugRenderSettings).GetProperty(nameof(TextQueueTimeVisible));

				case 2717954171:
					return typeof(DebugRenderSettings).GetProperty(nameof(Ps3SpuFrameBufferSize));

				case 853125686:
					return typeof(DebugRenderSettings).GetProperty(nameof(TextViewDistance));

				case 1799437200:
					return typeof(DebugRenderSettings).GetProperty(nameof(TextQueueMaxLineCount));

				case 981947110:
					return typeof(DebugRenderSettings).GetProperty(nameof(DxMaxVertexCount));

				case 3110006474:
					return typeof(DebugRenderSettings).GetProperty(nameof(ProcessJobCount));

				case 711726149:
					return typeof(DebugRenderSettings).GetProperty(nameof(DrawStatsEnable));

				case 3244714114:
					return typeof(DebugRenderSettings).GetProperty(nameof(Ps3SpuEnable));

				case 2342790116:
					return typeof(DebugRenderSettings).GetProperty(nameof(Enable));

				case 607168255:
					return typeof(DebugRenderSettings).GetProperty(nameof(TextQueueLocationTop));

				case 944294596:
					return typeof(DebugRenderSettings).GetProperty(nameof(DxLine2dAntialiasingEnable));

				case 542123237:
					return typeof(DebugRenderSettings).GetProperty(nameof(DxLine3dAntialiasingEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
