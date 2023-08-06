using UnityEngine;

public class MoveState : State
{
    [SerializeField] private float _speed;

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Target != null)
        {
            if (Enemy.Health > 0)
            {
                transform.position = Vector2.MoveTowards(transform.position, Target.transform.position, _speed * Time.deltaTime);
            }
            else if (Enemy.Health <= 0)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y);
            }
        }
        else
        {
            _animator.Play("Celebration");
        }
    }
}
