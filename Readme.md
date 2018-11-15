<!-- default file list -->
*Files to look at*:

* [CustomCommandExecutionListenerService.cs](./CS/DXApplication9/CustomCommandExecutionListenerService.cs) (VB: [CustomCommandExecutionListenerService.vb](./VB/DXApplication9/CustomCommandExecutionListenerService.vb))
* **[Form1.cs](./CS/DXApplication9/Form1.cs) (VB: [Form1.vb](./VB/DXApplication9/Form1.vb))**
<!-- default file list end -->
# How to determine a UI command executed in RichEditControl in response to a user action  


<p>In some cases, a default command should be extended with custom logic to implement additional functionality or customize existing functionality. If so, the first part of the task is to find which command should be overridden. The easiest way to achieve the goal is to listen to which commands are executed in the RichEditControl in response to a certain action. The XtraRichEdit Suite provides the <strong>CommandExecutionListenerService </strong>service for notifications. This example demonstrates how to create a custom <strong>CommandExecutionListenerService </strong>service to check which UI command is being executed at the moment.</p>
<p> Please note that the <strong>CommandExecutionListenerService </strong>service is a part of the RichEditControl's internal API. It is undocumented and can be changed in future versions. In this case, don't hesitate to contact our Support team for assistance in upgrading your project. </p>
<br/>


