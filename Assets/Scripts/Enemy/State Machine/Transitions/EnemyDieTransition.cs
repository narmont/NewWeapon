public class EnemyDieTransition : Transition
{
    private void Update()
    {
        if (Enemy.Health <= 0)
        {
            NeedTransit = true;
        }
    }
}
