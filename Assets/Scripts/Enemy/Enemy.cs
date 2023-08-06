using System.Collections;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private int _reward;

    [SerializeField] private Player _target;

    public int Reward => _reward;
    public int Health => _health;

    public Player Target => _target;
    public event UnityAction<Enemy> Dying;

    private BoxCollider2D _boxCollider;

    private void Awake()
    {
        _boxCollider = GetComponent<BoxCollider2D>();
    }

    public void Init(Player target)
    {
        _target = target;
    }    

    public void TakeDamage(int damage)
    {
        _health -= damage;

        if(_health <= 0)
        {
            Dying?.Invoke(this);
            _boxCollider.enabled = false;
        }
    }
}
