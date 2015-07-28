using Data;
using System;
using System.IO;

namespace CommandLine
{
    internal sealed class DisplayData
    {
		private readonly IDataRepository _repository;
		private readonly TextWriter _writer;

		public DisplayData(TextWriter writer, IDataRepository repository)
		{
			if (writer == null)
				throw new ArgumentNullException("writer");
			if (repository == null)
				throw new ArgumentNullException("repository");
			_writer = writer;
			_repository = repository;
		}

		public int Run()
		{
			foreach (var data in _repository.Fetch())
				_writer.WriteLine(data);
			return default(int);
		}
    }
}
