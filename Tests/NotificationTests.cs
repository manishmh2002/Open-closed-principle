using Xunit;
using Open_closed_principle.Models;

namespace Open_closed_principle.Tests
{
    public class NotificationTests
    {
        [Fact]
        public void Notification_Constructor_ShouldInitializeProperties()
        {
            // Arrange
            var type = NotificationType.Email;
            var message = "Test Email";

            // Act
            var notification = new Notification(type, message);

            // Assert
            Assert.Equal(type, notification.Type);
            Assert.Equal(message, notification.Message);
        }

        [Theory]
        [InlineData(NotificationType.Email, "Test Email", "Email Notification: Test Email")]
        [InlineData(NotificationType.SMS, "Test SMS", "SMS Notification: Test SMS")]
        [InlineData(NotificationType.Push, "Test Push", "Push Notification: Test Push")]
        public void Notification_Display_ShouldPrintCorrectMessage(NotificationType type, string message, string expectedOutput)
        {
            // Arrange
            var notification = new Notification(type, message);

            // Act
            using var sw = new System.IO.StringWriter();
            Console.SetOut(sw);
            notification.Display();
            var output = sw.ToString().Trim();

            // Assert
            Assert.Equal(expectedOutput, output);
        }
    }
}
