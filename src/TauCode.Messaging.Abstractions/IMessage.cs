namespace TauCode.Messaging;

public interface IMessage
{
    string? CorrelationId { get; set; }
    DateTimeOffset CreatedAt { get; set; }
}