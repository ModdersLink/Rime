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
	public class VaultWaypointData : 
		AbstractLocoWaypointData
	{
		protected AILocoVaultTaskData m_VaultTask = new AILocoVaultTaskData();
		[ContainerField(48), ContainerFieldNameHash(4073508114)]
		public AILocoVaultTaskData VaultTask { get { return m_VaultTask; } set { if (OnPropertyChanging("VaultWaypointData." + nameof(VaultTask), this, m_VaultTask, value)) m_VaultTask = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4073508114:
					VaultTask = (AILocoVaultTaskData) p_Value;
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
				case 4073508114:
					return VaultTask;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4073508114:
					return typeof(VaultWaypointData).GetProperty(nameof(VaultTask));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
