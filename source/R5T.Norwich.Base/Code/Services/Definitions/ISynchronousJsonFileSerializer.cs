using System;


namespace R5T.Norwich
{
    public interface ISynchronousJsonFileSerializer
    {
        T Deserialize<T>(string jsonFilePath);
        void Serialize<T>(string jsonFilePath, T @object, bool overwrite = true);
    }
}
