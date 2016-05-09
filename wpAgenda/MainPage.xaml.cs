using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using wpAgenda.Resources;
using SQLite;
using System.IO;
using Windows.Storage;

namespace wpAgenda
{
    public partial class MainPage : PhoneApplicationPage
    {
        // string de conexao
        public static string db_path = Path.Combine(Path.Combine(ApplicationData.Current.LocalFolder.Path, "sample.sqlite"));

        //objeto de conexao
        public static SQLiteConnection dbConn;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            dbConn = new SQLiteConnection(db_path);
            dbConn.CreateTable<Task>();
            //Referesh_ListBox();
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            if (dbConn != null)
                dbConn.Close();     // fecha o bd
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            if(txtNome.Text == string.Empty)
            {
                MessageBox.Show("Campo nome em branco!");
                txtNome.Focus();
                return;
            }
            if (txtTel.Text == string.Empty)
            {
                MessageBox.Show("Campo telefone em branco!");
                txtTel.Focus();
                return;
            }
            if (txtApelido.Text == string.Empty)
            {
                MessageBox.Show("Campo apelido em branco!");
                txtApelido.Focus();
                return;
            }

            try
            {
                // Create a new task.  
                Task task = new Task()
                {
                    nome = txtNome.Text,
                    apelido = txtApelido.Text,
                    telefone = txtTel.Text
                };
                // Insert the new task in the Task table.  
                dbConn.Insert(task);
            }
            catch(SQLiteException ex)
            {
                MessageBox.Show("Nome " + txtNome.Text + " já cadastrado!");
                return;
            }
            //Referesh_ListBox();
            txtNome.Text = txtTel.Text = txtApelido.Text = string.Empty;
        }

        private void Retrieve_Click(object sender, RoutedEventArgs e)
        {
            // Retriving Data  
            var tp = dbConn.Query<Task>("select * from task where nome='" + txtNome.Text + "'").FirstOrDefault();
            if (tp == null)
            {
                MessageBox.Show(txtNome.Text + " nao existe no banco de dados!");
                return;
            }
            else
            {
                txtApelido.Text = tp.apelido;
                txtTel.Text = tp.telefone;
            }
        }  

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if(txtNome.Text == string.Empty)    // campo nome vazio?
            {
                MessageBox.Show("Digite o nome a ser excluido!");
                txtNome.Focus();
                return;
            }
            // deletando linha de acordo com o campo nome selecionado
            var tp = dbConn.Query<Task>("select * from task where nome ='" + txtNome.Text + "'").FirstOrDefault();
            // Check result is empty or not  
            if (tp == null)
                MessageBox.Show(txtNome.Text + " nao existe no banco de dados");
            else
            {
                //Delete row from database  
                dbConn.Delete(tp);     //you can delete single column e.g.  dbConn.Delete(tp.Text);  
                //Referesh_ListBox();
            }
            txtNome.Text = txtTel.Text = txtApelido.Text = string.Empty;
        }

        private void btnContatos_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Contatos.xaml", UriKind.Relative));
        } 
    }

    public sealed class Task
    {
        /// <summary>
        /// voce pode criar uma chave primaria e o sqlite cuidara de controlar
        /// </summary>
        [PrimaryKey]
        public string nome { get; set; }
        public string apelido { get; set; }
        public string telefone { get; set; }

        public override string ToString()
        {
            // provavel que vai ser pra retornar o nome e apelido
            return "Nome: \n" + nome + "\nApelido: \n" + apelido + "\nTelefone: \n" + telefone + "\n";  

        }
    }

}