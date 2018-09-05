using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Travian_2._0
{
    class Village
    {
        public String NomVillage { get; set; }        // déclaration depuis .NET 3
        public String Bois { get; set; }
        public String Argile { get; set; }
        public String Fer  { get; set; }
        public String Silo { get; set; }
        public String Cereales { get; set; }
        public String Depot { get; set; }      
        public int BoisManquant { get; set; }
        public int ArgileManquant { get; set; }
        public int FerManquant { get; set; }
        public int CerealesManquant { get; set; }
        public int DepotManquant { get; set; }
        

        public System.Windows.Forms.GroupBox groupBoxVillage { get; set; }
        public System.ComponentModel.ComponentResourceManager resources;
        public System.Windows.Forms.Label labelRessources;
        public System.Windows.Forms.Label labelDisponibles;
        public System.Windows.Forms.Label ValueBois;
        public System.Windows.Forms.Label ValueArgile;
        public System.Windows.Forms.Label ValueFer;
        public System.Windows.Forms.Label ValueCereales;
        public System.Windows.Forms.Label ValueSilo;
        public System.Windows.Forms.Label ValueDepot;
        public System.Windows.Forms.Label ValueUpdateOne;
        public System.Windows.Forms.Label ValuePourcentBois;
        public System.Windows.Forms.Label ValuePourcentArgile;
        public System.Windows.Forms.Label ValuePourcentFer;
        public System.Windows.Forms.Label ValuePourcentCereales;
        public System.Windows.Forms.Label ValueUpdateTwo; 

        public System.Windows.Forms.Label ValueBoisManquant;
        public System.Windows.Forms.Label ValueArgileManquant;
        public System.Windows.Forms.Label ValueFerManquant;
        public System.Windows.Forms.Label ValueCerealesManquant;
        public System.Windows.Forms.Label ValueDepotManquant;       
        
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox7;
        public System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.PictureBox pictureBox2;
        
        public void InitgroupBox()
        {

            this.groupBoxVillage = new System.Windows.Forms.GroupBox();
            this.resources = new System.ComponentModel.ComponentResourceManager();
            this.labelRessources = new System.Windows.Forms.Label();
            this.labelDisponibles = new System.Windows.Forms.Label();
            this.ValueBois = new System.Windows.Forms.Label();
            this.ValueArgile = new System.Windows.Forms.Label();
            this.ValueFer = new System.Windows.Forms.Label();
            this.ValueCereales = new System.Windows.Forms.Label();
            this.ValueSilo = new System.Windows.Forms.Label();
            this.ValueDepot = new System.Windows.Forms.Label();
            this.ValueUpdateOne = new System.Windows.Forms.Label();
            this.ValueUpdateTwo = new System.Windows.Forms.Label();
            this.ValueBoisManquant = new System.Windows.Forms.Label();
            this.ValueArgileManquant = new System.Windows.Forms.Label();
            this.ValueFerManquant = new System.Windows.Forms.Label();
            this.ValueCerealesManquant = new System.Windows.Forms.Label();
            this.ValueDepotManquant = new System.Windows.Forms.Label();
            this.ValuePourcentBois = new System.Windows.Forms.Label();
            this.ValuePourcentArgile = new System.Windows.Forms.Label();
            this.ValuePourcentFer = new System.Windows.Forms.Label() ;
            this.ValuePourcentCereales = new System.Windows.Forms.Label() ;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            // 
            // groupBoxAffiche1
            //                     
            this.groupBoxVillage.Controls.Add(this.ValueFerManquant);
            this.groupBoxVillage.Controls.Add(this.ValueFer);
            this.groupBoxVillage.Controls.Add(this.labelRessources);
            this.groupBoxVillage.Controls.Add(this.labelDisponibles);
            this.groupBoxVillage.Controls.Add(this.ValueCerealesManquant);
            this.groupBoxVillage.Controls.Add(this.ValueDepotManquant);
            this.groupBoxVillage.Controls.Add(this.ValueArgileManquant);
            this.groupBoxVillage.Controls.Add(this.ValueBoisManquant);
            this.groupBoxVillage.Controls.Add(this.ValueUpdateOne);
            this.groupBoxVillage.Controls.Add(this.ValueUpdateTwo);
            this.groupBoxVillage.Controls.Add(this.ValueCereales);
            this.groupBoxVillage.Controls.Add(this.ValueDepot);
            this.groupBoxVillage.Controls.Add(this.ValueSilo);
            this.groupBoxVillage.Controls.Add(this.ValueArgile);
            this.groupBoxVillage.Controls.Add(this.ValueBois);
            this.groupBoxVillage.Controls.Add(this.ValuePourcentBois);
            this.groupBoxVillage.Controls.Add(this.ValuePourcentArgile);
            this.groupBoxVillage.Controls.Add(this.ValuePourcentFer);
            this.groupBoxVillage.Controls.Add(this.ValuePourcentCereales);
            this.groupBoxVillage.Controls.Add(this.pictureBox1);
            this.groupBoxVillage.Controls.Add(this.pictureBox2);
            this.groupBoxVillage.Controls.Add(this.pictureBox3);
            this.groupBoxVillage.Controls.Add(this.pictureBox4);
            this.groupBoxVillage.Controls.Add(this.pictureBox5);
            this.groupBoxVillage.Controls.Add(this.pictureBox6);
            this.groupBoxVillage.Controls.Add(this.pictureBox7);

            this.groupBoxVillage.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBoxVillage.Location = new System.Drawing.Point(10, 10);
            this.groupBoxVillage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxVillage.Size = new System.Drawing.Size(226, 267);
            this.groupBoxVillage.TabIndex = 11;
            this.groupBoxVillage.TabStop = false;         
            this.groupBoxVillage.Text = "";
            
            //
            // ValuePourcentBois
            //

            this.ValuePourcentBois.AutoSize = true;
            this.ValuePourcentBois.Location = new System.Drawing.Point(50, 53);
            this.ValuePourcentBois.Name = "ValuePourcentBois";
            this.ValuePourcentBois.Size = new System.Drawing.Size(16, 13);
            this.ValuePourcentBois.TabIndex = 12;
            this.ValuePourcentBois.Text = "0%";

            //
            // ValuePourcentArgile
            //

            this.ValuePourcentArgile.AutoSize = true;
            this.ValuePourcentArgile.Location = new System.Drawing.Point(50, 80);
            this.ValuePourcentArgile.Name = "ValuePourcentArgile";
            this.ValuePourcentArgile.Size = new System.Drawing.Size(16, 13);
            this.ValuePourcentArgile.TabIndex = 12;
            this.ValuePourcentArgile.Text = "0%";

            //
            // ValuePourcentFer
            //

            this.ValuePourcentFer.AutoSize = true;
            this.ValuePourcentFer.Location = new System.Drawing.Point(50, 107);
            this.ValuePourcentFer.Name = "ValuePourcentFer";
            this.ValuePourcentFer.Size = new System.Drawing.Size(16, 13);
            this.ValuePourcentFer.TabIndex = 12;
            this.ValuePourcentFer.Text = "0%";

            //
            // ValuePourcentCereales
            //

            this.ValuePourcentCereales.AutoSize = true;
            this.ValuePourcentCereales.Location = new System.Drawing.Point(50, 130);
            this.ValuePourcentCereales.Name = "ValuePourcentCereales";
            this.ValuePourcentCereales.Size = new System.Drawing.Size(16, 13);
            this.ValuePourcentCereales.TabIndex = 12;
            this.ValuePourcentCereales.Text = "0%";


            // 
            // pictureBox7
            // 
            
            this.pictureBox7.Image = Image.FromFile("Icon\\Village.png");
            this.pictureBox7.Location = new System.Drawing.Point(25, 223);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(19, 21);
            this.pictureBox7.TabIndex = 22;
            this.pictureBox7.TabStop = false; 
             
            // 
            // pictureBox6
            // 
            
            this.pictureBox6.Image = Image.FromFile("Icon\\Depot.png");
            this.pictureBox6.Location = new System.Drawing.Point(25, 193);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(21, 24);
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            
            this.pictureBox5.Image = Image.FromFile("Icon\\Silo.png");
            this.pictureBox5.Location = new System.Drawing.Point(25, 157);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(21, 30);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            
            this.pictureBox4.Image = Image.FromFile("Icon\\Cereales.png");
            this.pictureBox4.Location = new System.Drawing.Point(25, 129);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(18, 21);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false; 
            // 
            // pictureBox3
            // 
            
            this.pictureBox3.Image = Image.FromFile("Icon\\Fer.png");
            this.pictureBox3.Location = new System.Drawing.Point(25, 103);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            
            this.pictureBox2.Image = Image.FromFile("Icon\\Argile.png");
            this.pictureBox2.Location = new System.Drawing.Point(25, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 21);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            
            this.pictureBox1.Image = Image.FromFile("Icon\\Bois.png");
            this.pictureBox1.Location = new System.Drawing.Point(25, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 20);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // ValueFerManquant
            // 
            this.ValueFerManquant.AutoSize = true;
            this.ValueFerManquant.Location = new System.Drawing.Point(159, 99);
            this.ValueFerManquant.Name = "ValueFerManquant";
            this.ValueFerManquant.Size = new System.Drawing.Size(16, 13);
            this.ValueFerManquant.TabIndex = 13;
            this.ValueFerManquant.Text = "...";
            // 
            // ValueFer
            // 
            this.ValueFer.AutoSize = true;
            this.ValueFer.Location = new System.Drawing.Point(97, 99);
            this.ValueFer.Name = "ValueFer";
            this.ValueFer.Size = new System.Drawing.Size(16, 13);
            this.ValueFer.TabIndex = 12;
            this.ValueFer.Text = "...";
            // 
            // labelRessources
            // 
            this.labelRessources.AutoSize = true;
            this.labelRessources.Location = new System.Drawing.Point(12, 26);
            this.labelRessources.Name = "labelRessources";
            this.labelRessources.Size = new System.Drawing.Size(66, 13);
            this.labelRessources.TabIndex = 12;
            this.labelRessources.Text = "Ressources ";
            // 
            // labelDisponibles
            // 
            this.labelDisponibles.AutoSize = true;
            this.labelDisponibles.Location = new System.Drawing.Point(84, 26);
            this.labelDisponibles.Name = "labelDisponibles";
            this.labelDisponibles.Size = new System.Drawing.Size(125, 13);
            this.labelDisponibles.TabIndex = 12;
            this.labelDisponibles.Text = "Disponibles/Manquantes";
            // 
            // ValueCerealesManquant
            // 
            this.ValueCerealesManquant.AutoSize = true;
            this.ValueCerealesManquant.Location = new System.Drawing.Point(159, 130);
            this.ValueCerealesManquant.Name = "ValueCerealesManquant";
            this.ValueCerealesManquant.Size = new System.Drawing.Size(16, 13);
            this.ValueCerealesManquant.TabIndex = 15;
            this.ValueCerealesManquant.Text = "...";
            // 
            // ValueDepotManquant
            // 
            this.ValueDepotManquant.AutoSize = true;
            this.ValueDepotManquant.Location = new System.Drawing.Point(159, 203);
            this.ValueDepotManquant.Name = "ValueDepotManquant";
            this.ValueDepotManquant.Size = new System.Drawing.Size(16, 13);
            this.ValueDepotManquant.TabIndex = 16;
            this.ValueDepotManquant.Text = "...";
            // 
            // ValueArgileManquant
            // 
            this.ValueArgileManquant.AutoSize = true;
            this.ValueArgileManquant.Location = new System.Drawing.Point(159, 75);
            this.ValueArgileManquant.Name = "ValueArgileManquant";
            this.ValueArgileManquant.Size = new System.Drawing.Size(16, 13);
            this.ValueArgileManquant.TabIndex = 18;
            this.ValueArgileManquant.Text = "...";
            // 
            // ValueBoisManquant
            // 
            this.ValueBoisManquant.AutoSize = true;
            this.ValueBoisManquant.Location = new System.Drawing.Point(159, 50);
            this.ValueBoisManquant.Name = "ValueBoisManquant";
            this.ValueBoisManquant.Size = new System.Drawing.Size(16, 13);
            this.ValueBoisManquant.TabIndex = 19;
            this.ValueBoisManquant.Text = "...";
            // 
            // ValueUpdateTwo
            // 
            this.ValueUpdateTwo.AutoSize = true;
            this.ValueUpdateTwo.Location = new System.Drawing.Point(159, 230);
            this.ValueUpdateTwo.Name = "ValueUpdate2";
            this.ValueUpdateTwo.Size = new System.Drawing.Size(16, 13);
            this.ValueUpdateTwo.TabIndex = 12;
            this.ValueUpdateTwo.Text = "...";
            // 
            // ValueUpdateOne
            // 
            this.ValueUpdateOne.AutoSize = true;
            this.ValueUpdateOne.Location = new System.Drawing.Point(97, 230);
            this.ValueUpdateOne.Name = "ValueUpdate1";
            this.ValueUpdateOne.Size = new System.Drawing.Size(16, 13);
            this.ValueUpdateOne.TabIndex = 13;
            this.ValueUpdateOne.Text = "...";
            // 
            // ValueCereales
            // 
            this.ValueCereales.AutoSize = true;
            this.ValueCereales.Location = new System.Drawing.Point(97, 130);
            this.ValueCereales.Name = "ValueCereales";
            this.ValueCereales.Size = new System.Drawing.Size(16, 13);
            this.ValueCereales.TabIndex = 12;
            this.ValueCereales.Text = "...";
            // 
            // ValueDepot
            // 
            this.ValueDepot.AutoSize = true;
            this.ValueDepot.Location = new System.Drawing.Point(97, 203);
            this.ValueDepot.Name = "ValueDepot";
            this.ValueDepot.Size = new System.Drawing.Size(16, 13);
            this.ValueDepot.TabIndex = 12;
            this.ValueDepot.Text = "...";
            // 
            // ValueSilo
            // 
            this.ValueSilo.AutoSize = true;
            this.ValueSilo.Location = new System.Drawing.Point(97, 170);
            this.ValueSilo.Name = "ValueSilo";
            this.ValueSilo.Size = new System.Drawing.Size(16, 13);
            this.ValueSilo.TabIndex = 12;
            this.ValueSilo.Text = "...";
            // 
            // ValueArgile
            // 
            this.ValueArgile.AutoSize = true;
            this.ValueArgile.Location = new System.Drawing.Point(97, 75);
            this.ValueArgile.Name = "ValueArgile";
            this.ValueArgile.Size = new System.Drawing.Size(16, 13);
            this.ValueArgile.TabIndex = 12;
            this.ValueArgile.Text = "...";
            // 
            // ValueBois
            // 
            this.ValueBois.AutoSize = true;
            this.ValueBois.Location = new System.Drawing.Point(97, 50);
            this.ValueBois.Name = "ValueBois";
            this.ValueBois.Size = new System.Drawing.Size(16, 13);
            this.ValueBois.TabIndex = 12;
            this.ValueBois.Text = "...";
        }

        ~Village()
        { 

        }

    }
}
