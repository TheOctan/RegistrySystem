using System.IO;

namespace OctanGames.SaveModule.Serialization
{
	public abstract class BaseSerializationFileSystem : ISerializationFileSystem
	{
		public string LastDirectoryName { get; set; }
		public abstract string Extension { get; }

		public BaseSerializationFileSystem()
		{
		}

		public virtual bool SerializeObject<T>(T obj, string directory, string key)
		{
			LastDirectoryName = directory;

			if (!Directory.Exists(LastDirectoryName))
			{
				Directory.CreateDirectory(LastDirectoryName);
			}

			using (FileStream stream = new FileStream(SavePath(key), FileMode.Create))
			{
				return HandleSaveObject(stream, obj);
			}
		}

		public virtual T DeserializeObject<T>(string directory, string key)
		{
			LastDirectoryName = directory;

			if (!File.Exists(SavePath(key)))
			{
				return default;
			}

			using (FileStream stream = new FileStream(SavePath(key), FileMode.Open))
			{
				return HandleLoadObject<T>(stream);
			}
		}

		private string SavePath(string key)
		{
			return $"{LastDirectoryName}{key}.{Extension}";
		}

		protected abstract bool HandleSaveObject<T>(Stream stream, T obj);
		protected abstract T HandleLoadObject<T>(Stream stream);
	}
}
