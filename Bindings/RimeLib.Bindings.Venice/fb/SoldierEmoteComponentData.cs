///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class SoldierEmoteComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public SoldierEmoteBinding Binding { get; set; } = new SoldierEmoteBinding(); // 0x60 (96)
		
		[ContainerField(160)]
		public RefArray<SoldierEmoteNetworkedMessageMapping> NetworkedMessageMappings { get; set; } = new RefArray<SoldierEmoteNetworkedMessageMapping>(); // 0xA0 (160)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2590060228:
					Binding = (SoldierEmoteBinding) p_Value;
					break;

				case 682902766:
					NetworkedMessageMappings = (RefArray<SoldierEmoteNetworkedMessageMapping>) p_Value;
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
				case 2590060228:
					return Binding;

				case 682902766:
					return NetworkedMessageMappings;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2590060228:
					return typeof(SoldierEmoteComponentData).GetProperty(nameof(Binding));

				case 682902766:
					return typeof(SoldierEmoteComponentData).GetProperty(nameof(NetworkedMessageMappings));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
