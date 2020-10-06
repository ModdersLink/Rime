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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(60), ContainerStruct]
	public class VehicleEntryListenerBinding : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(41)]
		public AntRef InVehicle { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(4), MemberInfoFlag(41)]
		public AntRef InOpenEntry { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(8), MemberInfoFlag(41)]
		public AntRef VehicleEntryFire { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(12), MemberInfoFlag(41)]
		public AntRef VehicleEntryYaw { get; set; } = new AntRef(); // 0xC (12)
		
		[ContainerField(16), MemberInfoFlag(41)]
		public AntRef VehicleEntryPitch { get; set; } = new AntRef(); // 0x10 (16)
		
		[ContainerField(20), MemberInfoFlag(41)]
		public AntRef VehicleEntryRoll { get; set; } = new AntRef(); // 0x14 (20)
		
		[ContainerField(24), MemberInfoFlag(41)]
		public AntRef VehicleEntryRotation { get; set; } = new AntRef(); // 0x18 (24)
		
		[ContainerField(28), MemberInfoFlag(41)]
		public AntRef VehicleEntryForceX { get; set; } = new AntRef(); // 0x1C (28)
		
		[ContainerField(32), MemberInfoFlag(41)]
		public AntRef VehicleEntryForceY { get; set; } = new AntRef(); // 0x20 (32)
		
		[ContainerField(36), MemberInfoFlag(41)]
		public AntRef VehicleEntryForceZ { get; set; } = new AntRef(); // 0x24 (36)
		
		[ContainerField(40), MemberInfoFlag(41)]
		public AntRef VehicleEntryIndex { get; set; } = new AntRef(); // 0x28 (40)
		
		[ContainerField(44), MemberInfoFlag(41)]
		public AntRef VehicleEntryIndexUpdated { get; set; } = new AntRef(); // 0x2C (44)
		
		[ContainerField(48), MemberInfoFlag(41)]
		public AntRef VehicleOpenEntryIndex { get; set; } = new AntRef(); // 0x30 (48)
		
		[ContainerField(52), MemberInfoFlag(41)]
		public AntRef InVehicleRetrigger { get; set; } = new AntRef(); // 0x34 (52)
		
		[ContainerField(56), MemberInfoFlag(41)]
		public AntRef VehicleEntryChooserIndex { get; set; } = new AntRef(); // 0x38 (56)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2027857690:
					InVehicle = (AntRef) p_Value;
					break;

				case 3944895714:
					InOpenEntry = (AntRef) p_Value;
					break;

				case 1657787569:
					VehicleEntryFire = (AntRef) p_Value;
					break;

				case 50235142:
					VehicleEntryYaw = (AntRef) p_Value;
					break;

				case 3174613487:
					VehicleEntryPitch = (AntRef) p_Value;
					break;

				case 1658216564:
					VehicleEntryRoll = (AntRef) p_Value;
					break;

				case 2010737181:
					VehicleEntryRotation = (AntRef) p_Value;
					break;

				case 1432827884:
					VehicleEntryForceX = (AntRef) p_Value;
					break;

				case 1432827885:
					VehicleEntryForceY = (AntRef) p_Value;
					break;

				case 1432827886:
					VehicleEntryForceZ = (AntRef) p_Value;
					break;

				case 3148172503:
					VehicleEntryIndex = (AntRef) p_Value;
					break;

				case 3953478242:
					VehicleEntryIndexUpdated = (AntRef) p_Value;
					break;

				case 1471285795:
					VehicleOpenEntryIndex = (AntRef) p_Value;
					break;

				case 3157938229:
					InVehicleRetrigger = (AntRef) p_Value;
					break;

				case 2285531672:
					VehicleEntryChooserIndex = (AntRef) p_Value;
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
				case 2027857690:
					return InVehicle;

				case 3944895714:
					return InOpenEntry;

				case 1657787569:
					return VehicleEntryFire;

				case 50235142:
					return VehicleEntryYaw;

				case 3174613487:
					return VehicleEntryPitch;

				case 1658216564:
					return VehicleEntryRoll;

				case 2010737181:
					return VehicleEntryRotation;

				case 1432827884:
					return VehicleEntryForceX;

				case 1432827885:
					return VehicleEntryForceY;

				case 1432827886:
					return VehicleEntryForceZ;

				case 3148172503:
					return VehicleEntryIndex;

				case 3953478242:
					return VehicleEntryIndexUpdated;

				case 1471285795:
					return VehicleOpenEntryIndex;

				case 3157938229:
					return InVehicleRetrigger;

				case 2285531672:
					return VehicleEntryChooserIndex;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2027857690:
					return typeof(VehicleEntryListenerBinding).GetProperty(nameof(InVehicle));

				case 3944895714:
					return typeof(VehicleEntryListenerBinding).GetProperty(nameof(InOpenEntry));

				case 1657787569:
					return typeof(VehicleEntryListenerBinding).GetProperty(nameof(VehicleEntryFire));

				case 50235142:
					return typeof(VehicleEntryListenerBinding).GetProperty(nameof(VehicleEntryYaw));

				case 3174613487:
					return typeof(VehicleEntryListenerBinding).GetProperty(nameof(VehicleEntryPitch));

				case 1658216564:
					return typeof(VehicleEntryListenerBinding).GetProperty(nameof(VehicleEntryRoll));

				case 2010737181:
					return typeof(VehicleEntryListenerBinding).GetProperty(nameof(VehicleEntryRotation));

				case 1432827884:
					return typeof(VehicleEntryListenerBinding).GetProperty(nameof(VehicleEntryForceX));

				case 1432827885:
					return typeof(VehicleEntryListenerBinding).GetProperty(nameof(VehicleEntryForceY));

				case 1432827886:
					return typeof(VehicleEntryListenerBinding).GetProperty(nameof(VehicleEntryForceZ));

				case 3148172503:
					return typeof(VehicleEntryListenerBinding).GetProperty(nameof(VehicleEntryIndex));

				case 3953478242:
					return typeof(VehicleEntryListenerBinding).GetProperty(nameof(VehicleEntryIndexUpdated));

				case 1471285795:
					return typeof(VehicleEntryListenerBinding).GetProperty(nameof(VehicleOpenEntryIndex));

				case 3157938229:
					return typeof(VehicleEntryListenerBinding).GetProperty(nameof(InVehicleRetrigger));

				case 2285531672:
					return typeof(VehicleEntryListenerBinding).GetProperty(nameof(VehicleEntryChooserIndex));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
