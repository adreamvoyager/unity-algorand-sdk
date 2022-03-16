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
    
    
    public partial struct AssetFreezeTxn
    {
        
        private static bool @__generated__IsValid = AssetFreezeTxn.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.AssetFreezeTxn>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.AssetFreezeTxn>().Assign("fee", "fee", (AlgoSdk.AssetFreezeTxn x) => x.Fee, (ref AlgoSdk.AssetFreezeTxn x, System.UInt64 value) => x.Fee = value, false).Assign("first-valid", "fv", (AlgoSdk.AssetFreezeTxn x) => x.FirstValidRound, (ref AlgoSdk.AssetFreezeTxn x, System.UInt64 value) => x.FirstValidRound = value, false).Assign("genesis-hash", "gh", (AlgoSdk.AssetFreezeTxn x) => x.GenesisHash, (ref AlgoSdk.AssetFreezeTxn x, AlgoSdk.GenesisHash value) => x.GenesisHash = value, false).Assign("last-valid", "lv", (AlgoSdk.AssetFreezeTxn x) => x.LastValidRound, (ref AlgoSdk.AssetFreezeTxn x, System.UInt64 value) => x.LastValidRound = value, false).Assign("sender", "snd", (AlgoSdk.AssetFreezeTxn x) => x.Sender, (ref AlgoSdk.AssetFreezeTxn x, AlgoSdk.Address value) => x.Sender = value, false).Assign("tx-type", "type", (AlgoSdk.AssetFreezeTxn x) => x.TransactionType, (ref AlgoSdk.AssetFreezeTxn x, AlgoSdk.TransactionType value) => x.TransactionType = value, AlgoSdk.ByteEnumComparer<AlgoSdk.TransactionType>.Instance, false).Assign("genesis-id", "gen", (AlgoSdk.AssetFreezeTxn x) => x.GenesisId, (ref AlgoSdk.AssetFreezeTxn x, Unity.Collections.FixedString32Bytes value) => x.GenesisId = value, false).Assign("group", "grp", (AlgoSdk.AssetFreezeTxn x) => x.Group, (ref AlgoSdk.AssetFreezeTxn x, AlgoSdk.Crypto.Sha512_256_Hash value) => x.Group = value, false).Assign("lease", "lx", (AlgoSdk.AssetFreezeTxn x) => x.Lease, (ref AlgoSdk.AssetFreezeTxn x, AlgoSdk.Crypto.Sha512_256_Hash value) => x.Lease = value, false).Assign("note", "note", (AlgoSdk.AssetFreezeTxn x) => x.Note, (ref AlgoSdk.AssetFreezeTxn x, System.Byte[] value) => x.Note = value, AlgoSdk.ArrayComparer<byte>.Instance, false).Assign("rekey-to", "rekey", (AlgoSdk.AssetFreezeTxn x) => x.RekeyTo, (ref AlgoSdk.AssetFreezeTxn x, AlgoSdk.Address value) => x.RekeyTo = value, false).Assign(null, "fadd", (AlgoSdk.AssetFreezeTxn x) => x.FreezeAccount, (ref AlgoSdk.AssetFreezeTxn x, AlgoSdk.Address value) => x.FreezeAccount = value, false).Assign(null, "faid", (AlgoSdk.AssetFreezeTxn x) => x.FreezeAsset, (ref AlgoSdk.AssetFreezeTxn x, System.UInt64 value) => x.FreezeAsset = value, false).Assign(null, "afrz", (AlgoSdk.AssetFreezeTxn x) => x.AssetFrozen, (ref AlgoSdk.AssetFreezeTxn x, AlgoSdk.Optional<System.Boolean> value) => x.AssetFrozen = value, false));
            return true;
        }
        
        public partial struct Params
        {
            
            private static bool @__generated__IsValid = Params.@__generated__InitializeAlgoApiFormatters();
            
            private static bool @__generated__InitializeAlgoApiFormatters()
            {
                AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.AssetFreezeTxn.Params>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.AssetFreezeTxn.Params>().Assign("address", "fadd", (AlgoSdk.AssetFreezeTxn.Params x) => x.FreezeAccount, (ref AlgoSdk.AssetFreezeTxn.Params x, AlgoSdk.Address value) => x.FreezeAccount = value, false).Assign("asset-id", "faid", (AlgoSdk.AssetFreezeTxn.Params x) => x.FreezeAsset, (ref AlgoSdk.AssetFreezeTxn.Params x, System.UInt64 value) => x.FreezeAsset = value, false).Assign("new-freeze-status", "afrz", (AlgoSdk.AssetFreezeTxn.Params x) => x.AssetFrozen, (ref AlgoSdk.AssetFreezeTxn.Params x, AlgoSdk.Optional<System.Boolean> value) => x.AssetFrozen = value, false));
                return true;
            }
        }
    }
}
