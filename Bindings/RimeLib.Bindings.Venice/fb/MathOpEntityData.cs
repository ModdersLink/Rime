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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class MathOpEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(12), MemberInfoFlag(137), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("MathOpEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected List<MathOp> m_Operators = new List<MathOp>();
		[ContainerField(16), MemberInfoFlag(65), ContainerFieldNameHash(2346281206), ContainerArray]
		public List<MathOp> Operators { get { return m_Operators; } set { if (OnPropertyChanging("MathOpEntityData." + nameof(Operators), this, m_Operators, value)) m_Operators = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2346281206:
					if (p_Value.GetType() == typeof (List<uint>))
						Operators = ((List<uint>) p_Value).Select(x => (MathOp) Enum.ToObject(typeof(MathOp), x)).ToList();
					else
						Operators = (List<MathOp>) p_Value;
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
				case 229961746:
					return Realm;

				case 2346281206:
					return Operators;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(MathOpEntityData).GetProperty(nameof(Realm));

				case 2346281206:
					return typeof(MathOpEntityData).GetProperty(nameof(Operators));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
