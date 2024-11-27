namespace Lab6
{
    partial class Form1
    {
        private System.Windows.Forms.TextBox txtSideA;
        private System.Windows.Forms.TextBox txtSideB;
        private System.Windows.Forms.TextBox txtSideC;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;

        private void InitializeComponent()
        {
            this.txtSideA = new System.Windows.Forms.TextBox();
            this.txtSideB = new System.Windows.Forms.TextBox();
            this.txtSideC = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();

            // TextBox для Side A
            this.txtSideA.Location = new System.Drawing.Point(20, 20);
            this.txtSideA.Name = "txtSideA";
            this.txtSideA.Size = new System.Drawing.Size(100, 20);

            // TextBox для Side B
            this.txtSideB.Location = new System.Drawing.Point(20, 50);
            this.txtSideB.Name = "txtSideB";
            this.txtSideB.Size = new System.Drawing.Size(100, 20);

            // TextBox для Side C
            this.txtSideC.Location = new System.Drawing.Point(20, 80);
            this.txtSideC.Name = "txtSideC";
            this.txtSideC.Size = new System.Drawing.Size(100, 20);

            // Button для обчислення
            this.btnCalculate.Location = new System.Drawing.Point(20, 110);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 30);
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // Label для результату
            this.lblResult.Location = new System.Drawing.Point(20, 150);
            this.lblResult.Size = new System.Drawing.Size(250, 60);

            // Form1
            this.ClientSize = new System.Drawing.Size(300, 220);
            this.Controls.Add(this.txtSideA);
            this.Controls.Add(this.txtSideB);
            this.Controls.Add(this.txtSideC);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "Triangle Calculator";
        }
    }

}
