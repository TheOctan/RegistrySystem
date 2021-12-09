using System.IO;

namespace RegistrationSystem.SaveModule.Serialization
{
	public abstract class BaseSerializationFileSystem : ISerializationFileSystem
	{
		public BaseSerializationFileSystem()
		{
		}

		public virtual bool SerializeObject<T>(T obj, string path)
		{
			var directory = Path.GetDirectoryName(path);

			if (!Directory.Exists(directory))
			{
				Directory.CreateDirectory(directory);
			}

			using (FileStream stream = new FileStream(path, FileMode.Create))
			{
				return HandleSaveObject(stream, obj);
			}
		}

		public virtual T DeserializeObject<T>(string path)
		{
			if (!File.Exists(path))
			{
				return default;
			}

			using (FileStream stream = new FileStream(path, FileMode.Open))
			{
				return HandleLoadObject<T>(stream);
			}
		}

		protected abstract bool HandleSaveObject<T>(Stream stream, T obj);
		protected abstract T HandleLoadObject<T>(Stream stream);
	}
}
