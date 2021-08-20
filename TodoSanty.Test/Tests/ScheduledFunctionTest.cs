using System;
using TodoSanty.Functions.Functions;
using TodoSanty.Test.Helpers;
using Xunit;

namespace TodoSanty.Test.Tests
{
    public class ScheduledFunctionTest
    {
        [Fact]
        public void ScheduledFunctionTest_Should_Log_Message()
        {
            //Arrange
            MockCloudTableTodos mockTodos = new MockCloudTableTodos(new Uri("http://127.0.0.1:10002/devstoreaccount1/reports"));
            ListLogger logger = (ListLogger)TestFactory.CreateLogger(LoggerTypes.List);
            //Act
            ScheduledFunction.Run(null, mockTodos, logger);
            string message = logger.Logs[0];
            // Assert
            Assert.Contains("Deleting completed", message);
        }
    }
}
