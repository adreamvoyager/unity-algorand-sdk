//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlgoSdk
{
    
    
    public partial struct ListWalletsResponse
    {
        
        private static bool @__generated__IsValid = ListWalletsResponse.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.ListWalletsResponse>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.ListWalletsResponse>().Assign("error", null, (AlgoSdk.ListWalletsResponse x) => x.Error, (ref AlgoSdk.ListWalletsResponse x, AlgoSdk.Optional<System.Boolean> value) => x.Error = value, false).Assign("message", null, (AlgoSdk.ListWalletsResponse x) => x.Message, (ref AlgoSdk.ListWalletsResponse x, System.String value) => x.Message = value, AlgoSdk.StringComparer.Instance, false).Assign("wallets", null, (AlgoSdk.ListWalletsResponse x) => x.Wallets, (ref AlgoSdk.ListWalletsResponse x, AlgoSdk.Wallet[] value) => x.Wallets = value, AlgoSdk.ArrayComparer<AlgoSdk.Wallet>.Instance, false));
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.ListWalletsResponse[]>(AlgoSdk.Formatters.ArrayFormatter<AlgoSdk.ListWalletsResponse>.Instance);
            return true;
        }
    }
}
