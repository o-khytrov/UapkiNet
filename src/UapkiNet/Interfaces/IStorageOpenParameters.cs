using UapkiNet.Enums;

namespace UapkiNet.Interfaces
{
    public interface IStorageOpenParameters
    {
        string Provider { get; }
        string Storage { get; set; }
        StorageOpenMode OpenMode { get; set; }
    }
}
