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
	public class MovementActionRandomizerData : 
		MovementActionData
	{
		protected RefArray<MovementActionData> m_Actions = new RefArray<MovementActionData>();
		[ContainerField(Name: "Actions", Offset: 8, NameHash: 373511656, Flags: 65)]
		public RefArray<MovementActionData> Actions { get { return m_Actions; } set { if (OnPropertyChanging("MovementActionRandomizerData." + nameof(Actions), this, m_Actions, value)) m_Actions = value; } } // 0x8 (8)
		
		protected bool m_ReinsertIntoRandomizedListAfterUse = new bool();
		[ContainerField(Name: "ReinsertIntoRandomizedListAfterUse", Offset: 12, NameHash: 201056821, Flags: 49325), LayoutImmutable, Blittable]
		public bool ReinsertIntoRandomizedListAfterUse { get { return m_ReinsertIntoRandomizedListAfterUse; } set { if (OnPropertyChanging("MovementActionRandomizerData." + nameof(ReinsertIntoRandomizedListAfterUse), this, m_ReinsertIntoRandomizedListAfterUse, value)) m_ReinsertIntoRandomizedListAfterUse = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 373511656:
					Actions = (RefArray<MovementActionData>) p_Value;
					break;

				case 201056821:
					ReinsertIntoRandomizedListAfterUse = (bool) p_Value;
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
				case 373511656:
					return Actions;

				case 201056821:
					return ReinsertIntoRandomizedListAfterUse;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 373511656:
					return typeof(MovementActionRandomizerData).GetProperty(nameof(Actions));

				case 201056821:
					return typeof(MovementActionRandomizerData).GetProperty(nameof(ReinsertIntoRandomizedListAfterUse));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
