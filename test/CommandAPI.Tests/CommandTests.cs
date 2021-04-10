using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CommandAPI.Models;

namespace CommandAPI.Tests
{
    public class CommandTests : IDisposable
    {
        Command testCommand;

        public CommandTests()
        {
            //Arrange
            testCommand = new Command
            {
                HowTo = "Do something awesome",
                Platform = "Some platform",
                CommandLine = "some commandLine"
            };
        }
        [Fact]
        public void CanChangeHowTo()
        {

            //Act
            testCommand.HowTo = "Execute Unit Test";

            //Assert
            Assert.Equal("Execute Unit Test", testCommand.HowTo);
        }

        [Fact]
        public void CanChangePlatform()
        {
            //Arrange
            //Act
            testCommand.Platform = "xUnit";
            //Assert
            Assert.Equal("xUnit", testCommand.Platform);
        }

        [Fact]
        public void CanChangeCommandLine()
        {
            //Arrange
            //Act
            testCommand.CommandLine = "dotnet test";
            //Assert
            Assert.Equal("dotnet test", testCommand.CommandLine);
        }

        public void Dispose()
        {
            testCommand = null;
        }
    }
}
