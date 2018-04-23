# How to determine a UI command executed in RichEditControl in response to a user action  


<p>In some cases, a default command should be extended with custom logic to implement additional functionality or customize existing functionality. If so, the first part of the task is to find which command should be overridden. The easiest way to achieve the goal is to listen to which commands are executed in the RichEditControl in response to a certain action. The XtraRichEdit Suite provides the <strong>CommandExecutionListenerService </strong>service for notifications. This example demonstrates how to create a custom <strong>CommandExecutionListenerService </strong>service to check which UI command is being executed at the moment.</p>

<br/>


