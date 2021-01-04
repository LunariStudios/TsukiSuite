using System;
using UnityEngine;
using UnityEngine.Events;
namespace Lunari.Tsuki.Entities.Common {
    [Serializable]
    public sealed class HealthChangeEvent : UnityEvent<uint> { }

    [Serializable]
    public sealed class DeathEvent : UnityEvent { }

    public delegate void DamageModifier(DamageEvent damage);


    [TraitLocation(TraitLocations.Combat)]
    public class Living : Trait {
        public const string StatsGroup = "Stats";
        public const string ExtrasGroup = "Extras";
        public const string EventsGroup = "Events";
        public const string FunctionsGroup = "Functions";

        [SerializeField, HideInInspector]
        private uint health, maxHealth;

        public event DamageModifier onPreDamage, onPostDamage;
#if ODIN_INSPECTOR
        [FoldoutGroup(EventsGroup, order: 5)]
#endif
        public HealthChangeEvent onHealthChanged;
#if ODIN_INSPECTOR
        [FoldoutGroup(EventsGroup)]
#endif
        public DeathEvent onDeath;
#if ODIN_INSPECTOR
        [BoxGroup(ExtrasGroup)]
#endif
        public float damageCooldown;
#if ODIN_INSPECTOR
        [ShowInInspector, BoxGroup(StatsGroup)]
#endif

        public uint Health {
            get => health;
            private set {
                var newValue = Math.Min(value, maxHealth);
                health = newValue;
            }
        }
#if ODIN_INSPECTOR
        [FoldoutGroup(FunctionsGroup)]
#endif
        public DamageEvent Damage(Damage damage) {
            var e = new DamageEvent(damage, this);
            onPreDamage?.Invoke(e);

            var value = e.Value;
            if (value == 0) {
                return e;
            }

            if (CurrentDamageCooldown > 0) {
                return e;
            }

            if (value >= health) {
                onHealthChanged.Invoke(0);
                Kill();
            } else {
                onHealthChanged.Invoke(health - value);
                health -= value;
            }

            onPostDamage?.Invoke(e);
            CurrentDamageCooldown = damageCooldown;
            return e;
        }
#if ODIN_INSPECTOR
        [FoldoutGroup(FunctionsGroup)]
#endif
        public void Kill() {
            onDeath.Invoke();
            health = 0;
            Owner.Aware = false;
        }
#if ODIN_INSPECTOR
        [ShowInInspector, BoxGroup(StatsGroup, order: 0)]
#endif
        public uint MaxHealth {
            get => maxHealth;
            set {
                if (value < health) {
                    health = value;
                }

                maxHealth = value;
            }
        }

        public float CurrentDamageCooldown { get; private set; }

        public bool Dead => health == 0;

        private void Update() {
            if (CurrentDamageCooldown > 0) {
                CurrentDamageCooldown -= Time.deltaTime;
            }
        }

        public void Heal(uint healAmount) {
            var newHealth = Math.Min(health + healAmount, maxHealth);
            onHealthChanged.Invoke(newHealth);
            health = newHealth;
        }
    }
    [Serializable]
    public class UnityDamageEvent : UnityEvent<DamageEvent> { }

    [Serializable]
    public class DamageEvent {

        public uint HealthAfter => Math.Max(0, Target.Health - Value);

        public uint Value { get; set; }

        public DamageEvent(Damage damage, Living target) {
            this.Damage = damage;
            this.Target = target;
            Value = damage.Original;
        }

        public Damage Damage {
            get;
        }

        public Living Target {
            get;
        }

    }

    [Serializable]
    public struct Damage {
        [SerializeReference]
        private IDamageSource source;

        [SerializeField]
        private uint original;

        public IDamageSource Source => source;

        public uint Original => original;

        public Damage(
            IDamageSource source,
            uint amount
        ) {
            this.source = source;
            original = amount;
        }
    }

    public interface IDamageSource { }
}