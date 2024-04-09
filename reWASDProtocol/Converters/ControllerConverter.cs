using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using reWASDProtocol.DataTransferObjects.Controllers;

namespace reWASDProtocol.Converters
{
    public class ControllerConverter : JsonConverter
    {
        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;

            var item = JObject.Load(reader);
            var type = item["DataType"]?.Value<string>();

            BaseControllerDto device;
            switch (type)
            {
                case "Controller":
                    device = new ControllerDto();
                    break;
                case "PeripheralController":
                    device = new PeripheralControllerDto();
                    break;
                case "CompositeController":
                    device = new CompositeControllerDto();
                    break;
                default:
                    return null;
            }

            serializer.Populate(item.CreateReader(), device);
            return device;
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value is null)
                return;

            var o = JObject.FromObject(value);
            o.WriteTo(writer);
        }
        public override bool CanConvert(Type objectType)
        {
            return typeof(BaseControllerDto).IsAssignableFrom(objectType);
        }
    }
}
