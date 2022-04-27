using System;
using System.Threading.Tasks;using R5T.T0064;


namespace R5T.Norwich
{[ServiceDefinitionMarker]
    public interface IJsonFileSerializer:IServiceDefinition
    {
        Task<T> DeserializeAsync<T>(string jsonFilePath);
        Task SerializeAsync<T>(string jsonFilePath, T @object, bool overwrite = true);
    }
}
