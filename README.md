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
operators in the code behind.

After the list demo I looked at adding speech synthesis.  To do this I needed to install the NuGet package System.Speech (7.0.0).  Some explanation of how this works 
is included in the comments placed in the code behind.

Added an animation demonstration.  This changes the opacity of an object (Rectangle) using a storyboard.  This will work whether you are coding in .NET, .NET Core or 
.NET Framework.

The purpose of this app is to enable others to read the code and learn from it, a sort of self training.  Alternatively, sections of the codecan be freely used to enable 
functions in your own apps.  If you do find it useful, please consider sponsoring my work by clicking the sponsor button at the top of the code page.

02/04/2025: Added threading to move the speech synth to a free core in order to prevent the app from stalling.
