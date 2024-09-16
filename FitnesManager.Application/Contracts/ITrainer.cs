using FitnesManager.Application.Response;
using FitnesManager.Domain.Entities;

namespace FitnesManager.Application.Contracts
{
    public interface ITrainer
    {
        Task<ControllerResponse> InsertAsync(Trainer trainer);
        Task<ControllerResponse> UpdateAsync(Trainer trainer);
        Task<ControllerResponse> DeleteAsync(Trainer trainer);
        Task<List<Trainer>> SelectAllAsync();
    }
}
