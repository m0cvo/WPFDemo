# WPFDemo

(c) Nigel Booth 2022.

This is just a simple app that is going to progressivly be added to to demonstrate different attributes and abilities of WPF apps written using XAML and C#.

The first attribute is the gradient colour scheme (color if you are in the USA) which is set using XAML only.

The second attribute is a date loader which is set using the Label control in XAML and then using the DateTime object in C#.

Thirdly add some buttons - one displays a text message and the other is an exit button as all apps need an exit button. Buttons are created using XAML tool but their
actions are performed using C# code behind.

Next stage is to show how to add simple data entry (name in this case) and then act upon it with a pop up message using the code behind (C#).

Next stage is to add a new window with a background image and added a button to the start window to access it.

Next stage is to add a list demo.  This involves adding a new window with a button and then within the code behind (C#) creating a list of colors that is  echoed to 
the screen using a foreach command and a MessageBox.Show() command. We then use the "Remove" command to remove one of the colors, check if the color "Blue"" still 
exists and then list the remaining colors before clearing the whole list and performing a count to ensure the list is now empty.

Following on from the list demo, I have added some checkboxes.  These are convenient for allowing the user to make a choice and also demonstrate the use of logical
operators in the codse behind.