﻿using Dapper;

namespace Coreeple.Zigana.Core.Data.Repositories;

public class EndpointTransactionRepository(IDapperContext context) : IEndpointTransactionRepository
{
    public async Task AddAsync(Guid id, Guid endpointId, Guid requestId,
        string type, string name, DateTime date, string status,
        CancellationToken cancellationToken = default)
    {
        using var connection = context.CreateConnection();

        var sql = """
            INSERT INTO "EndpointTransactions" ("Id", "EndpointId", "RequestId", "Type", "Name", "Date", "Status")
            VALUES (@Id, @EndpointId, @RequestId, @Type, @Name, @Date, @Status)
        """;

        var result = await connection
            .ExecuteAsync(new CommandDefinition(sql, new
            {
                Id = id,
                EndpointId = endpointId,
                RequestId = requestId,
                Type = type,
                Name = name,
                Date = date,
                Status = status
            }, cancellationToken: cancellationToken));
    }
}

public interface IEndpointTransactionRepository
{
    Task AddAsync(Guid id, Guid endpointId, Guid requestId,
        string type, string name, DateTime date, string status,
        CancellationToken cancellationToken = default);
}