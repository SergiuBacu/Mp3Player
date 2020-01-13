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
using System.Media;
using WMPLib;

namespace Mp3Player
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
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
        private void Load_Click(object sender, EventArgs e)
        {
    //        FolderBrowserDialog FBD = new FolderBrowserDialog();
      //      FBD.ShowDialog();

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                int k;
                var dir  = fbd.SelectedPath;

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
               //     var dir = fbd.SelectedPath;
                    string[] files = Directory.GetFiles(dir,".mp3");
                    Playlist.Items.Add(files);
                }

                //-----------------------------
               string[] music = Directory.GetFiles(dir,".mp3");
               string[] names;


               int sdfs;

               
                foreach(string file in music)
                {
                    int fre;
                }
                string[] Files = Directory.GetFiles(dir,"*.mp3",SearchOption.AllDirectories);
             //   Playlist = Files;
                int nr = Files.Length;
               // for (int i = 0; Files[i] != null; i++)     // this was at the begginnig
                for (int i = 0; i < nr; i++ )
                {
                    Playlist.Items.Add(Files[i]);
                }

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
                    string SongData = Files[i].Substring(pos, Files[i].Length);

                    int sdafsdasdfa;
                }



                int delete;
                //-------------------------------------------------------------------

                int fret;
                //-----------------------------
            }

        }

        public const int KEYEVENTF_EXTENDEDKEY = 1;
        public const int KEYEVENTF_KEYUP = 0;
        public const int VK_MEDIA_NEXT_TRACK = 0xB0;
        public const int VK_MEDIA_PLAY_PAUSE = 0xB3;
        public const int VK_MEDIA_PREV_TRACK = 0xB1;

        WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
        private void PlayButton_Click(object sender, EventArgs e)
        {
            string path = Playlist.SelectedItem.ToString();       // Substracting the Title
            int k = path.LastIndexOf('\\');
         //   string title = 

      //      label1.Text = Playlist.SelectedItem.ToString();   // this was ok -- but was displaying all the path
            label1.Text = Playlist.SelectedItem.ToString().Substring(k + 1, path.Length - k - 1);

          //  WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
            myplayer.URL = Playlist.SelectedItem.ToString();
            myplayer.controls.stop(); // did it stop the previous ?           
            myplayer.controls.play();

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
            myplayer.controls.fastForward();
        }

        private void Backwards_Button(object sender, EventArgs e)
        {
           // myplayer.controls.previous();
            myplayer.controls.fastReverse();
        }
    }
}
