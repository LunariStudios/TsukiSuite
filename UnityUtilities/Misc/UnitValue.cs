using System;
using UnityEngine;

namespace UnityUtilities.Misc {
    [Serializable]
    public struct UnitValue {
        public static readonly UnitValue One = new UnitValue(1);
        public static readonly UnitValue Zero = new UnitValue(0);
        public static readonly UnitValue MinusOne = new UnitValue(-1);

        [SerializeField]
        private sbyte value;

        private UnitValue(sbyte value) {
            this.value = value;
        }

        public static implicit operator UnitValue(int i) {
            if (i > 0) {
                return One;
            }

            return i < 0 ? MinusOne : Zero;
        }

        public static implicit operator UnitValue(float f) {
            if (f > 0) {
                return One;
            }

            return f < 0 ? MinusOne : Zero;
        }

        public static UnitValue FromFloat(float val, float limit = 0) {
            if (val > limit) {
                return One;
            }

            return val < -limit ? MinusOne : Zero;
        }

        public static implicit operator sbyte(UnitValue val) {
            return val.value;
        }
    }
}