using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace reWASDProtocol.Infrastructure.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    [Flags]
    public enum MotorMask: byte
    {
        None         = 0,
        Left         = 0b_0001,
        Right        = 0b_0010,
        LeftTrigger  = 0b_0100,
        RightTrigger = 0b_1000
    }
}
