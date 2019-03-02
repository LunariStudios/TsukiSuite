using System;

namespace Lunari.Tsuki {
    public static class Numbers {
        public static string ToHex(this float value) {
            return BitConverter.ToString(BitConverter.GetBytes(value));
        }
        
        public static string ToHex(this double value) {
            return BitConverter.ToString(BitConverter.GetBytes(value));
        }

        public static string ToHex(this int value) {
            return BitConverter.ToString(BitConverter.GetBytes(value));
        }

        public static string ToHex(this uint value) {
            return BitConverter.ToString(BitConverter.GetBytes(value));
        }

        public static string ToHex(this short value) {
            return BitConverter.ToString(BitConverter.GetBytes(value));
        }

        public static string ToHex(this ushort value) {
            return BitConverter.ToString(BitConverter.GetBytes(value));
        }

        public static string ToHex(this byte value) {
            return BitConverter.ToString(new[] {value});
        }
    }
}