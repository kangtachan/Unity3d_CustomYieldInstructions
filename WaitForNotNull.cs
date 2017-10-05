using UnityEngine;

public class WaitForNotNull : CustomYieldInstruction
{
    private Object _target;


    public WaitForNotNull(Object target)
    {
        _target = target;
    }

    public override bool keepWaiting
    {
        get
        {
            return _target == null;
        }
    }
}
