using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace lombardi.samuele._4H.ReadCSV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void PulsanteApri(object sender, RoutedEventArgs e)
        {
            List<Utente> valori = new List<Utente>();


            try
            {
                StreamReader fin = new StreamReader("Utenti.csv");

                while (!fin.EndOfStream)
                {
                    string str = fin.ReadLine();
                    string[] colonne = str.Split(";");
                    Utente u = new Utente { Nome = colonne[0], Cognome = colonne[1] };
                    valori.Add(u);
                }
                fin.Close();
            }
            catch (Exception errore)
            {
                MessageBox.Show(errore.Message);
            }
            dgDati.ItemsSource = valori;
        }

        private void dgDati_LoadingRow(object sender, DataGridRowEventArgs e)
        {
           try
            {

                if (e != null && e.Row != null)
                {
                    Utente u = e.Row.Item as Utente;
                    if (u != null)
                        ;
                        //MessageBox.Show(u.Cognome);
                }
            }
            catch { }
        }

    }



}
