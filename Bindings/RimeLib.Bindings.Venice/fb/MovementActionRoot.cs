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
	[ContainerType(4)]
	public class MovementActionRoot : 
		Asset
	{
		protected CtrRef<MovementActionData> m_StartSequence = new CtrRef<MovementActionData>();
		[ContainerField(12), ContainerFieldNameHash(3846144538)]
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
