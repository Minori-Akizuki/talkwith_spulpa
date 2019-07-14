using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace talkwith_spulpa
{
    public partial class Form_Main : Form
    {
        private string CurrentFileName = @"talk.csv";
        bool isSaved = true;
        string formTitle = "簡易台本作成";
        List<Talking> talkings = new List<Talking>();

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Button_sendText_Click(object sender, EventArgs e)
        {

        }

        private void initTalkArea()
        {
            dataGridView_talk.DataSource = talkings;
            dataGridView_talk.Columns[0].HeaderText = "name";
            dataGridView_talk.Columns[1].HeaderText = "talk";
            dataGridView_talk.Columns[1].Width = 500;
            dataGridView_talk.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

            // 初期化
            // 会話エリア
            initTalkArea();
            dataGridView_talk.Columns[1].Width = 500;
            dataGridView_talk.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // キー入力
            KeyPreview = true;

            // 名前の詠み込み
            String[] names = ConfigurationManager.AppSettings["names"].Split(',');
            comboBox_talkingName.Items.AddRange(names);
            comboBox_talkingName.SelectedIndex = 0;
        }

        private void TextBox_Talk_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void TextBox_Talk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Down && comboBox_talkingName.SelectedIndex < comboBox_talkingName.Items.Count-1)
            {
                comboBox_talkingName.SelectedIndex++;
            }

            if (e.Control && e.KeyCode == Keys.Up && comboBox_talkingName.SelectedIndex > 0)
            {
                comboBox_talkingName.SelectedIndex--;
            }

            if ( (e.Control || e.Shift) && e.KeyCode == Keys.Enter)
            {
                //dataGridView_talk.Rows.Add(comboBox_talkingName.SelectedItem.ToString(), textBox_Talk.Text);
                talkings.Add(
                    new Talking(comboBox_talkingName.SelectedItem.ToString(), textBox_Talk.Text)
                    );
                // これ絶対バッドノウハウなので直したい
                dataGridView_talk.DataSource = null;
                dataGridView_talk.DataSource = talkings;
                //dataGridView_talk.DataSource = talkings;
                // データ送信後に改行が入力されてしまうため、テキストエリアの初期化は KeyUp に。何かスマートな方法無いかな……
                isSaved = false;
                this.Text = formTitle + "*";

            }
        }

        private void TextBox_Talk_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                textBox_Talk.Text = "";
            }
        }

        private void ComboBox_talkingName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                addnameToNameList(comboBox_talkingName.Text);
            }
        }

        private void toolStripMenuItem_name_delete_Click(object sender, EventArgs e)
        {
            comboBox_talkingName.Items.RemoveAt(comboBox_talkingName.SelectedIndex);
        }

        private void Button_nameAdd_Click(object sender, EventArgs e)
        {
            if (comboBox_talkingName.Text != "")
            {
                addnameToNameList(comboBox_talkingName.Text);
            }
        }

        private void addnameToNameList(String name)
        {
            comboBox_talkingName.Items.Add(name);
            comboBox_talkingName.Text = "";
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            String[] names = comboBox_talkingName.Items.Cast<String>().ToArray();
            ConfigurationManager.AppSettings["names"] = String.Join(",", names);
            foreach (string key in ConfigurationManager.AppSettings.AllKeys)
            {
                string value = ConfigurationManager.AppSettings[key];
                System.Diagnostics.Trace.WriteLine("appSettings: " + key + "=" + value);
            }
        }

        private void ToolStripMenuItem_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sa = new SaveFileDialog();
            sa.Title = "ファイルを保存する";
            sa.InitialDirectory = ConfigurationManager.AppSettings["lastSaveDir"];
            sa.FileName = CurrentFileName;
            sa.Filter = "CSV(*.csv)|*.csv|すべてのファイル(*.*)|*.*";
            sa.FilterIndex = 1;

            DialogResult result = sa.ShowDialog();

            if (result == DialogResult.OK)
            {
                // フルパスが取得される
                string fileName = sa.FileName;
                using (var csvr = new CsvHelper.CsvWriter(new StreamWriter(fileName, false, Encoding.UTF8)))
                {
                    csvr.Configuration.RegisterClassMap<TalkTable>();
                    csvr.WriteRecords(talkings.ToArray());

                    ConfigurationManager.AppSettings["lastSaveDir"] = Path.GetDirectoryName(fileName);
                    CurrentFileName = Path.GetFileName(fileName);
                    this.Text = formTitle;
                }
                isSaved = true;
            } else if(result == DialogResult.Cancel)
            {

            }
        }

        private void ToolStripMenuItem_load_Click(object sender, EventArgs e)
        {
            if (!isSaved)
            {
                if (warnNoSaved()==DialogResult.No) return;
            }

            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.FileName = "";
            ofd.InitialDirectory = ConfigurationManager.AppSettings["lastSaveDir"];
            ofd.Filter = "CSV(*.csv)|*.csv|すべてのファイル(*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.Title = "開くファイルを選択してください";
            ofd.RestoreDirectory = true;
            //存在しないファイルの名前が指定されたとき警告を表示する
            ofd.CheckFileExists = true;
            //存在しないパスが指定されたとき警告を表示する
            ofd.CheckPathExists = true;

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                initTalkArea();
                roadFile(ofd.FileName);
            }
        }

        private void roadFile(String fileName)
        {
            cleaNames();
            using (var csv = new CsvHelper.CsvReader(new StreamReader(fileName, Encoding.UTF8)))
            {
                csv.Configuration.HasHeaderRecord = true;
                var list = csv.GetRecords<Talking>();
                talkings = new List<Talking>();
                foreach(var line in list)
                {
                    if(comboBox_talkingName.Items.IndexOf(line.name) == -1)
                    {
                        comboBox_talkingName.Items.Add(line.name);
                    } 
                    talkings.Add(line);
                }
                dataGridView_talk.DataSource = null;
                dataGridView_talk.DataSource = talkings;
            }
        }

        private void cleaNames()
        {
            comboBox_talkingName.Items.Clear();
        }

        private DialogResult warnNoSaved()
        {
            return MessageBox.Show(
                "保存されていない会話は消えてしまいますがファイルの読み込みを続行しますか？",
                "警告",
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2
            );
        }

        private void ToolStripMenuItem_setting_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void ToolStripMenuItem_export_Click(object sender, EventArgs e)
        {
            SaveFileDialog sa = new SaveFileDialog();
            sa.Title = "ファイルを保存する";
            sa.InitialDirectory = ConfigurationManager.AppSettings["lastSaveDir"];
            sa.FileName = CurrentFileName;
            sa.Filter = "txt(*.txt)|*.txt|すべてのファイル(*.*)|*.*";
            sa.FilterIndex = 1;

            DialogResult result = sa.ShowDialog();

            if (result == DialogResult.OK)
            {
                // フルパスが取得される
                string fileName = sa.FileName;
                using (var sw = new StreamWriter(fileName, false, Encoding.UTF8))
                {
                    foreach (Talking t in talkings)
                    {
                        string sep = ConfigurationManager.AppSettings["sepString"];
                        sw.WriteLine(t.name + sep + t.talk);
                    }   
                }
            }
            else if (result == DialogResult.Cancel)
            {

            }
        }
    }
}
