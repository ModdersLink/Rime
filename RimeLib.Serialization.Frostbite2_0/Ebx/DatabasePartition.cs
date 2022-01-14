using System.Collections.Generic;
using System.IO;
using fb;
using Newtonsoft.Json;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Json;

namespace RimeLib.Serialization.Frostbite2_0.Ebx
{
    public class DatabasePartition
    {
        public string Name { get; set; } = null;

        public GUID PartitionGuid { get; set; } = new();

        public GUID PrimaryInstanceGuid { get; set; } = new();

        public Dictionary<GUID, DataContainer> Instances { get; set; } = new();

        [JsonIgnore]
        public DataContainer PrimaryInstance => Instances[PrimaryInstanceGuid];

        public string ToJsonString(Formatting p_Formatting = Formatting.None)
        {
            return JsonConvert.SerializeObject(this, p_Formatting, new CtrRefJsonConverter());
        }

        public void ToJsonFile(string p_FilePath, Formatting p_Formatting = Formatting.None)
        {
            using var s_Writer = new StreamWriter(p_FilePath);
            ToJsonStream(s_Writer, p_Formatting);
        }

        public void ToJsonStream(TextWriter p_Writer, Formatting p_Formatting = Formatting.None)
        {
            var s_Serializer = new JsonSerializer();
            s_Serializer.Converters.Add(new CtrRefJsonConverter());
            s_Serializer.NullValueHandling = NullValueHandling.Include;
            s_Serializer.MissingMemberHandling = MissingMemberHandling.Error;
            s_Serializer.TypeNameHandling = TypeNameHandling.None;
            s_Serializer.Formatting = p_Formatting;

            s_Serializer.Serialize(p_Writer, this);
        }

        public static DatabasePartition FromJsonFile(string p_FilePath)
        {
            using var s_Reader = File.OpenText(p_FilePath);
            return FromJsonStream(s_Reader);
        }

        public static DatabasePartition FromJsonStream(TextReader p_Reader)
        {
            var s_Serializer = new JsonSerializer();
            s_Serializer.Converters.Add(new CtrRefJsonConverter());
            s_Serializer.Converters.Add(new DataContainerJsonConverter());
            s_Serializer.NullValueHandling = NullValueHandling.Include;
            s_Serializer.MissingMemberHandling = MissingMemberHandling.Error;
            s_Serializer.TypeNameHandling = TypeNameHandling.None;

            return (DatabasePartition) s_Serializer.Deserialize(p_Reader, typeof(DatabasePartition));
        }
    }
}
