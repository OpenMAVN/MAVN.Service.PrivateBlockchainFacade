﻿namespace Lykke.Service.PrivateBlockchainFacade.Domain.Features.Balances
{
    public enum CustomerBalanceError
    {
        None,
        CustomerWalletMissing,
        InvalidCustomerId,
        InvalidAmount
    }
}
