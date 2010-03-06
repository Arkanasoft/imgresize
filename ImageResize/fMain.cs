using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class TfMain : Form
    {
        private const float SIZE_KILO = 1024;
        private const float SIZE_MEGA = SIZE_KILO * SIZE_KILO;

        private String xmlName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ImageResize\\config.xml";
 
        public TfMain()
        {
            InitializeComponent();
        }

        private String SizeToString(long Size)
        {
            if (Size > SIZE_MEGA)
                return String.Format("{0:F}Mb", (float)Size / SIZE_MEGA);
            else if (Size > SIZE_KILO)
                return String.Format("{0:F}Kb", (float)Size / SIZE_KILO);
            else
                return Convert.ToString(Size);
        }

        private void mExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool confDialog(String msg)
        {
            if (MessageBox.Show(msg, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                return true;
            else
                return false;
        }

        private void mClear_Click(object sender, EventArgs e)
        {
            if (lvFiles.Items.Count > 0)
            {
                if (confDialog("Are you sure you want to clear the list?"))
                {
                    lvFiles.Items.Clear();
                    refreshPreview();
                }
            }
        }

        private void mOpen_Click(object sender, EventArgs e)
        {
            bool addFile = false;

            if (odImages.ShowDialog() == DialogResult.OK)
            {
                foreach (String fileName in odImages.FileNames)
                {
                    addFile = true;
                    foreach (ListViewItem listItem in lvFiles.Items)
                        if (String.Compare(listItem.Text, fileName) == 0) addFile = false;

                    if (addFile)
                    {
                        ListViewItem listItem = lvFiles.Items.Add(fileName);
                        FileInfo fileInfo = new FileInfo(fileName);

                        listItem.Checked = true;
                        listItem.SubItems.Add(SizeToString(fileInfo.Length));
                        listItem.SubItems.Add(fileInfo.LastWriteTime.ToString());
                        listItem.SubItems.Add("");
                        listItem.SubItems.Add("");
                    }
                }
                refreshPreview();
            }
        }

        private void bConvert_Click(object sender, EventArgs e)
        {
            int fileCount = 0;

            if (lvFiles.Items.Count > 0 && Directory.Exists(eDestPath.Text))
            {
                bool doReplace = cbOverwrite.Checked;

                if (!doReplace || confDialog("Do you want to replace files wihout asking?"))
                {
                    pbFiles.Visible = true;
                    try
                    {
                        pbFiles.Maximum = lvFiles.Items.Count;
                        pbFiles.Minimum = 0;
                        pbFiles.Value = pbFiles.Minimum;

                        int numValue = (int)numCustomNumber.Value;

                        foreach (ListViewItem listItem in lvFiles.Items)
                        {
                            pbFiles.Value += 1;
                            if (listItem.Checked)
                            {
                                String fileName = listItem.Text;
                                FileInfo fileInfo = new FileInfo(fileName);
                                if (fileInfo.Exists)
                                {
                                    Bitmap imgData = new Bitmap(fileName);
                                    String doRotate = listItem.SubItems[4].Text.ToUpper();

                                    if (doRotate.Length > 0)
                                    {
                                        if (doRotate.CompareTo("CW") == 0) imgData.RotateFlip(RotateFlipType.Rotate90FlipNone);
                                        if (doRotate.CompareTo("CCW") == 0) imgData.RotateFlip(RotateFlipType.Rotate270FlipNone);
                                    }

                                    String shortName = fileInfo.Name;

                                    if (eCustomName.Text.Length > 0) shortName = eCustomName.Text + fileInfo.Extension.ToLower();

                                    String destFile = eDestPath.Text + "\\" + shortName.Replace("{C}", (numValue++).ToString("D6")).Replace("{D}", DateTime.UtcNow.ToString("yyyyMMdd")).Replace("{T}", DateTime.UtcNow.ToString("HHmmss")).Replace("{N}", Path.GetFileNameWithoutExtension(fileInfo.Name).ToUpper());

                                    if (File.Exists(destFile))
                                    {
                                        FileInfo destInfo = new FileInfo(destFile);
                                        String confMsg = String.Format("File \"{0}\" already exists.\nDo you want to replace it?\n\n[{1}]", destInfo.Name, destFile);

                                        if (doReplace || confDialog(confMsg)) File.Delete(destFile);
                                    }

                                    if (!File.Exists(destFile))
                                    {
                                        decimal f = 0;

                                        if (imgData.Width > imgData.Height)
                                            f = numMaxSize.Value / imgData.Width;
                                        else
                                            f = numMaxSize.Value / imgData.Height;

                                        int newWidth = (int)Math.Floor(imgData.Width * f);
                                        int newHeight = (int)Math.Floor(imgData.Height * f);

                                        Bitmap destImg = new Bitmap(newWidth, newHeight);
                                        Graphics g = Graphics.FromImage(destImg);
                                        g.DrawImage(imgData, 0, 0, newWidth, newHeight);

                                        if (cbWatermark.Checked)
                                        {
                                            String s = eWatermarkText.Text;
                                            Font fnt = new Font("Arial", (int)numSize.Value, FontStyle.Bold);
                                            SolidBrush br = new SolidBrush(Color.FromArgb((int)numOpacity.Value, pColour.BackColor));
                                            SizeF sSize = g.MeasureString(s, fnt);
                                            int posX = (int)(newWidth - sSize.Width) / 2;

                                            if (numCount.Value >= 1)
                                            {
                                                int deltaY = (int)Math.Floor(newHeight / (numCount.Value + 1));
                                                int posY = deltaY;

                                                for (int i = 0; i < numCount.Value; i++)
                                                {
                                                    g.DrawString(s, fnt, br, posX, posY - ((int)sSize.Height / 2));
                                                    posY += deltaY;
                                                }
                                            }
                                        }

                                        destImg.Save(destFile, ImageFormat.Jpeg);

                                        fileCount++;

                                        String ratio = "-";

                                        if (File.Exists(fileName) && File.Exists(destFile) && String.Compare(fileName, destFile) != 0)
                                        {
                                            FileInfo srcInfo = new FileInfo(fileName);
                                            long srcSize = srcInfo.Length;
                                            if (srcSize > 0)
                                            {
                                                FileInfo destInfo = new FileInfo(destFile);
                                                long destSize = destInfo.Length;
                                                if (srcSize > destSize && destSize > 0)
                                                {
                                                    float ratioValue = 100 - (((float)destSize * 100) / (float)srcSize);
                                                    ratio = String.Format("{0:F}%", ratioValue);
                                                }
                                            }
                                        }
                                        listItem.SubItems[3].Text = ratio;
                                    }
                                }
                            }
                        }
                    }
                    finally
                    {
                        pbFiles.Visible = false;
                    }
                }
                if (fileCount > 0) MessageBox.Show(String.Format("Successfully converted {0} image(s).", fileCount), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bBrowsePath_Click(object sender, EventArgs e)
        {
            fdPath.SelectedPath = eDestPath.Text;
            if (fdPath.ShowDialog() == DialogResult.OK) eDestPath.Text = fdPath.SelectedPath;
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            if (File.Exists(xmlName))
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(xmlName);
                if (xml.HasChildNodes)
                    for (int i = 0; i < xml.ChildNodes.Count; i++)
                    {
                        XmlNode node = xml.ChildNodes[i];
                        if (node.NodeType == XmlNodeType.Element && String.Compare(node.Name, "config") == 0)
                        {
                            if (node.HasChildNodes)
                                for (int j = 0; j < node.ChildNodes.Count; j++)
                                {
                                    XmlNode childNode = node.ChildNodes[j];

                                    foreach (Control ctr in Controls)
                                        if (String.Compare(childNode.Name, ctr.Name) == 0)
                                        {
                                            if (ctr is TextBox) (ctr as TextBox).Text = childNode.InnerText;
                                            if (ctr is NumericUpDown) (ctr as NumericUpDown).Value = Convert.ToInt32(childNode.InnerText);
                                            if (ctr is CheckBox) (ctr as CheckBox).Checked = Convert.ToBoolean(childNode.InnerText);
                                            if (ctr is Panel) (ctr as Panel).BackColor = Color.FromArgb(Convert.ToInt32(childNode.Attributes["red"].InnerText), Convert.ToInt32(childNode.Attributes["green"].InnerText), Convert.ToInt32(childNode.Attributes["blue"].InnerText));
                                        }
                                }
                        }
                    }
            }
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlDocument xml = new XmlDocument();

            XmlDeclaration xmlDeclaration = xml.CreateXmlDeclaration("1.0", "utf-8", null);
            XmlElement root = xml.CreateElement("config");
            xml.InsertBefore(xmlDeclaration, xml.DocumentElement);
            xml.AppendChild(root);
            foreach (Control ctr in Controls)
            {
                XmlElement node = null;

                if (ctr is TextBox)
                {
                    node = xml.CreateElement(ctr.Name);
                    node.InnerText = (ctr as TextBox).Text;
                }
                if (ctr is NumericUpDown)
                {
                    node = xml.CreateElement(ctr.Name);
                    node.InnerText = Convert.ToString((ctr as NumericUpDown).Value);
                }
                if (ctr is CheckBox)
                {
                    node = xml.CreateElement(ctr.Name);
                    node.InnerText = Convert.ToString((ctr as CheckBox).Checked);
                }
                if (ctr is Panel)
                {
                    node = xml.CreateElement(ctr.Name);
                    Color pc = (ctr as Panel).BackColor;
                    node.InnerText = pc.ToString();
                    node.SetAttribute("red", Convert.ToString(pc.R));
                    node.SetAttribute("green", Convert.ToString(pc.G));
                    node.SetAttribute("blue", Convert.ToString(pc.B));
                }
                if (node != null) root.AppendChild(node);
            }

            FileInfo xmlInfo = new FileInfo(xmlName);
            DirectoryInfo dirInfo = Directory.CreateDirectory(xmlInfo.DirectoryName);
            if (dirInfo.Exists) xml.Save(xmlName);
        }

        private void cbWatermark_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control ctr in Controls)
            {
                Object data = ctr.Tag;

                if (data is String && (data as String).CompareTo("1") == 0) ctr.Enabled = cbWatermark.Checked;
            }
        }

        private void refreshPreview()
        {
            if (lvFiles.SelectedItems.Count == 1)
            {
                ListViewItem itemData = lvFiles.SelectedItems[0];
                String doRotate = itemData.SubItems[4].Text.ToUpper();
                Bitmap imgPreview = new Bitmap(itemData.Text);

                if (doRotate.CompareTo("CW") == 0) imgPreview.RotateFlip(RotateFlipType.Rotate90FlipNone);
                if (doRotate.CompareTo("CCW") == 0) imgPreview.RotateFlip(RotateFlipType.Rotate270FlipNone);

                pbPreview.Image = imgPreview;
            }
            else
                pbPreview.Image = null;
        }

        private void lvFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshPreview();
        }

        private void removeFromList()
        {
            if (lvFiles.SelectedItems.Count > 0)
            {
                String confMsg = String.Format("Do you want to remove {0} item(s) from the list?", lvFiles.SelectedItems.Count);

                if (confDialog(confMsg))
                {
                    foreach (ListViewItem itemData in lvFiles.SelectedItems) itemData.Remove();
                    refreshPreview();
                }
            }
        }

        private void lvFiles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) removeFromList();
        }

        private void setRotate(String value)
        {
            foreach (ListViewItem itemData in lvFiles.SelectedItems) itemData.SubItems[4].Text = value;
            refreshPreview();
        }

        private void tsmRotateCW_Click(object sender, EventArgs e)
        {
            setRotate("CW");
        }

        private void tsmRotateCCW_Click(object sender, EventArgs e)
        {
            setRotate("CCW");
        }

        private void tsmRotateNone_Click(object sender, EventArgs e)
        {
            setRotate("");
        }

        private void tsmRemove_Click(object sender, EventArgs e)
        {
            removeFromList();
        }

        private void cmFiles_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = lvFiles.Items.Count == 0;
            tsmViewFull.Enabled = lvFiles.SelectedItems.Count == 1;
        }

        private void markItems(bool isChecked)
        {
            if (lvFiles.SelectedItems.Count > 1)
                foreach (ListViewItem itemData in lvFiles.SelectedItems) itemData.Checked = isChecked;
            else
                foreach (ListViewItem itemData in lvFiles.Items) itemData.Checked = isChecked;
        }

        private void tsmMarkChecked_Click(object sender, EventArgs e)
        {
            markItems(true);
        }

        private void tsmMarkUnchecked_Click(object sender, EventArgs e)
        {
            markItems(false);
        }

        private void eDestPath_DoubleClick(object sender, EventArgs e)
        {
            if (Directory.Exists(eDestPath.Text)) Process.Start(eDestPath.Text);
        }

        private void lvFiles_DoubleClick(object sender, EventArgs e)
        {
            Point mPos = lvFiles.PointToClient(Cursor.Position);
            ListViewItem itemData = lvFiles.GetItemAt(mPos.X, mPos.Y);
            if (itemData != null) Process.Start(itemData.Text);
        }

        private void tsmViewFull_Click(object sender, EventArgs e)
        {
            if (lvFiles.SelectedItems.Count == 1) Process.Start(lvFiles.SelectedItems[0].Text);
        }

        private void pColour_Click(object sender, EventArgs e)
        {
            cdWatermark.Color = pColour.BackColor;
            if (cdWatermark.ShowDialog() == DialogResult.OK)
            {
                pColour.BackColor = cdWatermark.Color;
            }
        }

        private void mAbout_Click(object sender, EventArgs e)
        {
            ImageResize.TfAbout aboutForm = new ImageResize.TfAbout();

            aboutForm.ShowDialog();
        }

    }

}
