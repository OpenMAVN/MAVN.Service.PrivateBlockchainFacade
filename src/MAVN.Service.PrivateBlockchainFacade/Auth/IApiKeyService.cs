namespace MAVN.Service.PrivateBlockchainFacade.Auth
{
    public interface IApiKeyService
    {
        bool ValidateKey(string apiKey);
    }
}
