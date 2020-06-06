///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class Vec3MathOpEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new Realm(); // 0xC (12)
		
		[ContainerField(16)]
		public List<Vec3MathOp> Operators { get; set; } = new List<Vec3MathOp>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2346281206:
					if (p_Value.GetType() == typeof (List<uint>))
						Operators = ((List<uint>) p_Value).Select(x => (Vec3MathOp) Enum.ToObject(typeof(Vec3MathOp), x)).ToList();
					else
						Operators = (List<Vec3MathOp>) p_Value;
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
					return typeof(Vec3MathOpEntityData).GetProperty(nameof(Realm));

				case 2346281206:
					return typeof(Vec3MathOpEntityData).GetProperty(nameof(Operators));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
