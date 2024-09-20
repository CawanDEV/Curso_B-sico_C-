using ArenaDeBatalha.GameLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace ArenaDeBatalha.GUI
{
    public partial class FormPrincipal : System.Windows.Forms.Form
    {
        DispatcherTimer gameLoopTimer {  get; set; }
        Bitmap screenBuffer {  get; set; }
        Graphics screenPainter { get; set; }
        Background background {  get; set; }
        List<GameObject> gameObjects { get; set; }
        public FormPrincipal()
        {
            InitializeComponent();
            this.screenBuffer = new Bitmap(Media.Background.Width, Media.Background.Height);
            this.screenPainter = Graphics.FromImage(screenBuffer);
            this.gameObjects = new List<GameObject>();
            this.background = new Background(this.screenBuffer.Size, this.screenPainter);

            this.gameLoopTimer = new DispatcherTimer(DispatcherPriority.Render);
            this.gameLoopTimer.Interval = TimeSpan.FromMilliseconds(16.66666);
            this.gameLoopTimer.Tick += GameLoop;

            this.gameObjects.Add(background);

        }
        public void StartGame()
        {
            this.gameLoopTimer.Start();
        }
        public void GameLoop(object sender, EventArgs e)
        {
            foreach(GameObject go in this.gameObjects)
            {
                go.UpdateObject();
            }
        }

        private void FormPrincipal_Paint_1(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawImage(this.screenBuffer, 0, 0);
        }
    }
}
