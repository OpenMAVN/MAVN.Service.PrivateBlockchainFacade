﻿using System.Threading.Tasks;

namespace Lykke.Service.PrivateBlockchainFacade.Domain.Features.Operations
{
    public interface IOperationsService
    {
        Task<GenericOperationResultModel> AddGenericOperationAsync(string operationId, string encodedData,
            string sourceAddress, string targetAddress);
    }
}
