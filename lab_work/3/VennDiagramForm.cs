using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleSignal
{
    public partial class VennDiagramForm : Form
    {
        public VennDiagramForm()
        {
            this.Text = "��������� ������-�����";
            this.Size = new Size(1200, 800); // ����������� ������ �����
            this.Paint += new PaintEventHandler(DrawVennDiagrams);
        }

        private void DrawVennDiagrams(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // ��������� ������ � �����
            Brush blueBrush = new SolidBrush(Color.Blue);
            Brush redBrush = new SolidBrush(Color.Red);
            Brush whiteBrush = new SolidBrush(Color.White);
            Pen blackPen = new Pen(Color.Black, 2);
            Pen transparentPen = new Pen(Color.Transparent, 2);

            // 0) ����������� ����� ������ (A � B)
            g.DrawEllipse(blackPen, 100, 100, 150, 150); // ���� A
            g.DrawString("A", new Font("Arial", 16), Brushes.Black, 160, 70);
            g.DrawEllipse(blackPen, 200, 100, 150, 150); // ���� B
            g.DrawString("B", new Font("Arial", 16), Brushes.Black, 270, 70);

            g.DrawString("����� A � B", new Font("Arial", 16), Brushes.Black, 160, 270);

            // 1) ����������� ��������
            g.DrawString("A", new Font("Arial", 16), Brushes.Black, 460, 70);
            g.DrawString("B", new Font("Arial", 16), Brushes.Black, 570, 70);

            // A
            Rectangle unionA = new Rectangle(400, 100, 150, 150);
            // g.FillEllipse(new SolidBrush(Color.FromArgb(128, Color.Blue)), unionA);
            g.FillEllipse(Brushes.Blue, unionA); 
            g.DrawEllipse(blackPen, unionA);

            // B
            Rectangle unionB = new Rectangle(500, 100, 150, 150);
            //g.FillEllipse(new SolidBrush(Color.FromArgb(128, Color.Blue)), unionB);
            g.FillEllipse(Brushes.Blue, unionB); 
            g.DrawEllipse(blackPen, unionB);

            g.DrawEllipse(blackPen, 400, 100, 150, 150); // ���� A
            g.DrawEllipse(blackPen, 500, 100, 150, 150); // ���� B

            g.DrawString("����������� A � B", new Font("Arial", 16), Brushes.Black, 420, 270);

            // 2) �� �����������
            g.DrawEllipse(blackPen, 700, 100, 150, 150); // ���� A
            g.DrawString("A", new Font("Arial", 16), Brushes.Black, 760, 70);
            g.DrawEllipse(blackPen, 800, 100, 150, 150); // ���� B
            g.DrawString("B", new Font("Arial", 16), Brushes.Black, 870, 70);

            Rectangle intersection = new Rectangle(800, 120, 50, 110);
            g.FillEllipse(Brushes.Blue, intersection);  
            g.DrawEllipse(blackPen, intersection);

            g.DrawString("����������� A � B", new Font("Arial", 16), Brushes.Black, 700, 270);
            // 3) �������� A \ B ���� ��������

            // A
            Rectangle subA = new Rectangle(250, 400, 150, 150);
            // g.FillEllipse(new SolidBrush(Color.FromArgb(128, Color.Blue)), unionA);
            g.FillEllipse(Brushes.Blue, subA);

            // B
            Rectangle subB = new Rectangle(350, 400, 150, 150);
            //g.FillEllipse(new SolidBrush(Color.FromArgb(128, Color.Blue)), unionB);
            g.FillEllipse(Brushes.White, subB);
            g.DrawEllipse(blackPen, subB);

            g.DrawEllipse(blackPen, 250, 400, 150, 150); // ���� A
            g.DrawString("A", new Font("Arial", 16), Brushes.Black, 310, 370);
            g.DrawEllipse(blackPen, 350, 400, 150, 150); // ���� B
            g.DrawString("B", new Font("Arial", 16), Brushes.Black, 420, 370);
            //g.DrawEllipse(blackPen, 450, 100, 100, 150); // ����������� C � D

            g.DrawString("�������� A � B", new Font("Arial", 16), Brushes.Black, 310, 550);

            // 4) �� �������������� ��������

            // A
            Rectangle simSubA = new Rectangle(550, 400, 150, 150);
            // g.FillEllipse(new SolidBrush(Color.FromArgb(128, Color.Blue)), unionA);
            g.FillEllipse(Brushes.Blue, simSubA);
            g.DrawEllipse(blackPen, simSubA);

            // B
            Rectangle simSubB = new Rectangle(650, 400, 150, 150);
            //g.FillEllipse(new SolidBrush(Color.FromArgb(128, Color.Blue)), unionB);
            g.FillEllipse(Brushes.Blue, simSubB);
            g.DrawEllipse(blackPen, simSubB);


            Rectangle simSub = new Rectangle(650, 420, 50, 110);
            g.FillEllipse(Brushes.White, simSub);
            g.DrawEllipse(blackPen, simSub);

            g.DrawEllipse(blackPen, 550, 400, 150, 150); // ���� A
            g.DrawString("A", new Font("Arial", 16), Brushes.Black, 610, 370);
            g.DrawEllipse(blackPen, 650, 400, 150, 150); // ���� B
            g.DrawString("B", new Font("Arial", 16), Brushes.Black, 720, 370);


            g.DrawString("�������� (����.) A � B", new Font("Arial", 16), Brushes.Black, 560, 550);
            // ������������ ��������
            blueBrush.Dispose();
            redBrush.Dispose();
            blackPen.Dispose();
            transparentPen.Dispose();
        }
    }
}
