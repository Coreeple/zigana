﻿using System.Text.Json.Nodes;

namespace Coreeple.Zigana.Core.Types;
public class Endpoint
{
    public Guid Id { get; set; }
    public Guid RequestId { get; set; }
    public string? Path { get; set; }
    public JsonObject Defs { get; set; } = [];
    public Request Request { get; set; } = new();
    public Dictionary<string, Action>? Actions { get; set; }
    public Dictionary<string, Response>? Responses { get; set; }
}
