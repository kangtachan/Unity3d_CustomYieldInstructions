using UnityEngine;

public class ExecuteForSeconds : CustomYieldInstruction
{
    System.Action<float> _apply;
    private float _timer;
    private float _duration;


    public ExecuteForSeconds(float duration, System.Action<float> apply)
    {
        Reset(duration, apply);
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

    public void Reset(float newDuration)
    {
        _duration = newDuration;
        Reset();
    }

    public void Reset(System.Action<float> newApply)
    {
        _apply = newApply;
        Reset();
    }

    public void Reset(float newDuration, System.Action<float> newApply)
    {
        _apply = newApply;
        _duration = newDuration;
        Reset();
    }
}
