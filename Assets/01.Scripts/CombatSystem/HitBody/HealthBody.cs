using System;
using UnityEngine;
using UnityEngine.Events;
namespace Project_Edge.CombatSystem
{

    public class HealthBody : MonoBehaviour, IDamageable
    {
        public UnityEvent OnDieEvent;
        public Action<float, float> OnHealthDecreaseEvent;
        public Action<float, float> OnHealthIncreaseEvent;
        private float _currentHealth;
        private float _maxHealth;
        protected bool _isDead;

        #region Properties
        public float CurrentHealth => _currentHealth;
        public float MaxHealth => _maxHealth;
        public bool IsDead => _isDead;

        #endregion

        public virtual DamageResponse ApplyDamage(DamageData damageData)
        {
            if (_isDead) return new DamageResponse() { isHit = false };

            //if(damageData.isCritical)
            _currentHealth -= damageData.damage;
            OnHealthDecreaseEvent?.Invoke(_currentHealth, _maxHealth);
            HandleHealthValueChange();

            return new DamageResponse()
            {
                isHit = true
            };
        }

        private void HandleHealthValueChange()
        {
            if (_isDead) return;

            if (_currentHealth < 0)
            {
                HandleDie();
            }
        }

        private void HandleDie()
        {
            OnDieEvent?.Invoke();
            _isDead = true;
        }

    }
}