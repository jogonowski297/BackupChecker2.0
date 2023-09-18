using BackupChecker.UserControls;
using System.Xml.Linq;

namespace BackupChecker
{
    public partial class Form1 : Form
    {
        bool sidebarExpand;
        private bool dragging = false;
        private Point startpoint = new Point(0, 0);
        XDocument config;
        private const string configFile = "appconfig.xml";

        public Form1()
        {
            InitializeComponent();

            if (File.Exists(configFile))
            {
                config = XDocument.Load("appconfig.xml");
            }
            else
            {
                // Tworzenie nowego pliku, jeœli nie istnieje
                XDocument newXmlDoc = new XDocument(
                    new XElement("configuration",
                        new XElement("appSettings",
                            new XElement("settings"),
                            new XElement("directory")
                                    )
                                )
                );

                newXmlDoc.Save(configFile);
                config = XDocument.Load("appconfig.xml");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }


        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                Sidebar.Width -= 10;
                if (Sidebar.Width == Sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                Sidebar.Width += 10;
                if (Sidebar.Width == Sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    SidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_Paths fp = new Form_Paths(config);
            addUserControl(fp);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startpoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startpoint.X, p.Y - this.startpoint.Y);
            }
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UC_Settings uc_s = new UC_Settings(config);
            addUserControl(uc_s);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            UC_Help uc_h = new UC_Help();
            addUserControl(uc_h);
        }
    }
}