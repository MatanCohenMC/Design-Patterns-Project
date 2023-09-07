using System.Windows.Forms;
using FacebookApp.Models;

namespace FacebookApp.Factory
{
    public abstract class FormsFactory
    {
        public abstract Form FactoryMethod(eFormName i_FormName);
    }
}