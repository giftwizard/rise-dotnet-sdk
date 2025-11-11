using System;
using System.Threading.Tasks;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Rise.SDK
{
    /// <summary>
    /// Rise SDK Client - Simple unified interface for all Rise APIs
    /// 
    /// <example>
    /// Example with API Key Authentication:
    /// <code>
    /// var sdk = RiseSDKClient.WithApiKey(
    ///     token: "IST.xxx.yyy.zzz",
    ///     accountId: "your-account-id"
    /// );
    /// var giftCard = await sdk.GiftCards.GetGiftCardAsync("card-123");
    /// </code>
    /// </example>
    /// 
    /// <example>
    /// Example with OAuth Authentication:
    /// <code>
    /// var sdk = await RiseSDKClient.WithOAuthAsync(
    ///     clientId: "your-app-id",
    ///     clientSecret: "your-app-secret",
    ///     instanceId: "merchant-instance-id"
    /// );
    /// var wallets = await sdk.Wallets.QueryWalletsAsync(request);
    /// </code>
    /// </example>
    /// </summary>
    public class RiseSDKClient
    {
        private readonly Configuration _configuration;

        /// <summary>
        /// Gift Card API - Manage gift cards
        /// </summary>
        public GiftCardApi GiftCards { get; }

        /// <summary>
        /// Gift Card Order API - Manage gift card orders
        /// </summary>
        public GiftCardOrderApi GiftCardOrders { get; }

        /// <summary>
        /// OAuth API - Handle OAuth operations
        /// </summary>
        public OAuthApi OAuth { get; }

        /// <summary>
        /// Recipient API - Manage recipients
        /// </summary>
        public RecipientApi Recipients { get; }

        /// <summary>
        /// Transaction API - Manage transactions
        /// </summary>
        public TransactionApi Transactions { get; }

        /// <summary>
        /// Wallet API - Manage wallets
        /// </summary>
        public WalletApi Wallets { get; }

        /// <summary>
        /// Wallet Action API - Manage wallet actions
        /// </summary>
        public WalletActionApi WalletActions { get; }

        /// <summary>
        /// Workflows API - Manage workflows
        /// </summary>
        public WorkflowsApi Workflows { get; }

        /// <summary>
        /// Private constructor - use static factory methods instead
        /// </summary>
        /// <param name="configuration">Configured API client configuration</param>
        private RiseSDKClient(Configuration configuration)
        {
            _configuration = configuration;

            // Initialize all API clients
            GiftCards = new GiftCardApi(configuration);
            GiftCardOrders = new GiftCardOrderApi(configuration);
            OAuth = new OAuthApi(configuration);
            Recipients = new RecipientApi(configuration);
            Transactions = new TransactionApi(configuration);
            Wallets = new WalletApi(configuration);
            WalletActions = new WalletActionApi(configuration);
            Workflows = new WorkflowsApi(configuration);
        }

        /// <summary>
        /// Create Rise SDK client with API Key authentication
        /// </summary>
        /// <param name="token">Authentication token (API Key), e.g., "IST.xxx.yyy.zzz"</param>
        /// <param name="accountId">Rise account ID</param>
        /// <param name="basePath">Base URL for the Rise API (default: "https://platform.rise.ai")</param>
        /// <returns>Configured Rise SDK client instance</returns>
        public static RiseSDKClient WithApiKey(
            string token,
            string accountId,
            string basePath = "https://platform.rise.ai")
        {
            var configuration = new Configuration
            {
                BasePath = basePath
            };

            // Set authentication headers
            configuration.DefaultHeaders.Add("Authorization", $"Bearer {token}");
            configuration.DefaultHeaders.Add("rise-account-id", accountId);

            return new RiseSDKClient(configuration);
        }

        /// <summary>
        /// Create Rise SDK client with OAuth authentication
        /// 
        /// This method automatically fetches an OAuth access token using the provided credentials.
        /// The token is valid for 4 hours.
        /// </summary>
        /// <param name="clientId">OAuth client ID (App ID)</param>
        /// <param name="clientSecret">OAuth client secret (App Secret Key)</param>
        /// <param name="instanceId">OAuth instance ID (App Instance ID)</param>
        /// <param name="basePath">Base URL for the Rise API (default: "https://platform.rise.ai")</param>
        /// <returns>Task that resolves to a configured Rise SDK client instance</returns>
        public static async Task<RiseSDKClient> WithOAuthAsync(
            string clientId,
            string clientSecret,
            string instanceId,
            string basePath = "https://platform.rise.ai")
        {
            // Create temporary configuration for OAuth token request
            var tempConfiguration = new Configuration
            {
                BasePath = basePath
            };
            var oauthApi = new OAuthApi(tempConfiguration);

            // Fetch OAuth token
            var tokenRequest = new AccessTokenRequest(
                grantType: "client_credentials",
                clientId: clientId,
                clientSecret: clientSecret,
                instanceId: instanceId
            );
            var tokenResponse = await oauthApi.SomeOperationAsync(tokenRequest);

            // Create SDK with OAuth token
            var configuration = new Configuration
            {
                BasePath = basePath
            };
            configuration.DefaultHeaders.Add("Authorization", tokenResponse.AccessToken);

            return new RiseSDKClient(configuration);
        }
    }
}
