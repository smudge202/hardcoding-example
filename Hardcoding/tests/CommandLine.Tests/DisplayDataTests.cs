using Data;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using TestAttributes;
using Xunit;

namespace CommandLine.Tests
{
    public class DisplayDataTests
    {
		private static TextWriter DefaultWriter
		{
			get
			{
				return new Mock<TextWriter>().Object;
			}
		}

		private static IDataRepository DefaultRepository
		{
			get
			{
				return new Mock<IDataRepository>().Object;
			}
		}

		[Unit]
		public static void WhenWriterIsNullThenThrowsException()
		{
			Action act = () => new DisplayData(null, DefaultRepository);
			act.ShouldThrow<ArgumentNullException>();
        }

		[Unit]
		public static void WhenRepositoryIsNullThenThrowsException()
		{
			Action act = () => new DisplayData(DefaultWriter, null);
			act.ShouldThrow<ArgumentNullException>();
		}

		[Unit]
		public static void WhenRunThenFetchesDataFromRepository()
		{
			var repository = new Mock<IDataRepository>();
			new DisplayData(DefaultWriter, repository.Object).Run();
			repository.Verify(m => m.Fetch(), Times.Once);
		}

		[Unit]
		public static void WhenDataFetchedThenWritesEachLine()
		{
			var data = new List<string> { Guid.NewGuid().ToString() };
            var repository = new Mock<IDataRepository>();
			repository.Setup(m => m.Fetch()).Returns(data);
			var writer = new Mock<TextWriter>();

			new DisplayData(writer.Object, repository.Object).Run();

			data.ForEach(x => writer.Verify(m => m.WriteLine(x), Times.Once));
		}
    }
}
