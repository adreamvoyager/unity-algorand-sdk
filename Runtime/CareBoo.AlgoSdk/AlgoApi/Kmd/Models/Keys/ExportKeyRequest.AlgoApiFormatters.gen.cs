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
    
    
    public partial struct ExportKeyRequest
    {
        
        private static bool @__generated__IsValid = ExportKeyRequest.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.ExportKeyRequest>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.ExportKeyRequest>().Assign("address", null, (AlgoSdk.ExportKeyRequest x) => x.Address, (ref AlgoSdk.ExportKeyRequest x, AlgoSdk.Address value) => x.Address = value, false).Assign("wallet_handle_token", null, (AlgoSdk.ExportKeyRequest x) => x.WalletHandleToken, (ref AlgoSdk.ExportKeyRequest x, Unity.Collections.FixedString128Bytes value) => x.WalletHandleToken = value, false).Assign("wallet_password", null, (AlgoSdk.ExportKeyRequest x) => x.WalletPassword, (ref AlgoSdk.ExportKeyRequest x, Unity.Collections.FixedString128Bytes value) => x.WalletPassword = value, false));
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.ExportKeyRequest[]>(AlgoSdk.Formatters.ArrayFormatter<AlgoSdk.ExportKeyRequest>.Instance);
            return true;
        }
    }
}
