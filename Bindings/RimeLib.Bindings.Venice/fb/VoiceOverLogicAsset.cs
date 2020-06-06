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
	public class VoiceOverLogicAsset : 
		Asset
	{
		[ContainerField(12)]
		public RefArray<VoiceOverEvent> Events { get; set; } = new RefArray<VoiceOverEvent>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<VoiceOverGroup> Groups { get; set; } = new RefArray<VoiceOverGroup>(); // 0x10 (16)
		
		[ContainerField(20)]
		public RefArray<VoiceOverLogicFlow> Flows { get; set; } = new RefArray<VoiceOverLogicFlow>(); // 0x14 (20)
		
		[ContainerField(24)]
		public CtrRef<VoiceOverSystemAsset> System { get; set; } = new CtrRef<VoiceOverSystemAsset>(); // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2352146554:
					Events = (RefArray<VoiceOverEvent>) p_Value;
					break;

				case 2573340009:
					Groups = (RefArray<VoiceOverGroup>) p_Value;
					break;

				case 207046276:
					Flows = (RefArray<VoiceOverLogicFlow>) p_Value;
					break;

				case 3333232768:
					System = (CtrRef<VoiceOverSystemAsset>) p_Value;
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
				case 2352146554:
					return Events;

				case 2573340009:
					return Groups;

				case 207046276:
					return Flows;

				case 3333232768:
					return System;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2352146554:
					return typeof(VoiceOverLogicAsset).GetProperty(nameof(Events));

				case 2573340009:
					return typeof(VoiceOverLogicAsset).GetProperty(nameof(Groups));

				case 207046276:
					return typeof(VoiceOverLogicAsset).GetProperty(nameof(Flows));

				case 3333232768:
					return typeof(VoiceOverLogicAsset).GetProperty(nameof(System));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
