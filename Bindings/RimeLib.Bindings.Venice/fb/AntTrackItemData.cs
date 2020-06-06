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
	public class AntTrackItemData : 
		DataContainer
	{
		[ContainerField(8)]
		public AntRef Controller { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public int SequenceTrackIndex { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public int StartTime { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint NumTicks { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public bool ResumeAtEnd { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1870777401:
					Controller = (AntRef) p_Value;
					break;

				case 2030753355:
					SequenceTrackIndex = (int) p_Value;
					break;

				case 3727579056:
					StartTime = (int) p_Value;
					break;

				case 775952821:
					NumTicks = (uint) p_Value;
					break;

				case 1451056774:
					ResumeAtEnd = (bool) p_Value;
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
				case 1870777401:
					return Controller;

				case 2030753355:
					return SequenceTrackIndex;

				case 3727579056:
					return StartTime;

				case 775952821:
					return NumTicks;

				case 1451056774:
					return ResumeAtEnd;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1870777401:
					return typeof(AntTrackItemData).GetProperty(nameof(Controller));

				case 2030753355:
					return typeof(AntTrackItemData).GetProperty(nameof(SequenceTrackIndex));

				case 3727579056:
					return typeof(AntTrackItemData).GetProperty(nameof(StartTime));

				case 775952821:
					return typeof(AntTrackItemData).GetProperty(nameof(NumTicks));

				case 1451056774:
					return typeof(AntTrackItemData).GetProperty(nameof(ResumeAtEnd));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
