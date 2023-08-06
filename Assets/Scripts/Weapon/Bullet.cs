using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private float _speed;

    public float Speed => _speed;

    private void Update()
    {
        transform.Translate(-transform.right * _speed * Time.deltaTime, Space.World);
        Destroy(gameObject, 2f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent(out Enemy enemy))
        {
            enemy.TakeDamage(_damage);

            Destroy(gameObject);
        }

        if (collision.gameObject.TryGetComponent(out Ground ground))
        {
            Destroy(gameObject);
        }
    }
}
