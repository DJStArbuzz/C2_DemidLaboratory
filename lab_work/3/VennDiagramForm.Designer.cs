namespace SimpleSignal
{
    partial class VennDiagramForm
    {
        /// <summary>
        /// ����������� ���������� ��� ���������.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// �������� ������������ ��������.
        /// </summary>
        /// <param name="disposing">true, ���� ����������� ������� ������ ���� �������; ����� � false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region ���, �������������� ��������� Windows Form Designer

        /// <summary>
        /// ��������� ����� ��� ��������� ������������ � �� ���������
        /// ���������� ����� ������ � ������� ��������� ����.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // VennDiagramForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Name = "VennDiagramForm";
            this.ResumeLayout(false);
        }

        #endregion
    }
}
