namespace Gtt.Labels.UI.WebService.Labels.IndividualLabels
{
    partial class EZIndividualLabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EZIndividualLabel));
            DevExpress.XtraPrinting.BarCode.DataMatrixGS1Generator dataMatrixGS1Generator1 = new DevExpress.XtraPrinting.BarCode.DataMatrixGS1Generator();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.txtInternalID = new DevExpress.XtraReports.UI.XRLabel();
            this.txtSerial = new DevExpress.XtraReports.UI.XRLabel();
            this.txtRefExt = new DevExpress.XtraReports.UI.XRLabel();
            this.barCode = new DevExpress.XtraReports.UI.XRBarCode();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.txtInternalID,
            this.txtSerial,
            this.txtRefExt,
            this.barCode});
            this.Detail.HeightF = 100F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.71737F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(23.50006F, 21.45833F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // txtInternalID
            // 
            this.txtInternalID.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.txtInternalID.CanGrow = false;
            this.txtInternalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtInternalID.LocationFloat = new DevExpress.Utils.PointFloat(4.374999F, 36.17569F);
            this.txtInternalID.Name = "txtInternalID";
            this.txtInternalID.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtInternalID.SizeF = new System.Drawing.SizeF(97.85834F, 17.75406F);
            this.txtInternalID.StylePriority.UseBorders = false;
            this.txtInternalID.StylePriority.UseFont = false;
            this.txtInternalID.StylePriority.UseTextAlignment = false;
            this.txtInternalID.Text = "(S) EZ000000";
            this.txtInternalID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.txtInternalID.WordWrap = false;
            // 
            // txtSerial
            // 
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.txtSerial.LocationFloat = new DevExpress.Utils.PointFloat(4.374999F, 53.92976F);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtSerial.SizeF = new System.Drawing.SizeF(97.85834F, 21.11193F);
            this.txtSerial.StylePriority.UseFont = false;
            this.txtSerial.StylePriority.UseTextAlignment = false;
            this.txtSerial.Text = "GT84737R4.5230LE";
            this.txtSerial.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // txtRefExt
            // 
            this.txtRefExt.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.txtRefExt.CanGrow = false;
            this.txtRefExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtRefExt.LocationFloat = new DevExpress.Utils.PointFloat(23.50006F, 14.71736F);
            this.txtRefExt.Name = "txtRefExt";
            this.txtRefExt.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtRefExt.SizeF = new System.Drawing.SizeF(78.73328F, 21.45834F);
            this.txtRefExt.StylePriority.UseBorders = false;
            this.txtRefExt.StylePriority.UseFont = false;
            this.txtRefExt.StylePriority.UseTextAlignment = false;
            this.txtRefExt.Text = "(P) 123456-10";
            this.txtRefExt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.txtRefExt.WordWrap = false;
            // 
            // barCode
            // 
            this.barCode.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.barCode.AutoModule = true;
            this.barCode.Font = new System.Drawing.Font("Times New Roman", 2F);
            this.barCode.LocationFloat = new DevExpress.Utils.PointFloat(102.2333F, 14.71736F);
            this.barCode.Module = 1F;
            this.barCode.Name = "barCode";
            this.barCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 0, 0, 100F);
            this.barCode.ShowText = false;
            this.barCode.SizeF = new System.Drawing.SizeF(68.64159F, 49.90767F);
            this.barCode.StylePriority.UseFont = false;
            this.barCode.StylePriority.UsePadding = false;
            dataMatrixGS1Generator1.MatrixSize = DevExpress.XtraPrinting.BarCode.DataMatrixSize.Matrix26x26;
            this.barCode.Symbology = dataMatrixGS1Generator1;
            this.barCode.Text = "1234567891212321312312312313213213213123213123123213123213213";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // EZIndividualLabel
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.PageHeight = 100;
            this.PageWidth = 200;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.SnapGridSize = 9.84252F;
            this.Version = "17.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRLabel txtInternalID;
        private DevExpress.XtraReports.UI.XRLabel txtSerial;
        private DevExpress.XtraReports.UI.XRLabel txtRefExt;
        private DevExpress.XtraReports.UI.XRBarCode barCode;
    }
}
