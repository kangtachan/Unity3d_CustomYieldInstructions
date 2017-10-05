using UnityEngine;

public class ExecuteForSeconds : CustomYieldInstruction
{
    System.Action<float> _apply;
    private float _timer;
    private float _duration;


    public ExecuteForSeconds(float duration, System.Action<float> apply)
    {
        _apply = apply;
        _duration = duration;
        Reset();
    }

    public override bool keepWaiting
    {
        get
        {
            _apply(Mathf.Clamp01(_timer / _duration));
            float timer = _timer;
            _timer += Time.deltaTime;

            return timer < _duration;
        }
    }

    public new void Reset()
    {
        _timer = 0;
        base.Reset();
    }
}
