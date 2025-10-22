///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;


namespace fb.VeniceShared;

[ContainerType(1, 4)]
public enum AwardKitAssociation : int
{
	AwardKitAssociation_Undefined = 0,
	AwardKitAssociation_Assault = 1,
	AwardKitAssociation_Engineer = 2,
	AwardKitAssociation_Recon = 3,
	AwardKitAssociation_Support = 4,
	AwardKitAssociation_Commander = 5,
	AwardKitAssociation_All = 6,
	AwardKitAssociation_LAST_ITEM = 7,
}

