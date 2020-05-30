using BookShopManagement.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement.Components
{
    public partial class Alert : Form
    {
        public Alert()
        {
            InitializeComponent();
        }

        public Alert(string msg, Type type)
        {
            InitializeComponent();
            this.ShowAlert(msg, type);
        }

        public enum Action
        {
            wait,
            start,
            close
        }

        public enum Type
        {
            Success,
            Warning,
            Error,
            Info,
            Added
        }

        private Action action;
        private int x, y;

        private void Timer_Tick(object sender, EventArgs e)
        {
            switch (action)
            {
                case Action.wait:
                    timer.Interval = 2500;
                    action = Action.close;
                    break;
                case Action.start:
                    timer.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                        this.Left--;
                    else if (this.Opacity == 1.0)
                        action = Action.wait;
                    break;
                case Action.close:
                    timer.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (this.Opacity == 0.0)
                        this.Close();
                    break;
            }
        }

        private void PbxClose_Click(object sender, EventArgs e)
        {
            timer.Interval = 1;
            action = Action.close;
        }

        public void ShowAlert(string msg, Type type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Alert frm = (Alert)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case Type.Success:
                    this.pbxIcon.Image = Resources.success;
                    this.BackColor = Color.FromArgb(39, 174, 96);
                    break;
                case Type.Error:
                    this.pbxIcon.Image = Resources.error;
                    this.BackColor = Color.FromArgb(192, 57, 43);
                    break;
                case Type.Info:
                    this.pbxIcon.Image = Resources.info;
                    this.BackColor = Color.FromArgb(41, 128, 185);
                    break;
                case Type.Warning:
                    this.pbxIcon.Image = Resources.warning;
                    this.BackColor = Color.FromArgb(243, 156, 18);
                    break;
                case Type.Added:
                    this.pbxIcon.Image = Resources.success;
                    this.BackColor = Color.FromArgb(39, 174, 96);
                    this.Location = new Point(this.x, 50);
                    break;

            }

            lblMsg.Text = msg;

            this.Show();
            action = Action.start;
            timer.Interval = 1;
            timer.Start();
        }

        public static void Create(string msg, Type type)
        {
            var t = new Thread(() => Application.Run(new Alert(msg, type)));
            t.Start();
        }
    }
}
