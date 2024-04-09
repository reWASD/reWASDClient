using reWASDProtocol.Infrastructure.Enums;

namespace reWASDProtocol.DataTransferObjects
{
    public class VibrationInfo
    {
        public Guid GamepadGuid { get; init; }
        public MotorMask Motors { get; init; }
        public ushort Duration { get; init; }
        public byte Intensity { get; init; }
    }
}
