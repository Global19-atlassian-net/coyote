---
layout: reference
section: learn
title: WhenAnyTaskCompletesInProductionAsync
permalink: /learn/ref/Microsoft.Coyote.Tasks/ControlledTask/WhenAnyTaskCompletesInProductionAsync
---
# ControlledTask.WhenAnyTaskCompletesInProductionAsync&lt;TResult&gt; method

Creates a [`ControlledTask`](../ControlledTaskType) that will complete when any task in the specified enumerable collection have completed.

```csharp
public static ControlledTask<ControlledTask<TResult>> 
    WhenAnyTaskCompletesInProductionAsync<TResult>(IEnumerable<ControlledTask<TResult>> tasks)
```

| parameter | description |
| --- | --- |
| tasks | The tasks to wait for completion. |

## See Also

* class [ControlledTask&lt;TResult&gt;](../ControlledTask-1Type)
* class [ControlledTask](../ControlledTaskType)
* namespace [Microsoft.Coyote.Tasks](../ControlledTaskType)
* assembly [Microsoft.Coyote](../../MicrosoftCoyoteAssembly)

<!-- DO NOT EDIT: generated by xmldocmd for Microsoft.Coyote.dll -->