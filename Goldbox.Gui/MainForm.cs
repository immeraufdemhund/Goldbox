using Goldbox.Engine;
using System.Windows.Forms;

namespace Goldbox.Gui
{
    public partial class MainForm : Form
    {
        public MainForm(IDisplay display)
        {
            InitializeComponent();
            Controls.Add(new GameDisplayControl(display));
        }
    }
}
