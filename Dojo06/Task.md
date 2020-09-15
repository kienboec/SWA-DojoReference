# Task

Extend the Coding Dojo 6 by using two detail views

1) Displays a menu with two options, the Overview, which is the same code as Coding Dojo 6
but without the Cart ItemsControl.
2) Displays a Status bar which displays a icon and a text message if new entries are added to My
Toys.
3) The detail view which is toggled if the user changes the menu selection.
If the user clicks the MyToys button the ItemsControl from Dojo 6 which contains the Cart info is
displayed here. But instead of showing it in one Window we are using several UserControls with
more than one ViewModel. 

If the Buy Button was clicked the MessageBar displays a Message for 2 seconds:

Playmobil and lego are toys, in case that you do not know one of them ;-)

The Coding dojo is a combination of Coding dojo 6 and the MultiVm Example from the Slides and
the WebCast.

The OverviewVm needs to inform the MyToysVm about new entries. 
Here The Messenger of MVVM light could be used.

The Messagebar could also be implemented in the same project as all the other code – 
that would make some things easier. 
The Reference implementation uses a more sophisticated way by moving the code for the messagebar into an own project so that reuse would be possible.
Removing Text/Images after a TimeSpan could be realized by the DispatcherTimer. 
