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

    public  class Elements
    {
      public  byte[] b = new byte[128];
      public  string sTitle;
      public  string sSinger;
      public  string sAlbum;
      public  string sYear;
      public  string sComm;
    }
 
   public class Play_Class
    {
 //    public  WindowsMediaPlayer delete_player = new WindowsMediaPlayer();   /// WORKS - IS VISIBLE
     public  WindowsMediaPlayer myplayer = new WindowsMediaPlayer();  
      
    }
}
