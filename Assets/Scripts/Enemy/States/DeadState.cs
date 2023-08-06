using System.Collections;
using UnityEngine;

public class DeadState : State
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
       _animator.Play("Die");
       StartCoroutine(WaitAnimationDie());
    }

    private void OnDisable()
    {
        _animator.StopPlayback();
    }

    private IEnumerator WaitAnimationDie()
    {
        float delay = 3f;

        WaitForSeconds timeAnimationDie = new WaitForSeconds(delay);

        yield return timeAnimationDie;

        Destroy(gameObject);        
    }
}
