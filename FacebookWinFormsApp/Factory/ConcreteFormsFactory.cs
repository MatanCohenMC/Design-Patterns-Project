using FacebookApp.Models;
using FacebookApp.UI.Forms;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace FacebookApp.Factory
{
    public class ConcreteFormsFactory : FormsFactory
    {
        private Dictionary<eFormName, Form> m_ENumFormsDictionary;
        public ConcreteFormsFactory(ref Dictionary<eFormName, Form> i_ENumFormsDictionary)
        {
            this.m_ENumFormsDictionary = i_ENumFormsDictionary;
        }


        public override Form FactoryMethod(eFormName formName)
        {
            Form formToReturn = null;
            if(formName == eFormName.AlbumForm)
            {
                formToReturn = new AlbumsForm();
            }
            else if(formName == eFormName.EventsForm)
            {
                formToReturn = new EventsForm();
            }
            else if(formName == eFormName.GroupsForm)
            {
                formToReturn = new GroupsForm();
            }
            else if(formName == eFormName.LikedPagesForm)
            {
                formToReturn = new LikedPagesForm();
            }
            else if(formName == eFormName.FriendsInUsersAgeRangeForm)
            {
                formToReturn = new FriendsInUsersAgeRangeForm();
            }
            else if(formName == eFormName.PostsForm)
            {
                formToReturn = new PostsForm();
            }
            else if(formName == eFormName.UserProfileForm)
            {
                formToReturn = new UserProfileForm();
            }
            else if(formName == eFormName.PostsByDateRangeForm)
            {
                formToReturn = new PostsByDateRangeForm();
            }
            else if(formName == eFormName.EventsByLocationForm)
            {
                formToReturn = new EventsByLocationForm();
            }
            else if(formName == eFormName.RandomMemoryForm)
            {
                formToReturn = new RandomMemoryForm();
            }
            else if(formName == eFormName.NavigationBarForm)
            {
                formToReturn = new NavigationBarForm();
            }
            else if(formName == eFormName.LoginBarForm)
            {
                formToReturn = new LoginBarForm();
            }
            else if(formName == eFormName.AppMainForm)
            {
                LoginBarForm curLoginBarForm = getForm(eFormName.LoginBarForm) as LoginBarForm;
                NavigationBarForm curNavigationBarForm = getForm(eFormName.NavigationBarForm) as NavigationBarForm;
                if(curNavigationBarForm != null && curNavigationBarForm != null)
                {
                    formToReturn = new AppMainForm(curNavigationBarForm, curLoginBarForm);
                }
            }

            return formToReturn;
        }
        private Form getForm(eFormName i_EnumFormName)
        {
            return m_ENumFormsDictionary[i_EnumFormName];
        }

    }
}