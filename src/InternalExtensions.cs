using System;
using NBitcoin;
using BitcoinKey = NBitcoin.Key;
using BitcoinPubKey = NBitcoin.PubKey;

namespace BIP39Wallet
{
    internal static class InternalExtensions
    {
        public static HDKey Wrap(this ExtKey extKey)
        {
            return HDKey.From(extKey);
        }

        public static PrivateKey Wrap(this BitcoinKey bitcoinKey)
        {
            return PrivateKey.From(bitcoinKey);
        }

        public static PublicKey Wrap(this BitcoinPubKey bitcoinPubKey)
        {
            return PublicKey.From(bitcoinPubKey);
        }
    }
}