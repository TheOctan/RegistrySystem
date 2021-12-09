namespace RegistrationSystem.SaveModule.Serialization
{
	public interface ISerializationFileSystem
	{
		bool SerializeObject<T>(T obj, string path);
		T DeserializeObject<T>(string path);
	}
}
