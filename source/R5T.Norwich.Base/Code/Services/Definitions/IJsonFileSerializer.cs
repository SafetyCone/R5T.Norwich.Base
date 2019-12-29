using System;
using System.Threading.Tasks;


namespace R5T.Norwich
{
    public interface IJsonFileSerializer
    {
        Task<T> DeserializeAsync<T>(string jsonFilePath);
        Task SerializeAsync<T>(string jsonFilePath, T @object, bool overwrite = true);
    }
}
