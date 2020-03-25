﻿using System;
using System.Threading.Tasks;
using Falcon.Numerics;
using Lykke.Service.PrivateBlockchainFacade.Contract.Operations;
using Lykke.Service.PrivateBlockchainFacade.Domain.Features.Fees;
using Lykke.Service.PrivateBlockchainFacade.Domain.Features.Operations;
using Lykke.Service.QuorumOperationExecutor.Client;

namespace Lykke.Service.PrivateBlockchainFacade.DomainServices.Features.Fees
{
    public class FeesService : IFeesService
    {
        private readonly IOperationRequestsProducer _operationRequestsProducer;
        private readonly IQuorumOperationExecutorClient _executorClient;

        public FeesService(IOperationRequestsProducer operationRequestsProducer, IQuorumOperationExecutorClient executorClient)
        {
            _operationRequestsProducer = operationRequestsProducer;
            _executorClient = executorClient;
        }

        public async Task<FeesError> SetTransfersToPublicFeeAsync(Money18 fee)
        {
            if (fee < 0 || fee > int.MaxValue)
                return FeesError.InvalidFee;

            await _operationRequestsProducer.AddAsync(
                OperationType.SetTransferToPublicFee,
                new SetTransfersToPublicFeeContext {Amount = fee});

            return FeesError.None;
        }

        public async Task<Money18> GetTransfersToPublicFeeAsync()
        {
            var result = await _executorClient.FeesApi.GetTransferToPublicFeeAsync();

            return result.Fee;
        }
    }
}
