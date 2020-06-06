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
	public class PlayerData : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<PlayerViewData> PlayerView { get; set; } = new CtrRef<PlayerViewData>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<EntryInputActionMapsData> InputConceptDefinition { get; set; } = new CtrRef<EntryInputActionMapsData>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<InputActionMappingsData> InputMapping { get; set; } = new CtrRef<InputActionMappingsData>(); // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 774623483:
					PlayerView = (CtrRef<PlayerViewData>) p_Value;
					break;

				case 1770668454:
					InputConceptDefinition = (CtrRef<EntryInputActionMapsData>) p_Value;
					break;

				case 1744270687:
					InputMapping = (CtrRef<InputActionMappingsData>) p_Value;
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
				case 774623483:
					return PlayerView;

				case 1770668454:
					return InputConceptDefinition;

				case 1744270687:
					return InputMapping;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 774623483:
					return typeof(PlayerData).GetProperty(nameof(PlayerView));

				case 1770668454:
					return typeof(PlayerData).GetProperty(nameof(InputConceptDefinition));

				case 1744270687:
					return typeof(PlayerData).GetProperty(nameof(InputMapping));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
