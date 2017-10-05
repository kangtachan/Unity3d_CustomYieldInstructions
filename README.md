# ExecuteForSeconds
Execute code while yielding in the same way as WaitForSeconds().

Usage:
```
yield return new ExecuteForSeconds
    (
	10,
	t =>
	{
	    Debug.Log("Percent of time complete: " + t.ToString());
	}
    );
```

_Note: If you cache an instance of ExecuteForSeconds you'll likely need to call Reset() before using it again._


# WaitForFunc
Yield until supplied Func returns false.

Usage:
```
yield return new WaitForFunc
            (
                () => { return Time.timeSinceLevelLoad > 10; }
            );
```


# WaitForInputTimeout
Yield for supplied time, returning early if any input is received.

Usage:
```
yield return new WaitForInputTimeout(10);
```

_Note: If you cache an instance of WaitForInputTimeout you'll likely need to call Reset() before using it again._


# WaitForNull
Yield until supplied Object becomes null.

Usage:
```
yield return new WaitForNull(_myObject);
```


# WaitForNotNull
Yield until supplied Object is no longer null.

Usage:
```
yield return new WaitForNotNull(_myObject);
```
