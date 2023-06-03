
namespace OTOMASYON_ÖDEV
{
    partial class KullaniciDetayliSatisYazdir
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.DataSetDetayliKullanici = new OTOMASYON_ÖDEV.TrenOtomasyonuDataSet2();
            this.kullaniciDetayRapor1 = new OTOMASYON_ÖDEV.KullaniciDetayRapor();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDetayliKullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(980, 721);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // DataSetDetayliKullanici
            // 
            this.DataSetDetayliKullanici.DataSetName = "TrenOtomasyonuDataSet2";
            this.DataSetDetayliKullanici.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KullaniciDetayliSatisYazdir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 721);
            this.Controls.Add(this.crystalReportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KullaniciDetayliSatisYazdir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciDetayliSatisYazdir";
            this.Load += new System.EventHandler(this.KullaniciDetayliSatisYazdir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDetayliKullanici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private TrenOtomasyonuDataSet2 DataSetDetayliKullanici;
        private KullaniciDetayRapor kullaniciDetayRapor1;
    }
}