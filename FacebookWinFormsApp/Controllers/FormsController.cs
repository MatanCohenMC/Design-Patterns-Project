using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookApp.UI.Forms;
using FacebookApp.UI;
using FacebookApp.UI.Forms;
using FacebookApp.Interfaces;
using FacebookWrapper;


namespace FacebookApp.Controllers
{
    public class FormsController
    {
        private Dictionary<string, Form> m_FormsDictionary;
        private static FormsController s_Instance = null;
        
        private FormsController()
        {
            InitializeForms();
        }
        // //

        private void InitializeForms()
        {
            m_FormsDictionary = new Dictionary<string, Form>();

            string formNameAlbums = "AlbumsForm";
            Form albumsForm = new AlbumsForm();
            AddForm(formNameAlbums, albumsForm);

            string formNameEvents = "EventsForm";
            Form eventsForm = new EventsForm();
            AddForm(formNameEvents, eventsForm);

            string formNameGroups = "GroupsForm";
            Form groupsForm = new GroupsForm();
            AddForm(formNameGroups, groupsForm);

            string formNamePages = "PagesForm";
            Form pagesForm = new FormPages();
            AddForm(formNamePages, pagesForm);

            string formNamePosts = "PostsForm";
            PostsForm postsForm = new PostsForm();
            postsForm.m_FetchButtonPressed += fetchUserFormData;
            AddForm(formNamePosts, postsForm);

            
        }

        public static FormsController Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    s_Instance = new FormsController();
                }

                return s_Instance;
            }
        }

        public void AddForm(string i_FormName, Form i_Form)
        {
            m_FormsDictionary.Add(i_FormName, i_Form);
        }

        public Form GetForm(string i_FormName)
        {
            return m_FormsDictionary[i_FormName];
        }

        public void Start()
        {
            Clipboard.SetText("design.patterns20cc");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            NavigationBarForm navigationBarForm = new NavigationBarForm();
            LoginBarForm loginBarForm = new LoginBarForm();

            Form appMainForm = new AppMainForm(navigationBarForm, loginBarForm);
            Application.Run(appMainForm);
        }

        private void fetchUserFormData(string i_FormName)
        {
            IComponentHandler componentHandler = m_FormsDictionary[i_FormName] as IComponentHandler;
            IDataHandler dataHandler = m_FormsDictionary[i_FormName] as IDataHandler;
            ListBox formListBox = componentHandler?.GetListBox();
            formListBox?.Items.Clear();

            foreach (string post in dataHandler.FetchListBoxData())
            {
                formListBox?.Items.Add(post);
            }
            //TODO: should add a picture box to the form
            //TODO: should load extra data about the list box items such as date and total likes and comments to a static dictionary later display it on the form

        }






    }
}
