using Newtonsoft.Json;

namespace RegistrationSystem.SaveModule.Serialization.Format
{
	public class JsonSerializationSystem : TextSerializationSystem
	{
		protected override T GetObject<T>(string line)
		{
			return JsonConvert.DeserializeObject<T>(line);
		}

		protected override string GetString<T>(T obj)
		{
			return JsonConvert.SerializeObject(obj);
		}
	}
}
