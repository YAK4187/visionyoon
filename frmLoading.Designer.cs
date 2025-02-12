
namespace DOT_Number_Reading
{
    partial class frmLoading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoading));
            this.tpnlLoading = new System.Windows.Forms.TableLayoutPanel();
            this.pbICON = new System.Windows.Forms.PictureBox();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.tpnlLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbICON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // tpnlLoading
            // 
            this.tpnlLoading.ColumnCount = 2;
            this.tpnlLoading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.0067F));
            this.tpnlLoading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.9933F));
            this.tpnlLoading.Controls.Add(this.pbICON, 0, 0);
            this.tpnlLoading.Controls.Add(this.pbLoading, 1, 0);
            this.tpnlLoading.Location = new System.Drawing.Point(0, 0);
            this.tpnlLoading.Name = "tpnlLoading";
            this.tpnlLoading.RowCount = 1;
            this.tpnlLoading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnlLoading.Size = new System.Drawing.Size(597, 208);
            this.tpnlLoading.TabIndex = 0;
            // 
            // pbICON
            // 
            this.pbICON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbICON.Image = ((System.Drawing.Image)(resources.GetObject("pbICON.Image")));
            this.pbICON.Location = new System.Drawing.Point(3, 3);
            this.pbICON.Name = "pbICON";
            this.pbICON.Size = new System.Drawing.Size(399, 202);
            this.pbICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbICON.TabIndex = 0;
            this.pbICON.TabStop = false;
            // 
            // pbLoading
            // 
            this.pbLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLoading.Image = global::DOT_Number_Reading.Properties.Resources.loading;
            this.pbLoading.InitialImage = null;
            this.pbLoading.Location = new System.Drawing.Point(408, 3);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(186, 202);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoading.TabIndex = 1;
            this.pbLoading.TabStop = false;
            // 
            // frmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 210);
            this.Controls.Add(this.tpnlLoading);
            this.Name = "frmLoading";
            this.tpnlLoading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbICON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpnlLoading;
        private System.Windows.Forms.PictureBox pbICON;
        internal System.Windows.Forms.PictureBox pbLoading;
    }
}