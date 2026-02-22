import struct
import uuid
import json
from enum import IntEnum
from typing import BinaryIO, Dict, Any, List, Optional

class DbObjectType(IntEnum):
    Eoo = 0x00
    InternalMin = 0x00
    Array = 0x01
    Object = 0x02
    HomoArray = 0x03
    Null = 0x04
    ObjectId = 0x05
    Bool = 0x06
    String = 0x07
    Integer = 0x08
    Long = 0x09
    VarInt = 0x0A
    Float = 0x0B
    Double = 0x0C
    Timestamp = 0x0D
    RecordId = 0x0E
    Guid = 0x0F
    Sha1 = 0x10
    Matrix44 = 0x11
    Vector4 = 0x12
    Blob = 0x13
    Attachment = 0x14
    Timespan = 0x15
    InternalMax = 0x1F
    Mask = 0x1F
    Anonymous = 0x80
    AnonymousObject = 0x82

def decode_7bit(file: BinaryIO) -> int:
    value = 0
    shift = 0
    size = 0
    while True:
        byte = file.read(1)[0]
        value |= (byte & 0x7F) << shift
        size += 1
        if (byte & 0x80) == 0:
            break
        shift += 7
    return value

def parse_db_object_element(file: BinaryIO) -> Dict[str, Any]:
    objType = (int)(file.read(1)[0])
    obj_type = DbObjectType(objType)
    real_type = obj_type & DbObjectType.Mask
    
    field_name: Optional[str] = None
    if real_type != DbObjectType.Eoo and (obj_type & DbObjectType.Anonymous) == 0:
        field_name_bytes = bytearray()
        while True:
            byte = file.read(1)
            if byte == b'\x00':
                break
            field_name_bytes.extend(byte)
        field_name = field_name_bytes.decode('utf-8')
    
    value: Optional[Any] = None
    if real_type in {DbObjectType.Array, DbObjectType.HomoArray, DbObjectType.Object}:
        size = decode_7bit(file)
        value = parse_db_elements(file, size)
    elif real_type == DbObjectType.ObjectId:
        value = file.read(16)
    elif real_type == DbObjectType.Bool:
        value = bool(file.read(1)[0])
    elif real_type == DbObjectType.String:
        str_len = decode_7bit(file)
        value = file.read(str_len).decode('utf-8')[:-1]
    elif real_type == DbObjectType.Integer:
        value = struct.unpack('<i', file.read(4))[0]
    elif real_type == DbObjectType.Long:
        value = struct.unpack('<q', file.read(8))[0]
    elif real_type == DbObjectType.Float:
        value = struct.unpack('<f', file.read(4))[0]
    elif real_type == DbObjectType.Double:
        value = struct.unpack('<d', file.read(8))[0]
    elif real_type == DbObjectType.Timestamp:
        value = struct.unpack('<I', file.read(4))[0]
    elif real_type == DbObjectType.Guid:
        value = file.read(16)
    elif real_type == DbObjectType.Sha1:
        value = file.read(20)
    elif real_type == DbObjectType.Blob:
        size = decode_7bit(file)
        value = file.read(size)
    return {'type': obj_type.name, 'name': field_name, 'value': value}

def parse_db_elements(file: BinaryIO, size: int) -> List[Dict[str, Any]]:
    elements: List[Dict[str, Any]] = []
    start_pos = file.tell()
    while file.tell() - start_pos < size:
        elements.append(parse_db_object_element(file))
    return elements

def parse_db_file(filename: str) -> List[Dict[str, Any]]:
    with open(filename, 'rb') as file:
        return parse_db_elements(file, file.__sizeof__())

output_json = {
    "ebx": [],
    "res": [],
    "chunks": []
}

db_objects = parse_db_file(r"d:\Games\Battlefield 3\Update\Patch\Data\Win32\Levels\MP_Subway\MP_Subway.sb") # only works for cas superbundles
#TODO lookup bundle name by looping over bundles and check the "path" value
bundle = db_objects[0]["value"][0]["value"][3]["value"] # index 3 is the bundle "levels/mp_subway/mp_subway"

total_size = 0
for i in range(len(bundle)):
    field_name = bundle[i]["name"]
    if field_name == "ebx":
        assets = bundle[i]["value"]
        for j in range(len(assets) - 1):
            asset = assets[j]["value"]
            output_json["ebx"].append(asset[0]["value"])
    
    if field_name == "res":
        assets = bundle[i]["value"]
        for j in range(len(assets) - 1):
            asset = assets[j]["value"]
            output_json["res"].append(asset[0]["value"])
    
    if field_name == "chunks":
        assets = bundle[i]["value"]
        for j in range(len(assets) - 1):
            asset = assets[j]["value"]
            raw_bytes = asset[0]["value"]
            guid_str = str(uuid.UUID(bytes_le=raw_bytes)).lower()
            output_json["chunks"].append(guid_str)

with open(r"d:\DUMPS\mp_subway_bundle_contents.json", "w") as f:
    json.dump(output_json, f, indent=4)
