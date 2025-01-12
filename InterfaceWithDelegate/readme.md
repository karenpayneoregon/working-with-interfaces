# Overview
The project demonstrates the use of `interfaces` and `delegates` to create flexible and reusable components in software development.
## Features
- Implements interfaces for abstraction and modularity.
- Utilizes delegates for event-driven programming and callback mechanisms.
- Written in modern **C# 13.0** with best practices.
- Compatible with `.NET 9.0`.

## Explanation 


The `Program` class subscribes to the `Started` and `StatusUpdated` events of the `ExampleClass` instance:
- The `+=` operator is used to attach event handlers to the events.
- Example:
  ```csharp
  ExampleClass.Started += OnStarted;
  ExampleClass.StatusUpdated += OnStatusUpdated;
  ```
  - The `-=` operator is used to detach event handlers from the events.
  - The `OnStarted` and `OnStatusUpdated` methods are called when the `Started` and `StatusUpdated` events are raised, respectively.

  ## Notes

  AI was used as noted below.

  Rather than figuring out a example for delegate
  
  - Did a search and used [the following](https://stackoverflow.com/a/3948742/5509738).
  - Used ChatGPT to write [example usage](https://chatgpt.com/share/6776953f-4870-8012-903e-8f14bee698bf).
  Used ChatGPT to write top section of this file and Jetbrains AI Assistant to write the rest of the file other than the `Notes` section.
  - Used Jetbrains AI Assistant to write code documentation.