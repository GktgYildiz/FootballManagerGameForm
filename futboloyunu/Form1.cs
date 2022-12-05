using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Image = System.Drawing.Image;

namespace FootballManagerForm
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public double[] statistic = new double[12];
        public double[] statistic2 = new double[12];
        #region ALL CLASSES
        class Team : IDisposable
        {

            private string PlayerName;
            public string PLAYERNAME
            {
                get { return PlayerName; }
                set { PlayerName = value; }
            }


            private string ImageLoc;
            public string IMAGELOC
            {
                get { return ImageLoc; }
                set { ImageLoc = value; }
            }


            public double Stats;
            public double STATS
            {
                get { return Stats; }
                set { Stats = value; }
            }

            public double Stats2;
            public double STATS2
            {
                get { return Stats2; }
                set { Stats2 = value; }
            }

           
            private int FormNo;
            public int FORMNO
            {
                get { return FormNo; }
                set { FormNo = value; }
            }


            public void Dispose()
            {
                //throw new NotImplementedException();
            }
        }


        #region TECHNICAL DIRECTER CLASS
        class TechDir : Team
        {
            #region technical Director Array
            public string[,] Technic = new string[7, 3]
            {
                {
                    "Jorge Jesus", "88", "D:\\fmoyunu0312\\Directors\\Jesus.png"
                },
                {
                    "Okan Buruk", "78", "D:\\fmoyunu0312\\Directors\\Buruk.png"
                },
                {
                    "Şenol Güneş", "80", "D:\\fmoyunu0312\\Directors\\Gunes.png"
                },
                {
                    "J.Nagelsmann", "92", "D:\\fmoyunu0312\\Directors\\Nagelsmann.png"
                },
                {
                    "Edin Terzic", "86", "D:\\fmoyunu0312\\Directors\\Terzic.png"
                },
                {
                    "Marco Rose", "81", "D:\\fmoyunu0312\\Directors\\Rose.png"
                },
                {
                    "Fatih Terim", "89", "D:\\fmoyunu0312\\Directors\\Terim.png"
                }
            };
           

            #endregion
        }
        #endregion

        #region GOALKEEPER CLASS
        class Goalkeeper1 : Team
        {
            #region Goalkeepers Array of team
            public string[,] GoalKeepers = new string[6, 3]
           {
                {
                    "Altay", "78", "D:\\fmoyunu0312\\Kaleciler\\AltayB.png"
                },
                {
                    "Muslera", "80", "D:\\fmoyunu0312\\Kaleciler\\Muslera.png"
                },
                {
                    "Ersin D.", "75", "D:\\fmoyunu0312\\Kaleciler\\ErsinD.png"
                },
                {
                    "M.Neuer", "90", "D:\\fmoyunu0312\\Kaleciler\\Neuer.png"
                },
                {
                    "Kobel", "84", "D:\\fmoyunu0312\\Kaleciler\\Kobel.png"
                },
                {
                   "Gulacsi", "85", "D:\\fmoyunu0312\\Kaleciler\\Gulacsi.png"
                }
           };

            #endregion
            
        }

        #endregion

        #region DEFANCE CLASSES
        class Defance1 : Team
        {
            #region DEFANCE PLAYER 1 ARRAY
            public string[,] Defance1Array = new string[6, 3]
            {
                {
                    "A.Szalai", "77", "D:\\fmoyunu0312\\Defance\\Szalai.png"
                },
                {
                    "V.Nelsson", "74", "D:\\fmoyunu0312\\Defance\\Nelsson.png"
                },
                {
                    "Tayyip S.", "74", "D:\\fmoyunu0312\\Defance\\Tayyip.png"
                },
                {
                    "M.de Ligt", "89", "D:\\fmoyunu0312\\Defance\\Ligt.png"
                },
                {
                    "R.Guerreiro", "82", "D:\\fmoyunu0312\\Defance\\Guerreiro.png"
                },
                {
                    "J.Gvardiol", "85", "D:\\fmoyunu0312\\Defance\\Gvardiol.png"
                }
            };
            #endregion
            
        }

        class Defance2 : Team
        {
            #region DEFANCE PLAYER 2 ARRAY
            public string[,] Defance2Array = new string[6, 3]
            {
                {
                    "G.Henrique", "66", "D:\\fmoyunu0312\\Defance\\Henrique.png"
                },
                {
                    "P.Aanholt", "77", "D:\\fmoyunu0312\\Defance\\Aanholt.png"
                },
                {
                    "F.Montero","75", "D:\\fmoyunu0312\\Defance\\Montero.png"
                },
                {
                    "Dayot U.", "82", "D:\\fmoyunu0312\\Defance\\Upamecano.png"
                },
                {
                     "Nico S.", "86", "D:\\fmoyunu0312\\Defance\\Schlotterbeck.png"
                },
                {
                    "M.Simakan","83", "D:\\fmoyunu0312\\Defance\\Simakan.png"
                }
            };
            #endregion
            
        }

        class Defance3 : Team
        {
            #region DEFANCE PLAYER 3 ARRAY
            public string[,] Defance3Array = new string[6, 3]
            {
                {
                    "N.Sangare", "75", "D:\\fmoyunu0312\\Defance\\Sangare.png"
                },
                {
                    "Sacha Boey", "77", "D:\\fmoyunu0312\\Defance\\Boey.png"
                },
                {
                    "Welinton", "69", "D:\\fmoyunu0312\\Defance\\Welinton.png"
                },
                {
                    "L.Hernandez", "86", "D:\\fmoyunu0312\\Defance\\Hernandez.png"
                },
                {
                     "Niklas S.", "87", "D:\\fmoyunu0312\\Defance\\Sule.png"
                },
                {
                    "David Raum", "83", "D:\\fmoyunu0312\\Defance\\Raum.png"
                }
            };
            #endregion
           
        }

        class Defance4 : Team
        {
            #region DEFANCE PLAYER 4 ARRAY
            public string[,] Defance4Array = new string[6, 3]
            {
                {
                    "Ferdi K.", "68", "D:\\fmoyunu0312\\Defance\\FerdiK.png"
                },
                {
                    "M. Ross", "72", "D:\\fmoyunu0312\\Defance\\Ross.png"
                },
                {
                    "V. Rosier", "80", "D:\\fmoyunu0312\\Defance\\Rosier.png"
                },
                {
                    "A. Davies", "87", "D:\\fmoyunu0312\\Defance\\Davies.png"
                },
                {
                     "M. Hummels", "84", "D:\\fmoyunu0312\\Defance\\Hummels.png"
                },
                {
                    "A. Diallo", "78", "D:\\fmoyunu0312\\Defance\\Diallo.png"
                }
            };
            #endregion
           
        }
        #endregion
        

        #region MIDDLE CLASSES

        class Middle1 : Team
        {
            #region Middle PLAYER 1 ARRAY
            public string[,] Mid1Array = new string[6, 3]
            {
                {
                    "M.Crespo","76","D:\\fmoyunu0312\\Mids\\Crespo.png"
                },
                {
                    "Kerem A.","78","D:\\fmoyunu0312\\Mids\\Kerem.png"
                },
                {
                    "Souza","78","D:\\fmoyunu0312\\Mids\\Souza.png"
                },
                {
                    "K.Coman","87","D:\\fmoyunu0312\\Mids\\Coman.png"
                },
                {
                    "Emre Can","82","D:\\fmoyunu0312\\Mids\\Emre.png"
                },
                {
                    "C.Nkunku","86","D:\\fmoyunu0312\\Mids\\Nkunku.png"
                }
            };
            #endregion
           
        }

        class Middle2 : Team
        {
            #region Middle PLAYER 2 ARRAY
            public string[,] Mid2Array = new string[6, 3]
            {
                {
                    "Miha Zajc","75","D:\\fmoyunu0312\\Mids\\Zajc.png"
                },
                {
                    "Juan Mata","76","D:\\fmoyunu0312\\Mids\\Mata.png"
                },
                {
                   "NKoudou","75","D:\\fmoyunu0312\\Mids\\Crespo.png"
                },
                {
                   "Gnabry","85","D:\\fmoyunu0312\\Mids\\Crespo.png"
                },
                {
                   "Reus","85","D:\\fmoyunu0312\\Mids\\Crespo.png"
                },
                {
                   "Szoboszlai","87","D:\\fmoyunu0312\\Mids\\Crespo.png"
                }
            };
            #endregion
            
        }

        class Middle3 : Team
        {
            #region Middle PLAYER 3 ARRAY
            public string[,] Mid3Array = new string[6, 3]
            {
                {
                   "Arda Güler","80","D:\\fmoyunu0312\\Mids\\Güler.png"
                },
                {
                    "L.Torreira","82","D:\\fmoyunu0312\\Mids\\Torreira.png"
                },
                {
                    "R.Ghezzal","79","D:\\fmoyunu0312\\Mids\\Ghezzal.png"
                },
                {
                   "Sadio Mane","89","D:\\fmoyunu0312\\Mids\\Mane.png"
                },
                {
                   "J.Bellingham","90","D:\\fmoyunu0312\\Mids\\Bellingham.png"
                },
                {
                   "A.Haidara","82","D:\\fmoyunu0312\\Mids\\Haidara.png"
                }
            };
            #endregion
           
        }

        class Middle4 : Team
        {
            #region Middle PLAYER 4 ARRAY
            public string[,] Mid4Array = new string[6, 3]
            {
                {
                   "Joao Pedro","79","D:\\fmoyunu0312\\Mids\\Pedro.png"
                },
                {
                    "Seferovic","76","D:\\fmoyunu0312\\Mids\\Seferovic.png"
                },
                {
                    "Weghorst","79","D:\\fmoyunu0312\\Mids\\Weghorst.png"
                },
                {
                   "Müller","87","D:\\fmoyunu0312\\Mids\\Müller.png"
                },
                {
                   "S.Haller","82","D:\\fmoyunu0312\\Mids\\Haller.png"
                },
                {
                   "Y.Poulsen","77","D:\\fmoyunu0312\\Mids\\Poulsen.png"
                }
            };
            #endregion
           
        }
        #endregion

        #region FORWARD CLASSES
        class Forward1 : Team
        {
            #region FORWARD PLAYER 1 ARRAY
            public string[,] Fw1Array = new string[6, 3]
            {
                {
                   "Michy Batshuayi","77","D:\\fmoyunu0312\\Forwards\\Batshuayi.png"
                },
                {
                    "Mauro Icardi","77","D:\\fmoyunu0312\\Forwards\\Icardi.png"
                },
                {
                    "Jackson Muleka","80","D:\\fmoyunu0312\\Forwards\\Muleka.png"
                },
                {
                   "Kingsley Coman","87","D:\\fmoyunu0312\\Forwards\\Coman.png"
                },
                {
                   "Karim Adeyemi","87","D:\\fmoyunu0312\\Forwards\\Adeyemi.png"
                },
                {
                   "Timo Werner","83","D:\\fmoyunu0312\\Forwards\\Werner.png"
                }
            };
            #endregion
           
        }
        class Forward2 : Team
        {
            #region FORWARD PLAYER 2 ARRAY
            public string[,] Fw2Array = new string[6, 3]
            {
                {
                   "E.Valencia","75","D:\\fmoyunu0312\\Forwards\\Valencia.png"
                },
                {
                    "D.Mertens","84","D:\\fmoyunu0312\\Forwards\\Mertens.png"
                },
                {
                    "Dele Alli","80","D:\\fmoyunu0312\\Forwards\\Alli.png"
                },
                {
                   "J. Musiala","90","D:\\fmoyunu0312\\Forwards\\Musiala.png"
                },
                {
                   "Y.Moukoko","88","D:\\fmoyunu0312\\Forwards\\Moukoko.png"
                },
                {
                   "Andre Silva","83","D:\\fmoyunu0312\\Forwards\\Silva.png"
                }
            };
            #endregion
           
        }
        #endregion
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
        #region diziler

        #region takımlar
        string[] TurkishTeams = new string[3] { "Beşiktaş", "Galatasaray", "Fenerbahçe" };
        string[] GermanTeams = new string[3] { "Bayern Münih", "Borussia Dortmund", "RB Liepzig" };


        #endregion
        #endregion

        private void takimlariyapbtn_Click(object sender, EventArgs e)
        {
            StartbtnWh.Visible = true;
            team1progressbar.Visible = true;
            team2progressbar.Visible = true;
            team1scorelbl.Visible = false;
            team2scorelbl.Visible = false;
            label8.Visible = false;
            #region Choosing Technical Director for Team-1


            using (TechDir tt = new TechDir())
            {
                
                int num = RandomNumber(7);
                int num2 = RandomNumber(7);
                while (num == num2)
                {
                     num2 = RandomNumber(7);
                }

                tt.PLAYERNAME = NameOfP(num, tt.Technic);
                tdname.Text = tt.PLAYERNAME;
                tt.STATS = StatP(num, tt.Technic);
                tdstat1.Text = tt.STATS.ToString();
                statistic[0] = tt.STATS;
                tt.IMAGELOC = PicLocP(num, tt.Technic);
                tdpcbx.Image = Image.FromFile(tt.IMAGELOC);


                tt.PLAYERNAME = NameOfP(num2, tt.Technic);
                tdname2.Text = tt.PLAYERNAME;
                tt.STATS2 = StatP(num2, tt.Technic);
                statistic2[0] = tt.STATS2;
                tdstat2.Text = tt.STATS2.ToString();
                tt.IMAGELOC = PicLocP(num2, tt.Technic);
                tdpcbx2.Image = Image.FromFile(tt.IMAGELOC);

                #region STAT LABEL COLOR
                if (tt.STATS <= 79)
                {
                    tdstat1.BackColor = Color.Yellow;
                }
                else if (tt.STATS >= 80 && tt.STATS < 84)
                {
                    tdstat1.BackColor = Color.Orange;
                }
                else
                {
                    tdstat1.BackColor = Color.GreenYellow;
                }


                if (tt.STATS2 <= 79)
                {
                    tdstat2.BackColor = Color.Yellow;
                }
                else if (tt.STATS2 >= 80 && tt.STATS2 < 84)
                {
                    tdstat2.BackColor = Color.Orange;
                }
                else
                {
                    tdstat2.BackColor = Color.GreenYellow;
                }
                #endregion
            }
            #endregion
            

            #region Choosing GoalKeeper for Team-1

            using (Goalkeeper1 gk1 = new Goalkeeper1())
            {

                int num = RandomNumber(6);
                int num2 = RandomNumber(6);
                while (num == num2)
                {
                    num2 = RandomNumber(6);
                }
                gk1.PLAYERNAME = NameOfP(num, gk1.GoalKeepers);
                gkteam1namelbl.Text = gk1.PLAYERNAME;
                gk1.STATS = StatP(num, gk1.GoalKeepers);
                gkteam1statlbl.Text = gk1.STATS.ToString();
                gk1.IMAGELOC = PicLocP(num, gk1.GoalKeepers);
                kalecibox.Image = Image.FromFile(gk1.IMAGELOC);
                gkformNumlbl.Text = "#" + FormNumGen(1, 9).ToString();
                

                gk1.PLAYERNAME = NameOfP(num2, gk1.GoalKeepers);
                gkteam2namelbl.Text = gk1.PLAYERNAME;
                gk1.STATS2 = StatP(num2, gk1.GoalKeepers);
                gkteam2statlbl.Text = gk1.STATS2.ToString();
                gk1.IMAGELOC = PicLocP(num2, gk1.GoalKeepers);
                kalecibox2.Image = Image.FromFile(gk1.IMAGELOC);
                gkformNumlbl2.Text = "#" + FormNumGen(1, 9).ToString();

                statistic[1] = gk1.STATS;
                statistic2[1] = gk1.STATS2;

                #region STAT LABEL COLOR
                if (gk1.STATS <= 79)
                {
                    gkteam1statlbl.BackColor = Color.Yellow;
                }
                else if (gk1.STATS >= 80 && gk1.STATS < 84)
                {
                    gkteam1statlbl.BackColor = Color.Orange;
                }
                else
                {
                    gkteam1statlbl.BackColor = Color.GreenYellow;
                }


                if (gk1.STATS2 <= 79)
                {
                    gkteam2statlbl.BackColor = Color.Yellow;
                }
                else if (gk1.STATS2 >= 80 && gk1.STATS2 < 84)
                {
                    gkteam2statlbl.BackColor = Color.Orange;
                }
                else
                {
                    gkteam2statlbl.BackColor = Color.GreenYellow;
                }
                #endregion
            }
            #endregion

            #region DEFENCE PLAYERS
            #region Choosing First Defance Player for Team-1
            using (Defance1 def1 = new Defance1())
            {

                int num = RandomNumber(6);
                int num2 = RandomNumber(6);
                while (num == num2)
                {
                    num2 = RandomNumber(6);
                }

                def1.PLAYERNAME = NameOfP(num, def1.Defance1Array);
                def1name1lbl.Text = def1.PLAYERNAME;
                def1.STATS = StatP(num, def1.Defance1Array);
                def1stat1lbl.Text = def1.STATS.ToString();
                def1.IMAGELOC = PicLocP(num, def1.Defance1Array);
                def3box.Image = Image.FromFile(def1.IMAGELOC);
                def1formnumlbl.Text = "#" + FormNumGen(25, 33).ToString();


                def1.PLAYERNAME = NameOfP(num2, def1.Defance1Array);
                def1name2lbl.Text = def1.PLAYERNAME;
                def1.STATS2 = StatP(num2, def1.Defance1Array);
                def1stat2lbl.Text = def1.STATS2.ToString();
                def1.IMAGELOC = PicLocP(num2, def1.Defance1Array);
                def3pic2box.Image = Image.FromFile(def1.IMAGELOC);
                def1formnumlbl2.Text = "#" + FormNumGen(25, 33).ToString();

                statistic[2] = def1.STATS;
                statistic2[2] = def1.STATS2;

                #region STAT LABEL COLOR
                if (def1.STATS <= 79)
                {
                    def1stat1lbl.BackColor = Color.Yellow;
                }
                else if (def1.STATS >= 80 && def1.STATS < 84)
                {
                    def1stat1lbl.BackColor = Color.Orange;
                }
                else
                {
                    def1stat1lbl.BackColor = Color.GreenYellow;
                }

                if (def1.STATS2 <= 79)
                {
                    def1stat2lbl.BackColor = Color.Yellow;
                }
                else if (def1.STATS2 >= 80 && def1.STATS2 < 84)
                {
                    def1stat2lbl.BackColor = Color.Orange;
                }
                else
                {
                    def1stat2lbl.BackColor = Color.GreenYellow;
                }

                #endregion
            }
            #endregion

            #region Choosing Second Defance Player for Team-1
            using (Defance2 def2 = new Defance2())
            {

                int num = RandomNumber(6);
                int num2 = RandomNumber(6);
                while (num == num2)
                {
                    num2 = RandomNumber(6);
                }

                def2.PLAYERNAME = NameOfP(num, def2.Defance2Array);
                def2name1lbl.Text = def2.PLAYERNAME;
                def2.STATS = StatP(num, def2.Defance2Array);
                def2stat1lbl.Text = def2.STATS.ToString();
                def2.IMAGELOC = PicLocP(num, def2.Defance2Array);
                def1box.Image = Image.FromFile(def2.IMAGELOC);
                def2formnumlbl.Text = "#" + FormNumGen(17, 24).ToString();

                def2.PLAYERNAME = NameOfP(num2, def2.Defance2Array);
                def2name2lbl.Text = def2.PLAYERNAME;
                def2.STATS2 = StatP(num2, def2.Defance2Array);
                def2stat2lbl.Text = def2.STATS2.ToString();
                def2.IMAGELOC = PicLocP(num2, def2.Defance2Array);
                def1box2.Image = Image.FromFile(def2.IMAGELOC);
                def2formnumlbl2.Text = "#" + FormNumGen(17, 24).ToString();

                statistic[3] = def2.STATS;
                statistic2[3] = def2.STATS2;

                #region STAT LABEL COLOR
                if (def2.STATS <= 79)
                {
                    def2stat1lbl.BackColor = Color.Yellow;
                }
                else if (def2.STATS >= 80 && def2.STATS < 84)
                {
                    def2stat1lbl.BackColor = Color.Orange;
                }
                else
                {
                    def2stat1lbl.BackColor = Color.GreenYellow;
                }


                if (def2.STATS2 <= 79)
                {
                    def2stat2lbl.BackColor = Color.Yellow;
                }
                else if (def2.STATS2 >= 80 && def2.STATS2 < 84)
                {
                    def2stat2lbl.BackColor = Color.Orange;
                }
                else
                {
                    def2stat2lbl.BackColor = Color.GreenYellow;
                }

                #endregion
            }
            #endregion

            #region Choosing Third Defance Player for Team-1
            using (Defance3 def3 = new Defance3())
            {

                int num = RandomNumber(6);
                int num2 = RandomNumber(6);
                while (num == num2)
                {
                    num2 = RandomNumber(6);
                }

                def3.PLAYERNAME = NameOfP(num, def3.Defance3Array);
                def3name1lbl.Text = def3.PLAYERNAME;
                def3.STATS = StatP(num, def3.Defance3Array);
                def3stat1lbl.Text = def3.STATS.ToString();
                def3.IMAGELOC = PicLocP(num, def3.Defance3Array);
                def2box.Image = Image.FromFile(def3.IMAGELOC);
                def3formnumlbl.Text = "#" + FormNumGen(10, 17).ToString();

                def3.PLAYERNAME = NameOfP(num2, def3.Defance3Array);
                def3name2lbl.Text = def3.PLAYERNAME;
                def3.STATS2 = StatP(num2, def3.Defance3Array);
                def3stat2lbl.Text = def3.STATS2.ToString();
                def3.IMAGELOC = PicLocP(num2, def3.Defance3Array);
                def2box2.Image = Image.FromFile(def3.IMAGELOC);
                def3formnumlbl2.Text = "#" + FormNumGen(10, 17).ToString();

                statistic[4] = def3.STATS;
                statistic2[4] = def3.STATS2;

                #region STAT LABEL COLOR
                if (def3.STATS <= 79)
                {
                    def3stat1lbl.BackColor = Color.Yellow;
                }
                else if (def3.STATS >= 80 && def3.STATS < 84)
                {
                    def3stat1lbl.BackColor = Color.Orange;
                }
                else
                {
                    def3stat1lbl.BackColor = Color.GreenYellow;
                }

                if (def3.STATS2 <= 79)
                {
                    def3stat2lbl.BackColor = Color.Yellow;
                }
                else if (def3.STATS2 >= 80 && def3.STATS2 < 84)
                {
                    def3stat2lbl.BackColor = Color.Orange;
                }
                else
                {
                    def3stat2lbl.BackColor = Color.GreenYellow;
                }

                #endregion
            }
            #endregion

            #region Choosing Fourth Defance Player for Team-1
            using (Defance4 def4 = new Defance4())
            {

                int num = RandomNumber(6);
                int num2 = RandomNumber(6);
                while (num == num2)
                {
                    num2 = RandomNumber(6);
                }

                def4.PLAYERNAME = NameOfP(num, def4.Defance4Array);
                def4name1lbl.Text = def4.PLAYERNAME;
                def4.STATS = StatP(num, def4.Defance4Array);
                def4stat1lbl.Text = def4.STATS.ToString();
                def4.IMAGELOC = PicLocP(num, def4.Defance4Array);
                def4box.Image = Image.FromFile(def4.IMAGELOC);
                def4formnumlbl.Text = "#" + FormNumGen(33, 40).ToString();

                def4.PLAYERNAME = NameOfP(num2, def4.Defance4Array);
                def4name2lbl.Text = def4.PLAYERNAME;
                def4.STATS2 = StatP(num2, def4.Defance4Array);
                def4stat2lbl.Text = def4.STATS2.ToString();
                def4.IMAGELOC = PicLocP(num2, def4.Defance4Array);
                def4box2.Image = Image.FromFile(def4.IMAGELOC);
                def4formnumlbl2.Text = "#" + FormNumGen(33, 40).ToString();

                statistic[5] = def4.STATS;
                statistic2[5] = def4.STATS2;

                #region STAT LABEL COLOR
                if (def4.STATS <= 79)
                {
                    def4stat1lbl.BackColor = Color.Yellow;
                }
                else if (def4.STATS >= 80 && def4.STATS < 84)
                {
                    def4stat1lbl.BackColor = Color.Orange;
                }
                else
                {
                    def4stat1lbl.BackColor = Color.GreenYellow;
                }

                if (def4.STATS2 <= 79)
                {
                    def4stat2lbl.BackColor = Color.Yellow;
                }
                else if (def4.STATS2 >= 80 && def4.STATS2 < 84)
                {
                    def4stat2lbl.BackColor = Color.Orange;
                }
                else
                {
                    def4stat2lbl.BackColor = Color.GreenYellow;
                }
                #endregion


            }
            #endregion
            #endregion

            #region Middle Players
            #region Choosing First Mid Player for Team-1
            using (Middle1 mid1 = new Middle1())
            {

                int num = RandomNumber(6);
                int num2 = RandomNumber(6);
                while (num == num2)
                {
                    num2 = RandomNumber(6);
                }

                mid1.PLAYERNAME = NameOfP(num, mid1.Mid1Array);
                mid1name1lbl.Text = mid1.PLAYERNAME;
                mid1.STATS = StatP(num, mid1.Mid1Array);
                mid1stat1lbl.Text = mid1.STATS.ToString();
                mid1.IMAGELOC = PicLocP(num, mid1.Mid1Array);
                mid1box.Image = Image.FromFile(mid1.IMAGELOC);
                mid1formnumlbl.Text = "#" + FormNumGen(41, 48).ToString();

                mid1.PLAYERNAME = NameOfP(num2, mid1.Mid1Array);
                mid1name2lbl.Text = mid1.PLAYERNAME;
                mid1.STATS2 = StatP(num2, mid1.Mid1Array);
                mid1stat2lbl.Text = mid1.STATS2.ToString();
                mid1.IMAGELOC = PicLocP(num2, mid1.Mid1Array);
                mid1box2.Image = Image.FromFile(mid1.IMAGELOC);
                mid1formnumlbl2.Text = "#" + FormNumGen(41, 48).ToString();

                statistic[6] = mid1.STATS;
                statistic2[6] = mid1.STATS2;

                #region STAT LABEL COLOR
                if (mid1.STATS <= 79)
                {
                    mid1stat1lbl.BackColor = Color.Yellow;
                }
                else if (mid1.STATS >= 80 && mid1.STATS < 84)
                {
                    mid1stat1lbl.BackColor = Color.Orange;
                }
                else
                {
                    mid1stat1lbl.BackColor = Color.GreenYellow;
                }

                if (mid1.STATS2 <= 79)
                {
                    mid1stat2lbl.BackColor = Color.Yellow;
                }
                else if (mid1.STATS2 >= 80 && mid1.STATS2 < 84)
                {
                    mid1stat2lbl.BackColor = Color.Orange;
                }
                else
                {
                    mid1stat2lbl.BackColor = Color.GreenYellow;
                }

                #endregion


            }
            #endregion

            #region Choosing Second Mid Player for Team-1
            using (Middle2 mid2 = new Middle2())
            {

                int num = RandomNumber(6);
                int num2 = RandomNumber(6);
                while (num == num2)
                {
                    num2 = RandomNumber(6);
                }
                mid2.PLAYERNAME = NameOfP(num, mid2.Mid2Array);
                mid2name1lbl.Text = mid2.PLAYERNAME;
                mid2.STATS = StatP(num, mid2.Mid2Array);
                mid2stat1lbl.Text = mid2.STATS.ToString();
                mid2.IMAGELOC = PicLocP(num, mid2.Mid2Array);
                mid2box.Image = Image.FromFile(mid2.IMAGELOC);
                mid2formnumlbl.Text = "#" + FormNumGen(49, 57).ToString();

                mid2.PLAYERNAME = NameOfP(num2, mid2.Mid2Array);
                mid2name2lbl.Text = mid2.PLAYERNAME;
                mid2.STATS2 = StatP(num2, mid2.Mid2Array);
                mid2stat2lbl.Text = mid2.STATS2.ToString();
                mid2.IMAGELOC = PicLocP(num2, mid2.Mid2Array);
                mid2box2.Image = Image.FromFile(mid2.IMAGELOC);
                mid2formnumlbl2.Text = "#" + FormNumGen(49, 57).ToString();

                statistic[7] = mid2.STATS;
                statistic2[7] = mid2.STATS2;

                #region STAT LABEL COLOR
                if (mid2.STATS <= 79)
                {
                    mid2stat1lbl.BackColor = Color.Yellow;
                }
                else if (mid2.STATS >= 80 && mid2.STATS < 84)
                {
                    mid2stat1lbl.BackColor = Color.Orange;
                }
                else
                {
                    mid2stat1lbl.BackColor = Color.GreenYellow;
                }

                if (mid2.STATS2 <= 79)
                {
                    mid2stat2lbl.BackColor = Color.Yellow;
                }
                else if (mid2.STATS2 >= 80 && mid2.STATS2 < 84)
                {
                    mid2stat2lbl.BackColor = Color.Orange;
                }
                else
                {
                    mid2stat2lbl.BackColor = Color.GreenYellow;
                }
                #endregion
            }

            #endregion

            #region Choosing Third Mid Player for Team-1
            using (Middle3 mid3 = new Middle3())
            {

                int num = RandomNumber(6);
                int num2 = RandomNumber(6);
                while (num == num2)
                {
                    num2 = RandomNumber(6);
                }

                mid3.PLAYERNAME = NameOfP(num, mid3.Mid3Array);
                mid3name1lbl.Text = mid3.PLAYERNAME;
                mid3.STATS = StatP(num, mid3.Mid3Array);
                mid3stat1lbl.Text = mid3.STATS.ToString();
                mid3.IMAGELOC = PicLocP(num, mid3.Mid3Array);
                mid3box.Image = Image.FromFile(mid3.IMAGELOC);
                mid3formnumlbl.Text = "#" + FormNumGen(58, 65).ToString();

                mid3.PLAYERNAME = NameOfP(num2, mid3.Mid3Array);
                mid3name1lbl2.Text = mid3.PLAYERNAME;
                mid3.STATS2 = StatP(num2, mid3.Mid3Array);
                mid3stat2lbl.Text = mid3.STATS2.ToString();
                mid3.IMAGELOC = PicLocP(num2, mid3.Mid3Array);
                mid3box2.Image = Image.FromFile(mid3.IMAGELOC);
                mid3formnumlbl2.Text = "#" + FormNumGen(58, 65).ToString();

                statistic[8] = mid3.STATS;
                statistic2[8] = mid3.STATS2;

                #region STAT LABEL COLOR
                if (mid3.STATS <= 79)
                {
                    mid3stat1lbl.BackColor = Color.Yellow;
                }
                else if (mid3.STATS >= 80 && mid3.STATS < 84)
                {
                    mid3stat1lbl.BackColor = Color.Orange;
                }
                else
                {
                    mid3stat1lbl.BackColor = Color.GreenYellow;
                }

                if (mid3.STATS2 <= 79)
                {
                    mid3stat2lbl.BackColor = Color.Yellow;
                }
                else if (mid3.STATS2 >= 80 && mid3.STATS2 < 84)
                {
                    mid3stat2lbl.BackColor = Color.Orange;
                }
                else
                {
                    mid3stat2lbl.BackColor = Color.GreenYellow;
                }
                #endregion
            }
            #endregion

            #region Choosing Fourth Mid Player for Team-1
            using (Middle4 mid4 = new Middle4())
            {

                int num = RandomNumber(6);
                int num2 = RandomNumber(6);
                while (num == num2)
                {
                    num2 = RandomNumber(6);
                }

                mid4.PLAYERNAME = NameOfP(num, mid4.Mid4Array);
                mid4name1lbl.Text = mid4.PLAYERNAME;
                mid4.STATS = StatP(num, mid4.Mid4Array);
                mid4stat1lbl.Text = mid4.STATS.ToString();
                mid4.IMAGELOC = PicLocP(num, mid4.Mid4Array);
                mid4box.Image = Image.FromFile(mid4.IMAGELOC);
                mid4formnumlbl.Text = "#" + FormNumGen(66, 71).ToString();

                mid4.PLAYERNAME = NameOfP(num2, mid4.Mid4Array);
                mid4name2lbl.Text = mid4.PLAYERNAME;
                mid4.STATS2 = StatP(num2, mid4.Mid4Array);
                mid4stat2lbl.Text = mid4.STATS2.ToString();
                mid4.IMAGELOC = PicLocP(num2, mid4.Mid4Array);
                mid4box2.Image = Image.FromFile(mid4.IMAGELOC);
                mid4formnumlbl2.Text = "#" + FormNumGen(66, 71).ToString();

                statistic[9] = mid4.STATS;
                statistic2[9] = mid4.STATS2;

                #region STAT LABEL COLOR
                if (mid4.STATS <= 79)
                {
                    mid4stat1lbl.BackColor = Color.Yellow;
                }
                else if (mid4.STATS >= 80 && mid4.STATS < 84)
                {
                    mid4stat1lbl.BackColor = Color.Orange;
                }
                else
                {
                    mid4stat1lbl.BackColor = Color.GreenYellow;
                }

                if (mid4.STATS2 <= 79)
                {
                    mid4stat2lbl.BackColor = Color.Yellow;
                }
                else if (mid4.STATS2 >= 80 && mid4.STATS2 < 84)
                {
                    mid4stat2lbl.BackColor = Color.Orange;
                }
                else
                {
                    mid4stat2lbl.BackColor = Color.GreenYellow;
                }
                #endregion
            }
            #endregion
            #endregion

            #region Forward Players
            #region Choosing First Forward Players 
            using (Forward1 fw1 = new Forward1())
            {
                int num = RandomNumber(6);
                int num2 = RandomNumber(6);
                while (num == num2)
                {
                    num2 = RandomNumber(6);
                }

                fw1.PLAYERNAME = NameOfP(num, fw1.Fw1Array);
                fw1name1lbl.Text = fw1.PLAYERNAME;
                fw1.STATS = StatP(num, fw1.Fw1Array);
                fw1stat1lbl.Text = fw1.STATS.ToString();
                fw1.IMAGELOC = PicLocP(num, fw1.Fw1Array);
                fw1box1.Image = Image.FromFile(fw1.IMAGELOC);
                fw1formnumlbl.Text = "#" + FormNumGen(71, 85).ToString();

                fw1.PLAYERNAME = NameOfP(num2, fw1.Fw1Array);
                fw1name2lbl.Text = fw1.PLAYERNAME;
                fw1.STATS2 = StatP(num2, fw1.Fw1Array);
                fw1stat2lbl.Text = fw1.STATS2.ToString();
                fw1.IMAGELOC = PicLocP(num2, fw1.Fw1Array);
                fw1box2.Image = Image.FromFile(fw1.IMAGELOC);
                fw1formnumlbl2.Text = "#" + FormNumGen(71, 85).ToString();

                statistic[10] = fw1.STATS;
                statistic2[10] = fw1.STATS2;

                #region STAT LABEL COLOR
                if (fw1.STATS <= 79)
                {
                    fw1stat1lbl.BackColor = Color.Yellow;
                }
                else if (fw1.STATS >= 80 && fw1.STATS < 84)
                {
                    fw1stat1lbl.BackColor = Color.Orange;
                }
                else
                {
                    fw1stat1lbl.BackColor = Color.GreenYellow;
                }

                if (fw1.STATS2 <= 79)
                {
                    fw1stat2lbl.BackColor = Color.Yellow;
                }
                else if (fw1.STATS2 >= 80 && fw1.STATS2 < 84)
                {
                    fw1stat2lbl.BackColor = Color.Orange;
                }
                else
                {
                    fw1stat2lbl.BackColor = Color.GreenYellow;
                }
                #endregion
            }
            #endregion

            #region Choosing Second Forward Player For Team-1 
            using (Forward2 fw2 = new Forward2())
            {

                int num = RandomNumber(6);
                int num2 = RandomNumber(6);
                while (num == num2)
                {
                    num2 = RandomNumber(6);
                }

                fw2.PLAYERNAME = NameOfP(num, fw2.Fw2Array);
                fw2name1lbl.Text = fw2.PLAYERNAME;
                fw2.STATS = StatP(num, fw2.Fw2Array);
                fw2stat1lbl.Text = fw2.STATS.ToString();
                fw2.IMAGELOC = PicLocP(num, fw2.Fw2Array);
                fw2box1.Image = Image.FromFile(fw2.IMAGELOC);
                fw2formnumlbl.Text = "#" + FormNumGen(86, 98).ToString();

                fw2.PLAYERNAME = NameOfP(num2, fw2.Fw2Array);
                fw2name2lbl.Text = fw2.PLAYERNAME;
                fw2.STATS2 = StatP(num2, fw2.Fw2Array);
                fw2stat2lbl.Text = fw2.STATS2.ToString();
                fw2.IMAGELOC = PicLocP(num2, fw2.Fw2Array);
                fw2box2.Image = Image.FromFile(fw2.IMAGELOC);
                fw2formnumlbl2.Text = "#" + FormNumGen(86, 98).ToString();

                statistic[11] = fw2.STATS;
                statistic2[11] = fw2.STATS2;

                #region STAT LABEL COLOR
                if (fw2.STATS <= 79)
                {
                    fw2stat1lbl.BackColor = Color.Yellow;
                }
                else if (fw2.STATS >= 80 && fw2.STATS < 84)
                {
                    fw2stat1lbl.BackColor = Color.Orange;
                }
                else
                {
                    fw2stat1lbl.BackColor = Color.GreenYellow;
                }

                if (fw2.STATS2 <= 79)
                {
                    fw2stat2lbl.BackColor = Color.Yellow;
                }
                else if (fw2.STATS2 >= 80 && fw2.STATS2 < 84)
                {
                    fw2stat2lbl.BackColor = Color.Orange;
                }
                else
                {
                    fw2stat2lbl.BackColor = Color.GreenYellow;
                }
                #endregion
            }
            #endregion
            #endregion


            #region Power of TEAMS
            double Team1StatTotal = 0;
            double Team2StatTotal = 0;
            for (int i = 0; i < 12; i++)
            {
                Team1StatTotal += statistic[i];
                Team2StatTotal += statistic2[i];
            }
            label4.Text = (Math.Round(Team1StatTotal / 12)).ToString();
            label5.Text = (Math.Round(Team2StatTotal / 12)).ToString();
            team1progressbar.Maximum = 100;
            team1progressbar.Minimum = 40;
            team1progressbar.Step = 1;
            team1progressbar.Style = ProgressBarStyle.Blocks;

            for (int i = 40; i < Team1StatTotal/11; i++)
            {
                team1progressbar.Value = i;
                
            }
            team2progressbar.Maximum = 100;
            team2progressbar.Minimum = 40;
            team2progressbar.Step = 1;
            team2progressbar.Style = ProgressBarStyle.Blocks;
            team2progressbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            team2progressbar.RightToLeftLayout = true;

            for (int i = 40; i < Team2StatTotal / 11; i++)
            {
                team2progressbar.Value = i;
                
            }
            #region  kombinasyon

            double r = 0;
            double n = 0;

            //if (Team1StatTotal< Team2StatTotal)
            //{
                 //r = Team1StatTotal / 11;
                 //n = (Team2StatTotal / 11);
            //}
            //else
            //{
                 n = (Team1StatTotal / 12);

                 r = (Team2StatTotal / 12);
            //}
            

            double ilkf = faktoriyel(n);

            double total = Math.Abs(n - r);

            double ortaf = faktoriyel(total);

            double sonf = faktoriyel(r);

            double permutasyon = ilkf / sonf;

            double kombinasyon = ilkf / (sonf * ortaf);
            label6.Text = kombinasyon.ToString();
            label7.Text = permutasyon.ToString();


            #endregion


            #endregion

        }
        public int RandomNumber(int y)
        {
            Random rnd = new Random();
            int num = rnd.Next(0, y);
            return num;
        }
        public string NameOfP(int y, string[,] array)
        {

            string NameOf;
            return NameOf = array[y, 0];
        }

        public string PicLocP(int y, string[,] array)
        {

            string PicLoc;
            return PicLoc = array[y, 2];
        }
        public int StatP(int y, string[,] array)
        {

            int Stat;
            return Stat = int.Parse(array[y, 1]);
        }
        public int FormNumGen(int x, int y)
        {
            Random rnd = new Random();
            int num = rnd.Next(x, y);
            return num;
        }
      


private void teams1cmbx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (teams1cmbx1.SelectedIndex == -1)
            {
                teamlogopic1.Visible = false;
                StartbtnWh.Visible = false;
                matchteam1picbx.Visible = false;
                matchteam2picbx.Visible = false;
                team1progressbar.Visible = false;
                    team2progressbar.Visible = false;
            }
            else
                teamlogopic1.Visible = true;
            switch (teams1cmbx1.SelectedItem)
            {
                case "Beşiktaş":
                    teamlogopic1.Image = Properties.Resources.BJKlogo;
                    matchteam1picbx.Image = Properties.Resources.BJKlogo;
                    break;
                case "Galatasaray":
                    teamlogopic1.Image = Properties.Resources.GSlogo;
                    matchteam1picbx.Image = Properties.Resources.GSlogo;
                    break;
                case "Fenerbahçe":
                    teamlogopic1.Image = Properties.Resources.FBlogo;
                    matchteam1picbx.Image = Properties.Resources.FBlogo;
                    break;
                case "Bayern Münih":
                    teamlogopic1.Image = Properties.Resources.BAYERNlogo;
                    matchteam1picbx.Image = Properties.Resources.BAYERNlogo;
                    break;
                case "Borussia Dortmund":
                    teamlogopic1.Image = Properties.Resources.BVBlogo;
                    matchteam1picbx.Image = Properties.Resources.BVBlogo;
                    break;
                case "RB Liepzig":
                    teamlogopic1.Image = Properties.Resources.LEIPZIGlogo;
                    matchteam1picbx.Image = Properties.Resources.LEIPZIGlogo;
                    break;
                default:
                    break;
            }
        }

        private void countrycmbx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            teams1cmbx1.SelectedIndex = -1;
            teams1cmbx1.Items.Clear();
            teams1cmbx1.Visible = true;
            label2.Visible = true;
            teamlogopic1.Visible = true;

            


            if (teams1cmbx1.SelectedIndex == -1)
            {
                teamlogopic1.Visible = false;
                StartbtnWh.Visible = false;
                matchteam1picbx.Visible = false;
                matchteam2picbx.Visible = false;
                team1progressbar.Visible = false;
                team2progressbar.Visible = false;
            }

            for (int i = 0; i < 3; i++)
            {
                if (countrycmbx1.SelectedIndex == 0)
                {
                    countryflagpic1.Image = Properties.Resources.TurkeyPng;
                    teams1cmbx1.Items.Add(TurkishTeams[i]);
                }
                else
                {
                    countryflagpic1.Image = Properties.Resources.GermanyFlag;

                    teams1cmbx1.Items.Add(GermanTeams[i]);
                }
            }
        }
       
        private void countrycmbx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                teams2cmbx2.SelectedIndex = -1;
                if (teams2cmbx2.SelectedIndex == -1)
                {
                    teamlogopic2.Visible = false;
                  StartbtnWh.Visible = false;
                  matchteam1picbx.Visible = false;
                  matchteam2picbx.Visible = false;
                team1progressbar.Visible = false;
                team2progressbar.Visible = false;
            }
                teams2cmbx2.Items.Clear();

                teams2cmbx2.Visible = true;
                label3.Visible = true;
                teamlogopic2.Visible = true;

                if (teams1cmbx1.SelectedItem != null)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (countrycmbx2.SelectedIndex == 0)
                        {
                            countryflagpic2.Image = Properties.Resources.TurkeyPng;
                            teams2cmbx2.Items.Add(TurkishTeams[i]);
                            
                                if (teams1cmbx1.SelectedItem.ToString() == TurkishTeams[i].ToString())
                                {
                                    teams2cmbx2.Items.Remove(TurkishTeams[i]);
                                }
                        }
                        else
                        {

                            countryflagpic2.Image = Properties.Resources.GermanyFlag;
                            teams2cmbx2.Items.Add(GermanTeams[i]);
                            
                                if (teams1cmbx1.SelectedItem.ToString() == GermanTeams[i].ToString())
                                {
                                    teams2cmbx2.Items.Remove(GermanTeams[i]);
                                }
                        }
                    }
                }
                else
                {
                MessageBox.Show("Lütfen önce 1. takımı seçiniz");
                countrycmbx2.SelectedIndex = -1;
                }
        }

        private void teams2cmbx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (teams1cmbx1.SelectedIndex != -1 && teams2cmbx2.SelectedIndex != -1)
            {
                takimlariyapbtn.Visible = true;

            }
            else
            { 
            takimlariyapbtn.Visible = false;
                StartbtnWh.Visible = false;
                matchteam1picbx.Visible = false;
                matchteam2picbx.Visible = false;
                team1progressbar.Visible = false;
                team2progressbar.Visible = false;
            }
            if (teams2cmbx2.SelectedIndex == -1)
            {
                teamlogopic2.Visible = false;
            }
            else
                teamlogopic2.Visible = true;
            switch (teams2cmbx2.SelectedItem)
            {
                case "Beşiktaş":
                    teamlogopic2.Image = Properties.Resources.BJKlogo;
                    matchteam2picbx.Image = Properties.Resources.BJKlogo;
                    break;
                case "Galatasaray":
                    teamlogopic2.Image = Properties.Resources.GSlogo;
                    matchteam2picbx.Image = Properties.Resources.GSlogo;
                    break;
                case "Fenerbahçe":
                    teamlogopic2.Image = Properties.Resources.FBlogo;
                    matchteam2picbx.Image = Properties.Resources.FBlogo;
                    break;
                case "Bayern Münih":
                    teamlogopic2.Image = Properties.Resources.BAYERNlogo;
                    matchteam2picbx.Image = Properties.Resources.BAYERNlogo;
                    break;
                case "Borussia Dortmund":
                    teamlogopic2.Image = Properties.Resources.BVBlogo;
                    matchteam2picbx.Image = Properties.Resources.BVBlogo;
                    break;
                case "RB Liepzig":
                    teamlogopic2.Image = Properties.Resources.LEIPZIGlogo;
                    matchteam2picbx.Image = Properties.Resources.LEIPZIGlogo;
                    break;
                default:
                    break;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Startmatch_Click(object sender, EventArgs e)
        {
            
        }
        public static double faktoriyel(double sayi)
        {
            double j = 1;
            double fakt = 1;
            while (j <= sayi)
            {
                fakt = fakt * j;
                j++;
            }
            return fakt;
        }
        public void StartbtnWh_Click(object sender, EventArgs e)
        {
            matchteam1picbx.Visible = true;
            matchteam2picbx.Visible = true;
            team1scorelbl.Visible = true;   
            team2scorelbl.Visible = true;
            label8.Visible = true;
            double kTM1 = Convert.ToDouble(label6.Text);
            double pTM2 = Convert.ToDouble(label7.Text);
            if (kTM1 == pTM2 && kTM1==1)
            {
                team1scorelbl.Text = "0";
                team2scorelbl.Text = "0";
            }
            else if (kTM1 == pTM2 && kTM1<50)
            {
                team1scorelbl.Text = "1";
                team2scorelbl.Text = "1";
            }
            else if (kTM1 == pTM2 && kTM1 >=50)
            {
                team1scorelbl.Text = "2";
                team2scorelbl.Text = "2";
            }
            else if (kTM1 == pTM2 && kTM1 >= 100)
            {
                team1scorelbl.Text = "3";
                team2scorelbl.Text = "3";
            }
            else if (kTM1 < pTM2 && kTM1<5000 && kTM1>0)
            {
                team1scorelbl.Text = "0";
                team2scorelbl.Text = "2";
            }
            else if (kTM1 < pTM2 && kTM1 < 10000 && kTM1 > 4000)
            {
                team1scorelbl.Text = "2";
                team2scorelbl.Text = "1";
            }
            else if (kTM1 < pTM2 && kTM1 >= 10000)
            {
                team1scorelbl.Text = "3";
                team2scorelbl.Text = "2";
            }
            else if (kTM1 > pTM2 && pTM2 >= 300000)
            {
                team1scorelbl.Text = "4";
                team2scorelbl.Text = "1";
            }
            else if (kTM1 < pTM2 && kTM1<1)
            {
                team1scorelbl.Text = "0";
                team2scorelbl.Text = "2";
            }
            else if (kTM1 > pTM2 && kTM1 < 1)
            {
                team1scorelbl.Text = "1";
                team2scorelbl.Text = "2";
            }
            else
            {
                team1scorelbl.Text = "1";
                team2scorelbl.Text = "2";
            }
        }

        private void team1progressbar_Layout(object sender, LayoutEventArgs e)
        {

        }
    }
}
