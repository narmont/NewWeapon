using UnityEngine;

public abstract class Transition : MonoBehaviour
{
    [SerializeField] private State _targetState;

    protected Player Target { get; private set; }
    protected Enemy Enemy { get; private set; }
    public State TargetState => _targetState;

    public bool NeedTransit { get; protected set; }

    private void Start()
    {
        Enemy = GetComponent<Enemy>();
    }

    public void Init(Player target)
    {
        Target = target;
    }

    private void OnEnable()
    {
        NeedTransit = false;
    }
}
