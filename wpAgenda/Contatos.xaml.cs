using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace wpAgenda
{
    public partial class Contatos : PhoneApplicationPage
    {
        public Contatos()
        {
            InitializeComponent();

            Referesh_ListBox();
        }

        private void Referesh_ListBox()
        {
            // Retrieve the task list from the database.  
            List<Task> retrievedTasks = MainPage.dbConn.Table<Task>().ToList<Task>();
            // Clear the list box that will show all the tasks.  
            taskListBox.Items.Clear();
            foreach (var t in retrievedTasks)
            {
                taskListBox.Items.Add(t);
            }
        }
    }
}