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
	public class MovementActionRoot : 
		Asset
	{
		protected CtrRef<MovementActionData> m_StartSequence = new CtrRef<MovementActionData>();
		[ContainerField(Name: "StartSequence", Offset: 12, NameHash: 3846144538, Flags: 53)]
		public CtrRef<MovementActionData> StartSequence { get { return m_StartSequence; } set { if (OnPropertyChanging("MovementActionRoot." + nameof(StartSequence), this, m_StartSequence, value)) m_StartSequence = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3846144538:
					StartSequence = (CtrRef<MovementActionData>) p_Value;
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
				case 3846144538:
					return StartSequence;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3846144538:
					return typeof(MovementActionRoot).GetProperty(nameof(StartSequence));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
