#  Extra exercise Delegates

We’re going to create an application for marathon organizers to help them managing these large events. When a marathon runner crosses the finish line, all kinds of actions need to be taken: their time has to be registered, they have to go to doping control for drug testing, and of course prizes should be given to the first, second and third finisher.

The solution [ExtraDelegatesAndGeneric](../ExtraDelegatesAndGenerics) can be downloaded as a template solution.

We will use the C# `EventHandler` delegate to link the necessary actions that need to be done when a runner finishes the marathon. 
First, we need a class that extends `EventArgs` to provide the information needed for a finisher. Complete the class `RunnerInfo` by adding properties for the runners name and rank.
Next, complete the classes `DopingControl`, `Administration` and `Prices` by implementing the following methods:
*	`RegisterTime(..)` in `Admin` that prints a message that runner X has finished as the 1st/2nd/3rd etc.
* `SendToDopingControl(..)` in `DopingControl` that print a message calling runner X to doping control.
*	`AwardPrice(..)` in `Prices` that gives the 1st runner $15.000, the 2nd $10.000 and the 3rd $5000. 

We can now complete the `Marathon` class by adding an EventHandler property with the appropriate type. Create a public method `Finished` that creates and passes the EventArgs object,  and a private `onFinished` method that triggers the delegate.

In `Main` we create the necessary objects and link the actions to the event handler. Then we simulate the marathon by shuffling a list of runners and registering their arrival at the finish. 

The result should like the image below:

![screenshot](https://github.com/Windesheim-HBO-ICT/CS1/blob/master/ExtraDelegatesAndGenerics/screenshot.png "screenshot")
