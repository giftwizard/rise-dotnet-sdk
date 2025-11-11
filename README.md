# Rise .NET SDK

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

## Reference

A full API reference for this library is available [here](./reference.md).

## Usage

The SDK supports two authentication methods: API Key and OAuth.

### API Key Authentication

```csharp
using Rise.SDK;

var sdk = RiseSDKClient.WithApiKey(
    token: "IST.xxx.yyy.zzz",
    accountId: "your-account-id"
);

// Use the SDK
var giftCard = await sdk.GiftCards.GetGiftCardAsync("card-123");
Console.WriteLine(giftCard);
```

### OAuth Authentication

```csharp
using Rise.SDK;

var sdk = await RiseSDKClient.WithOAuthAsync(
    clientId: "your-app-id",
    clientSecret: "your-app-secret",
    instanceId: "merchant-instance-id"
);

// Use the SDK
var wallets = await sdk.Wallets.QueryWalletsAsync(
    new QueryWalletsRequest
    {
        Query = new Query { Filter = "{\"email\": \"customer@example.com\"}" }
    }
);
Console.WriteLine(wallets);
```

## API Overview

The SDK provides access to the following APIs:

### Gift Cards

Manage gift cards, including creating, updating, and querying gift cards.

```csharp
// Create a gift card
var newCard = await sdk.GiftCards.CreateGiftCardAsync(
    new CreateGiftCardRequest
    {
        GiftCard = new GiftCard { InitialValue = 10000, Currency = "USD" }
    }
);

// Get a gift card
var card = await sdk.GiftCards.GetGiftCardAsync("card-123");

// Query gift cards
var cards = await sdk.GiftCards.QueryGiftCardsAsync(
    new QueryGiftCardsRequest
    {
        Query = new Query { Filter = "{\"status\": \"active\"}" }
    }
);
```

### Wallets

Manage customer wallets and their associated gift cards.

```csharp
// Create or get a wallet
var wallet = await sdk.Wallets.GetOrCreateWalletAsync(
    new GetOrCreateWalletRequest
    {
        CustomerReference = new CustomerReference { Email = "customer@example.com" }
    }
);

// Query wallets
var wallets = await sdk.Wallets.QueryWalletsAsync(
    new QueryWalletsRequest
    {
        Query = new Query { Filter = "{\"balance\": {\"$gt\": 0}}" }
    }
);
```

### Wallet Actions

Manage wallet actions such as issuing store credit, rewards, and refunds.

```csharp
// Create a wallet action
var action = await sdk.WalletActions.CreateWalletActionAsync(
    new CreateWalletActionRequest
    {
        WalletAction = new WalletAction
        {
            WalletId = "wallet-123",
            Type = WalletActionType.STORE_CREDIT,
            Amount = 5000,
            Reason = "Customer appreciation"
        }
    }
);

// Query wallet actions
var actions = await sdk.WalletActions.QueryWalletActionsAsync(
    new QueryWalletActionsRequest
    {
        Query = new Query { Filter = "{\"wallet_id\": \"wallet-123\"}" }
    }
);
```

### Orders

Manage gift card orders.

```csharp
// Create an order
var order = await sdk.GiftCardOrders.CreateOrderAsync(
    new CreateOrderRequest
    {
        Order = new Order
        {
            LineItems = new List<LineItem>
            {
                new LineItem { GiftCard = new GiftCard { InitialValue = 5000, Currency = "USD" } }
            }
        }
    }
);

// Fulfill an order
var fulfilled = await sdk.GiftCardOrders.FulfillOrderAsync(
    new FulfillOrderRequest { OrderId = "order-123" }
);
```

### Recipients

Manage gift card recipients.

```csharp
// Create a recipient
var recipient = await sdk.Recipients.CreateRecipientAsync(
    new CreateRecipientRequest
    {
        Recipient = new Recipient { Email = "recipient@example.com", Name = "John Doe" }
    }
);

// Query recipients
var recipients = await sdk.Recipients.QueryRecipientsAsync(
    new QueryRecipientsRequest
    {
        Query = new Query { Filter = "{\"email\": \"recipient@example.com\"}" }
    }
);
```

### Transactions

Query transaction history.

```csharp
// Query transactions
var transactions = await sdk.Transactions.QueryTransactionsAsync(
    new QueryTransactionsRequest
    {
        Query = new Query { Filter = "{\"gift_card_id\": \"card-123\"}" }
    }
);
```
