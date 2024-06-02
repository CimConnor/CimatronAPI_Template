using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using interop.CimBaseAPI;


namespace CImatronAPI_Template
{
    public class Command : interop.CimBaseAPI.ICimCommand, interop.CimBaseAPI.ICreateCommand
    {


        // This property allows you to enable the command in Cimatron

        public int Enable()

        {
            return 1; // return true
        }

        public void Execute()

        {
            // your application code...

        }

        //This property allows you to set the Category Name of your own command.

        public string GetCategoryName()

        {
            return "NewCommand";
        }

        // This property allows you to set the Command Name of your own command.

        public string GetCommandName()

        {
            return "NewCommand";
        }

        // This property allows you to set the location of your own command in Cimatron menus.

        public string GetMenuPath()

        {

            return "NewCommand" + "\n" + "Command";

        }

        // This property allows you to set the string that will be shown in the status bar of Cimatron.

        public string GetPrompt()

        {

            return "NewCommand";

        }

        // This property allows you to set the Toolbar title of your own command.

        public string GetToolbarName()

        {

            return "NewCommand";

        }

        // This property allows you to set the Tooltip for your own command.

        public string GetTooltip()

        {

            return "Create New Command";

        }

        // This property allows you to set the Description for your own command.

        public string GetDescription()

        {

            return "Create New Command";

        }

        // This property allows you to define the type of file that

        // you can use to view your own Commands.

        public int IsBelongToDoc(interop.CimBaseAPI.ECommandCategory iType)

        {

            // Check current file type, if PART then enable the command.
            if (iType == ECommandCategory.cmCmdAssembly)

            {
                return 1; // True
            }
            else
            {
                return 0; // True
            }


        }

        // This property allows you to Enable/Disable your own command in the Dropdown Menus.

        public int ShowInMenu()

        {

            return 1; // True

        }

        // This property allows you to Enable/Disable the command in the Toolbar.

        public int ShowInToolbar()

        {
            return 1; // True
        }
    }
}
