using UnityEngine;
namespace Project_Edge.AgentSytstem
{
    [RequireComponent(typeof(Animator))]
    public class AgentRenderer : MonoBehaviour
    {
        public Animator Animator { get; private set; }

        protected virtual void Awake()
        {
            Animator = GetComponent<Animator>();
            if (Animator == null)
            {
                Debug.LogError("[AgentSystem:AgentRenderer] Animator is null");
                return;
            }

        }
        
        
    }
}