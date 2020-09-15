# Task

Create two WPF applications, a client and a server to exchange messages.

The client:

* chat name
* connect button
* messages list
* message text-box
* send button

The Connect button is enabled only if not connected.
The send button is enabled only if Message contains at least one character (Set UpdateSourceTrigger
to PropertyChanged)
Receiving a “@quit” message lets the client disconnect from the server

## The server
Drop button sends a @quit command to the client and disconnects the client.
…Sends all the messages received from clients to the other clients.
Start is only enabled if not running and vica versa. 

## BONUS TASK
“Save to log” button writes the Received messages to a file. 
They can be viewed via the Logs section (use a TabControl). 
Show button displays the entries in the Log Message section; the Drop Button deletes the file. 
