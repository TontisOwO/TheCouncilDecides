using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    Animator animator;
    void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if(animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.95 && !animator.IsInTransition(0))
        {
            Destroy(gameObject);
        }
    }
}
