# Unity3d_ExecuteForSeconds
Simple to use CustomYieldInstruction for running code while "WaitingForSeconds" in your Coroutines.


Use it inside your coroutine like this:

yield return new ExecuteForSeconds
    (
        5,
        t =>
        {
            Debug.Log("Percent of time complete: " + t.ToString());
        }
    );
    
Note: If you cache an instance of ExecuteForSeconds, be sure to call Reset() before using it again if you want to use it for the full time.
