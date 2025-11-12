# Rise .NET SDK

[![NuGet version](https://badge.fury.io/nu/Rise.SDK.svg)](https://www.nuget.org/packages/Rise.SDK)

The Rise .NET SDK provides convenient access to the Rise Platform API from .NET applications.

## Installation

### Package Manager

```
Install-Package Rise.SDK
```

### .NET CLI

```bash
dotnet add package Rise.SDK
```

## Prerequisites


Before using the Rise .NET SDK, ensure you have the following:

#### Choosing an Authentication Method

- Use API keys for server-side applications and scripts that require direct access to your Rise account.
- Use OAuth for applications that need to integrate with multiple merchant accounts or require delegated access.

### Authentication


The SDK supports two authentication methods:

#### API Key Authentication
- **API Key** - A valid API key from your Rise account
- **Account ID** - Your Rise account identifier

#### OAuth Authentication
- **Client ID** - Your application's client ID (also known as App ID)
- **Client Secret** - Your application's client secret
- **Instance ID** - The merchant's instance ID (obtained during app installation)
- OAuth tokens are valid for 4 hours and automatically refresh
- Requires completing the [app installation flow](https://platform.rise.ai/docs#tag/Integrate-your-application-with-Rise/App-Installation-Flow/Step-2-or-Handle-installation-authentication-in-your-app)

For more information on OAuth authentication and the app installation flow, see the [Rise Platform Documentation](https://platform.rise.ai/docs#tag/Integrate-your-application-with-Rise/App-Installation-Flow/Step-2-or-Handle-installation-authentication-in-your-app).

## Reference

A full API reference for this library is available [here](./reference.md).

## Usage

### API Key Authentication

```csharp
using Rise.SDK;

var sdk = RiseSDKClient.WithApiKey(
    token: "IST.xxx.yyy.zzz",
    accountId: "your-account-id"
);
```

### OAuth Authentication

OAuth tokens are valid for 4 hours.

```csharp
using Rise.SDK;

var sdk = await RiseSDKClient.WithOAuthAsync(
    clientId: "your-app-id",
    clientSecret: "your-app-secret",
    instanceId: "instance-id"
);
```

## API Overview

The SDK provides access to the following APIs:


### Gift Cards

Manage gift cards, including creating, retrieving, and querying gift cards.

```csharp
var newCard = await sdk.GiftCards.CreateGiftCardAsync(
    new CreateGiftCardRequest
    {
        GiftCard = new GiftCard
        {
            InitialValue = "100",
            SourceInfo = new SourceInfo
            {
                Type = "MANUAL",
                ManualOptions = new ManualOptions
                {
                    Note = "new gift card"
                }
            }
        }
    }
);

var newGeneratedGiftcardID = newCard.Data.GiftCard?.Id;

var newGeneratedGiftcard = await sdk.GiftCards.GetGiftCardAsync(newGeneratedGiftcardID);

var cards = await sdk.GiftCards.QueryGiftCardsAsync(
    new QueryGiftCardsRequest
    {
        Query = new Query
        {
            CursorPaging = new CursorPaging
            {
                Limit = 10
            }
        }
    }
);
```

### Wallets

Manage customer wallets and their associated gift cards.

```csharp
var wallet = await sdk.Wallets.GetOrCreateWalletAsync(
    new GetOrCreateWalletRequest
    {
        CustomerReference = new CustomerReference
        {
            Email = "customer@example.com",
            SourceChannelId = "channel-id",
            SourceTenantId = "tenant-id",
            SourceCustomerId = "customer-id"
        }
    }
);

var wallets = await sdk.Wallets.QueryWalletsAsync(
    new QueryWalletsRequest
    {
        Query = new Query
        {
            Paging = new Paging
            {
                Limit = 10
            }
        }
    }
);
```

### Wallet Actions

Manage wallet actions such as issuing store credit, rewards, and refunds.

```csharp
var action = await sdk.WalletActions.CreateWalletActionAsync(
    new CreateWalletActionRequest
    {
        WalletAction = new WalletAction
        {
            WalletId = "wallet-id",
            Amount = "5000",
            Type = "REWARD",
            StoreCreditContext = new StoreCreditContext
            {
                SourceChannelId = "channel-id",
                SourceTenantId = "tenant-id"
            }
        }
    }
);

var actions = await sdk.WalletActions.QueryWalletActionsAsync(
    new QueryWalletActionsRequest
    {
        Query = new Query
        {
            Paging = new Paging
            {
                Limit = 10
            }
        }
    }
);
```

### Recipients

Manage gift card recipients.

```csharp
var recipient = await sdk.Recipients.CreateRecipientAsync(
    new CreateRecipientRequest
    {
        Recipient = new Recipient
        {
            Email = "recipient@example.com",
            Name = "John Doe",
            GiftCardId = "giftcard-id"
        }
    }
);

var recipients = await sdk.Recipients.QueryRecipientsAsync(
    new QueryRecipientsRequest
    {
        Query = new Query
        {
            CursorPaging = new CursorPaging
            {
                Limit = 5
            }
        }
    }
);
```

### Transactions

Query transaction history.

```csharp
var transactions = await sdk.Transactions.QueryTransactionsAsync(
    new QueryTransactionsRequest
    {
        Query = new Query
        {
            CursorPaging = new CursorPaging
            {
                Limit = 5
            }
        }
    }
);
```