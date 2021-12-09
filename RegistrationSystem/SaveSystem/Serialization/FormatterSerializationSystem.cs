﻿using System.IO;
using System.Runtime.Serialization;

namespace RegistrationSystem.SaveModule.Serialization
{
	public abstract class FormatterSerializationSystem<T> : BaseSerializationFileSystem where T : IFormatter, new()
	{
		public FormatterSerializationSystem() : base()
		{
		}

		protected override T1 HandleLoadObject<T1>(Stream stream)
		{
			var formatter = new T();
			T1 obj = (T1)formatter.Deserialize(stream);

			return obj;
		}

		protected override bool HandleSaveObject<T1>(Stream stream, T1 obj)
		{
			var formatter = new T();
			formatter.Serialize(stream, obj);

			return true;
		}
	}
}
