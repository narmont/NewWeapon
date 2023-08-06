using UnityEngine;

public class Shotgun : Weapon
{
    [SerializeField] private float _spread;
    [SerializeField] private int _bulletCount;

    private Bullet _bullet;
    private Vector3 _angle;

    private void Start()
    {
        _bullet = Bullet;
    }

    public override void Shoot(Transform shootPoint)
    {
        _angle = new Vector3(0, 0, _spread);

        for (int i = 0; i < _bulletCount; i++)
        {
            _bullet = Instantiate(Bullet, shootPoint.position, Quaternion.Euler(_angle));
            _angle.z -= _spread;
            Destroy(_bullet.gameObject, 0.3f);
        }
    }
}
