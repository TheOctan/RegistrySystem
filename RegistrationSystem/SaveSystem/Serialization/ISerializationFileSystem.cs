namespace OctanGames.SaveModule.Serialization
{
	public interface ISerializationFileSystem
	{
		string Extension { get; }
		string LastDirectoryName { get; set; }

		bool SerializeObject<T>(T obj, string directory, string key);
		T DeserializeObject<T>(string directory, string key);
	}
}
