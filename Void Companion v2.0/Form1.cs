using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Void_Companion_v2._0
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Item_Piece[] Pieces;

        private Item[] Items;

        private Tower[] Towers;
        private Rotation[] Rotations;
        string saveFileLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString() + @"\VoidCompanion.txt";
        //string saveFileLocation = @"C:\VoidCompanion.txt";

        private CheckBox[] Boxes;
        private TextBox[] Texts;
        public Form()
        {
            InitializeComponent();

            Boxes = new CheckBox[5] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5 };
            Texts = new TextBox[5] { textBox1, textBox2, textBox3, textBox4, textBox5 };


            //!!!!!!!!!!!!!THIS STUFF IS WHAT NEEDS TO BE UPDATED IN UPDATES!!!!!!!!!
            Items = new Item[]
            {
                new Item("Error"), new Item("Akbronco"), new Item("Akstiletto"), new Item("Ash"), new Item("Braton"), new Item("Bronco"), new Item("Burston"), new Item("Carrier"), new Item("Dual Kamas"), new Item("Fang"), new Item("Forma"), new Item("Fragor"), new Item("Hikou"), new Item("Kavasa"), new Item("Lex"), new Item("Nikana"), new Item("Nova"), new Item("Nyx"), new Item("Odonata"), new Item("Orthos"), new Item("Paris"), new Item("Saryn"), new Item("Scindo"), new Item("Soma"), new Item("Spira"), new Item("Trinity"), new Item("Vasto"), new Item("Vauban"), new Item("Vectis"), new Item("Volt"), new Item("") //Blank item: for Forma, Mods, Keys, Items.
            };

            Pieces = new Item_Piece[]
            {
                new Item_Piece("Error",getItem(""),0,0),

                new Item_Piece("Blueprint",getItem("Akbronco"),10,0),
                new Item_Piece("Link",getItem("Akbronco"),0,30),
                new Item_Piece("Bronco Prime",getItem("Akbronco"),0,0,2),

                new Item_Piece("Blueprint",getItem("Akstiletto"),50,0),
                new Item_Piece("Barrel",getItem("Akstiletto"),0,30),
                new Item_Piece("Receiver",getItem("Akstiletto"),0,30),
                new Item_Piece("Link",getItem("Akstiletto"),0,30),

                new Item_Piece("Blueprint",getItem("Ash"),50,0),
                new Item_Piece("Chasis",getItem("Ash"),20,20),
                new Item_Piece("Helmet",getItem("Ash"),30,50),
                new Item_Piece("Systems",getItem("Ash"),50,50),

                new Item_Piece("Blueprint",getItem("Braton"),20,0),
                new Item_Piece("Barrel",getItem("Braton"),0,30),
                new Item_Piece("Receiver",getItem("Braton"),0,30),
                new Item_Piece("Stock",getItem("Braton"),0,20),

                new Item_Piece("Blueprint",getItem("Bronco"),10,0),
                new Item_Piece("Barrel",getItem("Bronco"),0,50),
                new Item_Piece("Receiver",getItem("Bronco"),0,20),

                new Item_Piece("Blueprint",getItem("Burston"),20,0),
                new Item_Piece("Barrel",getItem("Burston"),0,20),
                new Item_Piece("Receiver",getItem("Burston"),0,30),
                new Item_Piece("Stock",getItem("Burston"),0,10),

                new Item_Piece("Blueprint",getItem("Carrier"),20,0),
                new Item_Piece("Carapace",getItem("Carrier"),0,50),
                new Item_Piece("Cerebrum",getItem("Carrier"),0,50),
                new Item_Piece("Systems",getItem("Carrier"),0,30),

                new Item_Piece("Blueprint",getItem("Dual Kamas"),20,0),
                new Item_Piece("Blade",getItem("Dual Kamas"),0,50,2),
                new Item_Piece("Handle",getItem("Dual Kamas"),0,20,2),

                new Item_Piece("Blueprint",getItem("Fang"),20,0),
                new Item_Piece("Blade",getItem("Fang"),0,10,2),
                new Item_Piece("Handle",getItem("Fang"),0,20,2),

                new Item_Piece("Forma Blueprint",getItem(""),0,0),
                new Item_Piece("Forma",getItem(""),0,0),

                new Item_Piece("Blueprint",getItem("Fragor"),30,0),
                new Item_Piece("Handle",getItem("Fragor"),0,10),
                new Item_Piece("Head",getItem("Fragor"),0,30),

                new Item_Piece("Blueprint",getItem("Hikou"),10,0),
                new Item_Piece("Pouch",getItem("Hikou"),0,20),
                new Item_Piece("Stars",getItem("Hikou"),0,20),

                new Item_Piece("Blueprint",getItem("Kavasa"),30,0),
                new Item_Piece("Band",getItem("Kavasa"),0,50),
                new Item_Piece("Buckle",getItem("Kavasa"),0,50),

                new Item_Piece("Blueprint",getItem("Lex"),10,0),
                new Item_Piece("Barrel",getItem("Lex"),0,20),
                new Item_Piece("Receiver",getItem("Lex"),0,30),

                new Item_Piece("Blueprint",getItem("Nikana"),50,0),
                new Item_Piece("Blade",getItem("Nikana"),0,50),
                new Item_Piece("Hilt",getItem("Nikana"),0,30),

                new Item_Piece("Blueprint",getItem("Nova"),10,0),
                new Item_Piece("Chasis",getItem("Nova"),50,50),
                new Item_Piece("Helmet",getItem("Nova"),20,20),
                new Item_Piece("Systems",getItem("Nova"),50,50),

                new Item_Piece("Blueprint",getItem("Nyx"),50,0),
                new Item_Piece("Chasis",getItem("Nyx"),50,50),
                new Item_Piece("Helmet",getItem("Nyx"),50,50),
                new Item_Piece("Systems",getItem("Nyx"),10,50),

                new Item_Piece("Blueprint",getItem("Odonata"),30,0),
                new Item_Piece("Harness",getItem("Odonata"),30,40),
                new Item_Piece("Systems",getItem("Odonata"),30,40),
                new Item_Piece("Wings",getItem("Odonata"),30,40),

                new Item_Piece("Blueprint",getItem("Orthos"),10,0),
                new Item_Piece("Blade",getItem("Orthos"),0,10),
                new Item_Piece("Handle",getItem("Orthos"),0,10),

                new Item_Piece("Blueprint",getItem("Paris"),10,0),
                new Item_Piece("Grip",getItem("Paris"),0,30),
                new Item_Piece("Upper Limb",getItem("Paris"),0,10),
                new Item_Piece("Lower Limb",getItem("Paris"),0,10),
                new Item_Piece("String",getItem("Paris"),0,10),

                new Item_Piece("Blueprint",getItem("Saryn"),30,0),
                new Item_Piece("Chasis",getItem("Saryn"),20,20),
                new Item_Piece("Helmet",getItem("Saryn"),30,50),
                new Item_Piece("Systems",getItem("Saryn"),50,50),

                new Item_Piece("Blueprint",getItem("Scindo"),50,0),
                new Item_Piece("Blade",getItem("Scindo"),0,50),
                new Item_Piece("Handle",getItem("Scindo"),0,30),

                new Item_Piece("Blueprint",getItem("Soma"),10,0),
                new Item_Piece("Stock",getItem("Soma"),0,50),
                new Item_Piece("Receiver",getItem("Soma"),0,30),
                new Item_Piece("Barrel",getItem("Soma"),0,10),

                new Item_Piece("Blueprint",getItem("Spira"),10,0),
                new Item_Piece("Blade",getItem("Spira"),0,20),
                new Item_Piece("Pouch",getItem("Spira"),0,20),

                new Item_Piece("Blueprint",getItem("Trinity"),30,0),
                new Item_Piece("Chasis",getItem("Trinity"),30,20),
                new Item_Piece("Helmet",getItem("Trinity"),30,50),
                new Item_Piece("Systems",getItem("Trinity"),50,50),

                new Item_Piece("Blueprint",getItem("Vasto"),50,0),
                new Item_Piece("Barrel",getItem("Vasto"),0,10),
                new Item_Piece("Receiver",getItem("Vasto"),0,30),

                new Item_Piece("Blueprint",getItem("Vauban"),50,0),
                new Item_Piece("Chasis",getItem("Vauban"),50,50),
                new Item_Piece("Helmet",getItem("Vauban"),50,50),
                new Item_Piece("Systems",getItem("Vauban"),50,50),

                new Item_Piece("Blueprint",getItem("Vectis"),50,0),
                new Item_Piece("Barrel",getItem("Vectis"),0,20),
                new Item_Piece("Receiver",getItem("Vectis"),0,50),
                new Item_Piece("Stock",getItem("Vectis"),0,50),

                new Item_Piece("Blueprint",getItem("Volt"),30,0),
                new Item_Piece("Chasis",getItem("Volt"),50,50),
                new Item_Piece("Helmet",getItem("Volt"),20,50),
                new Item_Piece("Systems",getItem("Volt"),30,50),


                new Item_Piece("Tower I Capture",getItem("")),
                new Item_Piece("Tower II Capture",getItem("")),
                new Item_Piece("Tower III Capture",getItem("")),
                new Item_Piece("Tower IV Capture",getItem("")),

                new Item_Piece("Tower I Exterminate",getItem("")),
                new Item_Piece("Tower II Exterminate",getItem("")),
                new Item_Piece("Tower III Exterminate",getItem("")),
                new Item_Piece("Tower IV Exterminate",getItem("")),
                new Item_Piece("Orokin Derelict Exterminate",getItem("")),

                new Item_Piece("Tower I Mobile Defense",getItem("")),
                new Item_Piece("Tower II Mobile Defense",getItem("")),
                new Item_Piece("Tower III Mobile Defense",getItem("")),
                new Item_Piece("Tower IV Mobile Defense",getItem("")),

                new Item_Piece("Tower I Defense",getItem("")),
                new Item_Piece("Tower II Defense",getItem("")),
                new Item_Piece("Tower III Defense",getItem("")),
                new Item_Piece("Tower IV Defense",getItem("")),
                new Item_Piece("Tower IV Defense",getItem("")),
                new Item_Piece("Orokin Derelict Defense",getItem("")),

                new Item_Piece("Tower I Sabotage",getItem("")),
                new Item_Piece("Tower II Sabotage",getItem("")),
                new Item_Piece("Tower III Sabotage",getItem("")),
                new Item_Piece("Tower IV Sabotage",getItem("")),

                new Item_Piece("Tower I Survival",getItem("")),
                new Item_Piece("Tower II Survival",getItem("")),
                new Item_Piece("Tower III Survival",getItem("")),
                new Item_Piece("Tower IV Survival",getItem("")),
                new Item_Piece("Orokin Derelict Survival",getItem("")),

                new Item_Piece("Tower IV Interception",getItem("")),


                new Item_Piece("Uncommon Fusion Core x1",getItem("")),
                new Item_Piece("Uncommon Fusion Core x2",getItem("")),
                new Item_Piece("Uncommon Fusion Core x3",getItem("")),
                new Item_Piece("Uncommon Fusion Core x5",getItem("")),

                new Item_Piece("Rare Fusion Core x1",getItem("")),
                new Item_Piece("Rare Fusion Core x2",getItem("")),
                new Item_Piece("Rare Fusion Core x3",getItem("")),
                new Item_Piece("Rare Fusion Core x5",getItem("")),


                new Item_Piece("Orokin Cell x1",getItem("")),
                new Item_Piece("Orokin Cell x2",getItem("")),
                new Item_Piece("Orokin Cell x3",getItem("")),
                new Item_Piece("Orokin Cell x5",getItem("")),

                new Item_Piece("Mutalist Alad V Nav Coord",getItem(""))

            };

            Towers = new Tower[]
            {
                new Tower("Error",
                    new Item_Piece[] {},
                    new double[] {}
                ),

                new Tower("Tower I Capture",
                    new Item_Piece[] { getPiece("Blueprint","Odonata"), getPiece("Grip","Paris"),getPiece("Forma Blueprint",""),getPiece("Tower I Defense",""),getPiece("String","Paris"),getPiece("Receiver","Lex"),getPiece("Tower II Capture","")},
                    new double[] {5.64,5.64,5.64,25.81,25.81,5.64,25.81}
                ),
                new Tower("Tower II Capture",
                    new Item_Piece[] {getPiece("Handle","Orthos"), getPiece("String","Paris"), getPiece("Forma Blueprint",""), getPiece("Blade","Orthos"), getPiece("Blueprint","Volt"), getPiece("Blueprint","Nyx"), getPiece("Band","Kavasa")},
                    new double[] { 14.29, 14.29, 14.29, 14.29, 14.29, 14.29, 14.29}
                ),
                new Tower("Tower III Capture",
                    new Item_Piece[] {getPiece("Hilt","Nikana"), getPiece("Forma Blueprint",""), getPiece("Pouch","Spira"), getPiece("Blade","Dual Kamas"), getPiece("Link","Akbronco"), getPiece("Barrel","Burston"), getPiece("Barrel","Lex")},
                    new double[] { 5.64,25.81,5.64,5.64,5.64,25.81,25.81}
                ),
                new Tower("Tower IV Capture",
                    new Item_Piece[] {getPiece("Systems","Nyx"), getPiece("Forma Blueprint",""), getPiece("Receiver","Bronco"), getPiece("Blueprint","Volt"), getPiece("Link","Akbronco"), getPiece("Rare Fusion Core x5", "") },
                    new double[] {19.36,19.36,19.36,11.28,19.36,11.28}
                ),
                
                   
                new Tower("Tower I Exterminate",
                    new Item_Piece[] { getPiece("Blueprint","Scindo"), getPiece("Blueprint","Fragor"), getPiece("Forma Blueprint",""), getPiece("Tower I Mobile Defense",""), getPiece("Tower II Exterminate",""), getPiece("Stock","Burston") },
                    new double[] { 7.52,7.52,7.52,25.81,25.81,25.81 }
                ),
                new Tower("Tower II Exterminate",
                    new Item_Piece[] { getPiece("Cerebrum","Carrier"), getPiece("Helmet","Volt"), getPiece("Blueprint","Nova"), getPiece("Forma Blueprint",""), getPiece("Blueprint","Orthos"), getPiece("Systems","Saryn"), getPiece("Systems","Volt") },
                    new double[] { 7.52,19.36,19.36,19.36,7.52,19.36,7.52 }
                ),
                new Tower("Tower III Exterminate",
                    new Item_Piece[] { getPiece("Chasis","Nyx"), getPiece("Stock","Soma"), getPiece("Receiver","Vasto"), getPiece("Blueprint","Nikana"), getPiece("Blueprint","Saryn"), getPiece("Systems","Nyx") },
                    new double[] { 5.64,5.64,38.72,5.64,5.64,38.72 }
                ),
                new Tower("Tower IV Exterminate",
                    new Item_Piece[] { getPiece("Buckle","Kavasa"), getPiece("Forma Blueprint",""), getPiece("Harness","Odonata"), getPiece("Pouch","Hikou"), getPiece("Blueprint","Saryn"), getPiece("Receiver","Vectis"), getPiece("Rare Fusion Core x5","") },
                    new double[] { 5.64,5.64,25.81,25.81,5.64,5.64,25.81 }
                ),


                new Tower("Tower I Mobile Defense",
                    new Item_Piece[] { getPiece("Helmet","Saryn"), getPiece("Blueprint","Vectis"), getPiece("Barrel","Braton"), getPiece("Forma Blueprint",""), getPiece("Tower I Capture",""), getPiece("Tower II Mobile Defense","") },
                    new double[] { 7.52,7.52,25.81,7.52,25.81,25.81 }
                ),
                new Tower("Tower II Mobile Defense",
                    new Item_Piece[] { getPiece("Blueprint","Burston"), getPiece("Helmet","Nyx"), getPiece("Blueprint","Vasto"), getPiece("Blueprint","Braton"), getPiece("Barrel","Vasto"), getPiece("Blueprint","Spira") },
                    new double[] { 19.36,11.28,11.28,19.36,19.36,19.36 }
                ),
                new Tower("Tower III Mobile Defense",
                    new Item_Piece[] { getPiece("Stock","Vectis"), getPiece("Systems","Trinity"), getPiece("Blade","Scindo"), getPiece("Forma Blueprint",""), getPiece("Blade","Spira"), getPiece("Barrel","Soma"), getPiece("Receiver","Burston") },
                    new double[] { 5.64,5.64,5.64,25.81,5.64,25.81,25.81 }
                ),
                new Tower("Tower IV Mobile Defense",
                    new Item_Piece[] { getPiece("Carapace","Carrier"), getPiece("Blueprint","Kavasa"), getPiece("Receiver","Vasto"), getPiece("Forma Blueprint",""), getPiece("Blueprint","Spira"), getPiece("Rare Fusion Core x5","") },
                    new double[] { 16.67,16.67,16.67,16.67,16.67,16.67 }
                ),


                new Tower("Tower I Sabotage",
                    new Item_Piece[] { getPiece("Handle","Scindo"), getPiece("Harness","Odonata"), getPiece("Stars","Hikou"), getPiece("Blueprint","Nova"), getPiece("Systems","Odonata"), getPiece("Barrel","Vasto") },
                    new double[] { 11.28,11.28,19.36,19.36,19.36,19.36 }
                ),
                new Tower("Tower II Sabotage",
                    new Item_Piece[] { getPiece("Helmet","Nyx"), getPiece("Helmet","Vauban"), getPiece("Blueprint","Hikou"), getPiece("Blueprint","Bronco"), getPiece("Chasis","Volt"), getPiece("Pouch","Hikou"), getPiece("Helmet","Trinity") },
                    new double[] { 5.64,5.64,25.81,25.81,5.64,25.81,5.64 }
                ),
                new Tower("Tower III Sabotage",
                    new Item_Piece[] { getPiece("Blueprint","Nyx"), getPiece("Forma Blueprint",""), getPiece("Blade","Scindo"), getPiece("Helmet","Nova"), getPiece("Barrel","Bronco"), getPiece("Barrel","Soma"), getPiece("Blueprint","Vauban"), getPiece("Forma","") },
                    new double[] { 25.29,25.29,5.53,5.53,5.53,25.29,5.53,2.01 }
                ),
                new Tower("Tower IV Sabotage",
                    new Item_Piece[] { getPiece("Receiver","Akstiletto"), getPiece("Systems","Nyx"), getPiece("Systems","Carrier"), getPiece("Forma Blueprint",""), getPiece("Head","Fragor"), getPiece("Band","Kavasa"), getPiece("Helmet","Ash"), getPiece("Helmet","Nova") },
                    new double[] { 7.52,15.49,15.49,7.52,15.49,7.52,15.49,15.49 }
                ),

            };

            Rotations = new Rotation[]
            {
                new Rotation("Error",
                    new Item_Piece[] {  },
                    new double[] {  },
                    new Item_Piece[] {  },
                    new double[] {  },
                    new Item_Piece[] {  },
                    new double[] {  }
                ),

                new Rotation("Tower I Defense",
                    new Item_Piece[] { getPiece("Rare Fusion Core x1",""), getPiece("Tower I Capture",""), getPiece("Tower III Capture",""), getPiece("Tower II Mobile Defense","")},
                    new double[] { 38.72,38.72,11.28,11.28},
                    new Item_Piece[] { getPiece("Rare Fusion Core x2", ""), getPiece("Tower I Mobile Defense", ""), getPiece("Tower II Defense",""), getPiece("Orokin Cell x1",""), getPiece("Tower II Mobile Defense",""), getPiece("Tower II Capture","")},
                    new double[] { 15.49,15.49,15.49,22.56,15.49,15.49 },
                    new Item_Piece[] { getPiece("Receiver","Vasto"), getPiece("Systems","Carrier"), getPiece("Forma Blueprint",""), getPiece("Stars","Hikou"), getPiece("Handle","Scindo")},
                    new double[] { 11.28,25.81,11.28,25.81,25.81 }
                ),
                new Rotation("Tower II Defense",
                    new Item_Piece[] { getPiece("Rare Fusion Core x2",""), getPiece("Uncommon Fusion Core x2",""), getPiece("Blueprint","Soma"), getPiece("Orokin Cell x2",""), getPiece("Blade","Orthos") },
                    new double[] { 20,20,20,20,20 },
                    new Item_Piece[] { getPiece("Rare Fusion Core x2",""), getPiece("Uncommon Fusion Core x2",""), getPiece("Stock","Burston"), getPiece("Blueprint","Paris") },
                    new double[] { 25,25,25,25 },
                    new Item_Piece[] { getPiece("Handle","Fang"), getPiece("Stock","Braton"), getPiece("Receiver","Lex"), getPiece("Upper Limb","Paris"), getPiece("Blueprint","Fang") },
                    new double[] { 20,20,20,20,20 }
                ),
                new Rotation("Tower III Defense",
                    new Item_Piece[] { getPiece("Rare Fusion Core x3",""), getPiece("Chasis","Trinity"), getPiece("Orokin Cell x1",""), getPiece("Uncommon Fusion Core x3","") },
                    new double[] { 25,25,25,25 },
                    new Item_Piece[] { getPiece("Rare Fusion Core x5",""), getPiece("Uncommon Fusion Core x5",""), getPiece("Blueprint","Lex"), getPiece("String","Paris"), getPiece("Blueprint","Burston") },
                    new double[] { 20,20,20,20,20 },
                    new Item_Piece[] { getPiece("Barrel","Braton"), getPiece("Receiver","Braton"), getPiece("Forma Blueprint",""), getPiece("Blueprint","Ash"), getPiece("Stock","Braton"), getPiece("Blueprint","Nyx"), getPiece("Handle","Fragor") },
                    new double[] { 7.52,7.52,19.36,7.52,19.36,19.36,19.36 }
                ),
                new Rotation("Tower IV Defense",
                    new Item_Piece[] { getPiece("Rare Fusion Core x5",""), getPiece("Forma Blueprint",""), getPiece("Blueprint","Lex"), getPiece("Handle","Orthos"), getPiece("Barrel","Vectis") },
                    new double[] { 20,20,20,20,20 },
                    new Item_Piece[] { getPiece("Barrel","Braton"), getPiece("Receiver","Braton"), getPiece("Systems","Carrier"), getPiece("Rare Fusion Core x5","") },
                    new double[] { 25,25,25,25 },
                    new Item_Piece[] { getPiece("Blueprint","Akstiletto"), getPiece("Chasis","Vauban"), getPiece("Blueprint","Trinity"), getPiece("Blueprint","Odonata"), getPiece("Carapace","Carrier"), getPiece("Receiver","Burston"), getPiece("Pouch","Hikou"), getPiece("Rare Fusion Core x5","") },
                    new double[] { 5.64,5.64,5.64,19.36,19.36,19.36,19.36,5.64 }
                ),
                new Rotation("Orokin Derelict Defense",
                    new Item_Piece[] { getPiece("Rare Fusion Core x3",""), getPiece("Uncommon Fusion Core x3",""), getPiece("Tower I Capture",""), getPiece("Tower I Defense",""), getPiece("Tower I Survival",""), getPiece("Tower I Mobile Defense",""), getPiece("Tower I Exterminate","") },
                    new double[] { 14.29,14.29,14.29,14.29,14.29,14.29,14.29 },
                    new Item_Piece[] { getPiece("Rare Fusion Core x3",""), getPiece("Uncommon Fusion Core x3",""), getPiece("Mutalist Alad V Nav Coord","") },
                    new double[] { 38.72,38.72,22.56 },
                    new Item_Piece[] { getPiece("Blueprint","Trinity"), getPiece("Handle","Dual Kamas"), getPiece("Stock","Soma"), getPiece("Tower II Mobile Defense",""), getPiece("Tower II Capture",""), getPiece("Tower II Exterminate",""), getPiece("Forma Blueprint",""), getPiece("Tower II Defense",""), getPiece("Tower II Survival","") },
                    new double[] { 12.91,7.52,7.52,12.91,12.91,12.91,7.52,12.91,12.91 }
                ),


                new Rotation("Tower I Survival",
                    new Item_Piece[] { getPiece("Rare Fusion Core x1",""), getPiece("Barrel","Burston"), getPiece("Tower I Defense",""), getPiece("Tower III Exterminate",""), getPiece("Tower I Capture",""), getPiece("Systems","Odonata") },
                    new double[] { 16.67,16.67,16.67,16.67,16.67,16.67 },
                    new Item_Piece[] { getPiece("Rare Fusion Core x1",""), getPiece("Tower II Survival",""), getPiece("Uncommon Fusion Core x1",""), getPiece("Tower II Mobile Defense",""), getPiece("Tower II Capture","") },
                    new double[] { 7.52,7.52,7.52,38.72,38.72 },
                    new Item_Piece[] { getPiece("Handle","Scindo"), getPiece("Upper Limb","Paris"), getPiece("Systems","Volt"), getPiece("Lower Limb","Paris"), getPiece("Stock","Burston"), getPiece("Helmet","Nova") },
                    new double[] { 7.52,7.52,7.52,25.81,25.81,25.81 }
                ),
                new Rotation("Tower II Survival",
                    new Item_Piece[] { getPiece("Rare Fusion Core x2",""), getPiece("Orokin Cell x1",""), getPiece("Blueprint","Akbronco"), getPiece("Lower Limb","Paris"), getPiece("Forma Blueprint","") },
                    new double[] { 20,20,20,20,20 },
                    new Item_Piece[] { getPiece("Blueprint","Soma"), getPiece("Blade","Fang"), getPiece("Rare Fusion Core x2",""), getPiece("Uncommon Fusion Core x2",""), getPiece("Blueprint","Hikou") },
                    new double[] { 20,20,20,20,20 },
                    new Item_Piece[] { getPiece("Receiver","Burston"), getPiece("Receiver","Soma"), getPiece("Blueprint","Paris"), getPiece("Chasis","Ash"), getPiece("Blade","Nikana"), getPiece("Blueprint","Bronco"), getPiece("Chasis","Trinity") },
                    new double[] { 7.52,7.52,19.36,19.36,7.52,19.36,19.36 }
                ),
                new Rotation("Tower III Survival",
                    new Item_Piece[] { getPiece("Rare Fusion Core x3",""), getPiece("Blueprint","Fang"), getPiece("Blade","Fang"), getPiece("Uncommon Fusion Core x3",""), getPiece("Orokin Cell x3","") },
                    new double[] { 20,20,20,20,20 },
                    new Item_Piece[] { getPiece("Uncommon Fusion Core x3",""), getPiece("Rare Fusion Core x3",""), getPiece("Barrel","Vectis"), getPiece("Barrel","Lex"), getPiece("Helmet","Volt") },
                    new double[] { 20,20,20,20,20 },
                    new Item_Piece[] { getPiece("Blueprint","Lex"), getPiece("Blueprint","Carrier"), getPiece("Systems","Vauban"), getPiece("Systems","Ash"), getPiece("Chasis","Saryn"), getPiece("Blueprint","Dual Kamas"), getPiece("Chasis","Nova"), getPiece("Forma","") },
                    new double[] { 25.29,25.29,5.53,5.53,5.53,25.29,5.53,2.01 }
                ),
                new Rotation("Tower IV Survival",
                    new Item_Piece[] { getPiece("Uncommon Fusion Core x5",""), getPiece("Chasis","Ash"), getPiece("Blueprint","Dual Kamas"), getPiece("Orokin Cell x3","") },
                    new double[] { 25,25,25,25 },
                    new Item_Piece[] { getPiece("Blueprint","Orthos"), getPiece("Rare Fusion Core x5",""), getPiece("Receiver","Bronco"), getPiece("Barrel","Lex") },
                    new double[] { 25,25,25,25 },
                    new Item_Piece[] { getPiece("Link","Akstiletto"), getPiece("Blueprint","Braton"), getPiece("Forma Blueprint",""), getPiece("Wings","Odonata"), getPiece("Blueprint","Vasto"), getPiece("Helmet","Ash"), getPiece("Rare Fusion Core x5","") },
                    new double[] { 14.29,14.29,14.29,14.29,14.29,14.29,14.29 }
                ),
                new Rotation("Orokin Derelict Survival",
                    new Item_Piece[] { getPiece("Rare Fusion Core x3",""), getPiece("Uncommon Fusion Core x3",""), getPiece("Tower I Exterminate",""), getPiece("Tower I Mobile Defense","") },
                    new double[] { 25,25,25,25 },
                    new Item_Piece[] { getPiece("Tower I Capture",""), getPiece("Tower I Defense",""), getPiece("Tower I Exterminate",""), getPiece("Tower I Mobile Defense",""), getPiece("Mutalist Alad V Nav Coord","") },
                    new double[] { 20,20,20,20,20 },
                    new Item_Piece[] { getPiece("Barrel","Burston"), getPiece("Tower II Capture",""), getPiece("Tower II Mobile Defense",""), getPiece("Tower II Exterminate",""), getPiece("Systems","Nova"), getPiece("Forma Blueprint","") },
                    new double[] { 19.36,19.36,19.36,19.36,11.28,11.28 }
                ),



                new Rotation("Tower IV Interception",
                    new Item_Piece[] { getPiece("Rare Fusion Core x5",""), getPiece("Blueprint","Carrier"), getPiece("Blueprint","Akbronco"), getPiece("Blueprint","Kavasa") },
                    new double[] { 25,25,25,25 },
                    new Item_Piece[] { getPiece("Barrel","Vectis"), getPiece("Rare Fusion Core x5",""), getPiece("Blueprint","Hikou"), getPiece("Forma Blueprint","") },
                    new double[] { 25,25,25,25 },
                    new Item_Piece[] { getPiece("Barrel","Akstiletto"), getPiece("Barrel","Soma"), getPiece("Handle","Fang"), getPiece("Receiver","Lex"), getPiece("Grip","Paris"), getPiece("Barrel","Bronco"), getPiece("Forma Blueprint","") },
                    new double[] { 14.29,14.29,14.29,14.29,14.29,14.29,14.29 }
                )
            };

            loadText();
            reSize();
        }

        private Item getItem(string name)
        {
            for (int i = 0; i < Items.Length; i++)
            {
                if (Items[i].Name == name)
                {
                    return Items[i];
                }
            }

            return Items[0];
        }

        private Item_Piece getPiece(string name, string parent)
        {
            for (int i = 0; i < Pieces.Length; i++)
            {
                if (Pieces[i].Parent == getItem(parent) && Pieces[i].Name == name)
                    return Pieces[i];
            }
            return Pieces[0];
        }

        private void cbxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this method:
            //finding item:
            //check towers to see if they have a piece that belongs to this item
            //
            //
            //

            string name = cbxItem.SelectedItem.ToString();
            Item item = getItem(name);
            lblLocation.Text = "" + name.ToUpper() + " PRIME\n";

            List<Item_Piece> Pieces = new List<Item_Piece>(); //List of the item pieces = Blueprint, Barrel, Stock, Receiver, etc.
            List<Item_PieceC> dropTables = new List<Item_PieceC>(); //List of drops from tower that is the item!
            foreach (Tower t in Towers) //check all towers!
            {
                foreach (Item_PieceC i in t.Drops) //check all items in this tower!
                {
                    if (i.Piece.Parent == item) //HOLY SHIT THIS IS FROM THE ITEM!!!!!
                    {
                        if (!dropTables.Contains(i)) //this should be irrelivant, but gonna jsut make sure we didn't already throw this specific tower drop table in the list
                            dropTables.Add(i);

                        if (!Pieces.Contains(i.Piece)) //okay we didn't already list it for the items list.
                            Pieces.Add(i.Piece); //add the piece to the list!
                    }
                }
            } //only got lists for tower, check rotation!

            foreach (Rotation r in Rotations) //check all rotations!
            {
                foreach (Item_PieceC i in r.RotA) //check all items in this rotation A!
                {
                    if (i.Piece.Parent == item) //HOLY SHIT THIS IS FROM THE ITEM!!!!!
                    {
                        if (!dropTables.Contains(i)) //this should be irrelivant, but gonna jsut make sure we didn't already throw this specific tower drop table in the list
                            dropTables.Add(i);

                        if (!Pieces.Contains(i.Piece)) //okay we didn't already list it for the items list.
                            Pieces.Add(i.Piece); //add the piece to the list!
                    }
                }

                foreach (Item_PieceC i in r.RotB) //check all items in this rotation B!
                {
                    if (i.Piece.Parent == item) //HOLY SHIT THIS IS FROM THE ITEM!!!!!
                    {
                        if (!dropTables.Contains(i)) //this should be irrelivant, but gonna jsut make sure we didn't already throw this specific tower drop table in the list
                            dropTables.Add(i);

                        if (!Pieces.Contains(i.Piece)) //okay we didn't already list it for the items list.
                            Pieces.Add(i.Piece); //add the piece to the list!
                    }
                }

                foreach (Item_PieceC i in r.RotC) //check all items in this rotation C!
                {
                    if (i.Piece.Parent == item) //HOLY SHIT THIS IS FROM THE ITEM!!!!!
                    {
                        if (!dropTables.Contains(i)) //this should be irrelivant, but gonna jsut make sure we didn't already throw this specific tower drop table in the list
                            dropTables.Add(i);

                        if (!Pieces.Contains(i.Piece)) //okay we didn't already list it for the items list.
                            Pieces.Add(i.Piece); //add the piece to the list!
                    }
                }
            } //k we should have the lists we need, now let's write it!!

            Pieces.Sort((x,y) => x.Name.CompareTo(y.Name));
            for (int i = 0; i < Pieces.Count; i++) //alphabetically, barrel comes first, this remedies that.
            {
                if (Pieces[i].Name == "Blueprint") //is blueprint
                {
                    Item_Piece clone = Pieces[i];
                    Pieces.RemoveAt(i);
                    Pieces.Insert(0, clone);
                }
            }

            foreach (Item_Piece p in Pieces) //do each piece, blueprint, then barrel, then etc.
            {

                lblLocation.Text += "\n" + p.Name.ToUpper() + " [ " + p.Ducats_U + " | " + p.Ducats_C + " ]D \n";
                foreach(Item_PieceC d in dropTables) //do each dropTable
                {
                    if (d.Piece == p) //this drop table is for this piece!
                    {
                        if (d.ParentTower != null) //this is from a tower
                            lblLocation.Text += "" + d.ParentTower.Name + " [" + d.Chance + "%]\n"; //write the item
                        else if (d.ParentRotation != null) //this is from a rotation
                            lblLocation.Text += "" + d.ParentRotation.Name + " " + d.Rot + " [" + d.Chance + "%]\n"; //write the item
                    }
                }
            }
        }

        private void cbxTower_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbxTower.SelectedItem.ToString();
            lblTower.Text = name + "\n\n";

            int ducatsTotalU = 0;
            int ducatsTotalC = 0;
            Tower tower = Towers[0]; //default at 1 so no crash, should always change V

            foreach (Tower t in Towers) //check towers
            {
                if (t.Name == name) //this one!
                {
                    for (int i = 0; i < t.Drops.Length; i++) //list of drops!!
                    {
                        ducatsTotalU += t.Drops[i].Piece.Ducats_U;
                        ducatsTotalC += t.Drops[i].Piece.Ducats_C;
                        tower = t;

                        if (t.Drops[i].Piece.Parent.Name != "")
                            lblTower.Text += t.Drops[i].Piece.Parent.Name + " " + t.Drops[i].Piece.Name + " [" + t.Drops[i].Chance.ToString() + "%] [" + t.Drops[i].Piece.Ducats_U + " | " + t.Drops[i].Piece.Ducats_C + "]\n";
                        else
                            lblTower.Text += t.Drops[i].Piece.Name + " [" + t.Drops[i].Chance.ToString() + "%] [" + t.Drops[i].Piece.Ducats_U + " | " + t.Drops[i].Piece.Ducats_C + "]\n";
                    }
                }
            }

            lblTower.Text = lblTower.Text.Insert(name.Length, "\nDucats: [ " + ducatsU(tower.Drops) + " | " + ducatsC(tower.Drops) + " ]/mission (Applied %)" );
        }

        private void cbxRot_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbxRot.SelectedItem.ToString();
            lblRotation.Text = name;

            lblRotA.Text = "Rotation A";
            lblRotB.Text = "Rotation B";
            lblRotC.Text = "Rotation C";

            double ducatsTotalU = 0;
            double ducatsTotalC = 0;
            //int totalAmount = 0;

            Rotation rot = Rotations[0]; //default at 1 so no crash, should always change V

            foreach (Rotation r in Rotations) //check rotations
            {
                if (r.Name == name) //this one!
                {
                    lblRotA.Text += " [ " + ducatsU(r.RotA) + " | " + ducatsC(r.RotA) + " ] x2\n\n";
                    lblRotB.Text += " [ " + ducatsU(r.RotB) + " | " + ducatsC(r.RotB) + " ]\n\n";
                    lblRotC.Text += " [ " + ducatsU(r.RotC) + " | " + ducatsC(r.RotC) + " ]\n\n";

                    for (int i = 0; i < r.RotA.Length; i++) //rotA loop to write
                    {
                        if (r.RotA[i].Piece.Parent.Name != "")
                            lblRotA.Text += r.RotA[i].Piece.Parent.Name + " " + r.RotA[i].Piece.Name + " [" + r.RotA[i].Chance.ToString() + "%] [" + r.RotA[i].Piece.Ducats_U + " | " + r.RotA[i].Piece.Ducats_C + "]\n";
                        else
                            lblRotA.Text += r.RotA[i].Piece.Name + " [" + r.RotA[i].Chance.ToString() + "%] [" + r.RotA[i].Piece.Ducats_U + " | " + r.RotA[i].Piece.Ducats_C + "]\n";
                    }

                    for (int i = 0; i < r.RotB.Length; i++) //RotB loop to write
                    {
                        if (r.RotB[i].Piece.Parent.Name != "")
                            lblRotB.Text += r.RotB[i].Piece.Parent.Name + " " + r.RotB[i].Piece.Name + " [" + r.RotB[i].Chance.ToString() + "%] [" + r.RotB[i].Piece.Ducats_U + " | " + r.RotB[i].Piece.Ducats_C + "]\n";
                        else
                            lblRotB.Text += r.RotB[i].Piece.Name + " [" + r.RotB[i].Chance.ToString() + "%] [" + r.RotB[i].Piece.Ducats_U + " | " + r.RotB[i].Piece.Ducats_C + "]\n";
                    }

                    for (int i = 0; i < r.RotC.Length; i++) //rotA loop to write
                    {
                        if (r.RotC[i].Piece.Parent.Name != "")
                            lblRotC.Text += r.RotC[i].Piece.Parent.Name + " " + r.RotC[i].Piece.Name + " [" + r.RotC[i].Chance.ToString() + "%] [" + r.RotC[i].Piece.Ducats_U + " | " + r.RotC[i].Piece.Ducats_C + "]\n";
                        else
                            lblRotC.Text += r.RotC[i].Piece.Name + " [" + r.RotC[i].Chance.ToString() + "%] [" + r.RotC[i].Piece.Ducats_U + " | " + r.RotC[i].Piece.Ducats_C + "]\n";
                    }

                    rot = r;
                }
            }

            double ducatsUFromA = ducatsU(rot.RotA);
            double ducatsCFromA = ducatsC(rot.RotA);
            double ducatsUFromB = ducatsU(rot.RotB);
            double ducatsCFromB = ducatsC(rot.RotB);
            double ducatsUFromC = ducatsU(rot.RotC);
            double ducatsCFromC = ducatsC(rot.RotC);

            ducatsTotalU = Math.Round((ducatsUFromA * 2) + ducatsUFromB + ducatsUFromC, 2);
            ducatsTotalC = Math.Round((ducatsCFromA * 2) + ducatsCFromB + ducatsCFromC, 2);

            lblRotation.Text += " | Ducats: [ " + ducatsTotalU + " | " + ducatsTotalC + " ] /20w : [ " + Math.Round(ducatsTotalU / 4, 2) + " | " + Math.Round(ducatsTotalC / 4, 2) + " ] /5w if 20";
        }

        private double ducatsU(Item_PieceC[] drops) // calculates ducats by %
        {
            double totalDucats = 0;

            for(int i = 0; i < drops.Length; i++)
            {
                totalDucats += (drops[i].Chance * .01) * drops[i].Piece.Ducats_U;
            }

            totalDucats = Math.Round(totalDucats, 2);

            return totalDucats;
        }

        private double ducatsC(Item_PieceC[] drops) // calculates ducats by %
        {
            double totalDucats = 0;

            for (int i = 0; i < drops.Length; i++)
            {
                totalDucats += (drops[i].Chance * .01) * drops[i].Piece.Ducats_C;
            }

            totalDucats = Math.Round(totalDucats, 2);

            return totalDucats;
        }

        private void reSize()
        {
            lblLocation.Width = pnlItems.Width - 2;
            lblLocation.Height = pnlItems.Height - 2;
            lblLocation.Left = 1;
            lblLocation.Top = 1;

            lblTower.Width = pnlTower.Width - 2;
            lblTower.Height = pnlTower.Height - 2;
            lblTower.Left = 1;
            lblLocation.Top = 1;

            lblRotation.Width = pnlRotation.Width - 2;
            lblRotation.Height = pnlRotation.Height - 2;
            lblRotation.Left = 1;
            lblRotation.Top = 1;

            pnlRotA.Left = 5;
            pnlRotA.Top = 19;
            lblRotA.Width = pnlRotA.Width - 2;
            lblRotA.Height = pnlRotA.Height - 2;
            lblRotA.Left = 1;
            lblRotA.Top = 1;

            lblBoxes.Width = pnlBoxes.Width - 2;
            lblBoxes.Height = pnlBoxes.Height - 2;
            lblBoxes.Left = 1;
            lblBoxes.Top = 1;

            pnlRotC.Left = 5;
            pnlRotC.Top = 8 + (pnlRotation.Height / 2);
            lblRotC.Width = pnlRotC.Width - 2;
            lblRotC.Height = pnlRotC.Height - 2;
            lblRotC.Left = 1;
            lblRotC.Top = 1;

            pnlRotB.Top = 19;
            lblRotB.Width = pnlRotB.Width - 2;
            lblRotB.Height = pnlRotB.Height - 2;
            lblRotB.Left = 1;
            lblRotB.Top = 1;
            pnlRotB.Left = pnlRotC.Left + pnlRotC.Width / 2 + 3;

            lblDisclaimer.Top = pnlRotation.Top + pnlRotation.Height + 2;
        }

        int getBool(bool b)
        {
            if (b == false)
                return 0;
            else
                return 1;
        }

        private void loadText()
        {
            string[] lines = new string[5] { "0", "0", "0", "0", "0" };

            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(saveFileLocation);
                String line;
                int counter = 0;

                while ((line = file.ReadLine()) != null)
                {
                    lines[counter] = line;
                    counter++;
                }

                file.Close();
            }
            catch (Exception e)
            {

            }

            for(int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("1"))
                    Boxes[i].Checked = true;
                else
                    Boxes[i].Checked = false;

                Texts[i].Text = lines[i].Substring(1);
            }
        }

        private void updateText(object sender, EventArgs e)
        {
            string[] lines = new string[5];
            for(int i = 0; i < Boxes.Length; i++)
            {
                lines[i] = getBool(Boxes[i].Checked).ToString() + "" + Texts[i].Text.ToString();
            }
            //string[] lines = new string[5] { getBool(checkBox1.Checked).ToString() + .Text.ToString(),
            //    getBool(checkBox2.Checked).ToString() + checkBox1.Text,
            //    getBool(checkBox3.Checked).ToString() + checkBox1.Text,
            //    getBool(checkBox4.Checked).ToString() + checkBox1.Text,
            //    getBool(checkBox5.Checked).ToString() + checkBox1.Text
            //};

            writeTo(lines);
        }

        private void writeTo(string[] lines)
        {
            System.IO.File.WriteAllLines(saveFileLocation, lines);
        }

        private void lblBig_Click(object sender, EventArgs e)
        {
            lblBig.Visible = false;
        }

        private void toBig(object sender, EventArgs e)
        {
            Label[] labels = new Label[5] { lblLocation, lblTower, lblRotA, lblRotB, lblRotC };

            for(int i=0; i < labels.Length; i++)
            {
                if (sender.Equals(labels[i]))
                {
                    lblBig.Visible = true;
                    lblBig.Text = labels[i].Text;
                }
            }
        }
    }
}
