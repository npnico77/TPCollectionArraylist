using System.Collections;

namespace TPCollectionArraylist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList maListe = new ArrayList();

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            maListe.Clear();
            maListe.Add("hello");
            maListe.Add(98);
            maListe.Add(25.6);
            maListe.Add("nico");
            maListe.Add(-12);
        }

        private void buttonAjoutDirect_Click(object sender, EventArgs e)
        {
            maListe.Clear();
            maListe = new ArrayList{"bonjour",12,25.4,"soleil",88};
        }

        private void buttonTabArray_Click(object sender, EventArgs e)
        {
            maListe.Clear();
            int[] tableau = { 12, 5, 47, 8, 6 };
            maListe = new ArrayList { 12.5, 5.6, 48.2 };
            maListe.AddRange(tableau);
            ArrayList maListe2 = new ArrayList { 52, 9,7 };
            maListe.AddRange(maListe2);
        }

        private void buttonMoyenne_Click(object sender, EventArgs e)
        {
            double moyenne=0;
            for (int i = 0; i < maListe.Count; i++)
            {
                moyenne += Convert.ToDouble(maListe[i]);
            }
            moyenne= moyenne/maListe.Count;
            MessageBox.Show("Moyenne : "+moyenne);
        }

        private void buttonMoyenneForeach_Click(object sender, EventArgs e)
        {
            double moyenne = 0;
            foreach (var i in maListe)
            {
                moyenne += Convert.ToDouble(i);
            }
            moyenne = moyenne / maListe.Count;
            MessageBox.Show("Moyenne : " + moyenne);
        }

        private void buttonInsererDebut_Click(object sender, EventArgs e)
        {
            maListe.Insert(0,textBoxInsererDebut.Text);
            textBoxInsererDebut.Text = "";
        }

        private void buttonInsererIndice4_Click(object sender, EventArgs e)
        {
            ArrayList maListe2 = new ArrayList { 52, 9, 7 };
            maListe.Insert(4, maListe2);
        }

        private void buttonSupprimerDernier_Click(object sender, EventArgs e)
        {
            maListe.RemoveAt(3);
        }

        private void buttonSupprimer3Derniers_Click(object sender, EventArgs e)
        {
            for (int i =0;i<3;i++)
            {
                maListe.RemoveAt(maListe.Count-1);

            }
        }
    }
}