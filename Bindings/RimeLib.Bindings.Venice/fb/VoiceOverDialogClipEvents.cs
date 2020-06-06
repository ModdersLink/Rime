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
	public class VoiceOverDialogClipEvents : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint StartedNameHash { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint FinishedNameHash { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2297623121:
					StartedNameHash = (uint) p_Value;
					break;

				case 651465762:
					FinishedNameHash = (uint) p_Value;
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
				case 2297623121:
					return StartedNameHash;

				case 651465762:
					return FinishedNameHash;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2297623121:
					return typeof(VoiceOverDialogClipEvents).GetProperty(nameof(StartedNameHash));

				case 651465762:
					return typeof(VoiceOverDialogClipEvents).GetProperty(nameof(FinishedNameHash));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
