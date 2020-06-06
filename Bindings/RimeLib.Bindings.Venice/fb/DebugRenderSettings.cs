///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class DebugRenderSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float TextQueueTimeVisible { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint Ps3SpuFrameBufferSize { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float TextViewDistance { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint TextQueueMaxLineCount { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint DxMaxVertexCount { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public int ProcessJobCount { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool DrawStatsEnable { get; set; } // 0x20 (32)
		
		[ContainerField(33), LayoutImmutable, Blittable]
		public bool Ps3SpuEnable { get; set; } // 0x21 (33)
		
		[ContainerField(34), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x22 (34)
		
		[ContainerField(35), LayoutImmutable, Blittable]
		public bool TextQueueLocationTop { get; set; } // 0x23 (35)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public bool DxLine2dAntialiasingEnable { get; set; } // 0x24 (36)
		
		[ContainerField(37), LayoutImmutable, Blittable]
		public bool DxLine3dAntialiasingEnable { get; set; } // 0x25 (37)
		
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
