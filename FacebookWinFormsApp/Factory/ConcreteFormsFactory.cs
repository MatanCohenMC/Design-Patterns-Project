using FacebookApp.Models;
using FacebookApp.UI.Forms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FacebookApp.Factory
{
    public class ConcreteFormsFactory : FormsFactory
    {
        private readonly Dictionary<eFormName, Form> r_EnumFormsDictionary;

        public ConcreteFormsFactory(ref Dictionary<eFormName, Form> i_EnumFormsDictionary)
        {
            r_EnumFormsDictionary = i_EnumFormsDictionary;
        }

        public override Form FactoryMethod(eFormName i_FormName)
        {
            Form formToReturn = null;
            if (i_FormName == eFormName.AlbumForm)
            {
                formToReturn = new AlbumsForm();
            }
            else if (i_FormName == eFormName.EventsForm)
            {
                formToReturn = new EventsForm();
            }
            else if (i_FormName == eFormName.GroupsForm)
            {
                formToReturn = new GroupsForm();
            }
            else if (i_FormName == eFormName.LikedPagesForm)
            {
                formToReturn = new LikedPagesForm();
            }
            else if (i_FormName == eFormName.FriendsInUsersAgeRangeForm)
            {
                formToReturn = new FriendsInUsersAgeRangeForm();
            }
            else if (i_FormName == eFormName.PostsForm)
            {
                formToReturn = new PostsForm();
            }
            else if (i_FormName == eFormName.UserProfileForm)
            {
                formToReturn = new UserProfileForm();
            }
            else if (i_FormName == eFormName.PostsByDateRangeForm)
            {
                formToReturn = new PostsByDateRangeForm();
            }
            else if (i_FormName == eFormName.EventsByLocationForm)
            {
                formToReturn = new EventsByLocationForm();
            }
            else if (i_FormName == eFormName.RandomMemoryForm)
            {
                formToReturn = new RandomMemoryForm();
            }
            else if (i_FormName == eFormName.NavigationBarForm)
            {
                formToReturn = new NavigationBarForm();
            }
            else if (i_FormName == eFormName.LoginBarForm)
            {
                formToReturn = new LoginBarForm();
            }
            else if (i_FormName == eFormName.AppMainForm)
            {
                LoginBarForm curLoginBarForm = getForm(eFormName.LoginBarForm) as LoginBarForm;
                NavigationBarForm curNavigationBarForm = getForm(eFormName.NavigationBarForm) as NavigationBarForm;
                if (curNavigationBarForm != null && curNavigationBarForm != null)
                {
                    formToReturn = new AppMainForm(curNavigationBarForm, curLoginBarForm);
                }
            }

            return formToReturn;
        }

        private Form getForm(eFormName i_EnumFormName)
        {
            return r_EnumFormsDictionary[i_EnumFormName];
        }
    }
}