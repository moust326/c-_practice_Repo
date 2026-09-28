![creating variables](<creating variables.png>)

# Student Information

# This C# program collects and displays student information.

# How it works:

- "String" variables store the student name and department.
- "int" variables store the student ID and semester.
- ".Text" gets information from the TextBoxes.
- "int.Parse()" converts student ID and semester from text to numbers.
- The "+" operator combines all information.
- "lbloutput.Text" displays the final student information.

# Output Example:

"Mustafe 12345 Computer Application 2"

The code runs when the Show Info button is clicked.

![clear button](clear.png)
# Clear Button

# This code clears all student information entered in the form.

- ".Clear()" removes the text from each TextBox.
- "lbloutput.Text = "";" clears the displayed result from the Label.

 When the Clear button is clicked, all input fields and the output are reset.

![close button](<close using this keyword.png>)

# Close Form

# "this.Close();"

This code closes the current Windows Form when the code is executed.

- "this" → refers to the current form.
- "Close()" → closes the form.