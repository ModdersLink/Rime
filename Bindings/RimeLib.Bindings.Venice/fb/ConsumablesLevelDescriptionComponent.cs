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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 12)]
	public class ConsumablesLevelDescriptionComponent : 
		LevelDescriptionComponent
	{
		protected List<Consumable> m_Consumables = new List<Consumable>();
		[ContainerField(Name: "Consumables", Offset: 8, NameHash: 1050838517, Flags: 65)]
		public List<Consumable> Consumables { get { return m_Consumables; } set { if (OnPropertyChanging("ConsumablesLevelDescriptionComponent." + nameof(Consumables), this, m_Consumables, value)) m_Consumables = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1050838517:
					Consumables = (List<Consumable>) p_Value;
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
				case 1050838517:
					return Consumables;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1050838517:
					return typeof(ConsumablesLevelDescriptionComponent).GetProperty(nameof(Consumables));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
