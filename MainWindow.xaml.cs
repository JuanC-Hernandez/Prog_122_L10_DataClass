using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog_122_L10_DataClass
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List <Album> albumList = new List<Album>();
        public MainWindow()
        {
            InitializeComponent();
            Preload();
            rtbDisplay.Text = "";
            for (int i = 0; i < albumList.Count; i++)
            {
                Album currentAlbum = albumList[i];
                rtbDisplay.Text += currentAlbum._artistName + " : " + currentAlbum._title + "\n";
            }


            #region earlier notes
            //Album
            //Declaring the Type - Give it a name - Equals - new Keyword - Type()

            // Instanced Object
            //new Keyword - Album();
            //Album thriller = new Album("Thriller","Michael Jackson");
            //thriller._title = "Thriller";
            //thriller._artistName = "Michael Jackson";
            //rtbDisplay.Text = thriller._title;
            #endregion
        }// MainWindow

        public void Preload()
        {
            Album juansChoice = new Album("Thriller", "Micheal Jackson");

            albumList.Add(juansChoice);
            albumList.Add(new Album("Egg","The Garden"));
            albumList.Add(new Album("Beautiful", "Teena Marie"));
            albumList.Add(new Album("Supernatural", "Santana"));
            albumList.Add(new Album("Milagro", "Santana"));
            albumList.Add(new Album("Butter", "BTS"));
        }
    }// class
}// namespace
