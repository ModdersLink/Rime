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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class VeniceUnlockUserData : 
		UnlockUserDataBase
	{
		protected bool m_CheckSquad = new bool();
		[ContainerField(Name: "CheckSquad", Offset: 12, NameHash: 28509873, Flags: 49325), LayoutImmutable, Blittable]
		public bool CheckSquad { get { return m_CheckSquad; } set { if (OnPropertyChanging("VeniceUnlockUserData." + nameof(CheckSquad), this, m_CheckSquad, value)) m_CheckSquad = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 28509873:
					CheckSquad = (bool) p_Value;
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
				case 28509873:
					return CheckSquad;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 28509873:
					return typeof(VeniceUnlockUserData).GetProperty(nameof(CheckSquad));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
