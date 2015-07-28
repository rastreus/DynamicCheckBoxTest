### About

![Screenpic for proof!](https://raw.githubusercontent.com/rastreus/DynamicCheckBoxTest/master/pic/DCBT.png)

This is a Windows Form application which dynamically creates and deletes [CheckBox controls](https://msdn.microsoft.com/en-us/library/System.Windows.Forms.CheckBox(v=vs.110).aspx).
It is largely an experiment of UI/UX concepts to better show the end user that the created
CheckBox can only be deleted when it is checked. Additionally, a "Select All" option is
available to make the process a little faster; it is good practice in figuring out how best
to work with the [Indeterminate CheckState](https://msdn.microsoft.com/en-us/library/system.windows.forms.checkbox.checkstate(v=vs.110).aspx?cs-save-lang=1&cs-lang=vb#code-snippet-1)
(when a user unchecks a CheckBox after checking "Select All").

Source code is located in the `src` folder and is licensed under the GNU GPLv3. Copyright information
is in the `COPYING` file in the root of this repo. Additional information on the GNU GPLv3 license
is located at http://www.gnu.org/licenses/.
