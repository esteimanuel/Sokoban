﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.IO;

namespace Sokoban
{
    class Vak
    {
        private BitmapImage img;
        public string path;
        public BitmapImage Image
        {
            get { return img; }
        }
        protected BitmapImage MaakPlaatje(string naam)
        {
            System.Reflection.Assembly thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            string path = thisExe.Location;
            DirectoryInfo dirinfo = new DirectoryInfo(path);
            string folderName = dirinfo.Parent.FullName;
            path = folderName + "/Images/" + naam + ".png";
            Uri uri = new Uri(path);
            return img = new BitmapImage(uri);
        }
    }

    class Vloer : Vak
    {
        public Vloer()
        {
            MaakPlaatje("vloer");
        }
    }

    /*class Bestemming : Vak
    {
        public Bestemming()
        {
            MaakPlaatje("bestemming");
        }
    }*/

    class Muur : Vak
    {
        public Muur()
        {
            MaakPlaatje("muur");
        }
    }
}