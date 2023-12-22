using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Rime.Projects
{
    /// <summary>
    /// This class is what saves a bit of state about the currently opened project file
    /// This will contain the frostbite version and directories that the user selects or provides
    /// as well as some user specific configuration information
    /// </summary>
    public class RimeProject
    {
        /// <summary>
        /// Name of the project
        /// </summary>
        [JsonInclude]
        public string Name { get; set; } = "Untitled Project";

        /// <summary>
        /// Project description
        /// </summary>
        [JsonInclude]
        public string Description { get; set; } = "Default Description";

        /// <summary>
        /// Version information in semver format
        /// </summary>
        [JsonInclude]
        public string Version { get; set; } = "0.0.1";

        /// <summary>
        /// Frostbite engine version
        /// </summary>
        [JsonInclude]
        public EngineType EngineVersion { get; set; } = EngineType.Frostbite2_0;

        /// <summary>
        /// Game directory
        /// </summary>
        [JsonInclude]
        public string GameDirectory { get; set; } = string.Empty;

        /// <summary>
        /// The previously mounted superbundles
        /// </summary>
        [JsonInclude]
        public string[] MountedSuperbundles
        {
            get
            {
                return m_MountedSuperbundles.ToArray();
            }
            set
            {
                m_MountedSuperbundles = new List<string>(value);
            }
        }

        /// <summary>
        /// Engine mounter class
        /// </summary>
        [JsonIgnore]
        public IEngineMounter? Mounter { get; set; }

        // Last loaded superbundles
        protected List<string> m_MountedSuperbundles = new List<string>();

        // TODO: Figure out what should be project centric and move that shit here
    }
}
