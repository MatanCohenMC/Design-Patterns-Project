using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;


namespace FacebookApp.Models
{
    public class Login
    {
        private static Login s_Instance = null;

        public User m_LoggedInUser { get; private set; }

        //private FacebookWrapper.LoginResult m_LoginResult;

        public static Login Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    s_Instance = new Login();
                }

                return s_Instance;
            }
        }
    }
}