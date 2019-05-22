using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STBlocker {

    public struct Blocked {
        public string name;
        public DateTime? time;

        public Blocked(string name, DateTime? time) {
            this.name = name;
            this.time = time;
        }
    }
    public partial class Form1 : Form {

        private const string hostLoc = "C:\\Windows\\System32\\drivers\\etc\\hosts";
        private Timer timer;
        private int timerInterval = 1000;

        private List<Blocked> blockedSites;

        public Form1() {
            InitializeComponent();
            datePicker.Visible = false;
            datePicker.Format = DateTimePickerFormat.Time;
            blockedSites = new List<Blocked>();
            ReadBlocked();

            timer = new Timer();
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = timerInterval;
            timer.Start();
        }

        public void ReadBlocked() {
            int count = 0;
            using (StreamReader reader = File.OpenText(hostLoc)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    if (!String.IsNullOrEmpty(line) && !line.Contains("#")) {
                        int index = line.IndexOf(" ");
                        listBox1.Items.Add(line.Substring(index+1));
                        Blocked blocked = new Blocked(line.Substring(index + 1), null);
                        blockedSites.Add(blocked);
                    }
                        
                    count++;
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(textBox1.Text))
                return;

            if (!checkBox1.Checked) {
                string newSite = "127.0.0.1 " + textBox1.Text;

                File.AppendAllText(hostLoc,
                       newSite + Environment.NewLine);

                listBox1.Items.Add(textBox1.Text);

                Blocked blocked = new Blocked(textBox1.Text, null);
                blockedSites.Add(blocked);

            } else {
                if( datePicker.Value <= DateTime.Now) {
                    MessageBox.Show("Şu andan ileri bir tarih seçin");
                    return;
                }


                Blocked blocked = new Blocked(textBox1.Text, datePicker.Value);
                blockedSites.Add(blocked);

                string newSite = textBox1.Text +" : "+ blocked.time.ToString();

                File.AppendAllText(hostLoc, "127.0.0.1 " + newSite + Environment.NewLine);

                listBox1.Items.Add(newSite);
            }
            
        }

        private void timerTick(object sender, EventArgs e) {
            for (int i = 0; i < blockedSites.Count; i++) {
                Blocked blocked = blockedSites[i];
                if (blocked.time != null) {
                    if (blocked.time < DateTime.Now) {
                        int removed = deleteBlock(blocked.name);
                        listBox1.Items.RemoveAt(removed);
                        continue;
                    }
                }
            }
        }

        private int deleteBlock(string name) {
            String[] lines = File.ReadAllLines(hostLoc);
            int index = 0;
            foreach (String item in lines) {
                index++;
                if (String.IsNullOrEmpty(item) || item.Contains("#"))
                    continue;
                if (item.Contains(name)) {
                    index--;
                    break;
                }

            }
            var lineList = lines.ToList();
            lineList.RemoveAt(index);

            File.WriteAllLines(hostLoc, lineList.ToArray());

            index = 0;
            foreach(Blocked blocked in blockedSites) {
                if (name.Contains(blocked.name)) {
                    break;
                }
                index++;
            }
            //index--;
            blockedSites.RemoveAt(index);

            return index;
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            if(listBox1.SelectedItem != null) {
                string blockName = listBox1.SelectedItem.ToString();

                int deleteIndex = deleteBlock(blockName);

                listBox1.Items.RemoveAt(deleteIndex);
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if (checkBox1.Checked)
                datePicker.Visible = true;
            else
                datePicker.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
