using UnityEngine;
namespace Project_Edge.CombatSystem
{
    
    public interface IDamageable
    {
        public DamageResponse ApplyDamage(DamageData damageData);
    }
}