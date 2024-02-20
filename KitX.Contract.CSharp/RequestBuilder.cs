using KitX.Shared.WebCommand;
using KitX.Shared.WebCommand.Infos;
using System;

namespace KitX.Contract.CSharp;

public class RequestBuilder
{
    private Request _request = new();

    private Command _command = new();

    private Func<Command, string>? _serializer;

    public Func<Command, string>? Serializer { set => _serializer = value; }

    public Action<Request>? Sender { get; set; }

    public RequestBuilder()
    {

    }

    public RequestBuilder SetSerializer(Func<Command, string>? func)
    {
        Serializer = func;

        return this;
    }

    public RequestBuilder SetSender(Action<Request>? sender)
    {
        Sender = sender;

        return this;
    }

    public RequestBuilder SetCommandRequest(string? command)
    {
        _command.Request = command ?? string.Empty;

        return this;
    }

    public RequestBuilder UpdateRequest(Func<Request, Request> updater)
    {
        _request = updater.Invoke(_request);

        return this;
    }

    public RequestBuilder UpdateCommand(Func<Command, Command> updater)
    {
        _command = updater.Invoke(_command);

        return this;
    }

    private Request Build()
    {
        _request.Content = _serializer?.Invoke(_command) ?? throw new ArgumentNullException(nameof(Serializer));

        return _request;
    }

    public RequestBuilder Send()
    {
        if (Sender is null) throw new ArgumentNullException(nameof(Sender));

        Sender?.Invoke(Build());

        return this;
    }
}

public static class RequestBuilderExtensions
{
    public static RequestBuilder RegisterPlugin(this RequestBuilder builder, byte[] body, int length)
    {
        builder = builder.UpdateCommand(cmd =>
        {
            cmd.Request = CommandRequestInfo.RegisterPlugin;

            cmd.Body = body;

            cmd.BodyLength = length;

            return cmd;
        });

        return builder;
    }

    public static RequestBuilder RequestWorkingDetail(this RequestBuilder builder)
    {
        builder = builder.UpdateCommand(cmd =>
        {
            cmd.Request = CommandRequestInfo.RequestWorkingDetail;

            return cmd;
        });

        return builder;
    }

    public static RequestBuilder ReportStatus(this RequestBuilder builder)
    {
        builder = builder.UpdateCommand(cmd =>
        {
            cmd.Request = CommandRequestInfo.ReportStatus;

            return cmd;
        });

        return builder;
    }

    public static RequestBuilder RequestCommand(this RequestBuilder builder)
    {
        builder = builder.UpdateCommand(cmd =>
        {
            cmd.Request = CommandRequestInfo.RequestCommand;

            return cmd;
        });

        return builder;
    }
}
