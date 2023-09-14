using FacebookApp.Controllers;
using FacebookApp.UI.Forms;

namespace FacebookApp
{
    internal interface ILoginStrategy
    {
        void ExecuteLogin(LoginBarForm i_LoginForm, FormsController i_Controller);
    }
}
