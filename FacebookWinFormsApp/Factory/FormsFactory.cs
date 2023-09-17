using FacebookApp.Models;
using System.Windows.Forms;

namespace FacebookApp.Factory
{
    public abstract class FormsFactory
    {
        public abstract Form FactoryMethod(eFormName i_FormName);
    }
}