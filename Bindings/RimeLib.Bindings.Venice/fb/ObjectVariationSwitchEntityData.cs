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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class ObjectVariationSwitchEntityData : 
		EntityData
	{
		protected CtrRef<ObjectVariation> m_Variation1 = new CtrRef<ObjectVariation>();
		[ContainerField(Name: "Variation1", Offset: 12, NameHash: 2728063333, Flags: 53)]
		public CtrRef<ObjectVariation> Variation1 { get { return m_Variation1; } set { if (OnPropertyChanging("ObjectVariationSwitchEntityData." + nameof(Variation1), this, m_Variation1, value)) m_Variation1 = value; } } // 0xC (12)
		
		protected CtrRef<ObjectVariation> m_Variation2 = new CtrRef<ObjectVariation>();
		[ContainerField(Name: "Variation2", Offset: 16, NameHash: 2728063334, Flags: 53)]
		public CtrRef<ObjectVariation> Variation2 { get { return m_Variation2; } set { if (OnPropertyChanging("ObjectVariationSwitchEntityData." + nameof(Variation2), this, m_Variation2, value)) m_Variation2 = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2728063333:
					Variation1 = (CtrRef<ObjectVariation>) p_Value;
					break;

				case 2728063334:
					Variation2 = (CtrRef<ObjectVariation>) p_Value;
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
				case 2728063333:
					return Variation1;

				case 2728063334:
					return Variation2;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2728063333:
					return typeof(ObjectVariationSwitchEntityData).GetProperty(nameof(Variation1));

				case 2728063334:
					return typeof(ObjectVariationSwitchEntityData).GetProperty(nameof(Variation2));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
