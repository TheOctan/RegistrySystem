using System.IO;
using System.Text;

namespace RegistrationSystem.SaveModule.Serialization
{
	public abstract class TextSerializationSystem : BaseSerializationFileSystem
	{
		protected abstract string GetString<T>(T obj);
		protected abstract T GetObject<T>(string line);

		protected override T HandleLoadObject<T>(Stream stream)
		{
			StringBuilder stringBuilder = new StringBuilder();
			using (var streamReader = new StreamReader(stream))
			{
				while (!streamReader.EndOfStream)
				{
					stringBuilder.Append(streamReader.ReadLine());
				}
			}

			var line = stringBuilder.ToString();
			if (string.IsNullOrEmpty(line))
			{
				return default;
			}

			var obj = GetObject<T>(line);
			return obj;
		}

		protected override bool HandleSaveObject<T>(Stream stream, T obj)
		{
			var line = GetString(obj);
			using (var writer = new StreamWriter(stream))
			{
				writer.WriteLine(line);
			}

			return true;
		}
	}
}
