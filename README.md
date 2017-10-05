# Unity3d_ExecuteForSeconds
Simple to use CustomYieldInstruction for running code while "WaitingForSeconds" in your Coroutines.


Use it inside your coroutine like this:
```
yield return new ExecuteForSeconds
	(
		5,
		t =>
		{
			Debug.Log("Percent of time complete: " + t.ToString());
		}
	);
```

_Note: If you cache an instance of ExecuteForSeconds you'll likely need to call Reset() (or one of its overloads) before using it again._
