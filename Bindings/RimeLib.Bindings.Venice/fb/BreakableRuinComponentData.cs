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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class BreakableRuinComponentData : 
		ComponentData
	{
		protected CtrRef<ObjectBlueprint> m_RuinModel = new CtrRef<ObjectBlueprint>();
		[ContainerField(Name: "RuinModel", Offset: 96, NameHash: 1172592682, Flags: 53)]
		public CtrRef<ObjectBlueprint> RuinModel { get { return m_RuinModel; } set { if (OnPropertyChanging("BreakableRuinComponentData." + nameof(RuinModel), this, m_RuinModel, value)) m_RuinModel = value; } } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1172592682:
					RuinModel = (CtrRef<ObjectBlueprint>) p_Value;
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
				case 1172592682:
					return RuinModel;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1172592682:
					return typeof(BreakableRuinComponentData).GetProperty(nameof(RuinModel));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
