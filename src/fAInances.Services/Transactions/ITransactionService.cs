using fAInances.Services.Entities;
using fAInances.Services.Models;

namespace fAInances.Services.Transactions;

public interface ITransactionService
{
    /// <summary>
    /// Returns the transactions dated within the given month, newest first.
    /// </summary>
    Task<IReadOnlyList<TransactionListItem>> GetForMonthAsync(int year, int month, CancellationToken cancellationToken = default);

    Task<Transaction?> GetByIdAsync(string id, CancellationToken cancellationToken = default);

    Task<Transaction> CreateAsync(TransactionInput input, CancellationToken cancellationToken = default);

    Task<Transaction> UpdateAsync(string id, TransactionInput input, CancellationToken cancellationToken = default);

    Task DeleteAsync(string id, CancellationToken cancellationToken = default);
}
