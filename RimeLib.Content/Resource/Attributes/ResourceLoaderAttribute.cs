using System;
using System.Collections.Generic;
using System.Text;

using RimeLib.Frostbite;
using RimeLib.Content.Frostbite;


namespace RimeLib.Content.Resource.Attributes
{
    [AttributeUsage( AttributeTargets.Class, AllowMultiple = true )]
    public class ResourceLoaderAttribute : Attribute
    {
        public ResourceType ResourceType
        {
            get; set;
        }

        public EngineType EngineVersion
        {
            get; set;
        }

        /// <summary>
        /// Loader attribute consturctor
        /// </summary>
        /// <param name="p_Type">what is this resoruce the handler is for?</param>
        /// <param name="p_EngineVersion">what is the engine this resoruce is for?</param>
        public ResourceLoaderAttribute( ResourceType p_Type, EngineType p_EngineVersion = EngineType.Unknown ) 
        {
            this.ResourceType = p_Type;
            this.EngineVersion = p_EngineVersion;
        }
    }
}
