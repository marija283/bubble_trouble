using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bubble_Trouble
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer BubbleSound = new System.Media.SoundPlayer(Bubble_Trouble.Properties.Resources.balon);
        System.Media.SoundPlayer SpiralaSound = new System.Media.SoundPlayer(Bubble_Trouble.Properties.Resources.Spirala);
        System.Media.SoundPlayer DeadSound = new System.Media.SoundPlayer(Bubble_Trouble.Properties.Resources.dead);

        Document doc;
        Rectangle bounds;
        GameInfo gameInfo;
        public bool flag = true;
        public long time = 0;
        public int timerValue = 60;
        public int pausa = 0;
        Image nextLvl;
        bool paused;

        public Form1()
        {
            InitializeComponent();
            doc = new Document(1);
            gameInfo = new GameInfo();
            bounds = new Rectangle(10, 10, this.Bounds.Width - 40, 380);
            doc.setIgrac(bounds.Right/2, bounds.Bottom-50);
            this.DoubleBuffered = true;
            paused = false;

            // disables resize
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;

            nextLvl = Properties.Resources.text;
            timerTopce.Start();
           
        }

        

        private void timerTopce_Tick(object sender, EventArgs e)
        {
                // gun shot 
                if (doc.igrac.shooted) 
                {
                    
                    Point nova;
                    if (doc.igrac.spirala.tocki.Count == 2)
                        nova = new Point(doc.igrac.spirala.prva.X - 3, doc.igrac.spirala.posledna.Y - 10);

                    else if (flag) 
                    {
                        nova = new Point(doc.igrac.spirala.prva.X + 6, doc.igrac.spirala.posledna.Y - 20);
                        flag = !flag;
                    }
                    else 
                    {
                        nova = new Point(doc.igrac.spirala.prva.X - 6, doc.igrac.spirala.posledna.Y - 20);
                        flag = !flag;
                    }
                    // proverka za za kraj
                    if (nova.Y > bounds.Top)
                    {
                        doc.igrac.spirala.AddTocka(nova);
                        if (doc.proveriPogodok())
                        {
                            gameInfo.poeni++;
                            SpiralaSound.Stop();
                            BubbleSound.Play();
                        }
                        lblPoeni.Text = gameInfo.poeni.ToString();
                    }
                    else
                    {
                        doc.igrac.shooted = false;
                        SpiralaSound.Stop();
                    }
                    
                }

                
           doc.Move(bounds);
           Invalidate(true);


            //timer za progress bar
           time++;
           if (time % 20 == 0)
           {
               timerValue--;
               progressBar1.Value = timerValue;
           }
            // out of time 
           if (timerValue <= 0)
           {
               timerValue = 60;
               progressBar1.Value = 60;

               timerTopce.Stop();

               gameInfo.zivoti--;

               if (gameInfo.zivoti <= 0)
               {
                   Lost izgubi = new Lost(gameInfo.poeni);
                   if(izgubi.ShowDialog()==DialogResult.Yes)
                   {
                       newGame();
                   }
                   else
                   {
                       this.Close();
                   }
               }
                   
               else
               {
                   doc = new Document(gameInfo.level);
                   doc.setIgrac(bounds.Right / 2, bounds.Bottom - 50);
                   timerTopce.Start();
               }
           }

            // dali e dopren igracot so topka nekoja 
           if (doc.isTouched())
           {
               DeadSound.Play();
               timerValue = 60;
               progressBar1.Value = timerValue;

               timerTopce.Stop();
               
               gameInfo.zivoti--;

               if(gameInfo.zivoti <= 0)
               {
                   Lost izgubi = new Lost(gameInfo.poeni);
                   if(izgubi.ShowDialog() == DialogResult.Yes)
                   {
                       newGame();
                   }
                   else
                   {
                       this.Close();
                   }
               }
               else 
               {
                   doc = new Document(gameInfo.level);
                   doc.setIgrac(bounds.Right / 2, bounds.Bottom - 50);
                   timerTopce.Start();
               }
           }

            // koga nema veke topcinja
           if (doc.Topcinja.Count == 0)
           {
               gameInfo.poeni += progressBar1.Value;
               lblPoeni.Text = gameInfo.poeni.ToString();
               progressBar1.Value = timerValue;
               timerTopce.Stop();
               timerPausa.Start();


               if (gameInfo.level < 3)
               {
                   doc = new Document(++gameInfo.level);
                   if (gameInfo.level == 2)
                       this.BackgroundImage = Bubble_Trouble.Properties.Resources.lvl2;
                   if (gameInfo.level == 3)
                       this.BackgroundImage = Bubble_Trouble.Properties.Resources.lvl3;
                   timerValue = 60;
                   progressBar1.Value = timerValue;
                   lblLevel.Text = gameInfo.level.ToString();
                   doc.setIgrac(bounds.Right / 2, bounds.Bottom - 50);

               }
               else
               {
                   timerTopce.Stop();
                   timerPausa.Stop();
                   Win pobedi = new Win(gameInfo.poeni);

                   if (pobedi.ShowDialog() == DialogResult.Yes)
                   {
                       newGame();
                   }
                   else
                   {
                       this.Close();
                   }                  
               }
           }
          
        }    //kraj na timer_tick


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Red), bounds);
            doc.Draw(e.Graphics);
            gameInfo.Draw(e.Graphics);
        }

        // useless
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //Point p = e.Location;
            //doc.isHit(p);
            if (doc.igrac.Shot())
                SpiralaSound.PlayLooping();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!paused)
            {
                    if (e.KeyCode == Keys.Left)
                    {
                        doc.igrac.moveLeft(bounds);
                        doc.igrac.imgSegasna = doc.igrac.imgLevo;
                    }
                    if (e.KeyCode == Keys.Right)
                    {
                        doc.igrac.moveRight(bounds);
                        doc.igrac.imgSegasna = doc.igrac.imgDesno;
                    }
                    if (e.KeyCode == Keys.Space)
                    {
                        if(doc.igrac.Shot())
                        SpiralaSound.PlayLooping();
                    }

                if(e.KeyCode==Keys.P)
                {
                    paused = true;
                    Pause pauza = new Pause();
                    timerTopce.Stop();
                    if (pauza.ShowDialog() == DialogResult.OK)
                    {
                        timerTopce.Start();
                        paused = false;
                    }

                }
            }
            

            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            doc.igrac.imgSegasna = doc.igrac.imgGore;
        }

      
        // pauza megu prethodniot i segasniot level
        private void timerPausa_Tick(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawImage(nextLvl, 200, 60, 450, 250);

            if(pausa == 10)
            {
                timerPausa.Stop();
                timerTopce.Start();
                pausa = 0;
               
            }

            else
            pausa++;
            
        }

        public void newGame()
        {
            doc = new Document(1);
            gameInfo = new GameInfo();
            doc.setIgrac(bounds.Right / 2, bounds.Bottom - 50);
            timerValue = 60;
            lblPoeni.Text = "0";
            this.BackgroundImage = Bubble_Trouble.Properties.Resources.lvl1;
            lblLevel.Text = "1";
            timerTopce.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerTopce.Stop();
            timerPausa.Stop();
            SpiralaSound.Stop();
           
        }

      
        

       

      
  


        
    }
}
