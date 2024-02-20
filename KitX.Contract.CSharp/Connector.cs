using KitX.Shared.WebCommand;
using System;

namespace KitX.Contract.CSharp;

public class Connector
{
    private static Connector? _instance;

    public static Connector Instance => _instance ??= new Connector();

    public Func<Command, string>? Serializer { get; set; }

    public Action<Request>? Sender { get; set; }

    public Connector SetSerializer(Func<Command, string>? func)
    {
        Serializer = func;

        return this;
    }

    public Connector SetSender(Action<Request>? sender)
    {
        Sender = sender;

        return this;
    }

    public RequestBuilder Request(string? commandRequest = null)
    {
        var builder = new RequestBuilder()
            .SetSerializer(Serializer)
            .SetSender(Sender)
            .SetCommandRequest(commandRequest)
            ;

        return builder;
    }
}
