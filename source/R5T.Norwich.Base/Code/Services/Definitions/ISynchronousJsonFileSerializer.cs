using System;using R5T.T0064;


namespace R5T.Norwich
{[ServiceDefinitionMarker]
    public interface ISynchronousJsonFileSerializer:IServiceDefinition
    {
        T Deserialize<T>(string jsonFilePath);
        void Serialize<T>(string jsonFilePath, T @object, bool overwrite = true);
    }
}
