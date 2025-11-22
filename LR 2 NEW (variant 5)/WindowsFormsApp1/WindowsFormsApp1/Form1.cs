using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class Form1 : Form
    {
        private Bitmap canvas;
        private Graphics graphics;
        private bool isDrawing = false;
        private Point lastPoint;
        private Color currentColor = Color.Black;
        private int penWidth = 5;
        private bool isEraser = false;

        public Form1()
        {
            InitializeComponent();
            SetupCanvas();
        }

        private void SetupCanvas()
        {
            canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(canvas);
            graphics.Clear(Color.White);
            pictureBox1.Image = canvas;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                lastPoint = e.Location;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && e.Button == MouseButtons.Left)
            {
                using (var pen = new Pen(isEraser ? Color.White : currentColor, penWidth))
                {
                    pen.StartCap = pen.EndCap = LineCap.Round;
                    graphics.DrawLine(pen, lastPoint, e.Location);
                }
                lastPoint = e.Location;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            using (var dialog = new ColorDialog())
            {
                dialog.Color = currentColor;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    currentColor = dialog.Color;
                    isEraser = false;
                    btnEraser.Checked = false;
                    btnColor.BackColor = currentColor;
                }
            }
        }

        private void btnEraser_CheckedChanged(object sender, EventArgs e)
        {
            isEraser = btnEraser.Checked;
            btnColor.BackColor = isEraser ? Color.LightGray : currentColor;
        }

        private void trackBarWidth_Scroll(object sender, EventArgs e)
        {
            penWidth = trackBarWidth.Value;
            lblWidth.Text = $"Толщина: {penWidth}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            pictureBox1.Invalidate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap|*.bmp";
                sfd.Title = "Сохранить изображение как...";
                sfd.FileName = "paint.png";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string ext = System.IO.Path.GetExtension(sfd.FileName).ToLowerInvariant();
                    try
                    {
                        switch (ext)
                        {
                            case ".jpg":
                            case ".jpeg":
                                canvas.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                                break;
                            case ".bmp":
                                canvas.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                                break;
                            default:
                                canvas.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                                break;
                        }
                        MessageBox.Show("Изображение успешно сохранено!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            graphics?.Dispose();
            canvas?.Dispose();
        }
    }
}