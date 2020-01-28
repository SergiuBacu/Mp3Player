using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mp3Player
{
    public partial class JumpToFile : Form
    {

        
        //---------------------
        public class Info
        {
            public int index { get; set; }
            public string path { get; set; }
        }

      //  public static List<info> SongsInfo = new List<info>();
        public List<Info> Songs  = new List<Info>();

         //Songs = Form1.S;

        public void passList(List<Info> theList)
        {
            theList = this.Songs;
        }


        //----------------------
        public JumpToFile()
        {
            InitializeComponent();


        //    Form1.InformationContained song = new Form1.InformationContained();
        //    Songs = song.GetSongs();

          //  elements = Form1.SongsInfo;


            
        }

        string TitleSubstract(string s)
        {
            int k = s.LastIndexOf('\\');
            
            string sdf = s.Substring(k+1,s.Length - k-1);

            return sdf;
        }

        private void JumpToFile_Load(object sender, EventArgs e)
        {
            this.ActiveControl = SearchBar;

            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Form1"];
            f.Show();

            foreach (var it in Form1.SongsInfo)
            {
                JumpListBox.Items.Add(TitleSubstract(it.path));
            }

          //  Songs = Mp3Player.Form1.SongsInfo; 

        }
        Play_Class play_function = new Play_Class();
        private void Jump_To_File_Button(object sender, EventArgs e)
        {
  //          play_function.myplayer.URL = 

       //    Mp3Player.Elements
       //     Mp3Player.Form1.playing
      //     Mp3Player.Form1 sdfa =new Mp3Player.Form1();
      //      sdfa.label1Text = "asdadasd";
            play_function.myplayer.URL =Form1.SongsInfo[JumpListBox.SelectedIndex].path;
            play_function.myplayer.controls.stop();
            play_function.myplayer.controls.play();


        }
    }
}
