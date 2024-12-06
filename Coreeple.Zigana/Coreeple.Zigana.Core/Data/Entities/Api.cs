﻿namespace Coreeple.Zigana.Core.Data.Entities;
public class Api
{
    public Guid Id { get; set; }
    public required string Path { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Definitions { get; set; }
}