using UnityEngine;

public class WaitForNull : CustomYieldInstruction
{
    private Object _target;


    public WaitForNull(Object target)
    {
        _target = target;
    }

    public override bool keepWaiting
    {
        get
        {
            return _target != null;
        }
    }
}
