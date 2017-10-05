using System;
using UnityEngine;

/// <summary>
/// Uses supplied func to return bool for "keepWaiting"
/// </summary>
public class WaitForFunc : CustomYieldInstruction
{
    private Func<bool> _keepWaitingFunc;


    public WaitForFunc(Func<bool> keepWaitingFunc)
    {
        _keepWaitingFunc = keepWaitingFunc;
    }

    public override bool keepWaiting
    {
        get
        {
            return _keepWaitingFunc();
        }
    }
}

/// <summary>
/// Uses supplied func to return bool for "keepWaiting"
/// </summary>
/// <typeparam name="T"></typeparam>
public class WaitForFunc<T> : CustomYieldInstruction
{
    private Func<T, bool> _keepWaitingFunc;
    private Func<T> _tFunc;


    public WaitForFunc(Func<T, bool> keepWaitingFunc, Func<T> tFunc)
    {
        _keepWaitingFunc = keepWaitingFunc;
        _tFunc = tFunc;
    }

    public override bool keepWaiting
    {
        get
        {
            return _keepWaitingFunc(_tFunc());
        }
    }
}

/// <summary>
/// Uses supplied func to return bool for "keepWaiting"
/// </summary>
/// <typeparam name="T"></typeparam>
/// <typeparam name="U"></typeparam>
public class WaitForFunc<T, U> : CustomYieldInstruction
{
    private Func<T, U, bool> _keepWaitingFunc;
    private Func<T> _tFunc;
    private Func<U> _uFunc;


    public WaitForFunc(Func<T, U, bool> keepWaitingFunc, Func<T> tFunc, Func<U> uFunc)
    {
        _keepWaitingFunc = keepWaitingFunc;
        _tFunc = tFunc;
        _uFunc = uFunc;
    }

    public override bool keepWaiting
    {
        get
        {
            return _keepWaitingFunc(_tFunc(), _uFunc());
        }
    }
}

/// <summary>
/// Uses supplied func to return bool for "keepWaiting"
/// </summary>
/// <typeparam name="T"></typeparam>
/// <typeparam name="U"></typeparam>
/// <typeparam name="V"></typeparam>
public class WaitForFunc<T, U, V> : CustomYieldInstruction
{
    private Func<T, U, V, bool> _keepWaitingFunc;
    private Func<T> _tFunc;
    private Func<U> _uFunc;
    private Func<V> _vFunc;


    public WaitForFunc(Func<T, U, V, bool> keepWaitingFunc, Func<T> tFunc, Func<U> uFunc, Func<V> vFunc)
    {
        _keepWaitingFunc = keepWaitingFunc;
        _tFunc = tFunc;
        _uFunc = uFunc;
        _vFunc = vFunc;
    }

    public override bool keepWaiting
    {
        get
        {
            return _keepWaitingFunc(_tFunc(), _uFunc(), _vFunc());
        }
    }
}
