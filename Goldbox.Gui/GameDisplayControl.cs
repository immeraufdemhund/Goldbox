using System.Windows.Forms;
using Goldbox.Engine;
using System.Drawing;
using System.IO;

namespace Goldbox.Gui
{
    internal class GameDisplayControl : UserControl
    {
        private readonly IDisplay _display;
        private readonly PictureBox _displayArea;

        public GameDisplayControl(IDisplay display)
        {
            _display = display;
            _display.Updated += UpdateDisplay;

            _displayArea = new PictureBox
            {
                Dock = DockStyle.Fill,
                Size = new Size(640, 400),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            Controls.Add(_displayArea);
        }

        private void UpdateDisplay(byte[] videoRam, int videoRamSize)
        {
            using (var ms = new MemoryStream(videoRam, 0, videoRamSize))
            {
                _displayArea.Image = Image.FromStream(ms);//(Image)Image.FromStream(ms).Clone();
            }
        }
    }
}
