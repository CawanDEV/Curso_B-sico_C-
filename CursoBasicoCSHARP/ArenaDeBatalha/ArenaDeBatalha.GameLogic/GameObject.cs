﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ArenaDeBatalha.GameLogic
{
    public class GameObject
    {
        public Bitmap Sprite { get; set; }
        public bool Active { get; set; }
        public int Speed { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        public int Widht { get { return this.Sprite.Width; } }
        public int Height { get { return this.Sprite.Height; } } 
        public Size Bounds { get; set; }
        public Rectangle Rectangle { get; set; }
        public Stream Sound { get; set; }
        public Graphics Screen { get; set; }
        private SoundPlayer soundPlayer { get; set; }

    }
}
