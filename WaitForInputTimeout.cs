using UnityEngine;

public class WaitForInputTimeout : CustomYieldInstruction
{
    public bool ReceivedInput { get; set; }
    private float _targetTime;
    private float _seconds;


    public WaitForInputTimeout(float seconds)
    {
        _seconds = seconds;
        Reset();
    }

    public override bool keepWaiting
    {
        get
        {
            if (InputX.AnyInput())
            {
                ReceivedInput = true;
                return false;
            }

            return _targetTime > Time.time;
        }
    }

    public new void Reset()
    {
        ReceivedInput = false;
        _targetTime = Time.time + _seconds;
        base.Reset();
    }
}
