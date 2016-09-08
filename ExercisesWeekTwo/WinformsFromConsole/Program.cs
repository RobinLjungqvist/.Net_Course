using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsFromConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Run(new MainWindow("My Window",200,300));

        }

    }
    class MainWindow : Form
    {
        private MenuStrip menuMainMenu = new MenuStrip();
        private ToolStripMenuItem menuFile = new ToolStripMenuItem();
        private ToolStripMenuItem menuFileExit = new ToolStripMenuItem();
        private ToolStripMenuItem menuAbout = new ToolStripMenuItem();
        private ToolStripMenuItem menuAboutAbout = new ToolStripMenuItem();

        public MainWindow() { }

        public MainWindow(string title, int height, int width)
        {
            Text = title;
            Width = width;
            Height = height;

            CenterToScreen();
            BuildMenuSystem();
        }

        private void BuildMenuSystem()
        {
            // Add the File menu item to the main menu.
            menuFile.Text = "&File";
            menuMainMenu.Items.Add(menuFile);
            menuAbout.Text = "&About";
            menuMainMenu.Items.Add(menuAbout);
            // Now add the Exit menu to the File menu.
            menuFileExit.Text = "E&xit";
            menuFile.DropDownItems.Add(menuFileExit);
            menuFileExit.Click += (o, s) => Application.Exit();

            menuAboutAbout.Text = "&About";
            menuAbout.DropDownItems.Add(menuAboutAbout);
            menuAboutAbout.Click += (o, s) => new About().Show();
            // Finally, set the menu for this Form.
            Controls.Add(this.menuMainMenu);
            MainMenuStrip = this.menuMainMenu;
        }
    }

    class About : Form
    {
        private Label msgLabel = new Label();
        
        public About()
        {
            Text = "About";
            Width = 200;
            Height = 300;
            msgLabel.Text = "Hello. Welcome to about!";

            CenterToParent();
            buildAbout();
        }
        private void buildAbout()
        {
            this.msgLabel.Show();
        }

    }
}
