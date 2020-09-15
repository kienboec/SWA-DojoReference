# Task

Create an application which enables users to select a category form a list (1). 
After that selection the user can choose toys from a second list (2) which could be put into a 3rd list 
which represents a wish list (3). 
All lists are using the same data structures but different templates to visualize the items.
The details are shown in a WrapPanel (override ItemPanelTemplate). 
After the user clicks on the Buy button the package is added to the 3rd list.

The Items provide the following data:
* Description
* Image
* Age recommendation

One tricky part is to point the Command of the Button to the MainViewModel and not to the ItemVm itself. 
Here you can use a RelativeSource statement in your databinding:

```
<Button Content="Buy"
  Command="{Binding DataContext.BuyBtnClickCmd, RelativeSource={RelativeSource AncestorType=ItemsControl}}"
  CommandParameter="{Binding}">
```

BuyBtnClickCmd is a property in the MainViewModel class. The command uses a CommandParameter to provide the Item which was clicked.
Implementations of the Webcast are available in the REPO (LegoCatalog and PlaymobilCatalog projects)