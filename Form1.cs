using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using HtmlAgilityPack;
using System.Globalization;


namespace Travian_2._0
{
    public partial class Main1 : Form
    {
        public int compteur;
        public bool Auto;
         public Main1()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.compteur = 0;
            this.ValueTime.Text = "Le script s'est exécuté à ";
            this.ValueTime.Visible = false;
            this.button1.Hide();
            this.textBoxSecondes.Hide();
            this.label1.Hide();
            this.Auto = false;
            
        }

        static void Init()
        {
            try
            {
               Process process = new Process();
                process.StartInfo.FileName = "perl.exe";
                process.StartInfo.Arguments = "Connexion.pl";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
                process.Start();               
               // MessageBox.Show("Lancement du script");                
                process.WaitForExit();
               // MessageBox.Show("Fin du script");                            
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de lancement");   
            }
        }

         void Time(object sender)
        {
            
            //DateTime.Now.TimeOfDay.ToString("hh\\:mm\\:ss");
            this.ValueTime.Text = "Le script s'est exécuté à " + DateTime.Now.TimeOfDay.ToString("hh\\:mm\\:ss"); 
        }

        Village TraitementVillage(string CheminDuFichier, Village MonVillage, int x , int y)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.Load(CheminDuFichier);
            MonVillage.InitgroupBox();

            // Nom du Village
            var root = doc.DocumentNode;
            var Village = root.Descendants()
                .Where(n => n.GetAttributeValue("id", "").Equals("villageNameField"))
                .Single()
                .Descendants()
                .Single();
            var ValueVillage = Village.InnerText;

            // suppression des infos inutiles 
            
            string[] stringSeparators2 = new string[] { "&#x202d;", "&#x202c;" };
            string[] result = new string[] {  };
            result = ValueVillage.Split(stringSeparators2, StringSplitOptions.RemoveEmptyEntries);
            ValueVillage = string.Concat(result);
            

            MonVillage.groupBoxVillage.Text = ValueVillage;
            MonVillage.groupBoxVillage.Location = new System.Drawing.Point(x, y);
            

            // Depot de ressources Max
            var DM = root.Descendants()
                .Where(n => n.GetAttributeValue("id", "").Equals("stockBarWarehouse"))
                .Single()
                .Descendants()
                .Single();
            var ValueDepotMax = DM.InnerText;
        
            string[] result2 = new string[] { };
            result2 = ValueDepotMax.Split(stringSeparators2, StringSplitOptions.RemoveEmptyEntries);
            ValueDepotMax = string.Concat(result2);
            ValueDepotMax = ValueDepotMax.Replace(".", "");
            
            MonVillage.ValueDepot.Text = ValueDepotMax;
            MonVillage.ValueDepot.ForeColor = Color.LimeGreen;
            MonVillage.ValueDepot.BackColor = Color.Black;

            // Bois
            var Bois = root.Descendants()
                .Where(n => n.GetAttributeValue("id", "").Equals("l1"))
                .Single()
                .Descendants()
                .Single();
            var ValueBois = Bois.InnerText;
           
            string[] result3 = new string[] {  };
            result3 = ValueBois.Split(stringSeparators2, StringSplitOptions.RemoveEmptyEntries);
            ValueBois = string.Concat(result3);
            ValueBois = ValueBois.Replace(".", "");

            MonVillage.ValueBois.Text = ValueBois;

            // Pourcentage pour les Couleurs
            
            double Bois75 = Convert.ToDouble(ValueDepotMax) * 0.75;
            double Bois50 = Convert.ToDouble(ValueDepotMax) * 0.50;
            double Bois25 = Convert.ToDouble(ValueDepotMax) * 0.25;
            double ValueDoubleBois = Convert.ToDouble(ValueBois);
            int PourcentBois = (Convert.ToInt32(ValueDoubleBois) * 100) / Convert.ToInt32(ValueDepotMax);      
            MonVillage.ValuePourcentBois.Text = PourcentBois.ToString() + "%";

            // Pourcentage Color
            if (PourcentBois < 25)
            {
                MonVillage.ValuePourcentBois.ForeColor = Color.Red;
               MonVillage.ValuePourcentBois.BackColor = Color.Black;
            }

            if (PourcentBois >= 25)
            {
                MonVillage.ValuePourcentBois.ForeColor = System.Drawing.Color.Yellow;
                MonVillage.ValuePourcentBois.BackColor = Color.Black;
            }

            if (PourcentBois >= 50)
            {
                MonVillage.ValuePourcentBois.ForeColor = Color.Magenta;
                MonVillage.ValuePourcentBois.BackColor = Color.Black;
            }

            if (PourcentBois >= 75)
            {
                MonVillage.ValuePourcentBois.ForeColor = Color.LimeGreen;
                MonVillage.ValuePourcentBois.BackColor = Color.Black;
            }


            // Variable Manquantes toujours en Rouge 
            int RessourcesManquantesBois = Convert.ToInt32(ValueDepotMax) - Convert.ToInt32(ValueBois);
            MonVillage.ValueBoisManquant.ForeColor = Color.Red;
            MonVillage.ValueBoisManquant.BackColor = Color.Black;
            MonVillage.ValueBoisManquant.Text = RessourcesManquantesBois.ToString();

            //Pourcentage
            if (ValueDoubleBois < Bois25)
            {
                MonVillage.ValueBois.ForeColor = Color.Red;
               MonVillage.ValueBois.BackColor = Color.Black;
            }

             if (ValueDoubleBois >= Bois25)
            {
                MonVillage.ValueBois.ForeColor = System.Drawing.Color.Yellow;
                MonVillage.ValueBois.BackColor = Color.Black;
            }


             if (ValueDoubleBois >= Bois50)
            {
                MonVillage.ValueBois.ForeColor = Color.Magenta;
                MonVillage.ValueBois.BackColor = Color.Black;
            }

             if (ValueDoubleBois >= Bois75)
            {
                MonVillage.ValueBois.ForeColor = Color.LimeGreen;
                MonVillage.ValueBois.BackColor = Color.Black;
            }
                    

            if (RessourcesManquantesBois == 0)
            {
                MonVillage.ValueBoisManquant.ForeColor = Color.LimeGreen;
                MonVillage.ValueBoisManquant.BackColor = Color.Black;
                MonVillage.ValueBoisManquant.Text = "0";
            }
           
            // Argile
            var Argile = root.Descendants()
                .Where(n => n.GetAttributeValue("id", "").Equals("l2"))
                .Single()
                .Descendants()
                .Single();
            var ValueArgile = Argile.InnerText;

            string[] result4 = new string[] { };
            result4 = ValueArgile.Split(stringSeparators2, StringSplitOptions.RemoveEmptyEntries);
            ValueArgile = string.Concat(result4);
            ValueArgile = ValueArgile.Replace(".", "");

            MonVillage.ValueArgile.Text = ValueArgile;

            double Argile75 = Convert.ToDouble(ValueDepotMax) * 0.75;
            double Argile50 = Convert.ToDouble(ValueDepotMax) * 0.50;
            double Argile25 = Convert.ToDouble(ValueDepotMax) * 0.25;

            double ValueDoubleArgile = Convert.ToDouble(ValueArgile);
            int PourcentArgile = (Convert.ToInt32(ValueDoubleArgile) * 100) / Convert.ToInt32(ValueDepotMax);
            MonVillage.ValuePourcentArgile.Text = PourcentArgile.ToString() + "%";

            // Pourcentage Color
            if (PourcentArgile < 25)
            {
                MonVillage.ValuePourcentArgile.ForeColor = Color.Red;
                MonVillage.ValuePourcentArgile.BackColor = Color.Black;
            }

            if (PourcentArgile >= 25)
            {
                MonVillage.ValuePourcentArgile.ForeColor = System.Drawing.Color.Yellow;
                MonVillage.ValuePourcentArgile.BackColor = Color.Black;
            }

            if (PourcentArgile >= 50)
            {
                MonVillage.ValuePourcentArgile.ForeColor = Color.Magenta;
                MonVillage.ValuePourcentArgile.BackColor = Color.Black;
            }

            if (PourcentArgile >= 75)
            {
                MonVillage.ValuePourcentArgile.ForeColor = Color.LimeGreen;
                MonVillage.ValuePourcentArgile.BackColor = Color.Black;
            }

            int RessourcesManquantesArgile = Convert.ToInt32(ValueDepotMax) - Convert.ToInt32(ValueArgile);    
            MonVillage.ValueArgileManquant.ForeColor = Color.Red;
            MonVillage.ValueArgileManquant.BackColor = Color.Black;
            MonVillage.ValueArgileManquant.Text = RessourcesManquantesArgile.ToString();

            // Pourcentage
            if (ValueDoubleArgile < Argile25)
            {
                MonVillage.ValueArgile.ForeColor = Color.Red;
                MonVillage.ValueArgile.BackColor = Color.Black;
            }

            if (ValueDoubleArgile >= Argile25)
            {
                MonVillage.ValueArgile.ForeColor = System.Drawing.Color.Yellow;               
                MonVillage.ValueArgile.BackColor = Color.Black;
            }


            if (ValueDoubleArgile >= Argile50)
            {
                MonVillage.ValueArgile.ForeColor = Color.Magenta;
                MonVillage.ValueArgile.BackColor = Color.Black;
            }

            if (ValueDoubleArgile >= Argile75)
            {
                MonVillage.ValueArgile.ForeColor = Color.LimeGreen;
               MonVillage.ValueArgile.BackColor = Color.Black;
            }

            if (RessourcesManquantesArgile == 0)
            {
                MonVillage.ValueArgileManquant.ForeColor = Color.LimeGreen;
                MonVillage.ValueArgileManquant.BackColor = Color.Black;
                MonVillage.ValueArgileManquant.Text = "0";
            }
            
            // Fer
            var Fer = root.Descendants()
                .Where(n => n.GetAttributeValue("id", "").Equals("l3"))
                .Single()
                .Descendants()
                .Single();
            var ValueFer = Fer.InnerText;

            string[] result5 = new string[] {  };
            result5 = ValueFer.Split(stringSeparators2, StringSplitOptions.RemoveEmptyEntries);
            ValueFer = string.Concat(result5);
            ValueFer = ValueFer.Replace(".", "");

            MonVillage.ValueFer.Text = ValueFer;
            int RessourcesManquantesFer = Convert.ToInt32(ValueDepotMax) - Convert.ToInt32(ValueFer);

            MonVillage.ValueFer.ForeColor = Color.LimeGreen;
            MonVillage.ValueFer.BackColor = Color.Black;

            MonVillage.ValueFerManquant.ForeColor = Color.Red;
            MonVillage.ValueFerManquant.BackColor = Color.Black;
            MonVillage.ValueFerManquant.Text = RessourcesManquantesFer.ToString();
            double Fer75 = Convert.ToDouble(ValueDepotMax) * 0.75;
            double Fer50 = Convert.ToDouble(ValueDepotMax) * 0.50;
            double Fer25 = Convert.ToDouble(ValueDepotMax) * 0.25;
            double ValueDoubleFer = Convert.ToDouble(ValueFer);
            int PourcentFer = (Convert.ToInt32(ValueDoubleFer) * 100) / Convert.ToInt32(ValueDepotMax);
            MonVillage.ValuePourcentFer.Text = PourcentFer.ToString() + "%";
            
            //Pourcentage Color
            if (PourcentFer < 25)
            {
                MonVillage.ValuePourcentFer.ForeColor = Color.Red;
                MonVillage.ValuePourcentFer.BackColor = Color.Black;
            }

            if (PourcentFer >= 25)
            {
                MonVillage.ValuePourcentFer.ForeColor = System.Drawing.Color.Yellow;
                MonVillage.ValuePourcentFer.BackColor = Color.Black;
            }

            if (PourcentFer >= 50)
            {
                MonVillage.ValuePourcentFer.ForeColor = Color.Magenta;
                MonVillage.ValuePourcentFer.BackColor = Color.Black;
            }

            if (PourcentFer >= 75)
            {
                MonVillage.ValuePourcentFer.ForeColor = Color.LimeGreen;
                MonVillage.ValuePourcentFer.BackColor = Color.Black;
            }

            // Pourcentage 
            if (ValueDoubleFer < Fer25)
            {
                MonVillage.ValueFer.ForeColor = Color.Red;
                MonVillage.ValueFer.BackColor = Color.Black;
            }

            if (ValueDoubleFer >= Fer25)
            {
                MonVillage.ValueFer.ForeColor = System.Drawing.Color.Yellow;
                MonVillage.ValueFer.BackColor = Color.Black;
            }


            if (ValueDoubleFer >= Fer50)
            {
                MonVillage.ValueFer.ForeColor = Color.Magenta;
                MonVillage.ValueFer.BackColor = Color.Black;
            }

            if (ValueDoubleFer >= Fer75)
            {
                MonVillage.ValueFer.ForeColor = Color.LimeGreen;
                MonVillage.ValueFer.BackColor = Color.Black;
            }

            if (RessourcesManquantesFer == 0)
            {
                MonVillage.ValueFerManquant.ForeColor = Color.LimeGreen;
                MonVillage.ValueFerManquant.BackColor = Color.Black;
                MonVillage.ValueFerManquant.Text = "0";
            }        

            // Silo de céréales 
            var SiloCereales = root.Descendants()
                .Where(n => n.GetAttributeValue("id", "").Equals("stockBarGranary"))
                .Single()
                .Descendants()
                .Single();
            var ValueSiloCereales = SiloCereales.InnerText;

            string[] result6 = new string[] {  };
            result6 = ValueSiloCereales.Split(stringSeparators2, StringSplitOptions.RemoveEmptyEntries);
            ValueSiloCereales = string.Concat(result6);
            ValueSiloCereales = ValueSiloCereales.Replace(".", "");

            MonVillage.ValueSilo.Text = ValueSiloCereales;
            MonVillage.ValueSilo.ForeColor = Color.LimeGreen;
           MonVillage.ValueSilo.BackColor = Color.Black;

            // Céréales
            var Cereales = root.Descendants()
                .Where(n => n.GetAttributeValue("id", "").Equals("l4"))
                .Single()
                .Descendants()
                .Single();
            var ValueCereales = Cereales.InnerText;

            string[] result7 = new string[] { };
            result7 = ValueCereales.Split(stringSeparators2, StringSplitOptions.RemoveEmptyEntries);
            ValueCereales = string.Concat(result7);
            ValueCereales = ValueCereales.Replace(".", "");

            // suppression des espaces 

            string nospace ="";

            foreach (var c in ValueCereales)
            {
                if (char.IsNumber(c))
                {
                    nospace = nospace + c;
                }
            }

            ValueCereales = nospace;


            int RessourcesManquantesCereales = Convert.ToInt32(ValueSiloCereales) - Convert.ToInt32(ValueCereales);
            MonVillage.ValueCereales.Text = ValueCereales;

            MonVillage.ValueCereales.ForeColor = Color.LimeGreen;
            MonVillage.ValueCereales.BackColor = Color.Black;

            MonVillage.ValueCerealesManquant.BackColor = Color.Black;
            MonVillage.ValueCerealesManquant.ForeColor = Color.Red;

            MonVillage.ValueCerealesManquant.Text = RessourcesManquantesCereales.ToString();

            double Cereales75 = Convert.ToDouble(ValueSiloCereales) * 0.75;
            double Cereales50 = Convert.ToDouble(ValueSiloCereales) * 0.50;
            double Cereales25 = Convert.ToDouble(ValueSiloCereales) * 0.25;
            double ValueDoubleCereales = Convert.ToDouble(ValueCereales);
            int PourcentCereales = (Convert.ToInt32(ValueDoubleCereales) * 100) / Convert.ToInt32(ValueSiloCereales);
            MonVillage.ValuePourcentCereales.Text = PourcentCereales.ToString() + "%";

            // Pourcentage Color
            if (PourcentCereales < 25)
            {
                MonVillage.ValuePourcentCereales.ForeColor = Color.Red;
                MonVillage.ValuePourcentCereales.BackColor = Color.Black;
            }

            if (PourcentCereales >= 25)
            {
                MonVillage.ValuePourcentCereales.ForeColor = System.Drawing.Color.Yellow;
               MonVillage.ValuePourcentCereales.BackColor = Color.Black;
            }

            if (PourcentCereales >= 50)
            {
                MonVillage.ValuePourcentCereales.ForeColor = Color.Magenta;
                MonVillage.ValuePourcentCereales.BackColor = Color.Black;
            }

            if (PourcentCereales >= 75)
            {
                MonVillage.ValuePourcentCereales.ForeColor = Color.LimeGreen;
                MonVillage.ValuePourcentCereales.BackColor = Color.Black;
            }

            // Pourcentage 
            if (ValueDoubleCereales < Cereales25)
            {
                MonVillage.ValueCereales.ForeColor = Color.Red;
                MonVillage.ValueCereales.BackColor = Color.Black;
            }

            if (ValueDoubleCereales >= Cereales25)
            {
                MonVillage.ValueCereales.ForeColor = System.Drawing.Color.Yellow;
                MonVillage.ValueCereales.BackColor = Color.Black;
            }


            if (ValueDoubleCereales >= Cereales50)
            {
                MonVillage.ValueCereales.ForeColor = Color.Magenta;
                MonVillage.ValueCereales.BackColor = Color.Black;
            }

            if (ValueDoubleCereales >= Cereales75)
            {
                MonVillage.ValueCereales.ForeColor = Color.LimeGreen;
               MonVillage.ValueCereales.BackColor = Color.Black;
            }

            if (RessourcesManquantesCereales == 0)
            {
                MonVillage.ValueCerealesManquant.ForeColor = Color.LimeGreen;
                MonVillage.ValueCerealesManquant.BackColor = Color.Black;
                MonVillage.ValueCerealesManquant.Text = "0";
            }
                    
            // Ressources Total
            int RessourcesManquantesAll = RessourcesManquantesArgile + RessourcesManquantesBois + RessourcesManquantesFer;
            MonVillage.ValueDepotManquant.ForeColor = Color.Red;
            MonVillage.ValueDepotManquant.BackColor = Color.Black;

            MonVillage.ValueDepotManquant.Text = RessourcesManquantesAll.ToString();
            if (RessourcesManquantesAll == 0)
            {
                MonVillage.ValueDepotManquant.ForeColor = Color.LimeGreen;
                MonVillage.ValueDepotManquant.BackColor = Color.Black;
                MonVillage.ValueDepotManquant.Text = "0";
            }

            // Les amélioration en cours 
            try
            {
                string time1 = string.Empty;
                string time2 = string.Empty;
                var span = root.SelectNodes("//span[@counting='down']");
                foreach (var link in span)
                { 
                    if (time1 == string.Empty)
                    {
                        time1 = link.InnerText;
                    }
                    else
                    {
                        time2 = link.InnerText;
                    }
                
                
                }

                
                MonVillage.ValueUpdateOne.Text = time1;
                MonVillage.ValueUpdateOne.BackColor = Color.Black;
                MonVillage.ValueUpdateOne.ForeColor = Color.LimeGreen;

                MonVillage.ValueUpdateTwo.Text = time2;
                MonVillage.ValueUpdateTwo.BackColor = Color.Black;
                MonVillage.ValueUpdateTwo.ForeColor = Color.LimeGreen;
            }
            catch (Exception e)
            {
                MonVillage.ValueUpdateOne.BackColor = Color.Black;
                MonVillage.ValueUpdateOne.ForeColor = Color.Red;
                MonVillage.ValueUpdateOne.Text = "Aucun"; 

                MonVillage.ValueUpdateTwo.BackColor = Color.Black;
                MonVillage.ValueUpdateTwo.ForeColor = Color.Red;
                MonVillage.ValueUpdateTwo.Text = "Aucun";
   
       
            }

          
 
            return MonVillage;
        }

        private void buttonDemarrer_Click(object sender, EventArgs e)
        {
           // Init();
            compteur = compteur + 1;

            string CheminDuFichier1 = "Villages\\Village1.html";
            string CheminDuFichier2 = "Villages\\Village2.html";
            string CheminDuFichier3 = "Villages\\Village3.html";
            string CheminDuFichier4 = "Villages\\Village4.html";
            string CheminDuFichier5 = "Villages\\Village5.html";
            string CheminDuFichier6 = "Villages\\Village6.html";
            string CheminDuFichier7 = "Villages\\Village7.html";
            string CheminDuFichier8 = "Villages\\Village8.html";
            string CheminDuFichier9 = "Villages\\Village9.html";
            string CheminDuFichier10 = "Villages\\Village10.html";
            string CheminDuFichier11 = "Villages\\Village11.html";
            string CheminDuFichier12 = "Villages\\Village12.html";


            Village MonVillage = new Village();
            
            Village MonVillage2 = new Village();
            Village MonVillage3 = new Village();
            Village MonVillage4 = new Village();
            Village MonVillage5 = new Village();
            Village MonVillage6 = new Village();
            Village MonVillage7 = new Village();
            Village MonVillage8 = new Village();
            Village MonVillage9 = new Village();
            Village MonVillage10 = new Village();
            Village MonVillage11 = new Village();
            Village MonVillage12 = new Village();

            if (compteur > 1)
            {
                this.Controls.Remove(groupView1);
                this.Controls.Remove(groupView2);
                this.Controls.Remove(groupView3);
                this.Controls.Remove(groupView4);
                this.Controls.Remove(groupView5);
                this.Controls.Remove(groupView6);
                this.Controls.Remove(groupView7);
                this.Controls.Remove(groupView8);
                this.Controls.Remove(groupView9);
                this.Controls.Remove(groupView10);
                this.Controls.Remove(groupView11);
                this.Controls.Remove(groupView12);

            }
            
            TraitementVillage(CheminDuFichier1, MonVillage,      0, 0);
            TraitementVillage(CheminDuFichier2, MonVillage2,   226, 0);
            TraitementVillage(CheminDuFichier3, MonVillage3,   452, 0);
            TraitementVillage(CheminDuFichier4, MonVillage4,   678, 0);
            TraitementVillage(CheminDuFichier5, MonVillage5,   904, 0);
            TraitementVillage(CheminDuFichier6, MonVillage6,     0, 266);
            TraitementVillage(CheminDuFichier7, MonVillage7,   226, 266);
            TraitementVillage(CheminDuFichier8, MonVillage8,   452, 266);
            TraitementVillage(CheminDuFichier9, MonVillage9,   678, 266);
            TraitementVillage(CheminDuFichier10, MonVillage10, 904, 266);
            TraitementVillage(CheminDuFichier11, MonVillage11,   0, 532);
            TraitementVillage(CheminDuFichier12, MonVillage12,   226, 532);


            this.groupView1 = MonVillage.groupBoxVillage;
            this.groupView2 = MonVillage2.groupBoxVillage;
            this.groupView3 = MonVillage3.groupBoxVillage;
            this.groupView4 = MonVillage4.groupBoxVillage;
            this.groupView5 = MonVillage5.groupBoxVillage;
            this.groupView6 = MonVillage6.groupBoxVillage;
            this.groupView7 = MonVillage7.groupBoxVillage;
            this.groupView8 = MonVillage8.groupBoxVillage;
            this.groupView9 = MonVillage9.groupBoxVillage;
            this.groupView10 = MonVillage10.groupBoxVillage;
            this.groupView11 = MonVillage11.groupBoxVillage;
            this.groupView12 = MonVillage12.groupBoxVillage;

            Time(sender);

            //MessageBox.Show("Affichage des villages");
            this.Controls.Add(groupView1);
            this.Controls.Add(groupView2);
            this.Controls.Add(groupView3);
            this.Controls.Add(groupView4);
            this.Controls.Add(groupView5);
            this.Controls.Add(groupView6);
            this.Controls.Add(groupView7);
            this.Controls.Add(groupView8);
            this.Controls.Add(groupView9);
            this.Controls.Add(groupView10);
            this.Controls.Add(groupView11);
            this.Controls.Add(groupView12);


            this.button1.Show();
            this.textBoxSecondes.Show();
            this.label1.Show();
            this.ValueTime.Visible = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            timer1.Interval = Convert.ToInt32(textBoxSecondes.Text)*1000*60;
            timer1.Enabled = true;
            if (StatusAutoLabel.Text == "Off")
            {              
                StatusAutoLabel.Text = "On";
                StatusAutoLabel.ForeColor = Color.LimeGreen;
                            
                MessageBox.Show("Mode automatique activé ");
                timer1.Start();                                      
            }

            else  
            {
                StatusAutoLabel.Text = "Off";
                StatusAutoLabel.ForeColor = Color.Red;
                MessageBox.Show("Mode automatique désactivé");
                timer1.Stop();
            }        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            buttonDemarrer_Click(sender, e);
        }
   

    }
}
