using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AutoClickerTyper
{
    public partial class Form1 : Form
    {
        GlobalKeyboardHook gHook;

        DataTable dt = new DataTable();

        int curDGVRow = 0;

        bool isRunning = false;

        [Flags]
        public enum MouseEventFlags
        {
            LeftDown = 0x00000002,
            LeftUp = 0x00000004,
            MiddleDown = 0x00000020,
            MiddleUp = 0x00000040,
            Move = 0x00000001,
            Absolute = 0x00008000,
            RightDown = 0x00000008,
            RightUp = 0x00000010
        }

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetCursorPos(out MousePoint lpMousePoint);

        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        public static void SetCursorPosition(int X, int Y)
        {
            SetCursorPos(X, Y);
        }

        public static void SetCursorPosition(MousePoint point)
        {
            SetCursorPos(point.X, point.Y);
        }

        public static MousePoint GetCursorPosition()
        {
            MousePoint currentMousePoint;
            var gotPoint = GetCursorPos(out currentMousePoint);
            if (!gotPoint) { currentMousePoint = new MousePoint(0, 0); }
            return currentMousePoint;
        }

        public static void MouseEvent(MouseEventFlags value)
        {
            MousePoint position = GetCursorPosition();

            mouse_event
                ((int)value,
                 position.X,
                 position.Y,
                 0,
                 0)
                ;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MousePoint
        {
            public int X;
            public int Y;

            public MousePoint(int x, int y)
            {
                X = x;
                Y = y;
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isRunning = false;

            // LANGUAGE FILE LOAD ====>
            DirectoryInfo d = new System.IO.DirectoryInfo(Directory.GetCurrentDirectory()+"\\lang");//Assuming Test is your Folder
            /*FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files

            Dictionary<string, string> ValDic = new Dictionary<string, string>();

            foreach (FileInfo file in Files)
            {
                string readLangLine = File.ReadLines(Directory.GetCurrentDirectory() + "\\lang\\" + file.Name).First();
                string[] LangName = readLangLine.Split('=');

                if (LangName[1].Trim() == Properties.Settings.Default.Language)
                {
                    string[] FileLines = System.IO.File.ReadAllLines(Directory.GetCurrentDirectory() + "\\lang\\" + file.Name);
                    foreach (string line in FileLines)
                    {
                        string[] val = line.Split('=');
                        ValDic.Add(val[0].Trim(), val[1].Trim());
                        //label1.Text = ValDic["Language"];
                    }
                }
            }*/

            // LANGUAGE FILE LOAD <====


            // KEY DEDECTION ====>
            gHook = new GlobalKeyboardHook(); // Create a new GlobalKeyboardHook
                                              // Declare a KeyDown Event
            gHook.KeyUp += new KeyEventHandler(gHook_KeyUp);
            // Add the keys you want to hook to the HookedKeys list
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
                gHook.HookedKeys.Add(key);

            gHook.hook();
            // KEY DEDECTION <====

            // NEW PROGRAM FUNCTION COMBOBOX FILLING ====>
            Dictionary<string, string> userCache = new Dictionary<string, string>
            {
              {"Sol Tık (mlc)", "mlc"},
              {"Çift Tık (mdc)", "mdc"},
              {"Sağ Tık (mrc)", "mrc"},
              {"Hareket (mov)", "mov"},
              {"Metin Yaz (txt)", "txt"},
              {"Kopyala (cpy)", "cpy"},
              {"Sayı Yap (int)", "int"},
              {"Metin Yap (str)", "str"}
            };
            cbNewProgFunction.DataSource = new BindingSource(userCache, null);
            cbNewProgFunction.DisplayMember = "Key";
            cbNewProgFunction.ValueMember = "Value";

            // NEW PROGRAM FUNCTION COMBOBOX FILLING <====

            dt.Columns.Add("Sort", typeof(int));
            dt.Columns.Add("İşlem", typeof(string));
            dt.Columns.Add("X", typeof(int));
            dt.Columns.Add("Y", typeof(int));
            dt.Columns.Add("Bekle", typeof(int));
            dt.Columns.Add("Metin", typeof(string));

            DataRow rw = dt.NewRow();

            dgvProgram.DataSource = dt;

            dgvProgram.Columns["Sort"].Visible = false;

            dgvProgram.Columns["İşlem"].Width = 50;
            dgvProgram.Columns["Bekle"].Width = 50;
            dgvProgram.Columns["X"].Width = 50;
            dgvProgram.Columns["Y"].Width = 50;
            dgvProgram.Columns["Metin"].Width = 110;

            
        }

        // Handle the KeyUp Event
        public void gHook_KeyUp(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.F2:

                    // Coordinate detection
                    Point OriginalPoint = System.Windows.Forms.Cursor.Position;
                    txbNewProgX.Text = OriginalPoint.X.ToString();
                    txbNewProgY.Text = OriginalPoint.Y.ToString();
                    break;
            }


            if(e.KeyCode == Keys.Escape)
            {
                isRunning = false;

            }
        }

        private void tmrGeneric_Tick(object sender, EventArgs e)
        {
            // Mouse current coordinates
            Point OriginalPoint = System.Windows.Forms.Cursor.Position;
            txbCurX.Text = OriginalPoint.X.ToString();
            txbCurY.Text = OriginalPoint.Y.ToString();
        }

        private void cbNewProgFunction_SelectedIndexChanged(object sender, EventArgs e)
        {
            string val = cbNewProgFunction.SelectedValue.ToString();
            if (val == "txt")
                txbNewProgText.Enabled = true;
            else
                txbNewProgText.Enabled = false;

        }

        private void btNewRow_Click(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow();
            row["X"] = txbNewProgX.Text;
            row["Y"] = txbNewProgY.Text;
            row["İşlem"] = cbNewProgFunction.SelectedValue;
            row["Bekle"] = txbNewProgDelay.Text;
            row["Metin"] = txbNewProgText.Text;
            dt.Rows.Add(row);
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (dgvProgram.RowCount < 1)
            {
                MessageBox.Show("Liste boş!", "HATA!");
            }
            else
            {
                if (cbxConfirm.Enabled == true && cbxConfirm.Checked)
                    if(MessageBox.Show("Liste çalıştırılacak, onaylıyor musunuz?", "ONAY GEREKLİ!", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;

                isRunning = true;
                curDGVRow = 0;
                tmrProgram.Interval = Int32.Parse(dgvProgram.Rows[curDGVRow].Cells["Bekle"].Value.ToString());
                tmrProgram.Enabled = true;
                
            }
        }

        private void tmrProgram_Tick(object sender, EventArgs e)
        {
            tmrProgram.Enabled = false;

            if (isRunning && curDGVRow < dgvProgram.RowCount)
            {
                string cmd = dgvProgram.Rows[curDGVRow].Cells["İşlem"].Value.ToString();
                int x = Int32.Parse(dgvProgram.Rows[curDGVRow].Cells["X"].Value.ToString());
                int y = Int32.Parse(dgvProgram.Rows[curDGVRow].Cells["Y"].Value.ToString());
                string txt = dgvProgram.Rows[curDGVRow].Cells["Metin"].Value.ToString();

                switch (cmd)
                {
                    case "mov":
                        //SetCursorPosition(x, y);
                        SetCursorPosition(x, y);
                        SetCursorPosition(x, y);
                        //MouseEvent(MouseEventFlags.Move);
                        break;

                    case "mlc":
                        SetCursorPosition(x, y);
                        MouseEvent(MouseEventFlags.LeftDown);
                        MouseEvent(MouseEventFlags.LeftUp);
                        break;

                    case "mdc":
                        SetCursorPosition(x, y);
                        MouseEvent(MouseEventFlags.LeftDown);
                        MouseEvent(MouseEventFlags.LeftUp);
                        MouseEvent(MouseEventFlags.LeftDown);
                        MouseEvent(MouseEventFlags.LeftUp);
                        break;

                    case "mrc":
                        SetCursorPosition(x, y);
                        MouseEvent(MouseEventFlags.RightDown);
                        MouseEvent(MouseEventFlags.RightUp);
                        break;

                    case "txt":
                        SetCursorPosition(x, y);
                        SendKeys.Send(txt);
                        break;

                    case "cpy":

                        break;

                    case "int":

                        break;

                    case "str":

                        break;
                }

                tmrProgram.Interval = Int32.Parse(dgvProgram.Rows[curDGVRow].Cells["Bekle"].Value.ToString());
                tmrProgram.Enabled = true;
                curDGVRow++;
            }
        }

        private void cbxConfirm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btStop_Click(object sender, EventArgs e)
        {
            isRunning = false;
            tmrProgram.Enabled = false;
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            string strLine;
            bool isFirstLine = true;

            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "xy (*.xy)|*.xy";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.CheckFileExists = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName != "")
                {
                    StreamReader file = new StreamReader(openFileDialog1.FileName);
                    while ((strLine = file.ReadLine()) != null)
                    {
                        if (isFirstLine)
                        {
                            isFirstLine = false;
                            if (strLine != "0.1")
                            {
                                MessageBox.Show("Versiyon uyumsuz!");
                                file.Close();
                                return;
                            }

                            if (dt.Rows.Count > 0)
                                dt.Rows.Clear();
                                //dgvProgram.Rows.Clear();
                        }
                        else
                        {
                            string[] cols = strLine.Split(';');
                            DataRow row = dt.NewRow();
                            row["İşlem"] = cols[0].Trim();
                            row["X"] = cols[1].Trim();
                            row["Y"] = cols[2].Trim();
                            row["Bekle"] = cols[3].Trim();
                            row["Metin"] = cols[4].Trim();
                            dt.Rows.Add(row);
                        }
                    }
                    file.Close();
                } else
                {
                    MessageBox.Show("Geçerli bir dosya seçmediniz!");
                }
            }
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            string strListRow, strCmd, strX, strY, strDelay, strText;

            if (dgvProgram.RowCount < 1)
            {
                MessageBox.Show("Liste boş!", "HATA!");
            } else
            {
                strListRow = "0.1";

                for (int i = 0; i < dgvProgram.RowCount; i++)
                {
                    strCmd = dgvProgram.Rows[i].Cells["İşlem"].Value.ToString();
                    strX = dgvProgram.Rows[i].Cells["X"].Value.ToString();
                    strY = dgvProgram.Rows[i].Cells["Y"].Value.ToString();
                    strDelay = dgvProgram.Rows[i].Cells["Bekle"].Value.ToString();
                    strText = dgvProgram.Rows[i].Cells["Metin"].Value.ToString();

                    strListRow += Environment.NewLine + strCmd + ";" + strX + ";" + strY + ";" + strDelay + ";" + strText;
                }

                DateTime now = DateTime.Now;
                string strNow = "XY-List_"+now.ToString();
                strNow = strNow.Replace(" ", "_");
                strNow = strNow.Replace(".", "");
                strNow = strNow.Replace(":", "");

                saveFileDialog1.FileName = strNow;
                saveFileDialog1.Filter = "xy (*.xy)|*.xy";
                saveFileDialog1.Title = "Listeyi kaydet...";
                saveFileDialog1.OverwritePrompt = true;
                saveFileDialog1.CreatePrompt = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (saveFileDialog1.FileName != "")
                    {
                        StreamWriter Kayit = new StreamWriter(saveFileDialog1.FileName);
                        Kayit.WriteLine(strListRow);
                        Kayit.Close();
                    }
                }
            }
        }

        private void btSimulate_Click(object sender, EventArgs e)
        {
            if (dgvProgram.RowCount < 1)
            {
                MessageBox.Show("Liste boş!", "HATA!");
            }
            else
            {
                if (MessageBox.Show("Simulasyon başlatılıyor, onaylıyor musunuz?", "ONAY GEREKLİ!", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                curDGVRow = 0;
                tmrSimulate.Interval = Int32.Parse(dgvProgram.Rows[curDGVRow].Cells["Bekle"].Value.ToString());
                tmrSimulate.Enabled = true;
            }
        }

        private void btInsertRow_Click(object sender, EventArgs e)
        {
            try
            {
                int selRowNum = dgvProgram.CurrentCell.RowIndex;

                if (selRowNum < 0)
                {
                    MessageBox.Show("Satır seçilmedi!");
                    return;
                }

                if (MessageBox.Show("Araya satır eklenecek, onaylıyor musunuz?", "ONAY GEREKLİ!", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;

                DataRow row = dt.NewRow();
                row["İşlem"] = dgvProgram.Rows[dgvProgram.RowCount - 1].Cells["İşlem"].Value.ToString();
                row["X"] = Convert.ToInt32(dgvProgram.Rows[dgvProgram.RowCount - 1].Cells["X"].Value.ToString());
                row["Y"] = Convert.ToInt32(dgvProgram.Rows[dgvProgram.RowCount - 1].Cells["Y"].Value.ToString());
                row["Bekle"] = Convert.ToInt32(dgvProgram.Rows[dgvProgram.RowCount - 1].Cells["Bekle"].Value.ToString());
                row["Metin"] = dgvProgram.Rows[dgvProgram.RowCount - 1].Cells["Metin"].Value.ToString();
                dt.Rows.Add(row);

                for (int i = dgvProgram.RowCount-1; i > selRowNum; i--)
                {
                    dgvProgram.Rows[i].Cells["İşlem"].Value = dgvProgram.Rows[i-1].Cells["İşlem"].Value;
                    dgvProgram.Rows[i].Cells["X"].Value = dgvProgram.Rows[i - 1].Cells["X"].Value;
                    dgvProgram.Rows[i].Cells["Y"].Value = dgvProgram.Rows[i - 1].Cells["Y"].Value;
                    dgvProgram.Rows[i].Cells["Bekle"].Value = dgvProgram.Rows[i - 1].Cells["Bekle"].Value;
                    dgvProgram.Rows[i].Cells["Metin"].Value = dgvProgram.Rows[i - 1].Cells["Metin"].Value;
                }

                dgvProgram.Rows[selRowNum].Cells["İşlem"].Value = "-- yeni --";
                dgvProgram.Rows[selRowNum].Cells["X"].Value = 0;
                dgvProgram.Rows[selRowNum].Cells["Y"].Value = 0;
                dgvProgram.Rows[selRowNum].Cells["Bekle"].Value = 0;
                dgvProgram.Rows[selRowNum].Cells["Metin"].Value = "-- yeni --";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
            }
        }

        private void btCopyRow_Click(object sender, EventArgs e)
        {
            try
            {
                int selRowNum = dgvProgram.CurrentCell.RowIndex;

                if (selRowNum < 0)
                {
                    MessageBox.Show("Satır seçilmedi!");
                    return;
                }

                if (MessageBox.Show("Seçilen satır listenin sonuna kopyalanacak, onaylıyor musunuz?", "ONAY GEREKLİ!", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;

                DataRow row = dt.NewRow();
                row["İşlem"] = dgvProgram.Rows[selRowNum].Cells["İşlem"].Value.ToString();
                row["X"] = Convert.ToInt32(dgvProgram.Rows[selRowNum].Cells["X"].Value.ToString());
                row["Y"] = Convert.ToInt32(dgvProgram.Rows[selRowNum].Cells["Y"].Value.ToString());
                row["Bekle"] = Convert.ToInt32(dgvProgram.Rows[selRowNum].Cells["Bekle"].Value.ToString());
                row["Metin"] = dgvProgram.Rows[selRowNum].Cells["Metin"].Value.ToString();
                dt.Rows.Add(row);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
            }
        }

        private void btEditRow_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProgram.SelectAll();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
            }
        }

        private void btDeleteRow_Click(object sender, EventArgs e)
        {
            try
            {
                int selRowNum = dgvProgram.CurrentCell.RowIndex;

                if (selRowNum < 0)
                {
                    MessageBox.Show("Satır seçilmedi!");
                    return;
                }

                if (MessageBox.Show("Satır silinecek, onaylıyor musunuz?", "ONAY GEREKLİ!", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;   
                
                dgvProgram.Rows.RemoveAt(selRowNum);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
            }
        }

        private void tmrSimulate_Tick(object sender, EventArgs e)
        {
            tmrSimulate.Enabled = false;

            if (curDGVRow < dgvProgram.RowCount)
            {
                string cmd = dgvProgram.Rows[curDGVRow].Cells["İşlem"].Value.ToString();
                int x = Int32.Parse(dgvProgram.Rows[curDGVRow].Cells["X"].Value.ToString());
                int y = Int32.Parse(dgvProgram.Rows[curDGVRow].Cells["Y"].Value.ToString());
                string txt = dgvProgram.Rows[curDGVRow].Cells["Metin"].Value.ToString();

                SetCursorPosition(x, y);

                tmrSimulate.Interval = Int32.Parse(dgvProgram.Rows[curDGVRow].Cells["Bekle"].Value.ToString());
                tmrSimulate.Enabled = true;
                curDGVRow++;
            }
        }

        private void tsmAlwaysOnTop_Click(object sender, EventArgs e)
        {
            this.TopMost = tsmAlwaysOnTop.Checked;
        }
    }
}
