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
	public class SupportedShootingBinding : FrostbiteContainer
	{
		[ContainerField(0)]
		public AntRef Supported { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(4)]
		public AntRef SupportedPos { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(8)]
		public AntRef ForwardVector { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(12)]
		public AntRef Yaw { get; set; } = new AntRef(); // 0xC (12)
		
		[ContainerField(16)]
		public AntRef Pitch { get; set; } = new AntRef(); // 0x10 (16)
		
		[ContainerField(20)]
		public AntRef DistToObject { get; set; } = new AntRef(); // 0x14 (20)
		
		[ContainerField(24)]
		public AntRef HeightOfObject { get; set; } = new AntRef(); // 0x18 (24)
		
		[ContainerField(28)]
		public AntRef Undeploying { get; set; } = new AntRef(); // 0x1C (28)
		
		[ContainerField(32)]
		public AntRef AnimatedCamera { get; set; } = new AntRef(); // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1676564587:
					Supported = (AntRef) p_Value;
					break;

				case 900279143:
					SupportedPos = (AntRef) p_Value;
					break;

				case 2279866951:
					ForwardVector = (AntRef) p_Value;
					break;

				case 193468618:
					Yaw = (AntRef) p_Value;
					break;

				case 232604323:
					Pitch = (AntRef) p_Value;
					break;

				case 1707862081:
					DistToObject = (AntRef) p_Value;
					break;

				case 2836557414:
					HeightOfObject = (AntRef) p_Value;
					break;

				case 2784429365:
					Undeploying = (AntRef) p_Value;
					break;

				case 496739715:
					AnimatedCamera = (AntRef) p_Value;
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
				case 1676564587:
					return Supported;

				case 900279143:
					return SupportedPos;

				case 2279866951:
					return ForwardVector;

				case 193468618:
					return Yaw;

				case 232604323:
					return Pitch;

				case 1707862081:
					return DistToObject;

				case 2836557414:
					return HeightOfObject;

				case 2784429365:
					return Undeploying;

				case 496739715:
					return AnimatedCamera;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1676564587:
					return typeof(SupportedShootingBinding).GetProperty(nameof(Supported));

				case 900279143:
					return typeof(SupportedShootingBinding).GetProperty(nameof(SupportedPos));

				case 2279866951:
					return typeof(SupportedShootingBinding).GetProperty(nameof(ForwardVector));

				case 193468618:
					return typeof(SupportedShootingBinding).GetProperty(nameof(Yaw));

				case 232604323:
					return typeof(SupportedShootingBinding).GetProperty(nameof(Pitch));

				case 1707862081:
					return typeof(SupportedShootingBinding).GetProperty(nameof(DistToObject));

				case 2836557414:
					return typeof(SupportedShootingBinding).GetProperty(nameof(HeightOfObject));

				case 2784429365:
					return typeof(SupportedShootingBinding).GetProperty(nameof(Undeploying));

				case 496739715:
					return typeof(SupportedShootingBinding).GetProperty(nameof(AnimatedCamera));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
