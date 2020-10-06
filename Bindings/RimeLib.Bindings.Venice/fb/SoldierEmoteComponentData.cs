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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(176), ContainerClass]
	public class SoldierEmoteComponentData : 
		ComponentData
	{
		protected SoldierEmoteBinding m_Binding = new SoldierEmoteBinding();
		[ContainerField(96), MemberInfoFlag(41), ContainerFieldNameHash(2590060228)]
		public SoldierEmoteBinding Binding { get { return m_Binding; } set { if (OnPropertyChanging("SoldierEmoteComponentData." + nameof(Binding), this, m_Binding, value)) m_Binding = value; } } // 0x60 (96)
		
		protected RefArray<SoldierEmoteNetworkedMessageMapping> m_NetworkedMessageMappings = new RefArray<SoldierEmoteNetworkedMessageMapping>();
		[ContainerField(160), MemberInfoFlag(65), ContainerFieldNameHash(682902766), ContainerRefArray]
		public RefArray<SoldierEmoteNetworkedMessageMapping> NetworkedMessageMappings { get { return m_NetworkedMessageMappings; } set { if (OnPropertyChanging("SoldierEmoteComponentData." + nameof(NetworkedMessageMappings), this, m_NetworkedMessageMappings, value)) m_NetworkedMessageMappings = value; } } // 0xA0 (160)
		
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
