using System;
using System.Linq;
using UnityEditor;
using UnityEngine.UIElements;

namespace Lunari.Tsuki.Editor.Elements {
    public class TypeSelector<T> : VisualElement {
        private readonly PopupField<Type> _dropdown;
        public event Action<Type> OnTypeSelected;
        public TypeSelector() {
            var types = TypeCache.GetTypesDerivedFrom<T>()
                .Where(type => !type.IsAbstract && !type.IsGenericType)
                .ToList();

            _dropdown = new PopupField<Type>() {
                choices = types,
                formatSelectedValueCallback = FormatLabel
            };
            _dropdown.RegisterValueChangedCallback(OnChanged);
            Add(_dropdown);

        }
        private void OnChanged(ChangeEvent<Type> evt) {
            var type = evt.newValue;
            if (type != null) {
                OnTypeSelected?.Invoke(type);
            }
        }
        private string FormatLabel(Type arg) {
            if (arg == null) {
                return string.Empty;
            }
            return arg.GetLegibleName();
        }

        public string title {
            get => _dropdown.label;
            set => _dropdown.label = value;
        }

    }
}