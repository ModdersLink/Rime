///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class SimpleMovementActionBaseData : 
		MovementActionData
	{
		[ContainerField(8)]
		public SimpleMovementActionTimeData StartTimeInfo { get; set; } = new SimpleMovementActionTimeData(); // 0x8 (8)
		
		[ContainerField(16)]
		public SimpleMovementActionTimeData RunTimeInfo { get; set; } = new SimpleMovementActionTimeData(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2015117886:
					StartTimeInfo = (SimpleMovementActionTimeData) p_Value;
					break;

				case 3849518743:
					RunTimeInfo = (SimpleMovementActionTimeData) p_Value;
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
				case 2015117886:
					return StartTimeInfo;

				case 3849518743:
					return RunTimeInfo;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2015117886:
					return typeof(SimpleMovementActionBaseData).GetProperty(nameof(StartTimeInfo));

				case 3849518743:
					return typeof(SimpleMovementActionBaseData).GetProperty(nameof(RunTimeInfo));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
