using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Media;
using WMPLib;

namespace Mp3Player
{
    public partial class Form1 : Form
    {

        
        public Form1(List<info> titles)
        {
            InitializeComponent();
            titles = SongsInfo;
            
          //  JumpToFile.
        }

        private void ClearList_Click(object sender, EventArgs e)
        {
            Playlist.Items.Clear();
        }
//----------------------- Playing Functions-----------------------------
        public class Sounds
        {
            WMPLib.WindowsMediaPlayer player = new WindowsMediaPlayer();
            public void PlayFile(String url)
            {
                player.URL = url;
                player.controls.play();
            }
        }

        public class playing
        {
            Sounds sounds = new Sounds();
            string SelectedFile;
            public void OnPlayClick()
            {
                sounds.PlayFile(SelectedFile);
            }
        }
//----------------------------------------------------------------------
        int CurrentSongIndex = 0;
   /*  public struct  info 
              {
                 int index;
                 string path;
              }
     List<info> SongsInfo = new List<info>();*/
        public class info
        {
            public int index { get; set; }
            public string path { get; set; } 
        }

    public static List<info> SongsInfo = new List<info>();
        byte[] b = new byte[128];
        string sTitle;
        string sSinger;
        string sAlbum;
        string sYear;
        string sComm;

       


        private void Load_Click(object sender, EventArgs e)
        {
    //        FolderBrowserDialog FBD = new FolderBrowserDialog();
      //      FBD.ShowDialog();

        //    Playlist.Items.Clear();   -- useless

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                int k;
                var dir  = fbd.SelectedPath;

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
               //     var dir = fbd.SelectedPath;
                    string[] files = Directory.GetFiles(dir,".mp3");
            //        Playlist.Items.Add(files);   /// this  line adds String[]
                }

                //-----------------------------
               string[] music = Directory.GetFiles(dir,".mp3");
               string[] names;

               int CurrentSongIndex = 0;

               int sdfs;              
              
                string[] Files = Directory.GetFiles(dir,"*.mp3",SearchOption.AllDirectories);
     
                int nr = Files.Length;          
            
                //---------------THIS IS CORRECT--------WORKS-------!!!!!!!!!!!!!!!!!!!
                for (int i = 0; i < nr; i++ )
                {
                    Playlist.Items.Add(Files[i]);                   
                    SongsInfo.Add(new info { index = i, path = Files[i] });
                }
                //--------------------------------------------------!!!!!!!!!!!!!!!!!!!!
                int sdfqwer;

                //------------Loop and Display only the Artist and Title-------------
          /*      byte[] b = new byte[128];
                bool isSet = false;
                string sFlag = System.Text.Encoding.Default.GetString(b, 0, 3);
                if (sFlag.CompareTo("TAG") == 0) isSet = true;

                if (isSet)
                {
                    string sTitle = System.Text.Encoding.Default.GetString(b, 3, 30);
                    string Singer = System.Text.Encoding.Default.GetString(b, 33, 30);
                }*/

                string[] SongandArtist;
                int len = Files.Length;
                for (int i = 0; i < len; i++)
                {
                    string deleted = Files[i];
                    int pos = deleted.LastIndexOf('\\');
                    string SongData = Files[i].Substring(pos, Files[i].Length- pos);

                    int sdafsdasdfa;
                }



                int delete;
                //-------------------------------------------------------------------

                int fret;
                //-----------------------------
            }

        }

        string Replacement(string str)
        {
            
            for (int i = 0; i < str.Length; i++)
            {
               // if (str[i] == '\0') str[i] = Convert.ToChar("");
            }

            str.TrimEnd('\0');
                return str;
        }

        public void GetSongsInfo(string ThePath)
        {         

            FileStream fs = new FileStream(ThePath, FileMode.Open);
            fs.Seek(-128, SeekOrigin.End);
            fs.Read(b, 0, 128);
            bool isSet = false;
            string sFlag = System.Text.Encoding.Default.GetString(b, 0, 3);
            if (sFlag.CompareTo("TAG") == 0)
            {
                //System.Console.WriteLine("Tag is  setted");
                isSet = true;
            }
            if (isSet)
            {
                // get title of the song
                sTitle = System.Text.Encoding.Default.GetString(b, 3, 30);
               // System.Console.WriteLine("Title: " + sTitle);
                sTitle.Replace("\0", string.Empty);
               string newq = Replacement(sTitle);

               
                int sdfsfsadf;


                //get singer
                sSinger = System.Text.Encoding.Default.GetString(b, 33, 30);
                sSinger.Replace("\0", "");
                // System.Console.WriteLine("Singer " + sSinger);


                // get album
                sAlbum = System.Text.Encoding.Default.GetString(b, 63, 30);
                sAlbum.Replace("\0", string.Empty);
                //System.Console.WriteLine("Album " + sAlbum);

                // get year of publish
                sYear = System.Text.Encoding.Default.GetString(b, 93, 4);
                sYear.Replace("\0", string.Empty);
                //System.Console.WriteLine("Year " + sYear);

                // get comment
                sComm = System.Text.Encoding.Default.GetString(b, 97, 30);
                //System.Console.WriteLine("Comment " + sComm);

            }

        }

        WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
        private void PlayButton_Click(object sender, EventArgs e)
        {
          string path = Playlist.SelectedItem.ToString();       // Substracting the Title
            int k = path.LastIndexOf('\\');
         //   string title = 

      //      label1.Text = Playlist.SelectedItem.ToString();   // this was ok -- but was displaying all the path
        //    label1.Text = Playlist.SelectedItem.ToString().Substring(k + 1, path.Length - k - 1);
            //----Trying to get the information----------
            this.GetSongsInfo(path);
            if ((sSinger != null) && (sTitle != null))
            {
                //  label1.Text = sSinger + " - " + sTitle;
                label1.Text = sSinger;// +" - " + '\n' + sTitle;
                label2.Text = sTitle;
            }
            else
            {

            }
            //-------------------------------------------
          //  WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
            myplayer.URL = Playlist.SelectedItem.ToString();
            myplayer.controls.stop(); // did it stop the previous ?           
            myplayer.controls.play();
        //    CurrentSongIndex = Playlist.SelectedItem;
            CurrentSongIndex = Playlist.SelectedIndex;

            int sdfsdf;
/*            SoundPlayer player = new SoundPlayer();
            player.Stop();
            player.SoundLocation = Playlist.SelectedItem.ToString();
            player.Play();*/
            

        }
      
        private void PauseButton_Click(object sender, EventArgs e)
        {            
            myplayer.controls.pause();
            
        }
      
        private void Stop_Button(object sender, EventArgs e)
        {
            // the stop button 
            myplayer.controls.stop();
        }

        private void Forward_Button(object sender, EventArgs e)
        {
         //   myplayer.controls.next();
        //    myplayer.controls.fastForward();
            int Total = Playlist.Items.Count;

            bool sadfasdff = Playlist.SelectedIndex < Total;

            if ((Playlist.SelectedIndex < Total - 1))
            {
                Playlist.SelectedIndex++;
                myplayer.controls.next();
                //   myplayer.controls.play();  ///  include this if it doesn't play the next
                myplayer.URL = Playlist.SelectedItem.ToString();
                myplayer.controls.stop(); // did it stop the previous ?           
                myplayer.controls.play();

                string path = Playlist.SelectedItem.ToString();       // Substracting the Title
                int k = path.LastIndexOf('\\');
          //      label1.Text = Playlist.SelectedItem.ToString().Substring(k + 1, path.Length - k - 1);
                label1.Text = sSinger + " - " + sTitle;



                int asdasdasdasd;

                //------- Scroll View---------
                int index = 0;
                int count = 0;
                int x = Convert.ToInt16(Playlist.Width / 2);
                int y = 0;
                // Count hits
                while ((index = Playlist.IndexFromPoint(x, y)) != -1)
                {
                    // Jump to next item
                    // (Do not check unnecessary pixels)
                    y += Playlist.ItemHeight;
                    // increase counter
                    count++;
                }

                //---------------------------
                //--------------------Another Scroll into view Example -----------
                Playlist.TopIndex = Playlist.SelectedIndex; // it's not aesthetic
            //    Playlist.AutoScrollOffset.Y;
                var DEindex = Playlist.SelectedIndex;
            //    var item = Playlist.getItem
                //------------------------------------------------------------
            }
        }

        private void Backwards_Button(object sender, EventArgs e)
        {
           // myplayer.controls.previous();
         //   myplayer.controls.fastReverse();

            //   myplayer.controls.next();
            //    myplayer.controls.fastForward();
            if (Playlist.SelectedIndex > 0)
            {
                Playlist.SelectedIndex--;
                myplayer.controls.previous();
                //   myplayer.controls.play();  ///  include this if it doesn't play the next
                myplayer.URL = Playlist.SelectedItem.ToString();
                myplayer.controls.stop(); // did it stop the previous ?           
                myplayer.controls.play();



                string path = Playlist.SelectedItem.ToString();       // Substracting the Title
                int k = path.LastIndexOf('\\');
           //     label1.Text = Playlist.SelectedItem.ToString().Substring(k + 1, path.Length - k - 1);
                label1.Text = sSinger + " - " + sTitle;


                int asdasdasdasd;

                object scvncvbnf = myplayer.controls.currentItem.getItemInfo(Playlist.SelectedIndex.ToString());

                //-------------Auto Scroll--------------
            //    Playlist.SelectedIndex = Playlist.Items.Count - 1;   // NOT working
           //     Playlist.SelectedIndex = -1;  // Not working
               
                //--------------------------------------
                int sdfasdfsd_feqw;
            }

        }

        private void Exit_Command(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Open_Command(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.InitialDirectory = "C:\\";
                openDialog.Filter = "Video (.wmv)|*.wmv|Music (.mp3)|*.mp3|ALL Files (*.*)|*.*";
                openDialog.RestoreDirectory = true;

                if (openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    filePath = openDialog.FileName;
                    Playlist.Items.Add(filePath);
                }

            }

     //       OpenDialog.InitialDirectory = ;
            int sdfsdfsdf;
        }

        private void Playlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            // this method should not be here -            
        }

        private void jumpToFile(object sender, EventArgs e)
        {
            JumpToFile jump = new JumpToFile();
            jump.Show();

            

        }
    }
}
