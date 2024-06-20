namespace Gtt.Labels.UI.WebService.Labels.IndividualLabels
{
    partial class IndividualLabelError
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndividualLabelError));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.MessageLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1});
            this.TopMargin.HeightF = 83.34004F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPanel1
            // 
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.MessageLabel});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 13F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(136.7672F, 46.13287F);
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(17.49666F, 16.00001F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // MessageLabel
            // 
            this.MessageLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.MessageLabel.CanGrow = false;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.MessageLabel.LocationFloat = new DevExpress.Utils.PointFloat(17.66678F, 0F);
            this.MessageLabel.Multiline = true;
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.MessageLabel.SizeF = new System.Drawing.SizeF(119.1004F, 46.13287F);
            this.MessageLabel.StylePriority.UseBorders = false;
            this.MessageLabel.StylePriority.UseFont = false;
            this.MessageLabel.StylePriority.UseTextAlignment = false;
            this.MessageLabel.Text = "Part #00000000 payload not expecting 7 but 7";
            this.MessageLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.MessageLabel.TextTrimming = System.Drawing.StringTrimming.None;
            // 
            // Detail
            // 
            this.Detail.HeightF = 99F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // IndividualLabelError
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Margins = new System.Drawing.Printing.Margins(2, 3, 83, 100);
            this.PageHeight = 295;
            this.PageWidth = 276;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.SnapGridSize = 9.84252F;
            this.Version = "17.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRLabel MessageLabel;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    }
}
