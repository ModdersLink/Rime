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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 40)]
	public class DebugRenderSettings : 
		DataContainer
	{
		protected float m_TextQueueTimeVisible = new float();
		[ContainerField(Name: "TextQueueTimeVisible", Offset: 8, NameHash: 1402582002, Flags: 49469), LayoutImmutable, Blittable]
		public float TextQueueTimeVisible { get { return m_TextQueueTimeVisible; } set { if (OnPropertyChanging("DebugRenderSettings." + nameof(TextQueueTimeVisible), this, m_TextQueueTimeVisible, value)) m_TextQueueTimeVisible = value; } } // 0x8 (8)
		
		protected uint m_Ps3SpuFrameBufferSize = new uint();
		[ContainerField(Name: "Ps3SpuFrameBufferSize", Offset: 12, NameHash: 2717954171, Flags: 49421), LayoutImmutable, Blittable]
		public uint Ps3SpuFrameBufferSize { get { return m_Ps3SpuFrameBufferSize; } set { if (OnPropertyChanging("DebugRenderSettings." + nameof(Ps3SpuFrameBufferSize), this, m_Ps3SpuFrameBufferSize, value)) m_Ps3SpuFrameBufferSize = value; } } // 0xC (12)
		
		protected float m_TextViewDistance = new float();
		[ContainerField(Name: "TextViewDistance", Offset: 16, NameHash: 853125686, Flags: 49469), LayoutImmutable, Blittable]
		public float TextViewDistance { get { return m_TextViewDistance; } set { if (OnPropertyChanging("DebugRenderSettings." + nameof(TextViewDistance), this, m_TextViewDistance, value)) m_TextViewDistance = value; } } // 0x10 (16)
		
		protected uint m_TextQueueMaxLineCount = new uint();
		[ContainerField(Name: "TextQueueMaxLineCount", Offset: 20, NameHash: 1799437200, Flags: 49421), LayoutImmutable, Blittable]
		public uint TextQueueMaxLineCount { get { return m_TextQueueMaxLineCount; } set { if (OnPropertyChanging("DebugRenderSettings." + nameof(TextQueueMaxLineCount), this, m_TextQueueMaxLineCount, value)) m_TextQueueMaxLineCount = value; } } // 0x14 (20)
		
		protected uint m_DxMaxVertexCount = new uint();
		[ContainerField(Name: "DxMaxVertexCount", Offset: 24, NameHash: 981947110, Flags: 49421), LayoutImmutable, Blittable]
		public uint DxMaxVertexCount { get { return m_DxMaxVertexCount; } set { if (OnPropertyChanging("DebugRenderSettings." + nameof(DxMaxVertexCount), this, m_DxMaxVertexCount, value)) m_DxMaxVertexCount = value; } } // 0x18 (24)
		
		protected int m_ProcessJobCount = new int();
		[ContainerField(Name: "ProcessJobCount", Offset: 28, NameHash: 3110006474, Flags: 49405), LayoutImmutable, Blittable]
		public int ProcessJobCount { get { return m_ProcessJobCount; } set { if (OnPropertyChanging("DebugRenderSettings." + nameof(ProcessJobCount), this, m_ProcessJobCount, value)) m_ProcessJobCount = value; } } // 0x1C (28)
		
		protected bool m_DrawStatsEnable = new bool();
		[ContainerField(Name: "DrawStatsEnable", Offset: 32, NameHash: 711726149, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawStatsEnable { get { return m_DrawStatsEnable; } set { if (OnPropertyChanging("DebugRenderSettings." + nameof(DrawStatsEnable), this, m_DrawStatsEnable, value)) m_DrawStatsEnable = value; } } // 0x20 (32)
		
		protected bool m_Ps3SpuEnable = new bool();
		[ContainerField(Name: "Ps3SpuEnable", Offset: 33, NameHash: 3244714114, Flags: 49325), LayoutImmutable, Blittable]
		public bool Ps3SpuEnable { get { return m_Ps3SpuEnable; } set { if (OnPropertyChanging("DebugRenderSettings." + nameof(Ps3SpuEnable), this, m_Ps3SpuEnable, value)) m_Ps3SpuEnable = value; } } // 0x21 (33)
		
		protected bool m_Enable = new bool();
		[ContainerField(Name: "Enable", Offset: 34, NameHash: 2342790116, Flags: 49325), LayoutImmutable, Blittable]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("DebugRenderSettings." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x22 (34)
		
		protected bool m_TextQueueLocationTop = new bool();
		[ContainerField(Name: "TextQueueLocationTop", Offset: 35, NameHash: 607168255, Flags: 49325), LayoutImmutable, Blittable]
		public bool TextQueueLocationTop { get { return m_TextQueueLocationTop; } set { if (OnPropertyChanging("DebugRenderSettings." + nameof(TextQueueLocationTop), this, m_TextQueueLocationTop, value)) m_TextQueueLocationTop = value; } } // 0x23 (35)
		
		protected bool m_DxLine2dAntialiasingEnable = new bool();
		[ContainerField(Name: "DxLine2dAntialiasingEnable", Offset: 36, NameHash: 944294596, Flags: 49325), LayoutImmutable, Blittable]
		public bool DxLine2dAntialiasingEnable { get { return m_DxLine2dAntialiasingEnable; } set { if (OnPropertyChanging("DebugRenderSettings." + nameof(DxLine2dAntialiasingEnable), this, m_DxLine2dAntialiasingEnable, value)) m_DxLine2dAntialiasingEnable = value; } } // 0x24 (36)
		
		protected bool m_DxLine3dAntialiasingEnable = new bool();
		[ContainerField(Name: "DxLine3dAntialiasingEnable", Offset: 37, NameHash: 542123237, Flags: 49325), LayoutImmutable, Blittable]
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
