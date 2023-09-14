using FacebookApp.Controllers;
using FacebookApp.UI.Forms;

namespace FacebookApp
{
    internal interface ILogoutStrategy
    {
        void ExecuteLogout(LoginBarForm i_LoginForm, FormsController i_Controller);
    }
}
