using AlgoSdk.Json;
using AlgoSdk.MessagePack;

namespace AlgoSdk.Formatters
{
    public sealed class HexFormatter : IAlgoApiFormatter<Hex>
    {
        public Hex Deserialize(ref JsonReader reader)
        {
            reader.ReadString(out var s).ThrowIfError(reader.Char, reader.Position);
            return Hex.FromString(s);
        }

        public Hex Deserialize(ref MessagePackReader reader)
        {
            throw new System.NotImplementedException();
        }

        public void Serialize(ref JsonWriter writer, Hex value)
        {
            writer.WriteString(value.ToString());
        }

        public void Serialize(ref MessagePackWriter writer, Hex value)
        {
            throw new System.NotImplementedException();
        }
    }
}
