using System.Runtime.Serialization.Formatters.Binary;

namespace RegistrationSystem.SaveModule.Serialization.Format
{
	public class BinarySerializationSystem : FormatterSerializationSystem<BinaryFormatter>
	{
		public override string Extension => "bin";
	}
}
