﻿using Coreeple.Zigana.Core.Types;
using System.Text.Json.Nodes;

namespace Coreeple.Zigana.Core.Abstractions;
public interface IResponseBuilder
{
    Task Build(Dictionary<string, Response> response, JsonObject context);
}